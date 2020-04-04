using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NikitaApp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("MjMzNDk3QDMxMzgyZTMxMmUzMGN2cFdZeEg1ck1nSG9iTE9Bd1hWZ3EwblZBRkMwdjRUVS9SM0d5NURLYUE9");

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            
    }
    }
}
