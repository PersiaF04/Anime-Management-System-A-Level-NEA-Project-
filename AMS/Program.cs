using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.OleDb;

namespace AMS
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application
        /// </summary>
        [STAThread]
        static void Main()
        {
            DarkModeSwitch.SwitchFunction();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FmMenu());
        }
        public const string connString = "Provider =Microsoft.ACE.OLEDB.12.0; Data Source = AMS.accdb";
    }
}
