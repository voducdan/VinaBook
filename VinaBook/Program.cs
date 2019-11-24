using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VinaBook
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
            Application.Run(new Home());
        }
    }
    static class globalVeriable
    {
        private static String _connectionString = "Data Source=DESKTOP-SEKM9M5\\SQLEXPRESS;Initial Catalog=Vinabook;User ID=danvo;Password=Voducdantiep.1";
        //private static String _connectionString = "Data Source=DESKTOP-QA7C0NU;Initial Catalog=Vinabook;User ID=binhnguyen;Password=binh123";
        private static string _userAdmin = "dpihgmgd";
        private static string _passAdmin = "cj";
        public static String GlobalVeriable
        {
            get { return _connectionString; }
        }
        public static String UserAdmin
        {
            get
            {
                return _userAdmin;
            }
        }
        public static String PassAdmin
        {
            get
            {
                return _passAdmin;
            }
        }

    }
}
