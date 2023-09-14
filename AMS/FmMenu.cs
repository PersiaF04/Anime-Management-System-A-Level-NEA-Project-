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
    /// Handles all inputs and validation of functions that will take place in <c>FmMenu</c>
    /// </summary>
    public partial class FmMenu : Form
    {

        /// <summary>
        ///     Required Method for Designer support for <c>FmMenu</c>
        /// </summary>
        public FmMenu()
        {
            InitializeComponent();
        }

        /// <summary>
        /// The resulting method when the user clicks on the Sign-in button
        /// </summary>
        /// <param name="sender"> The <see cref="System.Object"/> that represents the sender instance  </param>
        /// <param name="e">The <see cref="System.EventArgs"/> that Represents the event arguments passed to the event handler </param>
        /// 
        private void btSignUp_Click(object sender, EventArgs e)
        {
            //Hides the form from the user
            Hide();

            //Creates a variable from the Form FmSignUp 
            FmSignUp FmSign = new FmSignUp();

            // Shows the Form FmSign
            FmSign.ShowDialog();
            
        }

        /// <summary>
        /// The resulting method for when the user clicks on the Log-in button
        /// </summary>
        /// <param name="sender"> The <see cref="System.Object"/> that represents the sender instance  </param>
        /// <param name="e">The <see cref="System.EventArgs"/> that Represents the event arguments passed to the event handler </param>
        private void btLogIn_Click(object sender, EventArgs e)
        {
            //Hides the form from the user
            Hide();

            //Creates a variable from the Form
            FmLogIn FmLog = new FmLogIn();

            // Shows the Form FmLog
            FmLog.ShowDialog();

        }

        /// <summary>
        /// The resulting method for when the user clicks the Exit button
        /// </summary>
        /// <param name="sender"> The <see cref="System.Object"/> that represents the sender instance  </param>
        /// <param name="e">The <see cref="System.EventArgs"/> that Represents the event arguments passed to the event handler </param>
        private void btExit_Click(object sender, EventArgs e)
        {

            //When exit button is clicked the form will close.
            Close();
            
        }

        /// <summary>
        /// The resulting method for when the Form loads
        /// </summary>
        /// <param name="sender"> The <see cref="System.Object"/> that represents the sender instance  </param>
        /// <param name="e">The <see cref="System.EventArgs"/> that Represents the event arguments passed to the event handler </param>
        private void FmMenu_Load(object sender, EventArgs e)
        {
            // Checks if database exists, if it doesnt it will create the database
            if (File.Exists("AMS.accdb") == false)

            {
                ADOX.Catalog cat = new ADOX.Catalog();

                //Uses constant defined in Program.cs to create database
                cat.Create(Program.connString);

                //Create a database connection object with the constant defined in program.cs
                OleDbConnection Conn = new OleDbConnection(Program.connString);

                //Opens Connection to the database
                Conn.Open();

                //Creates a database command object
                OleDbCommand Cmd = new OleDbCommand();

                //Creates a connection with the Command Object
                Cmd.Connection = Conn;

                //Creates User Table
                Cmd.CommandText = "CREATE TABLE Users(UserID AUTOINCREMENT, Username VARCHAR(60), Pword VARCHAR(255), UserType VARCHAR(30), Forename VARCHAR(60), Surname VARCHAR(60), Email VARCHAR(255), PRIMARY KEY (UserID))";

                //Executes the SQL Query
                Cmd.ExecuteNonQuery();

                //Creates Studios table
                Cmd.CommandText = "CREATE TABLE Studios(StudioID INTEGER, Studio VARCHAR(100), PRIMARY KEY (StudioID))";

                //Executes the SQL Query
                Cmd.ExecuteNonQuery();

                //Creates Animes table
                Cmd.CommandText = "CREATE TABLE Animes(AnimeID INTEGER,AnimeTitle VARCHAR(200), Episodes INTEGER, Ratings INTEGER, AnimeSynopsis LONGTEXT, AnimePictures TEXT,  PRIMARY KEY (AnimeID))";

                //Executes the SQL Query
                Cmd.ExecuteNonQuery();

                //Creates UserFavourites Table
                Cmd.CommandText = "CREATE TABLE UserFavourites(UserFavID AUTOINCREMENT, UserID INTEGER,  AnimeID INTEGER, AnimeTitle VARCHAR(200), Ratings INTEGER, CONSTRAINT PK_UserCompKey PRIMARY KEY(UserFavID, UserID), FOREIGN KEY (UserID) REFERENCES Users(UserID))";

                //Executes the SQL Query
                Cmd.ExecuteNonQuery();

                //Creates UserWatchList Table
                Cmd.CommandText = "CREATE TABLE UserWatchList(UserWatchID AUTOINCREMENT, UserID INTEGER, AnimeID INTEGER, AnimeTitle VARCHAR (200), WatchStatus VARCHAR(100), EpisodesWatched INTEGER, Ratings INTEGER, CONSTRAINT PK_UserCompKey PRIMARY KEY(UserWatchID, UserID), FOREIGN KEY (UserID) REFERENCES Users(UserID))";

                //Executes the SQL Query
                Cmd.ExecuteNonQuery();

                //Creates Genres Table
                Cmd.CommandText = "CREATE TABLE Genres(GenreID INTEGER,Genre TEXT, PRIMARY KEY (GenreID))";

                //Executes the SQL Query
                Cmd.ExecuteNonQuery();

                // Creates AnimeStudios table (Creates a junction table between Animes and Studio to eliminate Many to Many relationship / Composite Key)
                Cmd.CommandText = "CREATE TABLE AnimeStudios(AnimeID INTEGER, StudioID INTEGER, CONSTRAINT PK_AnimeStudios PRIMARY KEY (AnimeID, StudioID), FOREIGN KEY (AnimeID) REFERENCES Animes(AnimeID), FOREIGN KEY (StudioID) REFERENCES Studios(StudioID))";

                //Executes the SQL Query
                Cmd.ExecuteNonQuery();

                // Creates AnimeGenres table (Creates a junction table between Animes and Genre to eliminate Many to Many relationship / Composite Key)
                Cmd.CommandText = "CREATE TABLE AnimeGenres(AnimeID INTEGER, GenreID INTEGER, CONSTRAINT PK_AnimeGenres PRIMARY KEY (AnimeID, GenreID), FOREIGN KEY (AnimeID) REFERENCES Animes(AnimeID), FOREIGN KEY (GenreID) REFERENCES Genres(GenreID))";

                //Executes the SQL Query
                Cmd.ExecuteNonQuery();

                // Creates AnimeStatus table (Composite key)
                Cmd.CommandText = "CREATE TABLE AnimeStatus(AnimeID INTEGER, Status VARCHAR(150), CONSTRAINT PK_AnimeStatus PRIMARY KEY (AnimeID, Status), FOREIGN KEY(AnimeID) REFERENCES Animes(AnimeID))";

                //Executes the SQL Query
                Cmd.ExecuteNonQuery();
                

                // Assigned a variable to read the Studio.csv file
                var lines = File.ReadLines("Studios.csv");

                // Iterates the Studio.csv file with a condition associated to the line variable
                foreach (string line in lines) 

                {
                    // splits the Studio.csv file into values that are associated with the Table column for Studios and stores it into an array
                    string[] StudioList = line.Split(',');

                    // Inserts the values into the database from Studio.csv file that are contained in the array
                    Cmd.CommandText = "INSERT INTO Studios VALUES('" + StudioList[0] + "', '" + StudioList[1] + "')";

                    //Execute SQL command
                    Cmd.ExecuteNonQuery();

                    // will keep inserting until the end of the Studio.csv file

                }

                // Assigned a variable to read the Anime.csv file
                lines = File.ReadLines("Anime.csv");

                // Iterates the Anime.csv file with a condition associated to the line variable
                foreach (string line in lines)

                {
                    // splits the Anime.csv file into values that are associated with the Table column for Animes and stores it into an array
                    string[] AnimeList = line.Split(',');

                    // Inserts the value into the database from Anime.csv file that are contained in the array
                    Cmd.CommandText = "INSERT INTO Animes VALUES('" + AnimeList[0] + "', '" + AnimeList[1] + "','" + AnimeList[2] + "','" + AnimeList[3] + "','"+ AnimeList[4]+ "','"+ AnimeList[5] + "')";

                    //Execute SQL command
                    Cmd.ExecuteNonQuery();

                    // will keep inserting until the end of the Anime.csv file

                }

                // Assigned a variable to read the Genre.csv file
                lines = File.ReadLines("Genre.csv");

                // Iterates the Genre.csv file with a condition associated to the line variable
                foreach (string line in lines)

                {
                    // splits the Genre.csv file into values that are associated with the Table column for Genres and stores it into an array
                    string[] GenreList = line.Split(',');

                    // Inserts the values into the database from Genre.csv file that are contained in the array
                    Cmd.CommandText = "INSERT INTO Genres VALUES('" + GenreList[0] + "','" + GenreList[1] + "')";

                    //Execute SQL command
                    Cmd.ExecuteNonQuery();

                    // will keep inserting until the end of the csv file

                }

                // Assigned a variable to read the Animestudio.csv file
                lines = File.ReadLines("Animestudio.csv");

                // Iterates the Animestudio.csv file with a condition associated to the line variable
                foreach (string line in lines)

                {
                    // splits the Animestudio.csv file into values that are associated with the Table column for AnimeStudios and stores it into an array
                    string[] AnimeStudioList = line.Split(',');

                    // Insert the values into the database from Animestudio.csv file that are contained in the array 
                    Cmd.CommandText = "INSERT INTO AnimeStudios VALUES('" + AnimeStudioList[0] + "','" + AnimeStudioList[1] + "')";

                    //Execute SQL command
                    Cmd.ExecuteNonQuery();

                    // will keep inserting until the end of the csv file

                }

                // Assigned a variable to read the Animegenre.csv file
                lines = File.ReadLines("Animegenre.csv");

                // Iterates the Animegenre.csv file with a condition associated to the line variable
                foreach (string line in lines)

                {
                    // splits the Animegenre.csv file into values that are associated with the Table column for AnimeGenres and stores it into an array
                    string[] AnimeGenreList = line.Split(',');

                    // Insert the values into the database from Animegenre.csv file that are contained in the array
                    Cmd.CommandText = "INSERT INTO AnimeGenres VALUES('" + AnimeGenreList[0] + "','" + AnimeGenreList[1] + "')";

                    //Execute SQL command
                    Cmd.ExecuteNonQuery();
                    
                    // will keep inserting until the end of the csv file

                }

                // Assigned a variable to read the AnimeStatus.csv file
                lines = File.ReadLines("AnimeStatus.csv");

                // Iterates the AnimeStatus.csv file with a condition associated to the line variable
                foreach (string line in lines)

                {
                    // splits the AnimeStatus.csv file into values that are associated with the Table column for AnimeGenres and stores it into an array
                    string[] AnimeStatuslist = line.Split(',');

                    // Insert the values into the database from AnimeStatus.csv file that are contained in the array
                    Cmd.CommandText = "INSERT INTO AnimeStatus VALUES('" + AnimeStatuslist[0] + "','" + AnimeStatuslist[1] + "')";

                    //Execute SQL command
                    Cmd.ExecuteNonQuery();
                    
                    // will keep inserting until the end of the csv file
                }

                // Closes the connection to the database
                Conn.Close();
                
            }
        }


    }
}
