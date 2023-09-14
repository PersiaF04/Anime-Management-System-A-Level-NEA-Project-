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
    /// Handles all inputs and validation of functions that will take place in <c>FmEditAnimes</c>
    /// </summary>
    public partial class FmEditAnimes : Form
    {
        /// <summary>
        ///     Required Method for Designer support for <c>FmEditAnimes</c>
        /// </summary>
        public FmEditAnimes()
        {
            InitializeComponent();
        }

        /// <summary>
        /// The resulting method for when the Form loads
        /// </summary>
        /// <param name="sender"> The <see cref="System.Object"/> that represents the sender instance  </param>
        /// <param name="e">The <see cref="System.EventArgs"/> that Represents the event arguments passed to the event handler </param>

        private void FmEditAnimes_Load(object sender, EventArgs e)
        {
            //Sets the textbox tbAnimeID to the value of the global variable AnimeID from FmAMS(Admin) which contains a cell
            tbAnimeID.Text = FmAMS_admin_.AnimeID;

            //Sets the textbox tbAnimeTitle to the value of the global variable AnimeTitle from FmAMS(Admin) which contains a cell
            tbAnimeTitle.Text = FmAMS_admin_.AnimeTitle;

            //Sets the textbox tbEpisodes to the value of the global variable Episodes from FmAMS(Admin) which contains a cell
            tbEpisodes.Text = FmAMS_admin_.Episodes;

            //Sets the textbox tbRatings to the value of the global variable Ratings from FmAMS(Admin) which contains a cell
            tbRatings.Text = FmAMS_admin_.Ratings;

            //Sets the textbox tbAnimeSynopsis to the value of the global variable AnimeSynopsis from FmAMS(Admin) which contains a cell
            tbAnimeSynopsis.Text = FmAMS_admin_.AnimeSynopsis;

            //Sets the textbox tbAnimePictures to the value of the global variable AnimeID from FmAMS(Admin) which contains a cell
            tbAnimePictures.Text = FmAMS_admin_.AnimePictures;
        }
        /// <summary>
        /// The resulting method for when the user clicks on the insert button
        /// </summary>
        /// <param name="sender"> The <see cref="System.Object"/> that represents the sender instance  </param>
        /// <param name="e">The <see cref="System.EventArgs"/> that Represents the event arguments passed to the event handler </param>
        private void btInsert_Click(object sender, EventArgs e)
        {
            //Exception Handling
            try
            {
                //Create a database connection object with the constant defined in program.cs
                OleDbConnection Conn = new OleDbConnection(Program.connString);

                //Creates a database command object
                OleDbCommand Cmd = new OleDbCommand();

                //Creates a connection with the Command Object
                Cmd.Connection = Conn;

                //Insert the textboxes, tbAnimeID, tbAnimeTitle, tbEpisodes, tbRatings, tbAnimeSynopsis and tbAnimePictures to the table Animes.
                Cmd.CommandText = "INSERT INTO Animes VALUES("+tbAnimeID.Text+",'"+tbAnimeTitle.Text+"',"+ tbEpisodes.Text +","+tbRatings.Text+",'"+tbAnimeSynopsis.Text+"','" + tbAnimePictures.Text + "')";

                //Opens Connection to the database
                Conn.Open();

                //Executes the SQL Query
                Cmd.ExecuteNonQuery();

                // Closes the connection to the database
                Conn.Close();

                //Displays a message box informing the user that everything from the textbox has been added!
                MessageBox.Show("Information successfully added");
            }
            catch(Exception) //Catches error
            {
                //Displays a message box informing the user that it could not be added
                MessageBox.Show("Could not be added");
            }

        }
        /// <summary>
        /// The resulting method for when the user clicks on the update button
        /// </summary>
        /// <param name="sender"> The <see cref="System.Object"/> that represents the sender instance  </param>
        /// <param name="e">The <see cref="System.EventArgs"/> that Represents the event arguments passed to the event handler </param>
        private void btUpdate_Click(object sender, EventArgs e)
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

               //Updates the information contained in AnimeTitle, Episodes, Ratings, AnimeSynopsis and AnimePictures with the textboxes tbAnimeTitle, tbEpisodes, tbRatings, tbAnimeSynopsis and tbAnimePictures. This update will happen where AnimeID is the same as the value in textbox tbAnimeID
                Cmd.CommandText = "UPDATE Animes SET AnimeTitle='" + tbAnimeTitle.Text + "', Episodes= " + tbEpisodes.Text + ", Ratings= " + tbRatings.Text + ", AnimeSynopsis= '" + tbAnimeSynopsis.Text + "', AnimePictures='" + tbAnimePictures.Text + "' WHERE AnimeID=" + tbAnimeID.Text + "";

                //Executes the SQL Query
                Cmd.ExecuteNonQuery();

                //Displays a message box informing the user that the information has been updated
                MessageBox.Show("Information updated!");

                // Closes the connection to the database
                Conn.Close();
            }
            catch(Exception ) //Catches the error
            {
                //Displays a message box informing the user that the update could not happen
                MessageBox.Show("Could not update!");
            }

        }

        /// <summary>
        /// The resulting method for when the user clicks on the Delete button
        /// </summary>
        /// <param name="sender"> The <see cref="System.Object"/> that represents the sender instance  </param>
        /// <param name="e">The <see cref="System.EventArgs"/> that Represents the event arguments passed to the event handler </param>
        private void btDelete_Click(object sender, EventArgs e)
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

                //The delete query will happen on the row containing the AnimeID that's the same as the textbox tbAnimeID
                Cmd.CommandText = "DELETE FROM Animes WHERE AnimeID=" + tbAnimeID.Text + "";

                //Executes the SQL Query
                Cmd.ExecuteNonQuery();

                //Displays a message box telling the user that the information is now deleted
                MessageBox.Show("Information is now deleted!");

                // Closes the connection to the database
                Conn.Close();
            }
            catch(Exception)//Catches error
            {
                //Displays a message box telling the user that the information could not be deleted
                MessageBox.Show("Information could not be deleted!");
            }

        }

        /// <summary>
        /// The resulting method for when the user clicks on the Clear button
        /// </summary>
        /// <param name="sender"> The <see cref="System.Object"/> that represents the sender instance  </param>
        /// <param name="e">The <see cref="System.EventArgs"/> that Represents the event arguments passed to the event handler </param>
        private void btClear_Click(object sender, EventArgs e)
        {
            //Clears the text that was entered in the textbox tbAnimeID
            tbAnimeID.Clear();

            //Clears the text that was entered in the textbox tbAnimeTitle
            tbAnimeTitle.Clear();

            //Clears the text that was entered in the textbox tbEpisodes
            tbEpisodes.Clear();

            //Clears the text that was entered in the textbox tbRatings
            tbRatings.Clear();

            //Clears the text that was entered in the textbox tbAnimePictures
            tbAnimePictures.Clear();

            //Clears the text that was entered in the textbox tbAnimeSynopsis
            tbAnimeSynopsis.Clear();

        }
    }
}
