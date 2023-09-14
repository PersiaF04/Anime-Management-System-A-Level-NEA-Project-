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
{ /// <summary>
  /// Handles all inputs and validation of functions that will take place in <c>FmProfile</c>
  /// </summary>
    public partial class FmProfile : Form
    {
        /// <summary>
        ///     Required Method for Designer support for <c>FmAMS</c>
        /// </summary>
        public FmProfile()
        {
            InitializeComponent();
        }

        /// <summary>
        /// The resulting method for when the Form loads
        /// </summary>
        /// <param name="sender"> The <see cref="System.Object"/> that represents the sender instance  </param>
        /// <param name="e">The <see cref="System.EventArgs"/> that Represents the event arguments passed to the event handler </param>
        private void FmProfile_Load(object sender, EventArgs e)
        {
            //Sets the label lbUsername to the global variable declared
            //in the form FmLogIn which contains th user's username
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
            //the username is (the username is the global variable from FmLogIn Username)
            Cmd.CommandText = "SELECT UserID FROM Users WHERE Username='" + FmLogIn.Username + "'";

            //Executes the SQL query
            Cmd.ExecuteNonQuery();

            //sets the variable UserID to the result of the Sql query
            var UserID = Cmd.ExecuteScalar();

            //sets the label DbUserID to the variable UserID
            DbUserID.Text = UserID.ToString();

            //A select query to select the Forename From the table users where the location of
            //the username is (the username is the global variable from FmLogIn Username)
            Cmd.CommandText = "SELECT Forename FROM Users WHERE Username='" + FmLogIn.Username + "'";

            //Executes the sql query
            Cmd.ExecuteNonQuery();

            //sets the variable Forename to the result of the Sql query
            var Forename = Cmd.ExecuteScalar();

            //sets the label DbForename to the variable Forename
            DbForename.Text = Forename.ToString();

            //A select query to select the Surname From the table users where the location of
            //the username is (the username is the global variable from FmLogIn Username)
            Cmd.CommandText = "SELECT Surname FROM Users WHERE Username='" + FmLogIn.Username + "'";

            //Executes the sql query
            Cmd.ExecuteNonQuery();

            //sets the variable Surname to the result of the Sql query
            var Surname = Cmd.ExecuteScalar();

            //sets the label DbSurname to the variable Forename
            DbSurname.Text = Surname.ToString();

            //A select query to select the UserType From the table users where the location of
            //the username is (the username is the global variable from FmLogIn Username)
            Cmd.CommandText = "SELECT UserType FROM Users WHERE Username='" + FmLogIn.Username + "'";

            //Executes the sql query
            Cmd.ExecuteNonQuery();

            //sets the variable UserType to the result of the Sql query
            var UserType = Cmd.ExecuteScalar();

            //sets the label DbUserType to the variable Forename
            DbUserType.Text = UserType.ToString();
        }

        /// <summary>
        /// The resulting method for when the reset button is clicked
        /// </summary>
        /// <param name="sender"> The <see cref="System.Object"/> that represents the sender instance  </param>
        /// <param name="e">The <see cref="System.EventArgs"/> that Represents the event arguments passed to the event handler </param>
        private void btReset_Click(object sender, EventArgs e)
        {

            //Creates a variable from the Form FmReset
            FmReset fmReset = new FmReset();

            // Shows the Form FmReset through the variable fmReset
            fmReset.ShowDialog();
        }

        /// <summary>
        /// The resulting method for when the watch list button is clicked
        /// </summary>
        /// <param name="sender"> The <see cref="System.Object"/> that represents the sender instance  </param>
        /// <param name="e">The <see cref="System.EventArgs"/> that Represents the event arguments passed to the event handler </param>
        private void btWatchList_Click(object sender, EventArgs e)
        {
            //Creates a variable from the Form FmUserWatchList
            FmUserWatchList fmUserWatchList = new FmUserWatchList();

            // Shows the Form FmUserWatchList through the variable fmUserWatchList
            fmUserWatchList.ShowDialog();
        }

        /// <summary>
        /// The resulting method for when the favourites button is clicked
        /// </summary>
        /// <param name="sender"> The <see cref="System.Object"/> that represents the sender instance  </param>
        /// <param name="e">The <see cref="System.EventArgs"/> that Represents the event arguments passed to the event handler </param>
        private void btFavourites_Click(object sender, EventArgs e)
        {
            //Creates a variable from the Form FmUserFavourites
            FmUserFavourites fmUserFavourites = new FmUserFavourites();

            // Shows the Form FmUserWatchList through the variable fmUserFavourites
            fmUserFavourites.ShowDialog();
        }

        /// <summary>
        /// The resulting method for when the stats button is clicked
        /// </summary>
        /// <param name="sender"> The <see cref="System.Object"/> that represents the sender instance  </param>
        /// <param name="e">The <see cref="System.EventArgs"/> that Represents the event arguments passed to the event handler </param>
        private void btStats_Click(object sender, EventArgs e)
        {
            //Creates a variable from the Form FmUserStats
            FmUserStats fmUserStats = new FmUserStats();

            // Shows the Form FmUserStats through the variable fmUserStats
            fmUserStats.ShowDialog();
        }
    }
}
