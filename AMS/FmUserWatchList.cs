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
using System.Text.RegularExpressions;

namespace AMS
{
    /// <summary>
    /// Handles all inputs and validation of functions that will take place in <c>FmUserWatchList</c>
    /// </summary>
    public partial class FmUserWatchList : Form
    {
        /// <summary>
        ///     Required Method for Designer support for <c>FmUserWatchList</c>
        /// </summary>
        public FmUserWatchList()
        {
            InitializeComponent();
        }

        /// <summary>
        /// The resulting method for when the Form loads
        /// </summary>
        /// <param name="sender"> The <see cref="System.Object"/> that represents the sender instance  </param>
        /// <param name="e">The <see cref="System.EventArgs"/> that Represents the event arguments passed to the event handler </param
        private void FmUserWatchList_Load(object sender, EventArgs e)
        {
            //Sets the label lbUsername to the global variable declared in the form FmLogIn which contains th user's username
            lbUsername.Text = FmLogIn.Username;

            //sets the visibility of the label lbTotalEpisodes to false (invisible)
            lbTotalEpisodes.Visible = false;

            //sets the visibility of the label lbEpisodeCount to false (invisible)
            lbEpisodeCount.Visible = false;

            //Create a database connection object with the constant defined in program.cs
            OleDbConnection Conn = new OleDbConnection(Program.connString);

            //Opens Connection to the database
            Conn.Open();

            //Creates a database command object
            OleDbCommand Cmd = new OleDbCommand();

            //Creates a connection with the Command Object
            Cmd.Connection = Conn;

            //A select query to select the UserID From the table users where the location of
            //the username is (the username is the label lbUsername)
            Cmd.CommandText = "SELECT UserID FROM Users WHERE Username='" + lbUsername.Text + "'";

            //sets the variable UserID to the result of the Sql query
            var UserID = Cmd.ExecuteScalar();


            //A select query to select everything from the table UserWatchList where
            //the location of the UserID is declared as the variable UserID
            Cmd.CommandText = "SELECT * From UserWatchList WHERE UserID=" + UserID + "";

            //Creates A connection between the datasource(select query) and dataset to Add rows or refresh rows
            OleDbDataAdapter da = new OleDbDataAdapter(Cmd);

            //Creates a table that will be filled with data from the select query
            DataTable table = new DataTable();

            //the data adapter da adds rows to the table
            da.Fill(table);

            // sets the datagridviewer UserWatchListGrid source to that of the DataTable table
            // that is filled with data from the select query
            UserWatchListGrid.DataSource = table;

            // Closes the connection to the database
            Conn.Close();

            //Displays the DataTable
            UserWatchListGrid.Show();

            //Runs the procedure AutoFillSearch
            AutoFillSearch();

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

                //A select query to select the UserID From the table users where the location of
                //the username is (the username is the label lbUsername)
                Cmd.CommandText = "SELECT UserID FROM Users WHERE Username='" + lbUsername.Text + "'";

                //sets the variable UserID to the result of the Sql query
                var UserID = Cmd.ExecuteScalar();

                //A select query to select AnimeTitle from the table UserWatchList where
                //the location of the UserID is declared as the variable UserID
                Cmd.CommandText = "SELECT AnimeTitle FROM UserWatchList WHERE UserID=" + UserID + "";

                //Defines the autocompletefeature that holds a collection of strings, AutoFill
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
                MessageBox.Show("Anime title not found!");
            }
        }

        /// <summary>
        /// The resulting method when the user clicks on a cell from the grid
        /// </summary>
        /// <param name="sender"> The <see cref="System.Object"/> that represents the sender instance</param>
        /// <param name="e">The <see cref="System.EventArgs"/> that represents the event arguments passed
        /// to the event handler</param>
        private void UserWatchListGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Create a database connection object with the constant defined in program.cs
            OleDbConnection Conn = new OleDbConnection(Program.connString);

            //Opens Connection to the database
            Conn.Open();

            //Creates a database command object
            OleDbCommand Cmd = new OleDbCommand();

            //Creates a connection with the Command Object
            Cmd.Connection = Conn;

            //if the cell's row is greater than or equal to 0
            if (e.RowIndex >= 0)
            {

                //stores the cell's row into a datagridviewrow variable 'row'
                DataGridViewRow row = UserWatchListGrid.Rows[e.RowIndex];

                //Sets the textbox tbUserID to the cell value under the column UserID
                tbUserID.Text = row.Cells["UserID"].Value.ToString();

                //Sets the textbox tbAnimeID to the cell value under the column AnimeID
                tbAnimeID.Text = row.Cells["AnimeID"].Value.ToString();

                //Sets the textbox tbAnimeTitle to the cell value under the column AnimeTitle
                tbAnimeTitle.Text = row.Cells["AnimeTitle"].Value.ToString();

                //Sets the combobox cbWatchStatus to the cell value under the column WatchStatus
                cbWatchStatus.Text = row.Cells["WatchStatus"].Value.ToString();

                //Sets the textbox tbEpisodesWatched to the cell value under the column EpisodesWatched
                tbEpisodesWatched.Text = row.Cells["EpisodesWatched"].Value.ToString();

                //Sets the combobox cbRatings to the cell value under the column Ratings
                cbRatings.Text = row.Cells["Ratings"].Value.ToString();

                //A select query to select the AnimePictures from the table Animes where the
                //location of the AnimeTitle is declared as tbAnimeTitle
                Cmd.CommandText="SELECT AnimePictures FROM Animes WHERE AnimeTitle='"+tbAnimeTitle.Text+"'";

                //sets the variable AnimePic to the result of the Sql query
                var AnimePic = Cmd.ExecuteScalar();

                //loads the url in the variable AnimePic to the picturebox PbAnimePicture
                PbAnimePicture.LoadAsync(AnimePic.ToString());

                //A select query to select the Episodes from the table Animes where the
                //location of the AnimeTitle is declared as tbAnimeTitle
                Cmd.CommandText ="SELECT Episodes FROM Animes WHERE AnimeTitle='"+tbAnimeTitle.Text+"'";

                //sets the variable Episodes to the result of the Sql query
                var Episodes = Cmd.ExecuteScalar();

                //sets the label lbEpisodeCount text to the value of the variable Episodes
                lbEpisodeCount.Text = Episodes.ToString();

                //sets the visibility of the label lbTotalEpisodes to true (visible)
                lbTotalEpisodes.Visible = true;

                //sets the visibility of the label lbEpisodeCount to true (visible)
                lbEpisodeCount.Visible = true;

            }
        }

        /// <summary>
        /// The resulting method when the user presses a key in the textbox tbSearch
        /// </summary>
        /// <param name="sender"> The <see cref="System.Object"/> that represents the sender instance</param>
        /// <param name="e">The <see cref="System.EventArgs"/> that represents the event arguments passed
        /// to the event handler</param>
        private void tbSearch_KeyPress(object sender, KeyPressEventArgs e)
        {

            //Create a database connection object with the constant defined in program.cs
            OleDbConnection Conn = new OleDbConnection(Program.connString);

            //Opens Connection to the database
            Conn.Open();

            //Creates a database command object
            OleDbCommand Cmd = new OleDbCommand();

            //Opens Connection to the database
            Cmd.Connection = Conn;

            //A select query to select the UserID From the table users where the location of
            //the username is (the username is the label lbUsername)
            Cmd.CommandText = "SELECT UserID FROM Users WHERE Username='" + lbUsername.Text + "'";

            //sets the variable UserID to the result of the Sql query
            var UserID = Cmd.ExecuteScalar();

            //if the textbox tbSearch is not empty
            if (tbSearch.Text != "")
            {
                try
                {
                    // Gets value entered from the user to indicate the size of the columns and fill it with data
                    UserWatchListGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                    //Creates A connection between the datasource(select query) and dataset to Add rows or refresh rows
                    OleDbDataAdapter Adapt = new OleDbDataAdapter();

                    //Creates an empty set for data to be filled
                    DataSet DS = new DataSet();

                    // Creates view of the the data stored in the dataset
                    DataView DV = new DataView();

                    // A select query that gets everything from the table UserWatchList where
                    // the location of the UserID is, and is declared as the variable UserID, when the user
                    // types a letter it is checked and compared to entries in the table
                    // to determine whetere a specific character string matches a specified pattern
                    //in the column AnimeTitle
                    string SQL = "SELECT * FROM UserWatchList WHERE AnimeTitle LIKE '" + tbSearch.Text + "%' AND UserID=" + UserID + "";

                    //Creates a database command object that contains the connection to the
                    //database and the string containing the select query
                    Cmd = new OleDbCommand(SQL, Conn);

                    //Creates A connection between the datasource(select query) and dataset to refresh rows from the command
                    Adapt = new OleDbDataAdapter(Cmd);

                    //Fills the DataSet with information from the select query
                    Adapt.Fill(DS);

                    // Creates a view of the data stored in the dataset
                    DV = new DataView(DS.Tables[0]);

                    // sets the datagridviewer UserWatchListGrid source to that of the DataView
                    // that is filled with data from the select query
                    UserWatchListGrid.DataSource = DV;

                    //Closes the connection to the database
                    Conn.Close();
                }
                catch(Exception) //catches error
                {
                    //Displays a message box informing the user that their input is invalid
                    MessageBox.Show("Invalid input");
                }
            }

            //if the textbox tbSearch is empty
            else if (tbSearch.Text == "")
            {

                //A select query to select everything from the table UserWatchList where
                //the location of the UserID is declared as the variable UserID
                Cmd.CommandText = "SELECT * FROM UserWatchList WHERE UserID="+UserID+"";

                //Creates A connection between the datasource(select query) and dataset
                //to Add rows or refresh rows
                OleDbDataAdapter da = new OleDbDataAdapter(Cmd);

                //Creates a table that will be filled with data from the select query
                DataTable table = new DataTable();

                //the data adapter da adds rows to the table
                da.Fill(table);

                // sets the datagridviewer UserFavouritesGrid source to that of the DataTable table
                // that is filled with data from the select query
                UserWatchListGrid.DataSource = table;

                //Closes the connection to the database
                Conn.Close();

                //Displays the DataTable
                UserWatchListGrid.Show();
            }
        }


        /// <summary>
        /// The resulting method for when the user clicks on the update button
        /// </summary>
        /// <param name="sender"> The <see cref="System.Object"/> that represents the sender instance  </param>
        /// <param name="e">The <see cref="System.EventArgs"/> that Represents the event arguments passed to the event handler </param>
        private void btUpdate_Click(object sender, EventArgs e)
        {
            try //Exception Handling
            {

                //Create a database connection object with the constant defined in program.cs
                OleDbConnection Conn = new OleDbConnection(Program.connString);

                //Opens Connection to the database
                Conn.Open();

                //Creates a database command object
                OleDbCommand Cmd = new OleDbCommand();

                //if the user did not select a watch status
                if (cbWatchStatus.SelectedIndex == -1)
                {
                    //Displays a message box informing the user to select a watch status
                    MessageBox.Show("Please select a watch status!");
                }

                //if the user did not select a rating
                else if (cbRatings.SelectedIndex == -1)
                {
                    //Displays a message box informing the user to select a rating
                    MessageBox.Show("Please select a rating");
                }
                else
                {
                    //Creates a connection with the Command Object
                    Cmd.Connection = Conn;

                    //A select query to select the UserID From the table users where the location of
                    //the username is (the username is the label lbUsername)
                    Cmd.CommandText = "SELECT UserID FROM Users WHERE Username='" + lbUsername.Text + "'";

                    //sets the variable UserID to the result of the Sql query
                    var UserID = Cmd.ExecuteScalar();

                    //Updates the information contained in WatchStatus, EpisodesWatched and Ratings with the entries,
                    //cbWatchStatus, tbEpisodesWatched and cbRatings
                    //This update will take place in the location where the UserID is as the same as the variable UserID
                    //and where the AnimeID is same as the textbox tbAnimeID
                    Cmd.CommandText = "UPDATE UserWatchlist SET WatchStatus='" + cbWatchStatus.Text + "', EpisodesWatched=" + tbEpisodesWatched.Text + ",Ratings = " + cbRatings.Text + " WHERE UserID=" + UserID + " AND AnimeTitle='" + tbAnimeTitle.Text + "'";

                    //Executes the SQL Query
                    Cmd.ExecuteNonQuery();

                    //Displays a messagebox informing the user that their watch list has been updated
                    MessageBox.Show("WatchList Updated!");
                }
            }
            catch(Exception) //catches error
            {
                //Displays a messagebox informing the user that their favourites list could not be updated
                MessageBox.Show("Could not update WatchList!");
            }
        }

        /// <summary>
        /// The resulting method for when the textbox tbEpisodeWatched is validating the user's input
        /// </summary>
        /// <param name="sender"> The <see cref="System.Object"/> that represents the sender instance</param>
        /// <param name="e">The <see cref="System.EventArgs"/> that represents the event arguments passed
        /// to the event handler</param>
        private void tbEpisodesWatched_Validating(object sender, CancelEventArgs e)
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
                }

                //if the text in the textboxtbEpisodes Watched contains symbols
                else if(hasSymbols.IsMatch(tbEpisodesWatched.Text))
                {
                    //Displays a message box informing the user to enter a number
                    MessageBox.Show("Please Enter a number!");
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
                    Cmd.CommandText = "SELECT Episodes FROM Animes WHERE AnimeTitle='" + tbAnimeTitle.Text + "'";

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
        /// The resulting method for when the user clicks on the Delete button
        /// </summary>
        /// <param name="sender"> The <see cref="System.Object"/> that represents the sender instance  </param>
        /// <param name="e">The <see cref="System.EventArgs"/> that Represents the event arguments passed to the event handler </param>
        private void btDelete_Click(object sender, EventArgs e)
        {
            try //Exception Handling
            {

                //Create a database connection object with the constant defined in program.cs
                OleDbConnection Conn = new OleDbConnection(Program.connString);

                //Opens Connection to the database
                Conn.Open();

                //Creates a database command object
                OleDbCommand Cmd = new OleDbCommand();

                //Creates a connection with the Command Object
                Cmd.Connection = Conn;

                //A select query to select the UserID From the table users where the location of
                //the username is (the username is the label lbUsername)
                Cmd.CommandText = "SELECT UserID FROM Users WHERE Username='" + lbUsername.Text + "'";

                //sets the variable UserID to the result of the Sql query
                var UserID = Cmd.ExecuteScalar();

                //The delete query will happen on the row containing the UserID
                //that's the same as the variable UserID and AnimeTitle that's the same as the textbox tbAnimeTitle
                Cmd.CommandText = "DELETE FROM UserWatchList WHERE UserID=" + UserID + " AND AnimeTitle='" + tbAnimeTitle.Text + "'";

                //Executes the SQL Query
                Cmd.ExecuteNonQuery();

                //Displays a  message box informing the user that the anime has been deleted from their watch list
                MessageBox.Show("Deleted from WatchList!");
            }
            catch(Exception) //catches error
            {
                //Displays a  message box informing the user that the anime could not be deleted from their watch list
                MessageBox.Show("Could not delete from WatchList");
            }
        }
        /// <summary>
        /// The resulting method for clearing the combobox and setting it to default
        /// </summary>
        private void ResetSelection()
        {

            // Sets the combo box cbRatings to no element selected when -by 1
            cbRatings.SelectedIndex = -1;

            // Sets the combo box cbWatchStatus to no element selected when -by 1
            cbWatchStatus.SelectedIndex = -1;
        }
        /// <summary>
        /// The resulting method for when the user clicks on the Clear button
        /// </summary>
        /// <param name="sender"> The <see cref="System.Object"/> that represents the sender instance  </param>
        /// <param name="e">The <see cref="System.EventArgs"/> that Represents the event arguments passed to the event handler </param>
        private void btClear_Click(object sender, EventArgs e)
        {
            //Clears the text that was entered in the textbox tbUserID
            tbUserID.Clear();

            //Clears the text that was entered in the textbox tbAnimeID
            tbAnimeID.Clear();

            //Clears the text that was entered in the textbox tbAnimeTitle
            tbAnimeTitle.Clear();

            //Clears the text that was entered in the textbox tbEpisodesWatched
            tbEpisodesWatched.Clear();

            //Runs the procedure ResetSelection
            ResetSelection();
            
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

            //Creates a database command object
            Conn.Open();

            //Creates a connection with the Command Object
            OleDbCommand Cmd = new OleDbCommand();

            //Creates a connection with the Command Object
            Cmd.Connection = Conn;

            //A select query to select episodes from the table Animes from the location of the AnimeTitle
            Cmd.CommandText = "SELECT Episodes FROM Animes WHERE AnimeTitle= @AnimeTitle";

            //Parameteriesed SQL that contains the label lbAnimeName
            Cmd.Parameters.Add("@AnimeTitle", OleDbType.Char).Value = tbAnimeTitle.Text;

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
