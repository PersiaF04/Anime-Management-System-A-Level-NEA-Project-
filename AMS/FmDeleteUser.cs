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
    /// Handles all inputs and validation of functions that will take place in <c>FmDeleteUser</c>
    /// </summary>
    public partial class FmDeleteUser : Form
    {
        /// <summary>
        ///     Required Method for Designer support for <c>FmDeleteUser</c>
        /// </summary>
        public FmDeleteUser()
        {
            InitializeComponent();
        }

        /// <summary>
        /// The resulting method for when the Form loads
        /// </summary>
        /// <param name="sender"> The <see cref="System.Object"/> that represents the sender instance  </param>
        /// <param name="e">The <see cref="System.EventArgs"/> that Represents the event arguments passed to the event handler </param>

        private void FmDeleteUser_Load(object sender, EventArgs e)
        {
            //Sets the textbox tbUserID to the value of the global variable UserID from FmAMS(Admin) which contains a cell
            tbUserID.Text = FmAMS_admin_.UserID;

            //Sets the textbox tbUsername to the value of the global variable Studio from FmLogIn which contains the username of the user
            tbUsername.Text = FmAMS_admin_.Username;
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

                //The delete query will happen on the row containing the UserID that's the same as the textbox tbUserID in UserFavourites
                Cmd.CommandText ="DELETE FROM UserFavourites WHERE UserID="+tbUserID.Text+"";

                //Executes the SQL Query
                Cmd.ExecuteNonQuery();

                //The delete query will happen on the row containing the UserID that's the same as the textbox tbUserID in UserWatchList
                Cmd.CommandText = "DELETE FROM UserWatchList WHERE UserID=" + tbUserID.Text + "";

                //Executes the SQL Query
                Cmd.ExecuteNonQuery();

                //The delete query will happen on the row containing the UserID that's the same as the textbox tbUserID in Users
                Cmd.CommandText = "DELETE FROM Users WHERE UserID=" + tbUserID.Text + " AND Username='" +tbUsername.Text+ "'";

                //Executes the SQL Query
                Cmd.ExecuteNonQuery();

                //Displays a message box informing the user that the user is now deleted
                MessageBox.Show("User is now deleted!");
            }
            catch (Exception) //catches error
            {
                //Displays a message box informing the user that the user could not be deleted
                MessageBox.Show("User could not be deleted!");
            }
        }

        /// <summary>
        /// The resulting method for when the user clicks on the Clear button
        /// </summary>
        /// <param name="sender"> The <see cref="System.Object"/> that represents the sender instance  </param>
        /// <param name="e">The <see cref="System.EventArgs"/> that Represents the event arguments passed to the event handler </param>
        private void BtClear_Click(object sender, EventArgs e)
        {
            //Clears the text that was entered in the textbox tbUserID
            tbUserID.Clear();

            //Clears the text that was entered in the textbox tbUsername
            tbUsername.Clear();
        }
    }
}
