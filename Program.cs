using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SmartLoyalty
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Database.setDatabase(System.Configuration.ConfigurationManager.AppSettings["aceeskey"]);
             Application.Run(new Form1());
            //Application.Run(new frmActivateLic());
        }
    }
}
