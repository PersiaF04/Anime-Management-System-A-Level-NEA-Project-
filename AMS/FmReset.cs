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
    /// Handles all inputs and validation of functions that will take place in <c>FmReset</c>
    /// </summary>
    public partial class FmReset : Form
    {
        /// <summary>
        ///     Required Method for Designer support for <c>FmReset</c>
        /// </summary>
        public FmReset()
        {
            InitializeComponent();
        }
        /// <summary>
        /// The resulting method when the user clicks on the Find button
        /// </summary>
        /// <param name="sender"> The <see cref="System.Object"/> that represents the sender instance  </param>
        /// <param name="e">The <see cref="System.EventArgs"/> that Represents the event arguments passed to the event handler </param>
        /// 
        private void btFind_Click(object sender, EventArgs e)
        {
            //Regex validation for Emails
            var EmailValid = new Regex(@"^([a-zA-Z0-9_\.\-\+])+\@(([a-zA-Z0-9\-])+\.)+([a-za-za-z]{2,3})+$");

            //Create a database connection object with the constant defined in program.cs
            OleDbConnection Conn = new OleDbConnection(Program.connString);

            //Opens Connection to the database
            Conn.Open();

            //Creates a database command object
            OleDbCommand Cmd = new OleDbCommand();

            //Creates a connection with the Command Object
            Cmd.Connection = Conn;

            //Sets the Variable UserName to the global variable Username from FmLogIn
            var UserName = FmLogIn.Username.ToString();

            //Select email from the table users from the username that is given
            Cmd.CommandText = "SELECT Email FROM Users WHERE Username='" + UserName + "'";

            //Creates a reader object and Executes the SQL Query
            OleDbDataReader reader = Cmd.ExecuteReader();

            // if the SQL query contains one or more rows
            if (reader.HasRows)
            {

                //read all the rows
                reader.Read();

                //If the email that is entered in the textbox tbEmail
                //does not match with the Selected Email
                if (tbEmail.Text != reader["Email"].ToString())
                {
                    //Displays a message window stating that the User's Entered Email
                    //is not correct/does not match up with the selected email
                    MessageBox.Show("This Email is incorrect");

                    //Clears the text that was entered in the textbox tbEmail
                    tbEmail.Clear();
                }

                // if the email that is entered in the textbox tbEmail
                //does not match regex validation for emails
                else if(!EmailValid.IsMatch(tbEmail.Text))
                {

                    //Displays a message window stating that the User's
                    //entered email is not vaild
                    MessageBox.Show("This is not a valid email address");

                }

                //If the entered Email matches the selected email and
                //matches regex validation for emails
                else
                {
                    //Set the visibilty of the label lbNewPassword to true(makes it visible to the user)
                    lbNewPassword.Visible = true;

                    //Set the visibilty of the label lbConfrimNewPassword to true(makes it visible to the user)
                    lbConfirmNewPassword.Visible = true;

                    //Set the visibilty of the textbox tbNewPassword to true(makes it visible to the user)
                    tbNewPassword.Visible = true;

                    //Set the visibilty of the textbox tbConfirmNewPassword to true(makes it visible to the user)
                    tbConfirmNewPassword.Visible = true;

                    //Closes the reader command object
                    reader.Close();
                }
            }

        }

        /// <summary>
        /// The resulting method when the user clicks on the Change button
        /// </summary>
        /// <param name="sender"> The <see cref="System.Object"/> that represents the sender instance  </param>
        /// <param name="e">The <see cref="System.EventArgs"/> that Represents the event arguments passed to the event handler </param>
        /// 
        private void btChange_Click(object sender, EventArgs e)
        {
            //Regex validation for upper case letters
            var hasUpperChar = new Regex(@"[A-Z]+");

            //Regex validation for lower case letters
            var hasLowerChar = new Regex(@"[a-z]+");

            //Regex validation for numbers
            var hasNumber = new Regex(@"[0-9]+");

            //Regex validation for symbols
            var hasSymbols = new Regex(@"[!@#$^&*()_+=\[{\]};:<>|./?,-]+");

            //Create a database connection object with the constant defined in program.cs
            OleDbConnection Conn = new OleDbConnection(Program.connString);

            //Opens Connection to the database
            Conn.Open();

            //Creates a database command object
            OleDbCommand Cmd = new OleDbCommand();

            //Creates a connection with the Command Object
            Cmd.Connection = Conn;

            //if the text entered in the textbox tbNewPassword does not match with the textbox tbConfirmNewPassword
            if (tbNewPassword.Text != tbConfirmNewPassword.Text)
            {
                //Displays a message window stating that the User
                //needs to enter the same password in both textboxes
                MessageBox.Show("Please enter the same password in both fields");
            }

            //if the text entered in the textbox tbNewPassword is empty
            else if (tbNewPassword.Text == "")
            {
                //Displays a message window stating that the User
                //needs to enter a password
                MessageBox.Show("Please enter a password");
            }

            //if the text entered in the textbox tbConfirmNewPassword is empty
            else if (tbConfirmNewPassword.Text == "")
            {
                //Displays a message window stating that the User
                //needs to enter a confirmation of new password
                MessageBox.Show("Enter confirmation of new password");
            }

            //if the text entered in the textbox tbConfirmNewPassword does not match the regex validation for
            //upper case letters or if the text entered in the textbox tbNewPassword
            //does not match the regex validation for Upper case letters
            else if(!hasUpperChar.IsMatch(tbConfirmNewPassword.Text)|| !hasUpperChar.IsMatch(tbNewPassword.Text))
            {

                //Displays a message window stating that the User's Entered password
                //must contain atleast one upper case letter
                MessageBox.Show("Your new password must contain atleast one upper case letter");
            }

            //if the text entered in the textbox tbConfirmNewPassword does not match the regex validation for
            //lower case letters or if the text entered in the textbox tbNewPassword
            //does not match the regex validation for lower case letters
            else if (!hasLowerChar.IsMatch(tbConfirmNewPassword.Text)|| !hasLowerChar.IsMatch(tbNewPassword.Text))
            {

                //Displays a message window stating that the User's Entered password
                //must contain atleast one lower case letter
                MessageBox.Show("Your new password must contain atleast one lower case letter");
            }

            //if the text entered in the textbox tbConfirmNewPassword does not match the regex validation for
            //numbers or if the text entered in the textbox tbNewPassword
            //does not match the regex validation for numbers
            else if (!hasNumber.IsMatch(tbConfirmNewPassword.Text)|| !hasNumber.IsMatch(tbNewPassword.Text))
            {

                //Displays a message window stating that the User's Entered password
                //must contain atleast one numeric value
                MessageBox.Show("Your new password must contain atleast one upper numeric value");

            }

            //if the text entered in the textbox tbConfirmNewPassword does not match the regex validation for
            //symbols or if the text entered in the textbox tbNewPassword
            //does not match the regex validation for symbols
            else if (!hasSymbols.IsMatch(tbConfirmNewPassword.Text)||!hasSymbols.IsMatch(tbNewPassword.Text))
            {

                //Displays a message window stating that the User's Entered password
                //must contain atleast one symbol
                MessageBox.Show("Your new password must contain atleast one symbol");
            }
            
            //if all the requirements are met for regex validation and the textboxes are not empty
            else
            {
                //Set the variable username to the global variable in FmLogIn
                var UserName = FmLogIn.Username.ToString();

                //Update the users password with the new hashed version of the confirmed password where the username is given
                Cmd.CommandText = "UPDATE Users SET Pword='" + Encryption.HashPassword(tbConfirmNewPassword.Text) + "'WHERE Username='" + UserName + "'";

                //Execute the sql statement
                Cmd.ExecuteNonQuery();

                //Displays a message window stating that the User's password
                //has been changed successfully
                MessageBox.Show("Password successfully changed");
            }
        }
    }
}
