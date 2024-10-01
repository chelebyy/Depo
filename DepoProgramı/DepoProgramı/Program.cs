using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.UserSkins;
using DevExpress.Skins;
using DevExpress.LookAndFeel;
using System.Data.SQLite;
using System.Threading;
using System.Globalization;


namespace DepoProgramı
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
            Thread.CurrentThread.CurrentCulture = new CultureInfo("tr-TR");
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("tr-TR");

            BonusSkins.Register();
            Application.Run(new Giris());
            
        }
    }
}
