using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Sistema_Automotivo
{
    static class Program
    {
        public static string conexaoDB = "Password=info211;Persist Security Info=True;User ID=sa;Initial Catalog=sistemaAutomotivo;Data Source=LAB-07-17";
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
