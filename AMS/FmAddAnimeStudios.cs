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
    public partial class FmAddAnimeStudios : Form
    {
        public FmAddAnimeStudios()
        {
            InitializeComponent();
        }

        private void btInsert_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection Conn = new OleDbConnection(Program.connString);
                Conn.Open();
                OleDbCommand Cmd = new OleDbCommand();
                Cmd.Connection = Conn;
                Cmd.CommandText = "Insert into AnimeStudios VALUES('" + tbAnimeID.Text + "','" + tbStudioID.Text + "')";
                Cmd.ExecuteNonQuery();
                MessageBox.Show("Anime ID and Studio ID successfully added");
            }
            catch (Exception)
            {
                MessageBox.Show("Anime ID and Studio ID both could not be added");
            }
        }
    }
}
