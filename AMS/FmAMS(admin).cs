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
using System.IO;

namespace AMS
{
    /// <summary>
    /// Handles all inputs and validation of functions that will take place in <c>FmAMS(Admin)</c>
    /// </summary>
    public partial class FmAMS_admin_ : Form
    {
        /// <summary>
        /// Global variable that is declared in <c>FmAms(Admin)</c>to make this variable accessible to other forms
        /// </summary>
        public static string AnimeID = "";
        /// <summary>
        /// Global variable that is declared in <c>FmAms(Admin)</c>to make this variable accessible to other forms
        /// </summary>
        public static string AnimeTitle = "";
        /// <summary>
        /// Global variable that is declared in <c>FmAms(Admin)</c>to make this variable accessible to other forms
        /// </summary>
        public static string Episodes = "";
        /// <summary>
        /// Global variable that is declared in <c>FmAms(Admin)</c>to make this variable accessible to other forms
        /// </summary>
        public static string Status = "";
        /// <summary>
        /// Global variable that is declared in <c>FmAms(Admin)</c>to make this variable accessible to other forms
        /// </summary>
        public static string Ratings = "";
        /// <summary>
        /// Global variable that is declared in <c>FmAms(Admin)</c>to make this variable accessible to other forms
        /// </summary>
        public static string AnimePictures = "";
        /// <summary>
        /// Global variable that is declared in <c>FmAms(Admin)</c>to make this variable accessible to other forms
        /// </summary>
        public static string AnimeSynopsis = "";
        /// <summary>
        /// Global variable that is declared in <c>FmAms(Admin)</c>to make this variable accessible to other forms
        /// </summary>
        public static string StudioID = "";
        /// <summary>
        /// Global variable that is declared in <c>FmAms(Admin)</c>to make this variable accessible to other forms
        /// </summary>
        public static string Studio = "";
        /// <summary>
        /// Global variable that is declared in <c>FmAms(Admin)</c>to make this variable accessible to other forms
        /// </summary>
        public static string GenreID = "";
        /// <summary>
        /// Global variable that is declared in <c>FmAms(Admin)</c>to make this variable accessible to other forms
        /// </summary>
        public static string Genre = "";
        /// <summary>
        /// Global variable that is declared in <c>FmAms(Admin)</c> to make this variable accessible to other forms
        /// </summary>
        public static string UserID = "";
        /// <summary>
        /// Global variable that is declared in <c>FmAms(Admin)</c> to make this variable accessible to other forms
        /// </summary>
        public static string Username = "";
        /// <summary>
        /// Global variable that is declared in <c>FmAms(Admin)</c>to make the form accessible to other forms
        /// </summary>
        public static FmAMS_admin_ FmAmsAdminInstance;

        /// <summary>
        ///     Required Method for Designer support for <c>FmAms(Admin)</c>
        /// </summary>
        public FmAMS_admin_()
   
   
        {
            InitializeComponent();
            FmAmsAdminInstance = this;


        }
        private void AutoFillAnimeSearch()
        {
            //Create a database connection object with the constant defined in program.cs
            OleDbConnection Conn = new OleDbConnection(Program.connString);

            //Opens Connection to the database
            Conn.Open();

            //Creates a database command object
            OleDbCommand Cmd = new OleDbCommand();

            //Creates a connection with the Command Object
            Cmd.Connection = Conn;


        }
        /// <summary>
        /// The resulting method when the user clicks on the Show button
        /// </summary>
        /// <param name="sender"> The <see cref="System.Object"/> that represents the sender instance</param>
        /// <param name="e">The <see cref="System.EventArgs"/> that represents the event arguments passed
        /// to the event handler</param>
        private void btShow_Click(object sender, EventArgs e)
        {
            //Create a database connection object with the constant defined in program.cs
            OleDbConnection Conn = new OleDbConnection(Program.connString);

            //Opens Connection to the database
            Conn.Open();

            //Creates a database command object
            OleDbCommand Cmd = new OleDbCommand();

            //Creates a connection with the Command Object
            Cmd.Connection = Conn;

            //if the radiobutton rbAnimes is clicked by the User
            if(rbAnimes.Checked)
            {
                //A select query to select everything in the table called Animes
                Cmd.CommandText = "SELECT * FROM Animes";

            }
            
            //if the radiobutton rbGenres is clicked by the User
            else if(rbGenres.Checked)
            {
                //A select query to select everything in the table called Genres
                Cmd.CommandText = "SELECT * FROM Genres";

            }

            //if the radiobutton rbStudios is clicked by the User
            else if (rbStudios.Checked)
            {
                //A select query to select everything in the table called Studios
                Cmd.CommandText = "SELECT * FROM Studios";

            }

            //if the radiobutton rbAnimeStudios is clicked by the User
            else if (rbAnimeStudios.Checked)
            {
                //A select query to select everything in the table called AnimeStudios
                Cmd.CommandText = "SELECT * FROM AnimeStudios";

            }
            //if the radiobutton rbAnimeGenres is clicked by the User
            else if (rbAnimeGenres.Checked)
            {
                //A select query to select everything in the table called AnimeGenres
                Cmd.CommandText = "SELECT * FROM AnimeGenres";

            }

            //if the radiobutton rbAnimeStatus is clicked by the User
            else if (rbAnimeStatus.Checked)
            {
                //A select query to select everything in the table called AnimeStatus
                Cmd.CommandText = "SELECT * FROM AnimeStatus";

            }
            //if the radiobutton rbUsers is clicked by the User
            else if (rbUsers.Checked)
            {
                //A select query to select everything in the table called AnimeStatus
                Cmd.CommandText = "SELECT UserID, Username FROM Users";

            }

            //Creates A connection between the datasource(select query) and dataset to Add rows or refresh rows
            OleDbDataAdapter da = new OleDbDataAdapter(Cmd);

            //Creates a table that will be filled with data from the select query
            DataTable table = new DataTable();

            //the data adapter da adds rows to the table
            da.Fill(table);

            // sets the datagridviewer Grid source to that of the DataTable table
            // that is filled with data from the select query
            Grid.DataSource = table;

            // Closes the connection to the database
            Conn.Close();

            //Displays the DataTable
            Grid.Show();

        }

        /// <summary>
        /// The resulting method when the user presses a key in the textbox tbSearch
        /// </summary>
        /// <param name="sender"> The <see cref="System.Object"/> that represents the sender instance</param>
        /// <param name="e">The <see cref="System.EventArgs"/> that represents the event arguments passed
        /// to the event handler</param>
        private void tbSearch_KeyPress(object sender, KeyPressEventArgs e)
       {
            //Exception Handling
            try
            {
                //Create a database connection object with the constant defined in program.cs
                OleDbConnection Conn = new OleDbConnection(Program.connString);

                //Creates a database command object
                OleDbCommand Cmd = new OleDbCommand();

                //Opens Connection to the database
                Cmd.Connection = Conn;

                //if the radiobutton rbAnimes is clicked by the User
                if (rbAnimes.Checked)
                {
                    //if the textbox tbSearch is not empty
                    if (tbSearch.Text != "")
                    {
                        try //Exception Handling
                        {
                            //Gets value entered from the user to indicate the size of the columns and fill it with data
                            Grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                            //Creates A connection between the datasource(select query) and dataset to Add rows or refresh rows
                            OleDbDataAdapter Adapt = new OleDbDataAdapter();

                            //Creates an empty set for data to be filled
                            DataSet DS = new DataSet();

                            // Creates view of the the data stored in the dataset
                            DataView DV = new DataView();

                            // A select query that gets everything from the table Animes, when the user
                            // types a letter it is checked and compared to entries in the table
                            // to determine whetere a specific character string matches a specified pattern
                            //in either the column AnimeTitle or AnimeID
                            string SQL = "SELECT * FROM Animes WHERE AnimeTitle LIKE '" + tbSearch.Text + "%' OR AnimeID LIKE '" + tbSearch.Text + "%'";

                            //Opens a connection to the database
                            Conn.Open();

                            //Creates a database command object that contains the connection to the
                            //database and the string containing the select query
                            Cmd = new OleDbCommand(SQL, Conn);

                            //Creates A connection between the datasource(select query) and dataset to refresh rows from the command
                            Adapt = new OleDbDataAdapter(Cmd);

                            //Fills the DataSet with information from the select query
                            Adapt.Fill(DS);

                            // Creates a view of the data stored in the dataset
                            DV = new DataView(DS.Tables[0]);

                            // sets the datagridviewer Grid source to that of the DataView
                            // that is filled with data from the select query
                            Grid.DataSource = DV;

                            //Closes the connection to the database
                            Conn.Close();
                        }
                        catch(Exception) //catches error
                        {
                            //Displays a message box informing the user that their input is invalid
                            MessageBox.Show("Invalid input");
                        }
                    }

                    //if the textbox tbSearch is empty
                    else if (tbSearch.Text == "")
                    {
                        //A select query to select everything in the table called Animes
                        Cmd.CommandText = "SELECT * FROM Animes";

                        //Creates A connection between the datasource(select query) and dataset
                        //to Add rows or refresh rows
                        OleDbDataAdapter da = new OleDbDataAdapter(Cmd);

                        //Creates a table that will be filled with data from the select query
                        DataTable table = new DataTable();

                        //the data adapter da adds rows to the table
                        da.Fill(table);

                        // sets the datagridviewer Grid source to that of the DataTable table
                        // that is filled with data from the select query
                        Grid.DataSource = table;

                        //Closes the connection to the database
                        Conn.Close();

                        //Displays the DataTable
                        Grid.Show();
                    }
                }

                //if the radiobutton rbGenres is clicked by the User
                else if (rbGenres.Checked)
                {
                    //if the textbox tbSearch is not empty
                    if (tbSearch.Text != "")
                    {
                        try //Exception Handling
                        {
                            //Gets value entered from the user to indicate the size of the columns and fill it with data
                            Grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                            //Creates A connection between the datasource(select query) and dataset to Add rows or refresh rows
                            OleDbDataAdapter Adapt = new OleDbDataAdapter();

                            //Creates an empty set for data to be filled
                            DataSet DS = new DataSet();

                            // Creates  view of the data stored in the dataset
                            DataView DV = new DataView();

                            // A select query that gets everything from the table Genres, when the user
                            // types a letter it is checked and compared to entries in the table
                            // to determine whetere a specific character string matches a specified pattern
                            //in either the column GenreID or Genre
                            string SQL = "SELECT * FROM Genres WHERE GenreID LIKE '" + tbSearch.Text + "%' OR Genre LIKE'" + tbSearch.Text + "%'";

                            //Opens a connection to the database
                            Conn.Open();

                            //Creates a database command object that contains the connection to the
                            //database and the string containing the select query
                            Cmd = new OleDbCommand(SQL, Conn);

                            //Creates A connection between the datasource(select query) and dataset to Add rows or refresh rows from the command
                            Adapt = new OleDbDataAdapter(Cmd);

                            //Fills the DataSet with information from the select query
                            Adapt.Fill(DS);

                            // Creates a view of the data stored in the dataset
                            DV = new DataView(DS.Tables[0]);

                            // sets the datagridviewer Grid source to that of the DataView
                            // that is filled with data from the select query
                            Grid.DataSource = DV;

                            //Closes the connection to the database
                            Conn.Close();
                        }
                        catch (Exception) //catches error
                        {
                            //Displays a message box informing the user that their input is invalid
                            MessageBox.Show("Invalid input");
                        }

                    }

                    //if the textbox tbSearch is empty
                    else if (tbSearch.Text == "")
                    {
                        //A select query to select everything in the table called Genres
                        Cmd.CommandText = "SELECT * FROM Genres";

                        //Creates A connection between the datasource(select query) and dataset
                        //to Add rows or refresh rows
                        OleDbDataAdapter da = new OleDbDataAdapter(Cmd);

                        //Creates a table that will be filled with data from the data adapter
                        DataTable table = new DataTable();

                        //the data adapter da adds rows to the table
                        da.Fill(table);

                        // sets the datagridviewer Grid source to that of the DataTable table
                        // that is filled with data from the select query
                        Grid.DataSource = table;

                        //Closes the connection to the database
                        Conn.Close();

                        //Displays the DataTable
                        Grid.Show();
                    }
                }

                //if the radiobutton rbStudios is clicked by the User
                else if (rbStudios.Checked)
                {
                    //if the textbox tbSearch is not empty
                    if (tbSearch.Text != "")
                    {
                        try //Exception Handling
                        {
                            //Gets value entered from the user to indicate the size of the columns and fill it with data
                            Grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                            //Creates A connection between the datasource(select query) and dataset to Add rows or refresh rows
                            OleDbDataAdapter Adapt = new OleDbDataAdapter();

                            //Creates an empty set for data to be filled
                            DataSet DS = new DataSet();

                            // Creates view of the data stored in the dataset
                            DataView DV = new DataView();

                            // A select query that gets everything from the table Studios, when the user
                            // types a letter it is checked and compared to entries in the table
                            // to determine whetere a specific character string matches a specified pattern
                            //in either the column StudioID or Studio
                            string SQL = "SELECT * FROM Studios WHERE StudioID LIKE '" + tbSearch.Text + "%' OR Studio LIKE'" + tbSearch.Text + "%'";

                            //Opens a connection to the database
                            Conn.Open();

                            //Creates a database command object that contains the connection to the
                            //database and the string containing the select query
                            Cmd = new OleDbCommand(SQL, Conn);

                            //Creates A connection between the datasource(select query) and dataset to refresh rows from the command
                            Adapt = new OleDbDataAdapter(Cmd);

                            //Fills the DataSet with information from the select query
                            Adapt.Fill(DS);

                            // Creates a view of the data stored in the dataset
                            DV = new DataView(DS.Tables[0]);

                            // sets the datagridviewer Grid source to that of the DataView
                            // that is filled with data from the select query
                            Grid.DataSource = DV;

                            //Closes the connection to the database
                            Conn.Close();
                        }
                        catch(Exception) //catches error
                        {
                            //Displays a message box informing the user that their input is invalid
                            MessageBox.Show("Invalid input");
                        }
                    }

                    //if the textbox tbSearch is empty
                    else if (tbSearch.Text == "")
                    {
                        //A select query to select everything in the table called Studios
                        Cmd.CommandText = "SELECT * FROM Studios";

                        //Creates A connection between the datasource(select query) and dataset
                        //to Add rows or refresh rows
                        OleDbDataAdapter da = new OleDbDataAdapter(Cmd);

                        //Creates a table that will be filled with data from the data adapter
                        DataTable table = new DataTable();

                        //the data adapter da adds rows to the table
                        da.Fill(table);

                        // sets the datagridviewer Grid source to that of the DataTable table
                        // that is filled with data from the select query
                        Grid.DataSource = table;

                        //Closes the connection to the database
                        Conn.Close();

                        //Displays the DataTable
                        Grid.Show();
                    }

                }
                //if the radiobutton rbAnimeStudios is clicked by the User
                else if (rbAnimeStudios.Checked)
                {
                    //if the textbox tbSearch is not empty
                    if (tbSearch.Text != "")
                    {
                        try //Exception Handling
                        {
                            //Gets value entered from the user to indicate the size of the columns and fill it with data
                            Grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                            //Creates A connection between the datasource(select query) and dataset to Add rows or refresh rows
                            OleDbDataAdapter Adapt = new OleDbDataAdapter();

                            //Creates an empty set for data to be filled
                            DataSet DS = new DataSet();

                            // Creates view of the data stored in the dataset
                            DataView DV = new DataView();

                            // A select query that gets everything from the table AnimeStudios, when the user
                            // types a letter it is checked and compared to entries in the table
                            // to determine whetere a specific character string matches a specified pattern
                            //in either the column AnimeID or StudioID
                            string SQL = "SELECT * FROM AnimeStudios WHERE AnimeID LIKE '" + tbSearch.Text + "%' OR StudioID LIKE'" + tbSearch.Text + "%'";

                            //Opens a connection to the database
                            Conn.Open();

                            //Creates a database command object that contains the connection to the
                            //database and the string containing the select query
                            Cmd = new OleDbCommand(SQL, Conn);

                            //Creates A connection between the datasource(select query) and dataset to  refresh rows from the command
                            Adapt = new OleDbDataAdapter(Cmd);

                            //Fills the DataSet with information from the select query
                            Adapt.Fill(DS);

                            // Creates a view of the data stored in the dataset
                            DV = new DataView(DS.Tables[0]);

                            // sets the datagridviewer Grid source to that of the DataTable table
                            // that is filled with data from the select query
                            Grid.DataSource = DV;

                            //Closes connection to the database
                            Conn.Close();
                        }
                        catch(Exception) //catches error
                        {
                            //Displays a message box informing the user that their input is invalid
                            MessageBox.Show("Invalid input");
                        }
                    }

                    //if the textbox tbSearch is empty
                    else if (tbSearch.Text == "")
                    {
                        //A select query to select everything in the table called AnimeStudios
                        Cmd.CommandText = "SELECT * FROM AnimeStudios";

                        //Creates A connection between the datasource(select query) and dataset
                        //to Add rows or refresh rows
                        OleDbDataAdapter da = new OleDbDataAdapter(Cmd);

                        //Creates a table that will be filled with data from the data adapter
                        DataTable table = new DataTable();

                        //the data adapter da adds rows to the table
                        da.Fill(table);

                        // sets the datagridviewer Grid source to that of the DataTable table
                        // that is filled with data from the select query
                        Grid.DataSource = table;

                        //Closes the connection to the database
                        Conn.Close();

                        //Displays the DataTable
                        Grid.Show();
                    }

                }
                //if the radiobutton rbAnimeGenres is clicked by the User
                else if (rbAnimeGenres.Checked)
                {
                    //if the textbox tbSearch is not empty
                    if (tbSearch.Text != "")
                    {
                        try //catches the error
                        {
                            //Gets value entered from the user to indicate the size of the columns and fill it with data
                            Grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                            //Creates A connection between the datasource(select query) and dataset to Add rows or refresh rows
                            OleDbDataAdapter Adapt = new OleDbDataAdapter();

                            //Creates an empty set for data to be filled
                            DataSet DS = new DataSet();

                            // Creates view of the the data stored in the dataset
                            DataView DV = new DataView();

                            // A select query that gets everything from the table AnimeGenres, when the user
                            // types a letter it is checked and compared to entries in the table
                            // to determine whetere a specific character string matches a specified pattern
                            //in either the column AnimeID or GenreID
                            string SQL = "SELECT * FROM AnimeGenres WHERE AnimeID LIKE '" + tbSearch.Text + "%' OR GenreID LIKE '" + tbSearch.Text + "%'";

                            //Opens a connection to the database
                            Conn.Open();

                            //Creates a database command object that contains the connection to the
                            //database and the string containing the select query
                            Cmd = new OleDbCommand(SQL, Conn);

                            //Creates A connection between the datasource(select query) and dataset to refresh rows from the command
                            Adapt = new OleDbDataAdapter(Cmd);

                            //Fills the DataSet with information from the select query
                            Adapt.Fill(DS);

                            // Creates a view of the data stored in the dataset
                            DV = new DataView(DS.Tables[0]);

                            // sets the datagridviewer Grid source to that of the DataTable table
                            // that is filled with data from the select query
                            Grid.DataSource = DV;

                            //Closes the connection to the database
                            Conn.Close();
                        }
                        catch(Exception) //catches error
                        {
                            //Displays a message box informing the user that their input is invalid
                            MessageBox.Show("Invalid Input!");
                        }
                    }

                    //if the textbox tbSearch is empty
                    else if (tbSearch.Text == "")
                    {
                        //A select query to select everything in the table called AnimeGenres
                        Cmd.CommandText = "SELECT * FROM AnimeGenres";

                        //Creates A connection between the datasource(select query) and dataset
                        //to Add rows or refresh rows
                        OleDbDataAdapter da = new OleDbDataAdapter(Cmd);

                        //Creates a table that will be filled with data from the data adapter
                        DataTable table = new DataTable();

                        //the data adapter da adds rows to the table
                        da.Fill(table);

                        // sets the datagridviewer Grid source to that of the DataTable table
                        // that is filled with data from the select query
                        Grid.DataSource = table;

                        //Closes the connection to the database
                        Conn.Close();

                        //Displays the DataTable
                        Grid.Show();
                    }

                }
                //if the radiobutton rbAnimeStatus is clicked by the User
                if (rbAnimeStatus.Checked)
                {
                    //if the textbox tbSearch is not empty
                    if (tbSearch.Text != "")
                    {
                        try //Exception handling
                        {
                            //Gets value entered from the user to indicate the size of the columns and fill it with data
                            Grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                            //Creates A connection between the datasource(select query) and dataset to Add rows or refresh rows
                            OleDbDataAdapter Adapt = new OleDbDataAdapter();

                            //Creates an empty set for data to be filled
                            DataSet DS = new DataSet();

                            //Creates an empty set for data to be filled
                            DataView DV = new DataView();

                            // A select query that gets everything from the table AnimeStatus, when the user
                            // types a letter it is checked and compared to entries in the table
                            // to determine whetere a specific character string matches a specified pattern
                            //in either the column AnimeID or Status
                            string SQL = "SELECT * FROM AnimeStatus WHERE AnimeID LIKE '" + tbSearch.Text + "%' OR Status LIKE '" + tbSearch.Text + "%'";

                            //Opens a connection to the database
                            Conn.Open();

                            //Creates a database command object that contains the connection to the
                            //database and the string containing the select query
                            Cmd = new OleDbCommand(SQL, Conn);

                            //Creates A connection between the datasource(select query) and dataset to refresh rows from the command
                            Adapt = new OleDbDataAdapter(Cmd);

                            //Fills the DataSet with information from the select query
                            Adapt.Fill(DS);

                            // Creates a view of the the data stored in the dataset
                            DV = new DataView(DS.Tables[0]);

                            // sets the datagridviewer Grid source to that of the DataTable table
                            // that is filled with data from the select query
                            Grid.DataSource = DV;

                            //Closes the connection to the database
                            Conn.Close();
                        }
                        catch(Exception) //catches error
                        {
                            //Displays a message box informing the user that their input is invalid
                            MessageBox.Show("Invalid input");
                        }
                    }

                    //if the textbox tbSearch is empty
                    else if (tbSearch.Text == "")
                    {
                        //A select query to select everything from the table called AnimeStatus
                        Cmd.CommandText = "SELECT * FROM AnimeStatus";

                        //Creates A connection between the datasource(select query) and dataset
                        //to Add rows or refresh rows
                        OleDbDataAdapter da = new OleDbDataAdapter(Cmd);

                        //Creates a table that will be filled with data from the data adapter
                        DataTable table = new DataTable();

                        //the data adapter da adds rows to the table
                        da.Fill(table);

                        // sets the datagridviewer Grid source to that of the DataTable table
                        // that is filled with data from the select query
                        Grid.DataSource = table;

                        //Closes the connection to the database
                        Conn.Close();

                        //Displays the DataTable
                        Grid.Show();
                    }

                }

                //if the radiobutton rbUsers is clicked by the User
                else if (rbUsers.Checked)
                {
                    //if the textbox tbSearch is not empty
                    if (tbSearch.Text != "")
                    {
                        try //Exception handling
                        {
                            //Gets value entered from the user to indicate the size of the columns and fill it with data
                            Grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                            //Creates A connection between the datasource(select query) and dataset to Add rows or refresh rows
                            OleDbDataAdapter Adapt = new OleDbDataAdapter();

                            //Creates an empty set for data to be filled
                            DataSet DS = new DataSet();

                            //Creates an empty set for data to be filled
                            DataView DV = new DataView();

                            // A select query that gets the UserID and Username from the table Users, when the user
                            // types a letter it is checked and compared to entries in the table
                            // to determine whetere a specific character string matches a specified pattern
                            //in the column Username
                            string SQL = "SELECT UserID, Username FROM Users WHERE Username LIKE'" + tbSearch.Text + "%'";

                            //Opens a connection to the database
                            Conn.Open();

                            //Creates a database command object that contains the connection to the
                            //database and the string containing the select query
                            Cmd = new OleDbCommand(SQL, Conn);

                            //Creates A connection between the datasource(select query) and dataset to refresh rows from the command
                            Adapt = new OleDbDataAdapter(Cmd);

                            //Fills the DataSet with information from the select query
                            Adapt.Fill(DS);

                            // Creates a view of the the data stored in the dataset
                            DV = new DataView(DS.Tables[0]);

                            // sets the datagridviewer Grid source to that of the DataTable table
                            // that is filled with data from the select query
                            Grid.DataSource = DV;

                            //Closes the connection to the database
                            Conn.Close();
                        }
                        catch(Exception) //catches error
                        {
                            //Displays a message box informing the user that their input is invalid
                            MessageBox.Show("Invalid input");
                        }
                    }

                    //if the textbox tbSearch is empty
                    else if (tbSearch.Text == "")
                    {
                        //A select query to select the UserID and Username from the table called Users
                        Cmd.CommandText = "SELECT UserID, Username FROM Users";

                        //Creates A connection between the datasource(select query) and dataset
                        //to Add rows or refresh rows
                        OleDbDataAdapter da = new OleDbDataAdapter(Cmd);

                        //Creates a table that will be filled with data from the data adapter
                        DataTable table = new DataTable();

                        //the data adapter da adds rows to the table
                        da.Fill(table);

                        // sets the datagridviewer Grid source to that of the DataTable table
                        // that is filled with data from the select query
                        Grid.DataSource = table;

                        //Closes the connection to the database
                        Conn.Close();

                        //Displays the DataTable
                        Grid.Show();
                    }

                }
            }
            catch(Exception)// catches the error
            {
                //Displays a message box saying it does not exist
                MessageBox.Show("Does not exist");
            }
        }


        /// <summary>
        /// The resulting method when the user clicks on a cell from the grid
        /// </summary>
        /// <param name="sender"> The <see cref="System.Object"/> that represents the sender instance</param>
        /// <param name="e">The <see cref="System.EventArgs"/> that represents the event arguments passed
        /// to the event handler</param>
        private void Grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //if the radiobutton rbAnimes is clicked by the User
            if (rbAnimes.Checked)
            {
                //if the cell's row is greater than or equal to 0
                if(e.RowIndex >=0)
                {
                    //stores the cell's row into a datagridviewrow variable 'row'
                    DataGridViewRow row = Grid.Rows[e.RowIndex];

                    //Sets the global variable AnimeID to the cell value under the column AnimeID
                     AnimeID= row.Cells["AnimeID"].Value.ToString();

                    //Sets the global variable AnimeTitle to the cell value under the column AnimeTitle
                    AnimeTitle = row.Cells["AnimeTitle"].Value.ToString();

                    //Sets the global variable Episodes to the cell value under the column Episodes
                    Episodes = row.Cells["Episodes"].Value.ToString();

                    //Sets the global variable Ratings to the cell value under the column Ratings
                    Ratings = row.Cells["Ratings"].Value.ToString();

                    //Sets the global variable AnimeSynopsis to the cell value under the column AnimeSynopsis
                    AnimeSynopsis = row.Cells["AnimeSynopsis"].Value.ToString();

                    //Sets the global variable AnimePictures to the cell value under the column AnimePictures
                    AnimePictures = row.Cells["AnimePictures"].Value.ToString();

                    //Creates a variable of the Form FmEditAnimes
                    FmEditAnimes fmEditAnimes = new FmEditAnimes();

                    //Shows the form FmEditAnimes through the variable
                    fmEditAnimes.ShowDialog();
                     
                }
            }

            //if the radiobutton rbStudios is clicked by the User
            else if (rbStudios.Checked)
            {
                //if the cell's row is greater than or equal to 0
                if (e.RowIndex >=0)
                 {
                    //stores the cell's row into a datagridviewrow variable 'row'
                    DataGridViewRow row = Grid.Rows[e.RowIndex];

                    //Sets the global variable StudioID to the cell value under the column StudioID
                    StudioID = row.Cells["StudioID"].Value.ToString();

                    //Sets the global variable Studio to the cell value under the column Studio
                    Studio = row.Cells["Studio"].Value.ToString();

                    //Creates a variable of the Form FmEditStudios
                    FmEditStudios fmEditStudios = new FmEditStudios();

                    //Shows the form FmEditStudios through the variable
                    fmEditStudios.ShowDialog();
                  
                 }
              }

            //if the radiobutton rbGenres is clicked by the User
            else if (rbGenres.Checked)
            {
                //if the cell's row is greater than or equal to 0
                if (e.RowIndex >=0)
                {
                    //stores the cell's row into a datagridviewrow variable 'row'
                    DataGridViewRow row = Grid.Rows[e.RowIndex];

                    //Sets the global variable GenreID to the cell value under the column GenreID
                    GenreID = row.Cells["GenreID"].Value.ToString();

                    //Sets the global variable Genre to the cell value under the column Genre
                    Genre = row.Cells["Genre"].Value.ToString();

                    //Creates a variable of the Form FmEditGenres
                    FmEditGenres fmEditGenres = new FmEditGenres();

                    //Shows the form FmEditGenres through the variable
                    fmEditGenres.ShowDialog();
                }
            }

            //if the radiobutton rbAnimeGenres is clicked by the User
            else if (rbAnimeGenres.Checked)
            {
                //if the cell's row is greater than or equal to 0
                if (e.RowIndex >= 0)
                {
                    //stores the cell's row into a datagridviewrow variable 'row'
                    DataGridViewRow row = Grid.Rows[e.RowIndex];

                    //Sets the global variable AnimeID to the cell value under the column AnimeID
                    AnimeID = row.Cells["AnimeID"].Value.ToString();

                    //Sets the global variable GenreID to the cell value under the column GenreID
                    GenreID = row.Cells["GenreID"].Value.ToString();

                    //Creates a variable of the Form FmEditAnimeGenres
                    FmEditAnimeGenres fmEditAnimeGenres = new FmEditAnimeGenres();

                    //Shows the form FmEditAnimeGenres through the variable
                    fmEditAnimeGenres.ShowDialog();
                }
            }
            //if the radiobutton rbAnimeStudios is clicked by the User
            else if (rbAnimeStudios.Checked)
            {
                //if the cell's row is greater than or equal to 0
                if (e.RowIndex >=0)
                {
                    //stores the cell's row into a datagridviewrow variable 'row'
                    DataGridViewRow row = Grid.Rows[e.RowIndex];

                    //Sets the global variable AnimeID to the cell value under the column AnimeID
                    AnimeID = row.Cells["AnimeID"].Value.ToString();

                    //Sets the global variable StudioID to the cell value under the column StudioID
                    StudioID = row.Cells["StudioID"].Value.ToString();

                    //Creates a variable of the Form FmEditAnimeStudios
                    FmEditAnimeStudios fmEditAnimeStudios = new FmEditAnimeStudios();

                    //Shows the form FmEditAnimeStudios through the variable
                    fmEditAnimeStudios.ShowDialog();
                }
            }

            //if the radiobutton rbAnimeStatus is clicked by the User
            else if (rbAnimeStatus.Checked)
            {

                //if the cell's row is greater than or equal to 0
                if (e.RowIndex >=0)
                {
                    //stores the cell's row into a datagridviewrow variable 'row'
                    DataGridViewRow row = Grid.Rows[e.RowIndex];

                    //Sets the global variable AnimeID to the cell value under the column AnimeID
                    AnimeID = row.Cells["AnimeID"].Value.ToString();

                    //Sets the global variable Status to the cell value under the column Status
                    Status = row.Cells["Status"].Value.ToString();

                    //Creates a variable of the Form FmEditAnimeStatus
                    FmEditAnimeStatus fmEditAnimeStatus = new FmEditAnimeStatus();

                    //Shows the form FmEditAnimeStatus through the variable
                    fmEditAnimeStatus.ShowDialog();

                }
            }
            //if the radiobutton rbUsers is clicked by the User
            else if (rbUsers.Checked)
            {
                //if the cell's row is greater than or equal to 0
                if (e.RowIndex >= 0)
                {
                    //stores the cell's row into a datagridviewrow variable 'row'
                    DataGridViewRow row = Grid.Rows[e.RowIndex];

                    //Sets the global variable UserID to the cell value under the column AnimeID
                    UserID = row.Cells["UserID"].Value.ToString();

                    //Sets the global variable Username to the cell value under the column Username
                    Username = row.Cells["Username"].Value.ToString();

                    //Creates a variable of the Form FmDeleteUser
                    FmDeleteUser fmDeleteUser = new FmDeleteUser();

                    //Shows the form FmDeleteUser through the variable
                    fmDeleteUser.ShowDialog();

                }
            }
        }

        /// <summary>
        /// The resulting method when the user clicks on the Edit button
        /// </summary>
        /// <param name="sender"> The <see cref="System.Object"/> that represents the sender instance</param>
        /// <param name="e">The <see cref="System.EventArgs"/> that represents the event arguments passed
        /// to the event handler</param>
        private void btEdit_Click(object sender, EventArgs e)
        {
            //if the radiobutton rbAnimes is clicked by the User
            if (rbAnimes.Checked)
            {
                //Creates a variable of the Form FmEditAnimes
                FmEditAnimes fmEditAnimes = new FmEditAnimes();

                //Shows the form FmEditAnimes through the variable
                fmEditAnimes.ShowDialog();
                
            }

            //if the radiobutton rbStudios is clicked by the User
            else if (rbStudios.Checked)
            {
                //Creates a variable of the Form FmEditStudios
                FmEditStudios fmEditStudios = new FmEditStudios();

                //Shows the form FmEditStudios through the variable
                fmEditStudios.ShowDialog();
            }
            //if the radiobutton rbGenres is clicked by the User
            else if (rbGenres.Checked)
            {
                //Creates a variable of the Form FmEditGenres
                FmEditGenres fmEditGenres = new FmEditGenres();

                //Shows the form FmEditGenres through the variable
                fmEditGenres.ShowDialog(); 

            }
            //if the radiobutton rbAnimeStudios is clicked by the User
            else if (rbAnimeStudios.Checked)
            {
                //Creates a variable of the Form FmEditAnimeStudios
                FmEditAnimeStudios fmEditAnimeStudios = new FmEditAnimeStudios();

                //Shows the form FmEditAnimeStudios through the variable
                fmEditAnimeStudios.ShowDialog();
            }

            //if the radiobutton rbAnimeGenres is clicked by the User
            else if (rbAnimeGenres.Checked)
            {
                //Creates a variable of the Form FmEditAnimeGenres
                FmEditAnimeGenres fmEditAnimeGenres = new FmEditAnimeGenres();

                //Shows the form FmEditAnimeGenres through the variable
                fmEditAnimeGenres.ShowDialog();
            }

            //if the radiobutton rbAnimeStatus is clicked by the User
            else if (rbAnimeStatus.Checked)
            {
                //Creates a variable of the Form FmEditAnimeStatus
                FmEditAnimeStatus fmEditAnimeStatus = new FmEditAnimeStatus();

                //Shows the form FmEditAnimeStatus through the variable
                fmEditAnimeStatus.ShowDialog();
            }

            //if the radiobutton rbUsers is clicked by the User
            else if (rbUsers.Checked)
            {
                //Creates a variable of the Form FmDeleteUser
                FmDeleteUser fmDeleteUser = new FmDeleteUser();

                //Shows the form FmDeleteUser through the variable
                fmDeleteUser.ShowDialog();
            }

        }

        /// <summary>
        /// The resulting method when the user clicks on the MainForm button
        /// </summary>
        /// <param name="sender"> The <see cref="System.Object"/> that represents the sender instance</param>
        /// <param name="e">The <see cref="System.EventArgs"/> that represents the event arguments passed
        /// to the event handler</param>
        private void btMainForm_Click(object sender, EventArgs e)
        {
            //Creates a variable of the Form FmAMS
            FmAMS fmAMS = new FmAMS();

            //Shows the form FmAMS through the variable
            fmAMS.ShowDialog();
        }
    }
}
