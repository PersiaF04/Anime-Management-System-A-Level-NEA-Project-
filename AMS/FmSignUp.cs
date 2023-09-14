 using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.OleDb;
using System.Text.RegularExpressions;

namespace AMS
{
    /// <summary>
    /// Handles all inputs and validation of functions that will take place in <c>FmSignIn</c>
    /// </summary>
    public partial class FmSignUp : Form
    {

        /// <summary>
        ///     Required Method for Designer support for <c>FmSignIn</c>
        /// </summary>
        public FmSignUp()
        {
            InitializeComponent();
        }

        /// <summary>
        /// The resulting method when the user clicks on the Return button
        /// </summary>
        /// <param name="sender"> The <see cref="System.Object"/> that represents the sender instance</param>
        /// <param name="e">The <see cref="System.EventArgs"/> that represents the event arguments passed
        /// to the event handler</param>
        private void btReturn_Click(object sender, EventArgs e)
        {
            //Closes the form FmSignIn
            Close();

            //Creates a variable from the Form FmMenu
            FmMenu fmMenu = new FmMenu();

            // Shows the Form FmMenu
            fmMenu.Show();
        }


        /// <summary>
        /// The resulting method when the user clicks on the save button
        /// </summary>
        /// <param name="sender"> The <see cref="System.Object"/> that represents the sender instance</param>
        /// <param name="e">The <see cref="System.EventArgs"/> that represents the event arguments passed
        /// to the event handler</param>
        private void btSave_Click(object sender, EventArgs e)
        {
            //Exception handling
            try 
            {
                

                //Sets Username to the text of textbox tbUsername
                var Username = tbUsername.Text;

                //Sets the variable Password to the text of textbox tbPword
                var Password = tbPword.Text;
                
                //Sets the variable Forname to the text of textbox tbForename
                var Forename = tbForename.Text;

                //Sets the variable Surname to the text of textbox tbSurname
                var Surname = tbSurname.Text;

                //Sets the variable Email to the text of textbox tbEmail
                var Email = tbEmail.Text;

                //Regex validation for upper case characters
                var hasUpperChar = new Regex(@"[A-Z]+");

                //Regex validation for lower case characters
                var hasLowerChar = new Regex(@"[a-z]+");

                //Regex validation for numbers
                var hasNumber = new Regex(@"[0-9]+");

                //Regex validation for symbols
                var hasSymbols = new Regex(@"[!@#$^&*()_+=\[{\]};:<>|./?,-]+");

                //Regex validation for Emails
                var EmailValid = new Regex(@"^([a-zA-Z0-9_\.\-\+])+\@(([a-zA-Z0-9\-])+\.)+([a-za-za-z]{2,3})+$");

                //if the variable Username is empty
                if(Username == ""|| Username ==" ")
                {
                    //Displays a message window stating that the User's Username is empty
                    MessageBox.Show("Usernames should not be empty!");
                    

                }

                //if the variable Forname is empty
               else if (Forename ==""|| Forename ==" ")
                {
                    //Displays a message window stating that the User's Forename should not be empty
                    MessageBox.Show("Forename should not be empty!");
                }

                //if the variable Surname is empty
              else if (Surname=="" || Surname ==" ")
                {
                    //Displays a message window stating that the User's Surname should not be empty
                    MessageBox.Show("Surname should not be empty!");
                }

                //if the variable Empty is empty
               else if (Email==""|| Email ==" ")
                {
                    //Displays a message window stating that the User's Email should not be empty
                    MessageBox.Show("Email should not be empty");
                   

                }

                //if the Variable Username does not match the regex validation for numbers
               else if(!hasNumber.IsMatch(Username))
                {
                    //Displays a message window stating that the User's Username
                    //should contain atleast one number
                    MessageBox.Show("Username should contain atleast one number");

                    //Clears the text that was entered in the textbox tbUsername
                    tbUsername.Clear();

                }

                //if the Variable Username does not match the regex validation for upper case characters
                else if (!hasUpperChar.IsMatch(Username))
                {
                    //Displays a message window stating that the User's Username
                    //should contain atleast one uppercase letter
                    MessageBox.Show("Username should contain atleast one uppercase letter!");

                    //Clears the text that was entered in the textbox tbUsername
                    tbUsername.Clear();

                }

                //if the variable Password is empty
                else if (Password ==""||Password ==" ")

                {
                    //Displays a message window stating that the User's Email should not be empty
                    MessageBox.Show("Password should not be empty!");

                }

                //if the Variable Password does not match the regex validation for numbers
                else if (!hasNumber.IsMatch(Password))
                {
                    //Displays a message window stating that the User's Password
                    //should contain atleast one numeric value
                    MessageBox.Show("Password shoud contain atleast one numeric value!");

                    //Clears the text that was entered in the textbox tbPword
                    tbPword.Clear();
                }

                //if the Variable Password does not match the regex validation for upper case characters
                if (!hasUpperChar.IsMatch(Password))
                {
                    //Displays a message window stating that the User's Password
                    //should contain atleast one upper case letter
                    MessageBox.Show("Password should contain atleast one upper case letter!");

                    //Clears the text that was entered in the textbox tbPword
                    tbPword.Clear();
                }

                //if the Variable Username does not match the regex validation for lower case characters
                else if (!hasLowerChar.IsMatch(Password))
                {
                    //Displays a message window stating that the User's Password
                    //should contain atleast one lower case letter
                    MessageBox.Show("Password should contain atleast one lower case letter!");

                    //Clears the text that was entered in the textbox tbPword
                    tbPword.Clear();
                }

                //if the Variable Username does not match the regex validation for symbols
               else if (!hasSymbols.IsMatch(Password))
                {

                    //Displays a message window stating that the User's Password
                    //should contain atleast one special case letter
                    MessageBox.Show("Password should contain atleast one special case character!");

                    //Clears the text that was entered in the textbox tbPword
                    tbPword.Clear();
                }

                //if the Variable Email does not match the regex validation for Emails
                else if (!EmailValid.IsMatch(Email))
                {
                    //Displays a message window stating that the User's Email is not valid
                    MessageBox.Show("Email is not valid");

                    //Clears the text that was entered in the textbox tbEmail
                    tbEmail.Clear();
                }
                else if(cbUserType.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select a user type!");
                }

                //if all the variables meet all the requirements 
                else
                {
                    try // Exception Handling
                    {


                        //Create a database connection object with the constant defined in program.cs
                        OleDbConnection Conn = new OleDbConnection(Program.connString);

                        //Opens Connection to the database
                        Conn.Open();

                        //Creates a database command object
                        OleDbCommand Cmd = new OleDbCommand();

                        //Creates a connection with the Command Object
                        Cmd.Connection = Conn;

                        //An Aggregate SQL query that selects the Count From the table users
                        //where username is given by the user
                        //This is done to check if the Username exists in the table Users
                        Cmd.CommandText = "SELECT count(*) From Users WHERE Username = @Username";

                        //Set the parameter for @Username to the username given by the user
                        Cmd.Parameters.Add("@Username",OleDbType.Char).Value = tbUsername.Text;

                        //Gets the result from the Select query and sets the count to the that result
                        int Count = Convert.ToInt32(Cmd.ExecuteScalar());

                        //if the Username Exists
                        if (Count > 0)
                        {
                            //Displays a MessageBox saying that the username entered
                            //by the user already exists
                            MessageBox.Show("Username already exists!");
                        }

                        //If the Username doesn't exist in the table
                        else
                        {
                            //if the user selected Administrator from the combobox cbUserType
                            if (cbUserType.Text == "Administrator")
                            {
                                //declares a key set as a string that contains the key
                                string key = "#?123";

                                //if the text that was entered by the user in the textbox tbAdminKey
                                //Does not match the key 
                                if (tbAdminKey.Text != key)
                                {
                                    //Displays a MessageBox stating that the key is invalid
                                    MessageBox.Show("Invalid key");

                                    //Clears the text that was entered by the user in the textbot tbAdminKey
                                    tbAdminKey.Clear();
                                }

                                //if the text that was entered by the user in the textbox tbAdminKey
                                //Matches the key 
                                else
                                {
                                    //Inserts the values that were entered by the user
                                    // the password that the user entered is hashed and then inserted
                                    Cmd.CommandText = "INSERT INTO Users(Username, Pword, UserType, Forename, Surname, Email) VALUES('" + tbUsername.Text + "','" + Encryption.HashPassword(tbPword.Text) + "','" + cbUserType.Text + "','" + tbForename.Text + "','" + tbSurname.Text + "','" + tbEmail.Text + "')";


                                    //Executes the SQL Query
                                    Cmd.ExecuteNonQuery();

                                    // Closes the connection to the database
                                    Conn.Close();

                                    //Displays a message window stating that the User's Details
                                    //are now saved and that th user can log in
                                    MessageBox.Show("Details saved, you can now log in!");

                                    //Clears the text that was entered in the textbox tbForename
                                    tbForename.Clear();

                                    //Clears the text that was entered in the textbox tbSurname
                                    tbSurname.Clear();

                                    //Clears the text that was entered in the textbox tbEmail
                                    tbEmail.Clear();

                                    //Clears the text that was entered in the textbox tbUsername
                                    tbUsername.Clear();

                                    //Clears the text that was entered in the textbox tbPword
                                    tbPword.Clear();

                                    //Clears the text that was entered in the textbox tbAdminKey
                                    tbAdminKey.Clear();

                                    //Resets the combo box so that nothing is selected
                                    ResetSelection();

                                    //Set the visibility of the label lbAdminKey to false
                                    //Makes it invisible
                                    lbAdminKey.Visible = false;

                                    //Set the visibility of the label tbAdminKey to false
                                    //Makes it invisible
                                    tbAdminKey.Visible = false;
                                }
                            }
                            else
                            {
                                //Inserts the values that were entered by the user
                                // the password that the user entered is hashed and then inserted
                                Cmd.CommandText = "INSERT INTO Users(Username, Pword, UserType, Forename, Surname, Email) VALUES('" + tbUsername.Text + "','" + Encryption.HashPassword(tbPword.Text) + "','" + cbUserType.Text + "','" + tbForename.Text + "','" + tbSurname.Text + "','" + tbEmail.Text + "')";

                                //Executes the SQL Query
                                Cmd.ExecuteNonQuery();

                                // Closes the connection to the database
                                Conn.Close();

                                //Displays a message window stating that the User's Details
                                //are now saved and that th user can log in
                                MessageBox.Show("Details saved, you can now log in!");

                                //Clears the text that was entered in the textbox tbForename
                                tbForename.Clear();

                                //Clears the text that was entered in the textbox tbSurname
                                tbSurname.Clear();

                                //Clears the text that was entered in the textbox tbEmail
                                tbEmail.Clear();

                                //Clears the text that was entered in the textbox tbUsername
                                tbUsername.Clear();

                                //Clears the text that was entered in the textbox tbPword
                                tbPword.Clear();

                                //Resets the combo box so that nothing is selected
                                ResetSelection();

                            }
                            
                        }
                    }

                    //If an Exception is caught in the sql queries
                    catch(Exception)
                    {
                        //Displays a message window saying it Could not insert
                        MessageBox.Show("Could not insert");
                    }
                }
                
            }

            //if an excepton is caught
            catch (Exception) 
            {
                //Displays a message window saying it is invaild
                MessageBox.Show("Invalid");
            }

        }
        /// <summary>
        /// The resulting method when the user clicks on the ComboBox cbUserType and selects something from the DropDownList
        /// </summary>
        /// <param name="sender"> The <see cref="System.Object"/> that represents the sender instance</param>
        /// <param name="e">The <see cref="System.EventArgs"/> that represents the event arguments passed
        /// to the event handler</param>
        private void cbUserType_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if the User Selects Administrator on the ComboBox cbUserType
            if(cbUserType.Text=="Administrator")
            {
                // Sets the visibility of the label lbAdminKey to true
                //Makes it visible(It is set as false in the label properties so the
                //Form will load up with this label hidden
                lbAdminKey.Visible = true;

                // Sets the visibility of the textbox tbAdminKey to true
                //Makes it visible(It is set as false in the label properties so the
                //Form will load up with this texbox hidden
                tbAdminKey.Visible = true;
            }
            else
            {
                // Sets the visibility of the label lbAdminKey to false
                //Makes it invisible
                lbAdminKey.Visible = false;

                // Sets the visibility of the label tbAdminKey to false
                //Makes it invisible
                tbAdminKey.Visible = false;
            }
        }

        private void ResetSelection()
        {
            cbUserType.SelectedIndex = -1;
        }
    }
}
