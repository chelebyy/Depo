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

namespace DepoProgramı
{
    public partial class YeniKullanici : DevExpress.XtraEditors.XtraForm
    {
        public YeniKullanici()
        {
            InitializeComponent();
        }


        SQLiteConnection conn = new SQLiteConnection("Data Source=Data.db;Version=3;Read Only=False;Journal Mode=off;Pooling=true;Cache Size=10000;Page Size=4096;Synchronous=off");
        SQLiteCommand cmd = new SQLiteCommand();


        private bool Validate(string text1, string text2)
        {

            return string.IsNullOrEmpty(text1) == false && text1 == text2;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Programı Kapatmak İstiyor musunuz ? ", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                Application.Exit();

            }
        }

        private void btnOlustur_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtKulAdi.Text) || string.IsNullOrWhiteSpace(txtSifre.Text) || string.IsNullOrWhiteSpace(txtSifreTekrar.Text) || Validate(txtSifre.Text,txtSifreTekrar.Text) == false)
            {
                XtraMessageBox.Show("Lütfen tüm alanları doldurunuz ve şifrelerin aynı olduğundan emin olunuz ! ", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            else
            {
                conn.Open();
                var kmt = new SQLiteCommand("INSERT INTO Kullanicilar (KulAdi,Sifre) VALUES ('"+txtKulAdi.Text+"','"+txtSifre.Text+"')",conn);
                kmt.ExecuteNonQuery();
                conn.Close();
                XtraMessageBox.Show("Kayıt Başarılı !", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtKulAdi.Text = null;
                txtSifre.Text = null;
                txtSifreTekrar.Text = null;

            }
        }

        private void lblGiris_Click(object sender, EventArgs e)
        {
            var giris = new Giris();
            giris.Show();
            Close();
        }
    }
}