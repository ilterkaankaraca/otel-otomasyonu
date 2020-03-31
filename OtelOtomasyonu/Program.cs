using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace OtelOtomasyonu
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary
        public static OleDbConnection baglan = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=veritabani.accdb");
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Giris_Form());
        }
    }
}
