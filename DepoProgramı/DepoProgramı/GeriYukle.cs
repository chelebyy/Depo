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
using System.Data.OleDb;

namespace DepoProgramı
{
    public partial class GeriYukle : DevExpress.XtraEditors.XtraForm
    {
        public GeriYukle()
        {
            InitializeComponent();
        }

       // private readonly SQLiteConnection conn = new SQLiteConnection("Data Source=Data.db;Version=3;Read Only=False;Journal Mode=off;Pooling=true;Cache Size=10000;Page Size=4096;Synchronous=off");

        private readonly SQLiteConnection conn = new SQLiteConnection("Data Source=Data.db;Version=3;Read Only=False;Data Source=" + Application.StartupPath + @"\Data.db");


        protected void BackUp(String path)
        {
            string src = Application.StartupPath + @"\Data.db"; string dst = path; System.IO.File.Copy(src, dst, true);
            //var src = Application.StartupPath + @"\Data.db";
            //var dst = path;
            //File.Copy(src, dst, true);

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

        private void btnGeriYukle_Click(object sender, EventArgs e)
        {
            XtraMessageBox.Show("Geri Yüklemek İstediğiniz Veritabanı Adı : Data olması gerekmektedir.Yoksa Program Hata Verir ", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Information);


            try
            {
                SaveFileDialog SaveFD2 = new SaveFileDialog();
                string FileName = "Data";
                SaveFD2.InitialDirectory = "D:"; SaveFD2.FileName = "Data";
                SaveFD2.Title = "Geri yüklemek istediğiniz veritabanını seçiniz. Veritabanı adı Data olması zorunludur.";
                SaveFD2.DefaultExt = "accdb";
                SaveFD2.Filter = "Microsoft.Data.SqLite(*.db)|*.db|All Files|*.*";
                SaveFD2.FilterIndex = 1;
                SaveFD2.RestoreDirectory = true;

                if (SaveFD2.ShowDialog() == DialogResult.OK)
                {
                    FileName = SaveFD2.FileName;
                    var src = FileName;
                    var dst = Application.StartupPath + @"\Data.db";
                    File.Copy(src, dst, true);
                    MessageBox.Show("Geri yükleme işlemi başarılı !", "İşlem Durumu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }





                //var SaveFD12 = new OpenFileDialog();
                //var FileName = "Data";
                //SaveFD12.InitialDirectory = "C:";
                //SaveFD12.Title = "Geri Yüklemek İstediğiniz Veritabanını Seçiniz";
                //SaveFD12.DefaultExt = "db";
                //SaveFD12.Filter = "SQLite (*.db)|*.db|All Files|*.* ";
                //SaveFD12.FilterIndex = 1;
                //SaveFD12.RestoreDirectory = true;

                //if (SaveFD12.ShowDialog() == DialogResult.OK)
                //{
                //    FileName = SaveFD12.FileName;
                //    BackUp(FileName);
                //    XtraMessageBox.Show("Geri Yükleme İşlemi Başarılı !", "Durum", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //}

            }
            catch (Exception ex)
            {

                XtraMessageBox.Show("Geri Yükleme Yapılırken Hata Oluştu !" + ex, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}