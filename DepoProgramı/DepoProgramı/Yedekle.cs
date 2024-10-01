using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SQLite;
using System.IO;
using System.Data.SqlClient;

//using System.Data.OleDb;

namespace DepoProgramı
{
    public partial class Yedekle : DevExpress.XtraEditors.XtraForm
    {
        public Yedekle()
        {
            InitializeComponent();
        }

        SQLiteConnection baglan = new SQLiteConnection("Data Source=Data.db;Version=3;Read Only=False;Data Source=" + Application.StartupPath + @"\Data.db");

        //SQLiteConnection baglan = new SQLiteConnection("Data Source=Data.db;Version=3");



        protected void BackUp(String path)
        {

            var src = Application.StartupPath + @"\Data.db";
            var dst = path;
            File.Copy(src, dst, true);

        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Programı Kapatmak İstiyor musunuz ? ", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                Application.Exit();

            }
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnAnaMenu_Click(object sender, EventArgs e)
        {
            var ana = new AnaMenu();
            ana.Show();
            Close();
        }

        private void btnYedekle_Click(object sender, EventArgs e)
        {
                                 
            try
            {

                var SaveFD1 = new SaveFileDialog();
                var FileName = "Data";
                SaveFD1.InitialDirectory = "C:";
                SaveFD1.Title = "Yedek Alma";
                SaveFD1.DefaultExt = "db";
                SaveFD1.Filter = "SQLite (*.db)|*.db|All Files|*.* ";
                SaveFD1.FilterIndex = 1;
                SaveFD1.RestoreDirectory = true;

                if (SaveFD1.ShowDialog() == DialogResult.OK)
                {
                    //BackupAllUserDatabases();
                    FileName = SaveFD1.FileName;
                    BackUp(FileName);
                    XtraMessageBox.Show("Yedekleme İşlemi Başarılı !", "Durum", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Yedekleme Yapılırken Hata Oluştu !" + ex, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}