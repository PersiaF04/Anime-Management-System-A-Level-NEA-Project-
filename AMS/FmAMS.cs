using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Net;
using Newtonsoft.Json.Linq;
using System.IO;
using System.Data.OleDb;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Net.Http;

namespace AMS
{
    /// <summary>
    /// Handles all inputs and validation of functions that will take place in <c>FmAMS</c>
    /// </summary>

    public partial class FmAMS : Form
    {    /// <summary>
         /// Global variable
         /// </summary>
        public static FmAMS FmAmsInstance;
        /// <summary>
        /// Global variables
        /// </summary>
        public static string animePic = "";
        /// <summary>
        /// Global variables
        /// </summary>
        public static string AnimeName = "";

        public static FmAMS fmAMSInstance;

        /// <summary>
        ///     Required Method for Designer support for <c>FmAMS</c>
        /// </summary>
        public FmAMS()
        {
            InitializeComponent();
            SetColour();

        }
        /// <summary>
        /// The resulting method for dertermining the colour of the form FmAMS
        /// </summary>
        private void SetColour()
        {
            //Sets the background colour of this form to the background colour declared in class: DarkModeSwitch
            this.BackColor = DarkModeSwitch.BackgroundColour;

            //Sets the text colour of this form to the font colour declared in class: DarkModeSwitch
            this.ForeColor = DarkModeSwitch.FontColour;

            //Sets the background colour for the panel PaAnimePanel of this form to the panel colour declared in class: DarkModeSwitch
            PaAnimePanel.BackColor = DarkModeSwitch.PanelColour;

            //Sets the background colour for the groupbox gbAMS of this form to the group box colour declared in class: DarkModeSwitch
            gbAMS.BackColor = DarkModeSwitch.GroupBoxColour;

            //Sets the background colour for the groupbox gbAnimeNews of this form to the group box colour declared in class: DarkModeSwitch
            gbAnimeNews.BackColor = DarkModeSwitch.GroupBoxColour;

            //Sets the text colour for the groupbox gbAnimeNews of this form to the font colour declared in class: DarkModeSwitch
            gbAnimeNews.ForeColor = DarkModeSwitch.FontColour;

            //Sets the background colour for the textbox tbNews of this form to the text box colour declared in class: DarkModeSwitch
            tbNews.BackColor = DarkModeSwitch.TextBoxColour;

            //Sets the text colour for the textbox tbNews of this form to the font colour declared in class: DarkModeSwitch
            tbNews.ForeColor = DarkModeSwitch.FontColour;

            //Sets the background colour for the textbox tbSearch of this form to the search box colour declared in class: DarkModeSwitch
            tbSearch.BackColor = DarkModeSwitch.SearchBoxColour;

            //Sets the text colour for the textbox tbSearch of this form to the font colour declared in class: DarkModeSwitch
            tbSearch.ForeColor = DarkModeSwitch.FontColour;

            //Sets the background colour for the button btBack of this form to the  text box colour declared in class: DarkModeSwitch
            btBack.BackColor = DarkModeSwitch.TextBoxColour;

            //Sets the background colour for the button btProfile of this form to the  profile button colour declared in class: DarkModeSwitch
            btProfile.BackColor =DarkModeSwitch.ProfileButtonColour;

            //Sets the background colour for the button btSearch of this form to the  search box colour declared in class: DarkModeSwitch
            btSearch.BackColor = DarkModeSwitch.SearchBoxColour;

            //Sets the background colour for the button btSwitch of this form to the  search box colour declared in class: DarkModeSwitch
            btSwitch.BackColor = DarkModeSwitch.SearchBoxColour;

            //Sets the background colour for the button btSearch of this form to the  text box colour declared in class: DarkModeSwitch
            btSearch.BackColor = DarkModeSwitch.TextBoxColour;

            //Sets the text colour for the button btBack of this form to the font colour declared in class: DarkModeSwitch
            btBack.ForeColor = DarkModeSwitch.FontColour;
        }


        /// <summary>
        /// The resulting method for when the Form loads
        /// </summary>
        /// <param name="sender"> The <see cref="System.Object"/> that represents the sender instance  </param>
        /// <param name="e">The <see cref="System.EventArgs"/> that Represents the event arguments passed to the event handler </param>
        private void FmAMS_Load(object sender, EventArgs e)
        {
            //loads the image from the link to the picture box PbAnimePicture1
            PbAnimePicture1.LoadAsync(@"https://cdn.myanimelist.net/images/anime/7/3791l.jpg");

            //loads the image from the link to the picture box PbAnimePicture2
            PbAnimePicture2.LoadAsync(@"https://cdn.myanimelist.net/images/anime/8/19968l.jpg");

            //loads the image from the link to the picture box PbAnimePicture3
            PbAnimePicture3.LoadAsync(@"https://cdn.myanimelist.net/images/anime/1/20l.jpg");

           //Sets the label lbUsername to the global variable declared in the form FmLogIn which contains th user's username
            lbUsername.Text = FmLogIn.Username;

            //Runs the procedure AutoFillSearch
            AutoFillSearch();

            //if the global variable switch is true in the class: DarkModeSwitch
            if(DarkModeSwitch.Switch==true)
            {
                //Runs the procedure SetColour
                SetColour();
            }

            //otherwise
            else
            {
                //Set the global variable switch to false in the class: DarkModeSwitch
                _ = DarkModeSwitch.Switch == false;
            }

            //Runs the procedure SeleniumDriver
             SeleniumDriver();

            //Sets the visibility of the panel PaAnimePanel to false
            PaAnimePanel.Visible = false;
        }

        /// <summary>
        /// The resulting method for the procedure AutoFillSearch
        /// </summary>
        private void AutoFillSearch()
        {

            try//Exception Handling
            {

                //Create a database connection object with the constant defined in program.cs
                OleDbConnection Conn = new OleDbConnection(Program.connString);

                //Opens Connection to the database
                Conn.Open();

                //Creates a database command object
                OleDbCommand Cmd = new OleDbCommand();

                //Creates a connection with the Command Object
                Cmd.Connection = Conn;

                //A select query to select the column AnimeTitle from the table Animes
                Cmd.CommandText = "SELECT AnimeTitle FROM Animes";

                //Defines the autocompletefeature that holds a collection of strings AutoFill
                AutoCompleteStringCollection AutoFill = new AutoCompleteStringCollection();

                //Creates a reader object and Executes the SQL Query
                OleDbDataReader reader = Cmd.ExecuteReader();

                //if the reader object has found rows
                if (reader.HasRows)
                {
                    //while the reader object is reading the rows in the column AnimeTitle
                    while (reader.Read())
                    {
                        //Add the rows that are in the column AnimeTitle to AutoFill
                        AutoFill.Add(reader["AnimeTitle"].ToString());
                    }

                }

                //otherwise
                else
                {

                    //Display a messagebox informing the user that there was no AnimeTitles found
                    MessageBox.Show("Anime title not found!");
                }

                //Closes the reader object.
                reader.Close();

                //Sets the autocomplete source of the textbox tbSearch to AutoFill which contains all the AnimeTitles
                tbSearch.AutoCompleteCustomSource = AutoFill;

                //Closes the connection to the database
                Conn.Close();
            }
            catch(Exception) //catches error
            {
                //Displays a message box informing the user that it could not loadAutoFill
                MessageBox.Show("Could not load");
            }
        }

        /// <summary>
        /// The resulting method for the procedure SeleniumDriver
        /// </summary>
        private async void SeleniumDriver()
        {
            //Suspends the function DelaySeleniumDriver
           await DelaySeleniumDriver();
        }
        /// <summary>
        /// The resulting method for the procedure DelaySeleniumDriver
        /// </summary>
        async Task DelaySeleniumDriver()
        {
            //Declaring serivice as a chromedriverservice variable
            ChromeDriverService service = ChromeDriverService.CreateDefaultService();

            //hides the command prompt window so its running in the background
            service.HideCommandPromptWindow = true;

            //Decalring chromeoptions as a new variable
            var chromeOptions = new ChromeOptions();

            //hides google chrome
            chromeOptions.AddArgument("headless");

            //declaring the variable driver with the variables service and chromeoptions
            var driver = new ChromeDriver(service, chromeOptions);

            //the driver navigates to the link in google chrome
            driver.Navigate().GoToUrl("https://www.animenewsnetwork.com/news/?ann-edition=uk");

            //finds the agree button via xpath
           // var agree = driver.FindElement(By.XPath("/ html / body / div[1] / div / div / div / div[2] / div / button[2]"));

            //clicks on the button agree that is on the site
           // agree.Click();

            //finds the main source of the news via css selector
            var News = driver.FindElements(By.CssSelector("#mainfeed > div.mainfeed-section.herald-boxes"));

            // runs forever
            while (true)
            {
                //untill i=80 (the rough amount of news on the site)
                for (int i = 1; i < 80; i++)
                {
                    try //Exception Handling
                    {
                        //delay the 4 loop by 4 seconds
                        await Task.Delay(4000);

                        //gets the news titles via xpath and will keep getting it until i=80
                        var NewsTitles = driver.FindElement(By.XPath("//*[@id='mainfeed']/div[2]/div[" + i + "]/div[3]/div/h3/a"));

                        //output the newstitles through the textbox tbNews
                        tbNews.Text = NewsTitles.Text;


                    }
                    catch (Exception) // catches error
                    {
                       //nothing to display for the user so that there's no disruption
                    }
                }

                //closes the driver
                driver.Close();

                //quits the driver
                driver.Quit();


            }
        }
        /// <summary>
        /// The resulting method for when the search button is clicked by the user
        /// </summary>
        /// <param name="sender"> The <see cref="System.Object"/> that represents the sender instance  </param>
        /// <param name="e">The <see cref="System.EventArgs"/> that Represents the event arguments passed to the event handler </param>

        private void btSearch_Click(object sender, EventArgs e)
        {
            //Create a database connection object with the constant defined in program.cs
            OleDbConnection Conn = new OleDbConnection(Program.connString);

            //Opens Connection to the database
            Conn.Open();

            //Creates a database command object
            OleDbCommand Cmd = new OleDbCommand();

            //Creates a connection with the Command Object
            Cmd.Connection = Conn;

            //A select query to get everything from the table animes from where the animetitle is entered by the user
            Cmd.CommandText = "SELECT * FROM Animes WHERE AnimeTitle= '"+tbSearch.Text+"'";

            //Creates a reader object and Executes the SQL Query
            OleDbDataReader reader = Cmd.ExecuteReader();

            //sets the visibility of the label lbCowboyBepop to false (invisible)
            lbCowboybebop.Visible = false;

            //sets the visibility of the label lbTrigun to false (invisible)
            lbTrigun.Visible = false;

            //sets the visibility of the label lbNaruto to false (invisible)
            lbNaruto.Visible = false;

            // if the SQL query contains one or more rows
            if (reader.HasRows)
            {
                //read all the rows
                reader.Read();

                //sets the variable pic with the value AnimePictures from the table
                var pic = reader["AnimePictures"].ToString();

                //declaring numeric value as an integer
                int numericvalue;

                //if the pic can be parsed as an integer meaning that the variable pic contains no url but the placeholder value
                if (int.TryParse(pic, out numericvalue))
                {
                    
                    try//Exception handling
                    {
                        //sets the variable animeID with the value AnimeID from the table
                        var animeID = reader["AnimeID"].ToString();

                        // Declaring anime url as a string which contains an api link with the variable animeID embedded into it
                        string animeURL = "https://api.jikan.moe/v3/anime/" + animeID + "/pictures";

                        //parses the url as a jsonfile and downloads the jsonfile
                        JObject json = JObject.Parse(new WebClient().DownloadString(animeURL));

                        //declaring the variable animelink with the value json where it contains a small picture
                        var animelink = json["pictures"][0]["small"];

                        //loads the link from the variable animelink into the picturebox PbAnimePicture4
                        PbAnimePicture4.LoadAsync(animelink.ToString());

                        //sets the label lbAnimeTitle with the same text as the textbpx tbSearch
                        lbAnimeTitle.Text = tbSearch.Text;

                        //Sets the global variable AnimeName with the label lbAnimeTitle
                        AnimeName = lbAnimeTitle.Text;

                        //sets the visibility of the panel PaAnimePanel to true
                        PaAnimePanel.Visible = true;

                        //Closes the reader object.
                        reader.Close();

                        //Update AnimePictures with the link from animelink. This update will take place where the AnimeID is the same as the variable animeID
                        Cmd.CommandText = "UPDATE Animes SET AnimePictures= '"+ animelink.ToString()+"' WHERE AnimeID = " + animeID.ToString() + "";

                        //Sets the global variable animePic with the variable animelink
                        animePic = animelink.ToString();

                        //Executes the SQL Query
                        Cmd.ExecuteNonQuery();
                       
                    }
                    catch(Exception ) //catches error
                    {
                        //Displays a message box informing the user that the anime could not be found
                        MessageBox.Show("Could not be found");
                    }
                }
            
                else //if it could not be parsed as an integer this means there is a Url in the table
                {
                    //sets the visibility of the label lbCowboyBepop to false (invisible)
                    lbCowboybebop.Visible = false;

                    //sets the visibility of the label lbTrigun to false (invisible)
                    lbTrigun.Visible = false;

                    //sets the visibility of the label lbNaruto to false (invisible)
                    lbNaruto.Visible = false;

                    //sets the variable animeID with the value AnimeID from the table
                    var animeID = reader["AnimeID"].ToString();

                    //closes the reader object
                    reader.Close();

                    //select the url from the table Animes where the AnimeID is located
                    Cmd.CommandText ="SELECT AnimePictures FROM Animes WHERE AnimeID="+ animeID +"";

                    //Exceutes the SQL query
                    Cmd.ExecuteNonQuery();

                    //sets the variable animeID with the value from the select query
                    var Picture = Cmd.ExecuteScalar();

                    //sets the global variable animePic with the url in the varaiable Picture
                    animePic = Picture.ToString();

                    //loads the url in the global variable animePic in the picturebox PbAnimePicture4
                    PbAnimePicture4.LoadAsync(animePic);

                    //Sets the global variable AnimeName with the text from the textbox tbSearch
                    AnimeName = tbSearch.Text;

                    //sets the label lbAnimeTitle with the text from the textbox tbSearch
                    lbAnimeTitle.Text = tbSearch.Text;

                    //sets the visibility of the panel PaAnimePanel to true (visible)
                    PaAnimePanel.Visible = true;
                    
                   
                }
            }

        }
        /// <summary>
        /// The resulting method for when the picture is clicked by the user
        /// </summary>
        /// <param name="sender"> The <see cref="System.Object"/> that represents the sender instance  </param>
        /// <param name="e">The <see cref="System.EventArgs"/> that Represents the event arguments passed to the event handler </param>

        private void PbAnimePicture1_Click(object sender, EventArgs e)
        {
            //sets the global variable animePic with url as its value
            animePic = @"https://cdn.myanimelist.net/images/anime/7/3791l.jpg";

            //sets the global variable AnimeName with the text from the label lbCowboyBepop as value
            AnimeName = lbCowboybebop.Text;

            //Creates a variable from the Form FmAnimeInformation
            FmAnimeInformation FmAnime = new FmAnimeInformation();

            // Shows the Form FmAnimeInformation through the variable
            FmAnime.ShowDialog();


        }
        /// <summary>
        /// The resulting method for when the picture is clicked by the user
        /// </summary>
        /// <param name="sender"> The <see cref="System.Object"/> that represents the sender instance  </param>
        /// <param name="e">The <see cref="System.EventArgs"/> that Represents the event arguments passed to the event handler </param>

        private void PbAnimePicture2_Click(object sender, EventArgs e)
        {
            //sets the global variable animePic with url as its value
            animePic = @"https://cdn.myanimelist.net/images/anime/8/19968l.jpg";

            //sets the global variable AnimeName with the text from the label lbtrigun as value
            AnimeName = lbTrigun.Text;

            //Creates a variable from the Form FmAnimeInformation
            FmAnimeInformation FmAnime = new FmAnimeInformation();

            // Shows the Form FmAnimeInformation through the variable
            FmAnime.ShowDialog();
        }

        /// <summary>
        /// The resulting method for when the picture is clicked by the user
        /// </summary>
        /// <param name="sender"> The <see cref="System.Object"/> that represents the sender instance  </param>
        /// <param name="e">The <see cref="System.EventArgs"/> that Represents the event arguments passed to the event handler </param>

        private void PbAnimePicture3_Click(object sender, EventArgs e)
        {
            //sets the global variable animePic with url as its value
            animePic = @"https://cdn.myanimelist.net/images/anime/1/20l.jpg";

            // sets the global variable AnimeName with the text from the label lbNaruto as value
            AnimeName = lbNaruto.Text;

            //Creates a variable from the Form FmAnimeInformation
            FmAnimeInformation FmAnime = new FmAnimeInformation();

            // Shows the Form FmAnimeInformation through the variable
            FmAnime.ShowDialog();     
            
        }

        /// <summary>
        /// The resulting method for when the picture is clicked by the user
        /// </summary>
        /// <param name="sender"> The <see cref="System.Object"/> that represents the sender instance  </param>
        /// <param name="e">The <see cref="System.EventArgs"/> that Represents the event arguments passed to the event handler </param>

        private void PbAnimePicture4_Click(object sender, EventArgs e)
        {
            //Creates a variable from the Form FmAnimeInformation
            FmAnimeInformation FmAnime = new FmAnimeInformation();

            // Shows the Form FmAnimeInformation through the variable
            FmAnime.ShowDialog();
            
        }

        /// <summary>
        /// The resulting method for when the profile button is clicked by the user
        /// </summary>
        /// <param name="sender"> The <see cref="System.Object"/> that represents the sender instance  </param>
        /// <param name="e">The <see cref="System.EventArgs"/> that Represents the event arguments passed to the event handler </param>

        private void btProfile_Click(object sender, EventArgs e)
        {
            //Creates a variable from the Form FmProfile
            FmProfile FmProfile = new FmProfile();

            // Shows the Form FmProfile through the variable
            FmProfile.ShowDialog();
        }

        /// <summary>
        /// The resulting method for when the back button is clicked by the user
        /// </summary>
        /// <param name="sender"> The <see cref="System.Object"/> that represents the sender instance  </param>
        /// <param name="e">The <see cref="System.EventArgs"/> that Represents the event arguments passed to the event handler </param>

        private void btBack_Click(object sender, EventArgs e)
        {

            //sets the visibility of the panel PaAnimePanel to false (invisible)
            PaAnimePanel.Visible = false;

            //sets the visibility of the label lbNaruto to true (visible)
            lbNaruto.Visible = true;

            //sets the visibility of the label lbTrigun to true (visible)
            lbTrigun.Visible = true;

            //sets the visibility of the label lbCowboybebop to true (visible)
            lbCowboybebop.Visible = true;

        }

        /// <summary>
        /// The resulting method for when the switch button is clicked by the user
        /// </summary>
        /// <param name="sender"> The <see cref="System.Object"/> that represents the sender instance  </param>
        /// <param name="e">The <see cref="System.EventArgs"/> that Represents the event arguments passed to the event handler </param>

        public void btSwitch_Click(object sender, EventArgs e)
        {
            //Refers to the class DarkmodeSwitch and runs the procedure
            DarkModeSwitch.SwitchFunction();

            //runs the procedure alongside the class DarkModeSwitch
            SetColour();
        }

    }
}







