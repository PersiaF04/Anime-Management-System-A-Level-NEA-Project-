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

namespace AMS
{
    /// <summary>
    /// Handles all inputs and validation of functions that will take place in <c>FmUserFavourites</c>
    /// </summary>
    public partial class FmUserFavourites : Form
    {
        /// <summary>
        ///     Required Method for Designer support for <c>FmUserFavourites</c>
        /// </summary>
        public FmUserFavourites()
        {
            InitializeComponent();
        }

        /// <summary>
        /// The resulting method for when the Form loads
        /// </summary>
        /// <param name="sender"> The <see cref="System.Object"/> that represents the sender instance  </param>
        /// <param name="e">The <see cref="System.EventArgs"/> that Represents the event arguments passed to the event handler </param>
        private void FmUserFavourites_Load(object sender, EventArgs e)
        {
            //Sets the label lbUsername to the global variable declared in the form FmLogIn which contains th user's username
            lbUsername.Text = FmLogIn.Username;

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

            //A select query to select everything from the table UserFavourites where
            //the location of the UserID is declared as the variable UserID
            Cmd.CommandText = "SELECT * From UserFavourites WHERE UserID=" + UserID + "";

            //Creates A connection between the datasource(select query) and dataset to Add rows or refresh rows
            OleDbDataAdapter da = new OleDbDataAdapter(Cmd);

            //Creates a table that will be filled with data from the select query
            DataTable table = new DataTable();

            //the data adapter da adds rows to the table
            da.Fill(table);

            // sets the datagridviewer UserFavouritesGrid source to that of the DataTable table
            // that is filled with data from the select query
            UserFavouritesGrid.DataSource = table;

            // Closes the connection to the database
            Conn.Close();

            //Displays the DataTable
            UserFavouritesGrid.Show();

            //Runs the procedure AutoFillSearch
            AutoFillSearch();
        }
        /// <summary>
        /// The resulting method for the procedure AutoFillSearch
        /// </summary>
        private void AutoFillSearch()
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

                //A select query to select AnimeTitle from the table UserFavourites where
                //the location of the UserID is declared as the variable UserID
                Cmd.CommandText = "SELECT AnimeTitle FROM UserFavourites WHERE UserID=" + UserID + "";

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
                MessageBox.Show("Could not load");
            }
        }

        /// <summary>
        /// The resulting method when the user clicks on a cell from the grid
        /// </summary>
        /// <param name="sender"> The <see cref="System.Object"/> that represents the sender instance</param>
        /// <param name="e">The <see cref="System.EventArgs"/> that represents the event arguments passed
        /// to the event handler</param>
        private void UserFavouritesGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
                DataGridViewRow row = UserFavouritesGrid.Rows[e.RowIndex];

                //Sets the textbox tbUserID to the cell value under the column UserID
                tbUserID.Text = row.Cells["UserID"].Value.ToString();

                //Sets the textbox tbAnimeID to the cell value under the column AnimeID
                tbAnimeID.Text = row.Cells["AnimeID"].Value.ToString();

                //Sets the textbox tbAnimeTitle to the cell value under the column AnimeTitle
                tbAnimeTitle.Text = row.Cells["AnimeTitle"].Value.ToString();

                //Sets the combobox cbRatings to the cell value under the column Ratings
                cbRatings.Text = row.Cells["Ratings"].Value.ToString();

                //A select query to select the AnimePictures from the table Animes where the
                //location of the AnimeTitle is declared as tbAnimeTitle
                Cmd.CommandText = "SELECT AnimePictures FROM Animes WHERE AnimeTitle='" + tbAnimeTitle.Text + "'";

                //sets the variable AnimePic to the result of the Sql query
                var AnimePic = Cmd.ExecuteScalar();

                //loads the url in the variable AnimePic to the picturebox PbAnimePicture
                PbAnimePicture.LoadAsync(AnimePic.ToString());

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
                try //Exception Handling
                {
                    // Gets value entered from the user to indicate the size of the columns and fill it with data
                    UserFavouritesGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                    //Creates A connection between the datasource(select query) and dataset to Add rows or refresh rows
                    OleDbDataAdapter Adapt = new OleDbDataAdapter();

                    //Creates an empty set for data to be filled
                    DataSet DS = new DataSet();

                    // Creates view of the the data stored in the dataset
                    DataView DV = new DataView();

                    // A select query that gets everything from the table UserFavourites where
                    // the location of the UserID is, and is declared as the variable UserID, when the user
                    // types a letter it is checked and compared to entries in the table
                    // to determine whetere a specific character string matches a specified pattern
                    //in the column AnimeTitle
                    string SQL = "SELECT * FROM UserFavourites WHERE AnimeTitle LIKE '" + tbSearch.Text + "%' AND UserID=" + UserID + "";

                    //Creates a database command object that contains the connection to the
                    //database and the string containing the select query
                    Cmd = new OleDbCommand(SQL, Conn);

                    //Creates A connection between the datasource(select query) and dataset to refresh rows from the command
                    Adapt = new OleDbDataAdapter(Cmd);

                    //Fills the DataSet with information from the select query
                    Adapt.Fill(DS);

                    // Creates a view of the data stored in the dataset
                    DV = new DataView(DS.Tables[0]);

                    // sets the datagridviewer UserFavouritesGrid source to that of the DataView
                    // that is filled with data from the select query
                    UserFavouritesGrid.DataSource = DV;

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
                //A select query to select everything from the table UserFavourites where
                //the location of the UserID is declared as the variable UserID
                Cmd.CommandText = "SELECT * FROM UserFavourites WHERE UserID=" + UserID + "";

                //Creates A connection between the datasource(select query) and dataset
                //to Add rows or refresh rows
                OleDbDataAdapter da = new OleDbDataAdapter(Cmd);

                //Creates a table that will be filled with data from the select query
                DataTable table = new DataTable();

                //the data adapter da adds rows to the table
                da.Fill(table);

                // sets the datagridviewer UserFavouritesGrid source to that of the DataTable table
                // that is filled with data from the select query
                UserFavouritesGrid.DataSource = table;

                //Closes the connection to the database
                Conn.Close();

                //Displays the DataTable
                UserFavouritesGrid.Show();
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

                //Creates a connection with the Command Object
                Cmd.Connection = Conn;

                //if the user did not select a rating
                if (cbRatings.SelectedIndex == -1)
                {
                    //Displays a message box informing the user to select a rating
                    MessageBox.Show("Please select a rating");
                }
                else
                {
                    //A select query to select the UserID From the table users where the location of
                    //the username is (the username is the label lbUsername)
                    Cmd.CommandText = "SELECT UserID FROM Users WHERE Username='" + lbUsername.Text + "'";

                    //sets the variable UserID to the result of the Sql query
                    var UserID = Cmd.ExecuteScalar();

                    //Updates the information contained in Ratings with the combobox cbRatings.
                    //This update will take place in the location where the UserID is as the same as the variable UserID
                    //and where the AnimeID is same as the textbox tbAnimeID
                    Cmd.CommandText = "UPDATE UserFavourites SET Ratings=" + cbRatings.Text + " WHERE UserID=" + UserID + " AND AnimeTitle='" + tbAnimeTitle.Text + "'";

                    //Executes the SQL Query
                    Cmd.ExecuteNonQuery();

                    //Displays a messagebox informing the user that their favourites list has been updated
                    MessageBox.Show(" Favourites Updated!");
                }
            }

            catch (Exception) //catches error
            {
                //Displays a messagebox informing the user that their favourites list could not be updated
                MessageBox.Show("Could not update Favourites!");
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
                Cmd.CommandText = "DELETE FROM UserFavourites WHERE UserID=" + UserID + " AND AnimeTitle='" + tbAnimeTitle.Text + "'";

                //Executes the SQL Query
                Cmd.ExecuteNonQuery();

                //Displays a  message box informing the user that the anime has been deleted from their favourites list
                MessageBox.Show("Deleted from Favourites!");
            }
            catch (Exception) //catches error
            {
                //Displays a  message box informing the user that the anime could not be deleted from their favourites list
                MessageBox.Show("Could not delete from favourites!");
            }
        }
        /// <summary>
        /// The resulting method for clearing the combobox and setting it to default
        /// </summary>
        private void ResetSelection()
        {
            //Sets the combo box to no element selected when - by 1
            cbRatings.SelectedIndex = -1;
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

            //Runs the procedure ResetSelection
            ResetSelection();
        }
    }
}
