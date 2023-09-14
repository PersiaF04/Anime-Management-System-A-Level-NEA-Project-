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
    /// Handles all inputs and validation of functions that will take place in <c>FmEditGenres</c>
    /// </summary>
    public partial class FmEditGenres : Form
    {
        /// <summary>
        ///     Required Method for Designer support for <c>FmEditGenres</c>
        /// </summary>
        public FmEditGenres()
        {
            InitializeComponent();

        }
        /// <summary>
        /// The resulting method for when the Form loads
        /// </summary>
        /// <param name="sender"> The <see cref="System.Object"/> that represents the sender instance  </param>
        /// <param name="e">The <see cref="System.EventArgs"/> that Represents the event arguments passed to the event handler </param>

        private void FmEditGenres_Load(object sender, EventArgs e)
        {
            //Sets the textbox tbGenreID to the value of the global variable GenreID from FmAMS(Admin) which contains a cell
            tbGenreID.Text = FmAMS_admin_.GenreID;

            //Sets the textbox tbGenre to the value of the global variable Genre from FmAMS(Admin) which contains a cell
            tbGenre.Text = FmAMS_admin_.Genre;
        }

        /// <summary>
        /// The resulting method for when the user clicks on the insert button
        /// </summary>
        /// <param name="sender"> The <see cref="System.Object"/> that represents the sender instance  </param>
        /// <param name="e">The <see cref="System.EventArgs"/> that Represents the event arguments passed to the event handler </param>
        private void btInsert_Click(object sender, EventArgs e)
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

                // Insert the textboxes, tbGenreID, tbGenre to the table Genres.
                Cmd.CommandText = "INSERT INTO Genres VALUES("+ tbGenreID.Text + ", '" + tbGenre.Text + "')";

                //Executes the SQL Query
                Cmd.ExecuteNonQuery();

                //Displays a message box telling the user that everything from the textbox has been added!
                MessageBox.Show("Information successfully added!");

                // Closes the connection to the database
                Conn.Close();

            }
            catch(Exception) //catches error
            {
                //Displays a message box informing the user that it could not be added
                MessageBox.Show("Information could not be added!");
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

                //Updates the information contained in Studio with the textbox tbStudio. This update will take place in where the GenreID is same as the textbox tbGenreID
                Cmd.CommandText ="UPDATE Genres SET Genre = '"+tbGenre.Text+"' WHERE GenreID="+tbGenreID.Text+"";

                //Executes the SQL Query
                Cmd.ExecuteNonQuery();

                //Displays a message box informing the user that the information has been updated
                MessageBox.Show("Information updated!");

                // Closes the connection to the database
                Conn.Close();
            }
            catch(Exception) //catches error
            {
                //Displays a message box informing the user that the update could not happen
                MessageBox.Show("Information could not be updated!");
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

                //The delete query will happen on the row containing the GenreID that's the same as the textbox tbGenreID
                Cmd.CommandText = "DELETE FROM Genres WHERE GenreID= "+tbGenreID.Text+"";

                //Executes the SQL Query
                Cmd.ExecuteNonQuery();

                //Displays a message box informing the user that the information is now deleted
                MessageBox.Show("Information deleted!");

                // Closes the connection to the database
                Conn.Close();

            }
            catch(Exception) //catches error
            {
                //Displays a message box informing the user that the information could not be deleted
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
            //Clears the text that was entered in the textbox tbGenreID
            tbGenreID.Clear();

            //Clears the text that was entered in the textbox tbGenre
            tbGenre.Clear();
        }
    }
}
