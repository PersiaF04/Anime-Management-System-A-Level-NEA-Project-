using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using Newtonsoft.Json.Linq;
using System.Net;
using System.Text.RegularExpressions;

namespace AMS
{
    /// <summary>
    /// Handles all inputs and validation of functions that will take place in <c>FmAnimeInformation</c>
    /// </summary>
    public partial class FmAnimeInformation : Form
    {
        /// <summary>
        /// Global variable
        /// </summary>
        public static string AnimePicLoad;
        /// <summary>
        /// Global variable that is declared in <c>FmAnimeInformation</c>to make the form accessible to other forms
        /// </summary>
        public static FmAnimeInformation fmAnimeInformationInstance;

        /// <summary>
        ///     Required Method for Designer support for <c>FmAnimeInformation</c>
        /// </summary>
        public FmAnimeInformation()
        {
            InitializeComponent();
        }

        /// <summary>
        /// The resulting method when the form loads
        /// </summary>
        /// <param name="sender"> The <see cref="System.Object"/> that represents the sender instance</param>
        /// <param name="e">The <see cref="System.EventArgs"/> that represents the event arguments passed
        /// to the event handler</param>
        private void FmAnimeInformation_Load(object sender, EventArgs e)
        {
            //runs the procedure AnimeInformation
            AnimeInformation();

            //runs the procedure SynopsisApi
            SynopsisApi();

        }

        /// <summary>
        /// The resulting method for the procedure AnimeInformation
        /// </summary>
        private void AnimeInformation()
        {
            try
            {
                //sets the label lbAnimeName to the global variable in FmAMS AnimeName
                lbAnimeName.Text = FmAMS.AnimeName;

                //loads the link from the global variable in FmAMS to the picturebox PbAnimePicture
                PbAnimePicture.LoadAsync(FmAMS.animePic.ToString());

                //Create a database connection object with the constant defined in program.cs
                OleDbConnection Conn = new OleDbConnection(Program.connString);

                //Opens Connection to the database
                Conn.Open();

                //Creates a database command object
                OleDbCommand Cmd = new OleDbCommand();

                //Creates a connection with the Command Object
                Cmd.Connection = Conn;

                //A select query to select the AnimeID from the table Where the AnimeTitle is the same as the text in the label lbAnimeName
                Cmd.CommandText = "SELECT AnimeID FROM Animes WHERE AnimeTitle= '" + lbAnimeName.Text + "'";

                //Executes the SQL query
                Cmd.ExecuteNonQuery();

                //sets the variable ID to the result of the sql query
                var ID = Cmd.ExecuteScalar();

                //sets the label DbAnimeID text to the value ID in  string form
                DbAnimeID.Text = ID.ToString();

                //A select query to select the Status from the table Animes where the AnimeID is the same as the variable ID
                Cmd.CommandText = "SELECT Status FROM AnimeStatus WHERE AnimeID= " + ID + "";

                //Executes the SQL query
                Cmd.ExecuteNonQuery();

                //sets the variable status to the result of the sql query
                var Status = Cmd.ExecuteScalar();

                //sets the label DbStatus text to the value Status in string form
                DbStatus.Text = Status.ToString();

                //A select query to select the Ratings from the table Animes where the AnimeID is the same as the variable ID
                Cmd.CommandText = "SELECT Ratings From Animes WHERE AnimeID= " + ID + "";

                //Executes the SQL query
                Cmd.ExecuteNonQuery();

                //sets the variable Ratings to the result of the sql query
                var Ratings = Cmd.ExecuteScalar();

                //sets the label DbRatings text to the value Ratings in string form
                DbRatings.Text = Ratings.ToString();

                //A select query to select the GenreID from the table AnimeGenres where the AnimeID is the same as the variable ID
                Cmd.CommandText = "SELECT GenreID FROM AnimeGenres WHERE AnimeID= " + ID + "";

                //Executes the SQL query
                Cmd.ExecuteNonQuery();

                //sets the variable GenreID to the result of the sql query
                var GenreID = Cmd.ExecuteScalar();

                //A select query to select the Genre from the table Genres where the GenreID is the same as the variable GenreID
                Cmd.CommandText = "SELECT Genre FROM Genres WHERE GenreID= " + GenreID + "";

                //Executes the SQL query
                Cmd.ExecuteNonQuery();

                //sets the variable Genre to the result of the sql query
                var Genre = Cmd.ExecuteScalar();

                //sets the textbox tbGenres text to the value Genre in string form
                tbGenres.Text = Genre.ToString();

                //A select query to select the StudioID from the table AnimeStudios where the AnimeID is the same as the variable ID
                Cmd.CommandText = "SELECT StudioID FROM AnimeStudios WHERE AnimeID= " + ID + "";

                //Executes the SQL query
                Cmd.ExecuteNonQuery();

                //sets the variable StudioID to the result of the sql query
                var StudioID = Cmd.ExecuteScalar();

                //A select query to select the Studio from the table Studios where the StudioID is the same as the variable StudioID
                Cmd.CommandText = "SELECT Studio From Studios WHERE StudioID= " + StudioID + "";

                //Executes the SQL query
                Cmd.ExecuteNonQuery();

                //sets the variable Studio to the result of the sql query
                var Studio = Cmd.ExecuteScalar();

                //sets the label DbStudios text to the value Studio in string form
                DbStudios.Text = Studio.ToString();

                //A select query to select the Episodes from the table Animes where the AnimeID is the same as the variable ID
                Cmd.CommandText = "SELECT Episodes FROM Animes WHERE AnimeID=" + ID + "";

                //sets the variable Episodes to the result of the sql query
                var Episodes = Cmd.ExecuteScalar();

                //sets the label DbEpisodes text to the value Episodes in string form
                DbEpisodes.Text = Episodes.ToString();
            }
            catch //catches error
            {
                //Displays a message box informing the user that nothing was found 
                MessageBox.Show("Nothing was found");
            }
        }
        /// <summary>
        /// The resulting method for the procedure SynopsisApi
        /// </summary>
        private void SynopsisApi()
        {
            //Create a database connection object with the constant defined in program.cs
            OleDbConnection Conn = new OleDbConnection(Program.connString);

            //Opens Connection to the database
            Conn.Open();

            //Creates a database command object
            OleDbCommand Cmd = new OleDbCommand();

            //Creates a connection with the Command Object
            Cmd.Connection = Conn;

            //A select query to select the AnimeID from the table Animes Where the anime title is the same as the label lbAnimeName
            Cmd.CommandText = "SELECT AnimeID FROM Animes WHERE AnimeTitle= '" + lbAnimeName.Text + "'";

            //Executes the SQL query
            Cmd.ExecuteNonQuery();

            //sets the variable ID to the result of the sql query
            var ID = Cmd.ExecuteScalar();

            //A select query to select everything from the table Anime where the location of the AnimeTitle is (which contains the label lbAnimeName)
            Cmd.CommandText = "SELECT * FROM Animes WHERE AnimeTitle='" + lbAnimeName.Text + "'";

            //Creates a reader object and Executes the SQL Query
            OleDbDataReader reader = Cmd.ExecuteReader();

            // if the SQL query contains one or more rows
            if (reader.HasRows)
            {
                //read all the rows
                reader.Read();

                //sets the variable pic with the value AnimeSynopsis from the table Animes
                var Asynopsis = reader["AnimeSynopsis"].ToString();

                //declaring numeric value as an integer
                int numericvalue;

                //if the Asynopsis can be parsed as an integer meaning that the variable Asynopsis contains no text but the placeholder value
                if (int.TryParse(Asynopsis, out numericvalue))
                {
                    try //Exception Handling
                    {
                        // Declaring anime url as a string which contains an api link with the variable ID embedded into it
                        string animeURL = "https://api.jikan.moe/v4/anime/" + ID.ToString();

                        //parses the url as a jsonfile and downloads the jsonfile
                        JObject json = JObject.Parse(new WebClient().DownloadString(animeURL));

                        //declaring the variable text with the value json where it contains synopsis
                        var text = json["data"]["synopsis"];

                        //Sets the rich text box rtbAnimeSynopsis to the variable text in string form
                        rtbAnimeSynopsis.Text = text.ToString();

                        //sets the variable AnimeSynopsis  to the value of the variable text in string form
                        var AnimeSynopsis = text.ToString();

                        //Closes the reader object
                        reader.Close();

                        // sets the variable EditedSynopsis with the value AnimeSynopsis where all the apostrophe
                        // is replaced with an empty space so that the sql query can work without an error
                        var EditedSynopsis = AnimeSynopsis.Replace("'", " ");

                        //Update AnimeSynopsis with the synopsis from EditedSynopsis. This update will take place where the  location of the AnimeID is (which contains the variable ID)
                        Cmd.CommandText = "UPDATE Animes SET AnimeSynopsis= '" + EditedSynopsis + "' WHERE AnimeID =" + ID.ToString() + "";

                        //Executes the SQL query
                        Cmd.ExecuteNonQuery();
                    }
                    catch(Exception) //catches error
                    {
                        //Displays a message box informing the user that the synopsis could not be found
                        MessageBox.Show("The synopsis could not be found");
                    }
                    
                }

                //if it could not be parsed as an integer this means that there is a synopsis in the table
                else
                {
                    //sets the variable animeID with the value AnimeID from the table
                    var animeID = reader["AnimeID"].ToString();

                    //closes the reader object
                    reader.Close();

                    //A select query to select the AnimeSynopsis in where the location of the AnimeID is the same as the variable animeID
                    Cmd.CommandText = "SELECT AnimeSynopsis FROM Animes WHERE AnimeID=" + animeID + "";

                    //Executes the SQL query
                    Cmd.ExecuteNonQuery();

                    //sets the variable Synopsis to the result of the sql query
                    var Synopsis = Cmd.ExecuteScalar();

                    //Sets the value of the rich text box rtbAnimeSynopsis to value of the variable Synopsis in string form
                    rtbAnimeSynopsis.Text = Synopsis.ToString();
                }
            }

        }
        /// <summary>
        /// The resulting method for when the 'Add to favourites' button is clicked by the user
        /// </summary>
        /// <param name="sender"> The <see cref="System.Object"/> that represents the sender instance</param>
        /// <param name="e">The <see cref="System.EventArgs"/> that represents the event arguments passed
        /// to the event handler</param>
        private void btFavourites_Click(object sender, EventArgs e)
        {
            try //catches error
            {
                //Create a database connection object with the constant defined in program.cs
                OleDbConnection Conn = new OleDbConnection(Program.connString);

                //Opens Connection to the database
                Conn.Open();

                //Creates a database command object
                OleDbCommand Cmd = new OleDbCommand();

                //Creates a connection with the Command Object
                Cmd.Connection = Conn;

                //if the user did not select a rating from the combo box cbRatings
                if (cbRate.SelectedIndex == -1)
                {
                    //Displays a message box informing the user to select a rating
                    MessageBox.Show("Please select a rating!");
                }

                else
                {
                    //sets the variable Username to the global variable Username from FmLogIn
                    var Username = FmLogIn.Username;

                    //A select query to select the UserID in the location where the username is and it is the same value as the variable Username 
                    Cmd.CommandText = "SELECT UserID FROM Users WHERE Username='" + Username + "'";

                    //sets the variable UserID to the result of the sql query
                    var UserID = Cmd.ExecuteScalar();

                    //sets the label lbAnimeName to the global variable AnimeName from FmAMS
                    lbAnimeName.Text = FmAMS.AnimeName;

                    //A select query to count the entries where it contains the AnimeTitle that is the
                    //same as lbAnimeName and the userID which is the same as the variable userID
                    Cmd.CommandText = "SELECT count(*) From UserFavourites WHERE AnimeTitle='" + lbAnimeName.Text + "' AND UserID=" + UserID + "";

                    //sets the integer count to the result of the sql query in an integer format
                    int Count = Convert.ToInt32(Cmd.ExecuteScalar());

                    //if the count is more than 0 meaning it already exists in th table UserFavourites
                    if (Count > 0)
                    {
                        //Displays a message box informing the user that the Anime is already in their favourites
                        MessageBox.Show("Anime is already favourited");
                    }

                    //if it does not exist in the table UserFavourites
                    else
                    {
                        //An insert query to insert the variable UserID, the label DbAnimeID, the label lbAnimeName and the combo box value from cbRate into the table UserFavourites
                        Cmd.CommandText = "INSERT INTO UserFavourites(UserID, AnimeID, AnimeTitle, Ratings) VALUES(" + UserID + "," + DbAnimeID.Text + ",'" + lbAnimeName.Text + "', " + cbRate.Text + ")";

                        //Executes the SQL query
                        Cmd.ExecuteNonQuery();

                        //Displays a message box informing the user that the anime has been added to WatchList
                        MessageBox.Show("Added to favourites!");
                    }
                }

            }

            
            catch(Exception) //catches an error
            {
                //Displays a messagebox informing the user that it was invalid.
                MessageBox.Show("Invalid");
            }
        }

        /// <summary>
        /// The resulting method for when the 'Add to Watchlist' button is clicked by the user
        /// </summary>
        /// <param name="sender"> The <see cref="System.Object"/> that represents the sender instance</param>
        /// <param name="e">The <see cref="System.EventArgs"/> that represents the event arguments passed
        /// to the event handler</param>
        private void btWatchList_Click(object sender, EventArgs e)
        {
            try//Catches error
            {
                //Create a database connection object with the constant defined in program.cs
                OleDbConnection Conn = new OleDbConnection(Program.connString);

                //Opens Connection to the database
                Conn.Open();

                //Creates a database command object
                OleDbCommand Cmd = new OleDbCommand();

                //Creates a connection with the Command Object
                Cmd.Connection = Conn;

                //if user did not select a watch status from the combobox cbWatchStatus
                if (cbWatchStatus.SelectedIndex == -1)

                {
                    //Displays a message box informing the user to select a watch status
                    MessageBox.Show("Please select a watch status");
                }

                //if the user did not select a rating
                else if (cbRate.SelectedIndex ==-1)
                {
                    //Displays a message box informing the user to select a rating
                    MessageBox.Show("Please select a rating");
                }

                //otherwise
                else
                {
                    //sets the variable Username to the global variable Username from FmLogIn
                    var Username = FmLogIn.Username;

                    //A select query to select the UserID in the location where the username is and it is the same value as the variable Username 
                    Cmd.CommandText = "SELECT UserID FROM Users WHERE Username='" + Username + "'";

                    //Executes the SQL query
                    Cmd.ExecuteNonQuery();

                    //sets the variable UserID to the result of the sql query
                    var UserID = Cmd.ExecuteScalar();

                    //A select query to count the entries where it contains the AnimeTitle that is the
                    //same as lbAnimeName and the userID which is the same as the variable userID
                    Cmd.CommandText = "SELECT count(*) From UserWatchList WHERE AnimeTitle= @AnimeTitle AND UserID= @UserID";

                    //Parameterised SQL which contains the label lbAnimeName
                    Cmd.Parameters.Add("@AnimeTitle", OleDbType.Char).Value = lbAnimeName.Text;

                    //Parameterised SQL which contains the variable UserID
                    Cmd.Parameters.Add("@UserID", OleDbType.Integer).Value = UserID;

                    //sets the integer count to the result of the sql query in an integer format
                    int Count = Convert.ToInt32(Cmd.ExecuteScalar());

                    //if the count is more than 0 meaning it already exists in the table UserWatchList
                    if (Count > 0)
                    {
                        //Displays a message box informing the user that the Anime is already in the user's watch list
                        MessageBox.Show("Anime is already in Watchlist!");
                    }

                    //if it does not exist in the table UserFavourites
                    else
                    {
                        //An insert query to insert the variable UserID, the label DbAnimeID, the label lbAnimeName, the combo box value
                        //from cbWatchStatus, the textbox value tbEpisodesWatched and the combo box value from cbRate into the table UserWatchList
                        Cmd.CommandText = "INSERT INTO UserWatchList(UserID, AnimeID, AnimeTitle, WatchStatus, EpisodesWatched, Ratings) VALUES(" + UserID + "," + DbAnimeID.Text + ",'" + lbAnimeName.Text + "','" + cbWatchStatus.Text + "' , " + tbEpisodesWatched.Text + "," + cbRate.Text + ")";

                        //Executes the sql query
                        Cmd.ExecuteNonQuery();

                        //Displays a message box informing the user that the anime has been added to their watch list
                        MessageBox.Show("Added to watchlist!");

                    }
                }
            }
            catch(Exception) //catches error
            {
                //Displays a messagebox informing the user that it was invalid.
                MessageBox.Show("Invalid");
            }
        }

        /// <summary>
        /// The resulting method for when the textbox tbEpisodeWatched is validating the user's input
        /// </summary>
        /// <param name="sender"> The <see cref="System.Object"/> that represents the sender instance</param>
        /// <param name="e">The <see cref="System.EventArgs"/> that represents the event arguments passed
        /// to the event handler</param>
        private void tbEpisodeWatched_Validating(object sender, CancelEventArgs e)
        {
                //Regex validation for symbols
                var hasSymbols = new Regex(@"[!@#$^&*()_+=\[{\]};:<>|./?,-]+");

                //Regex validation for numbers
                var hasNumber = new Regex(@"[0-9]+");
               
                //if the text in the textbox tbEpisodesWatched does not contain numbers
                if (!hasNumber.IsMatch(tbEpisodesWatched.Text))
                {

                    //Displays a message box informing the user to enter a number
                    MessageBox.Show("Please enter a number!");

                   //sets the text in the textbox tbEpisodesWatched to the text 0.
                   tbEpisodesWatched.Text = "0";
                }

                //if the text in the textboxtbEpisodes Watched contains symbols
                else if (hasSymbols.IsMatch(tbEpisodesWatched.Text))
                {
                    //Displays a message box informing the user to enter a number
                    MessageBox.Show("Please enter a number!");

                    //sets the text in the textbox tbEpisodesWatched to the text 0.
                    tbEpisodesWatched.Text = "0"; 
                }

                //if the input is fully valid
                else
                {
                    //Create a database connection object with the constant defined in program.cs
                    OleDbConnection Conn = new OleDbConnection(Program.connString);

                    //Opens Connection to the database
                    Conn.Open();

                    //Creates a database command object
                    OleDbCommand Cmd = new OleDbCommand();

                    //Creates a connection with the Command Object
                    Cmd.Connection = Conn;

                     //A select query to select episodes from the table Animes from the location of the AnimeTitle
                    Cmd.CommandText = "SELECT Episodes FROM Animes WHERE AnimeTitle= @AnimeTitle";

                    //Parameteriesed SQL that contains the label lbAnimeName
                    Cmd.Parameters.Add("@AnimeTitle", OleDbType.Char).Value = lbAnimeName.Text;

                     //sets the integer Episodes to the result of the sql query in an integer format
                    int Episodes = Convert.ToInt32(Cmd.ExecuteScalar());
                    
                    //sets the integer EpisodesEntered to the value of the text
                    //tbEpisodesWatched in an integer format
                    int EpisodesEntered = Convert.ToInt32(tbEpisodesWatched.Text);

                    // if the episodes entered by the user is greater than the total episodes of the anime
                    if (EpisodesEntered > Episodes)
                    {
                        //Displays a message box informing the user that the episodes entered are out range
                        MessageBox.Show("Out of range!");
                        
                        //sets the text from the textbox tbEpisodesWatched with the variable Episodes
                        //which contains the total episodes of the anime
                        tbEpisodesWatched.Text = Episodes.ToString();
                    }

                    //if the episodes entered by the user is less than 0
                    else if (EpisodesEntered < 0)
                    {
                        
                        //Displays a message box informing the user that the episodes entered are out range
                        MessageBox.Show("Out of range!");

                        //sets the text from the textbox tbEpisodesWatched to 0 in text form
                        tbEpisodesWatched.Text = "0";
                    }

                    //Closes the connection to the database
                    Conn.Close();
                }

        }

        /// <summary>
        /// The resulting method for when the combo box cbWatchStatus is selected
        /// </summary>
        /// <param name="sender"> The <see cref="System.Object"/> that represents the sender instance</param>
        /// <param name="e">The <see cref="System.EventArgs"/> that represents the event arguments passed
        /// to the event handler</param>
        private void cbWatchStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Create a database connection object with the constant defined in program.cs
            OleDbConnection Conn = new OleDbConnection(Program.connString);

            //Opens Connection to the database
            Conn.Open();

            //Creates a database command object
            OleDbCommand Cmd = new OleDbCommand();

            //Creates a connection with the Command Object
            Cmd.Connection = Conn;

            //A select query to select episodes from the table Animes from the location of the AnimeTitle
            Cmd.CommandText = "SELECT Episodes FROM Animes WHERE AnimeTitle= @AnimeTitle";

            //Parameteriesed SQL that contains the label lbAnimeName
            Cmd.Parameters.Add("@AnimeTitle", OleDbType.Char).Value = lbAnimeName.Text;

            //sets the integer Episodes to the result of the sql query in an integer format
            int Episodes = Convert.ToInt32(Cmd.ExecuteScalar());

            //if the user selects "Completed" in the drop down list for cbWatchStatus
            if (cbWatchStatus.Text == "Completed")
            {

                //sets the text from the textbox tbEpisodesWatched with the variable Episodes
                //which contains the total episodes of the anime
                tbEpisodesWatched.Text = Episodes.ToString();
            }

            //if the user selects "Not Yet Watched" in the drop down list for cbWatchStatus
            else if (cbWatchStatus.Text == "Not Yet Watched")
            {

                //sets the text from the textbox tbEpisodesWatched to 0 in text form
                tbEpisodesWatched.Text = "0";
            }
        }
    }
}
