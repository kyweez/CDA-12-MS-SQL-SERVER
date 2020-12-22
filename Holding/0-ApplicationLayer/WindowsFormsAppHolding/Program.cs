using ClassLibraryBusinessLayer;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppHolding
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
            string connectionString = ConfigurationManager.ConnectionStrings["db_holding"].ConnectionString;
            Supplier loadedSupplier = Supplier.Load(connectionString, 1);
            Application.Run(new FormSupplier(loadedSupplier));
        }
    }
}
