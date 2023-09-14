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
    /// Handles all inputs and validation of functions that will take place in <c>FmUserStats</c>
    /// </summary>
    public partial class FmUserStats : Form
    {
        /// <summary>
        ///     Required Method for Designer support for <c>FmUserStats</c>
        /// </summary>
        public FmUserStats()
        {
            InitializeComponent();
        }

        /// <summary>
        /// The resulting method for when the Form loads
        /// </summary>
        /// <param name="sender"> The <see cref="System.Object"/> that represents the sender instance  </param>
        /// <param name="e">The <see cref="System.EventArgs"/> that Represents the event arguments passed to the event handler </param>
        private void FmUserStats_Load(object sender, EventArgs e)
        {
            try //Exception Handling
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

                //A select query to count the entries where it contains enteries that has 
                //the userID which is the same as the variable userID in itin the table UserFavourites
                Cmd.CommandText = "SELECT COUNT(*) FROM UserFavourites WHERE UserID=" + UserID + "";

                //Executes the SQL query
                Cmd.ExecuteNonQuery();

                //sets the variable TotalRatingsFromFavourites to the result of the Sql query in integer form
                int TotalRatingsFromFavourites = Convert.ToInt32(Cmd.ExecuteScalar());

                //A select query to count the entries where it contains enteries  that has 
                //the userID which is the same as the variable userID in the table UserWatchList
                Cmd.CommandText = "SELECT COUNT(*) FROM UserWatchList WHERE UserID=" + UserID + "";
                Cmd.ExecuteNonQuery();

                //sets the variable TotalRatingsFromWatchList to the result of the Sql query in integer form
                int TotalRatingsFromWatchList = Convert.ToInt32(Cmd.ExecuteScalar());

                //Sets the integer TotalRatings to the sum of the two variables
                //TotalRatingsFromFavourites and TotalRatingsFromWatchList
                int TotalRatings = TotalRatingsFromFavourites + TotalRatingsFromWatchList;

                //sets the label DbTotalRatings to the variable TotalRatings in string form
                DbTotalRatings.Text = TotalRatings.ToString();

                //A select query to select the average ratings from the table UserFavourites and UserWatchList  where the UserIDs in both tables contain the variable UserID
                Cmd.CommandText = "SELECT AVG(UserFavourites.Ratings) + AVG(UserWatchList.Ratings)  FROM UserFavourites, UserWatchList WHERE UserFavourites.UserID=" + UserID + " AND UserWatchList.UserID=" + UserID + "";

                //Executes the SQL query
                Cmd.ExecuteNonQuery();

                // sets the variable RatingsAdded to the result of the Sql query in double form
                double RatingsAdded = Convert.ToDouble(Cmd.ExecuteScalar());

                //Sets the variable TrueAvgRatings to half of the variable RatingsAdded
                double TrueAvgRatings = RatingsAdded / 2;

                //Rounds the variable TrueAvgRatings to 1 decimal place and is set as the label DbAverageRatings
                DbAverageRatings.Text = Math.Round(TrueAvgRatings, 1).ToString();

                //A select query to count the entries where it contains enteries  that has 
                //the WatchStatus set as completed where the location of the UserID is (which contains the variable UserID)
                Cmd.CommandText = "SELECT COUNT(*) FROM UserWatchList WHERE WatchStatus = 'Completed' AND UserID=" + UserID + "";

                //Executes the SQL query
                Cmd.ExecuteNonQuery();

                //sets the variable Completed to the result of the Sql query in integer form
                int Completed = Convert.ToInt32(Cmd.ExecuteScalar());

                //Sets the label DbAnimesCompleted to variable Completed in string form
                DbAnimesCompleted.Text = Completed.ToString();

                //A select query to count the entries where it contains enteries  that has 
                //the WatchStatus set as CurrentlyWatching where the location of the UserID is (which contains the variable UserID)
                Cmd.CommandText = "SELECT COUNT(*) FROM UserWatchList WHERE WatchStatus = 'Currently Watching' AND UserID=" + UserID + "";

                //Executes the SQL query
                Cmd.ExecuteNonQuery();

                //sets the variable Currently Watching to the result of the Sql query in integer form
                int CurrentlyWatching = Convert.ToInt32(Cmd.ExecuteScalar());

                //Sets the label DbAnimesCurrentlyWatching to the variable CurrentlyWatching in string form
                DbAnimesCurrentlyWatching.Text = CurrentlyWatching.ToString();

                //A select query to count the entries where it contains enteries  that has 
                //the WatchStatus set as Not yet Watched where the location of the UserID is (which contains the variable UserID)
                Cmd.CommandText = "SELECT COUNT(*) FROM UserWatchList WHERE WatchStatus = 'Not Yet Watched' AND UserID=" + UserID + "";

                //Executes the SQL query
                Cmd.ExecuteNonQuery();

                //sets the variable NotYetWatched to the result of the Sql query in integer form
                int NotYetWatched = Convert.ToInt32(Cmd.ExecuteScalar());

                //Sets the label DbAnimesYetToWatch to the variable NotYetWatched in string form
                DbAnimesYetToWatch.Text = NotYetWatched.ToString();

                //A select query to count the entries where it contains enteries  that has 
                //the WatchStatus set as Dropped where the location of the UserID is (which contains the variable UserID)
                Cmd.CommandText = "SELECT COUNT(*) FROM UserWatchList WHERE WatchStatus = 'Dropped' AND UserID=" + UserID + "";

                //Executes the SQL query
                Cmd.ExecuteNonQuery();

                //sets the variable Dropped to the result of the Sql query in integer form
                int Dropped = Convert.ToInt32(Cmd.ExecuteScalar());

                //Sets the label DbAnimesDropped to the variable Dropped in string form
                DbAnimesDropped.Text = Dropped.ToString();

                //A select query to select the sum of all episodeswatched in UserWatchList in where the
                //location of the UserID is (which contains the variable UserID)
                Cmd.CommandText = "SELECT SUM(EpisodesWatched) FROM UserWatchList WHERE UserID=" + UserID + "";

                //Executes the SQL query
                Cmd.ExecuteNonQuery();

                //sets the variable EpisodesWatched to the result of the Sql query in integer form
                int EpisodesWatched = Convert.ToInt32(Cmd.ExecuteScalar());

                //Sets the label DbTotalEpisodesWatched to the variable Dropped in string form
                DbTotalEpisodesWatched.Text = EpisodesWatched.ToString();

                //sets the variable AnimeEpLength to the result of the multiplication between
                //the variable EpisodesWatched and the number 24
                int AnimeEpLength = EpisodesWatched * 24;

                //sets the variable Hours to the result of the division between
                //the variable AnimeEpLength and the number 60
                int Hours = AnimeEpLength / 60;

                //Sets the label DbHourSpent to the variable Hours in string form
                DbHourSpent.Text = Hours.ToString();
            }
            catch(Exception) //catches error
            {

                //Displays a message box informing the user that their stats could not be loaded.
                MessageBox.Show("Could not load stats");
            }

        }
    }
}
