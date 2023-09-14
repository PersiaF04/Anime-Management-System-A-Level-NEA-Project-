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
    /// Handles all inputs and validation of functions that will take place in <c>FmEditAnimeStudios</c>
    /// </summary>
    public partial class FmEditAnimeStudios : Form
    {
        /// <summary>
        ///     Required Method for Designer support for <c>FmEditAnimeStudios</c>
        /// </summary>
        public FmEditAnimeStudios()
        {
            InitializeComponent();
        }
        /// <summary>
        /// The resulting method for when the Form loads
        /// </summary>
        /// <param name="sender"> The <see cref="System.Object"/> that represents the sender instance  </param>
        /// <param name="e">The <see cref="System.EventArgs"/> that Represents the event arguments passed to the event handler </param>
        private void FmEditAnimeStudios_Load(object sender, EventArgs e)
        {
            //Sets the textbox tbAnimeID to the value of the global variable AnimeID from FmAMS(Admin) which contains a cell
            tbAnimeID.Text = FmAMS_admin_.AnimeID;

            //Sets the textbox tbStudioID to the value of the global variable StudioID from FmAMS(Admin) which contains a cell
            tbStudioID.Text = FmAMS_admin_.StudioID;
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

                //Insert the textboxes, tbAnimeID and tbStudioID to the table AnimeStudios.
                Cmd.CommandText = "INSERT INTO AnimeStudios VALUES("+tbAnimeID.Text+","+ tbStudioID.Text +")";

                //Executes the SQL Query
                Cmd.ExecuteNonQuery();

                //Displays a message box informing the user that everything from the textbox and the combobox has been added!
                MessageBox.Show("Information successfully inserted!");

                // Closes the connection to the database
                Conn.Close();

            }
            catch(Exception) //catches errror
            {
                //Displays a message box informing the user that it could not be added
                MessageBox.Show("Could not be inserted");
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

                //Updates the information contained in StudioID with the textbox tbStudioID. This update will take place in where the AnimeID is same as the textbox tbAnimeID
                Cmd.CommandText = "UPDATE AnimeStudios SET StudioID=" + tbStudioID.Text +" WHERE AnimeID="+tbAnimeID.Text+"";

                //Executes the SQL Query
                Cmd.ExecuteNonQuery();

                //Displays a message box informing the user that the information has been updated
                MessageBox.Show("Information successfully updated!");

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

                //The delete query will happen on the row containing the AnimeID that's the same as the textbox tbAnimeID
                Cmd.CommandText = "DELETE FROM AnimeStudios WHERE AnimeID= "+tbAnimeID.Text+"";

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
                MessageBox.Show("Information Could not be deleted!");
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

            //Clears the text that was entered in the textbox tbStudioID
            tbStudioID.Clear();
        }
    }
}
