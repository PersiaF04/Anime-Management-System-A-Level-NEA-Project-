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

namespace AMS
{
    /// <summary>
    /// Handles all inputs and validation of functions that will take place in <c>FmLogIn</c>
    /// </summary>
    public partial class FmLogIn : Form
    { 
        /// <summary>
        /// Global variables
        /// </summary>

        public static string Username="";
        public static FmLogIn FmLogInInstance;

        /// <summary>
        ///     Required Method for Designer support for <c>FmLogIn</c>
        /// </summary>
        public FmLogIn()
        {
            InitializeComponent();
        }
        /// <summary>
        /// The resulting method for when the Form loads
        /// </summary>
        /// <param name="sender"> The <see cref="System.Object"/> that represents the sender instance  </param>
        /// <param name="e">The <see cref="System.EventArgs"/> that Represents the event arguments passed to the event handler </param>
        
        private void FmLogIn_Load(object sender, EventArgs e)
        {
            // if the Username that is located in properties is not empty and contains a string
            if(Properties.Settings.Default.Username != string.Empty)

            {
                // Sets tbUsername(textbox) field value to the value of the Username stored in properties 
                tbUsername.Text = Properties.Settings.Default.Username;

                //Sets tbPword(textbox) value to the value of Password stored in properties
                tbPword.Text = Properties.Settings.Default.Password;

                // Sets cbRemember(combobox) to true when all conditions are met
                cbRemember.Checked = true;
            }
        }
        /// <summary>
        /// The resulting method when the user clicks on the Enter button
        /// </summary>
        /// <param name="sender"> The <see cref="System.Object"/> that represents the sender instance</param>
        /// <param name="e">The <see cref="System.EventArgs"/> that represents the event arguments
        /// passed to the event handler</param>
        private void btEnter_Click(object sender, EventArgs e)
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

                //Selecting everthing from the table Users where the username is entered in the textbox tbUsername
                Cmd.CommandText = "SELECT * FROM Users WHERE Username ='" + tbUsername.Text + "'";

                //Sets the global variable Username that is defined in FmMenu to the value
                //of the username that is entered in the textbox tbUsername
                Username = tbUsername.Text;

                //Creates a reader object and Executes the SQL Query
                OleDbDataReader reader = Cmd.ExecuteReader();

                // if the SQL query contains one or more rows
                if (reader.HasRows)

                {
                    //read all the rows
                    reader.Read();

                    // if the hashedvalue of the password that is entered in the textbox tbPword 
                    // matches the hashedPassword in the User table
                    if (Encryption.HashPassword(tbPword.Text) == reader["Pword"].ToString())

                    {
                        //if the UserType of the User is Administrator
                        if ("Administrator" == reader["UserType"].ToString())

                        {

                            this.Visible = false;

                            //Creates a variable from the Form FmAMS(admin)
                            FmAMS_admin_ f4 = new FmAMS_admin_();

                            // Shows the Form FmAms(Admin) through the variable
                            f4.ShowDialog();

                            this.Visible = true;
                        }

                        //if the UserType of the user is not Administrator
                        else

                        {

                            this.Visible = false;

                            //Creates a variable from the Form FmAMS
                            FmAMS f4 = new FmAMS();

                            // Shows the Form FmAMS through the variable
                            f4.ShowDialog();

                            this.Visible = true;
                        }
                    }

                    // if the hashedvalue of the password that is entered in the textbox tbPword 
                    // does not match the hashedPassword in the User table
                    else

                    {
                        //Displays a message window stating that the User's password is wrong
                        MessageBox.Show("Wrong password");

                        //Clears the text that was enter in the textbox tbUsername
                        tbUsername.Clear();

                        //Clears the text that was enter in the textbox tbPword
                        tbPword.Clear();
                    }
                }
            }
            catch (Exception) //Catches the error
            {
                //Displays a message box saying it could not be found
                MessageBox.Show(" Could not be found");
            }
            
            

            //if the checkbox cbRemember is checked
            if(cbRemember.Checked == true)

            {
                //Set the value of Username that is located in Properties to the value of the textbox tbUsername
                Properties.Settings.Default.Username = tbUsername.Text;

                //Set the value of Username that is located in Properties to the value of the textbox tbPword
                Properties.Settings.Default.Password = tbPword.Text;

                //Save the values in Properties
                Properties.Settings.Default.Save();

            }

            //if the checkbox cbRemember is not checked
            if (cbRemember.Checked == false)

            {
                //Set the value of Username that is located in Properties to an empty string
                Properties.Settings.Default.Username = "";

                //Set the value of Username that is located in Properties to an empty string
                Properties.Settings.Default.Password = "";

                //Save the values in Properties
                Properties.Settings.Default.Save();
            }
        }
        /// <summary>
        /// The resulting method when the user clicks on the Return button
        /// </summary>
        /// <param name="sender"> The <see cref="System.Object"/> that represents the sender instance</param>
        /// <param name="e">The <see cref="System.EventArgs"/> that represents the event arguments passed
        /// to the event handler</param>
        private void btReturn_Click(object sender, EventArgs e)
        {
            //Closes the form FmLogIn
            Close();

            //Creates a variable from the Form FmMenu
            FmMenu fmMenu = new FmMenu();

            // Shows the Form FmMenu
            fmMenu.ShowDialog();
        }


    }
}
