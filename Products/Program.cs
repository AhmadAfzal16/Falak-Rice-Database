using System;
using System.Windows.Forms;

namespace SalesManagementApp
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
            Application.Run(new MainForm()); // Change to the appropriate form you want to start with, e.g., new ProductForm()
        }
    }
}
