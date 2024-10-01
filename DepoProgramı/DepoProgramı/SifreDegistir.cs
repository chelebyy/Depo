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
    public partial class SifreDegistir : DevExpress.XtraEditors.XtraForm
    {
        public SifreDegistir()
        {
            InitializeComponent();
        }

        SQLiteConnection conn = new SQLiteConnection("Data Source=Data.db;Version=3;Read Only=False;Journal Mode=off;Pooling=true;Cache Size=10000;Page Size=4096;Synchronous=off");
        SQLiteCommand kmt = new SQLiteCommand();


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

        private void btnDegistir_Click(object sender, EventArgs e)
        {
            if (txtSifre.Text.Trim() != string.Empty && txtYeniSifre.Text.Trim() != string.Empty && txtKulAdi.Text.Trim() != string.Empty && txtYenisifreTekrar.Text.Trim() != string.Empty)
            {
                conn.Open();

                var cmd = new SQLiteCommand("SELECT * FROM Kullanicilar WHERE KulAdi='"+txtKulAdi.Text+"' AND Sifre='"+txtSifre.Text+"'",conn);
                var rdr = cmd.ExecuteReader();

                if (rdr.Read() && Validate(txtYeniSifre.Text,txtYenisifreTekrar.Text) == false)
                {
                    XtraMessageBox.Show("Kullanıcı Adı ve Şifrenizi Kontrol Ediniz !","Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    txtSifre.Text = null;
                    txtYeniSifre = null;
                    txtYenisifreTekrar = null;
                    txtKulAdi = null;
                }
                else
                {
                    kmt.Connection = conn;
                    kmt.CommandText = "UPDATE Kullanicilar SET Sifre='" + txtYeniSifre.Text + "'WHERE KulAdi='" + txtKulAdi.Text + "'AND Sifre='" + txtSifre.Text + "'";
                    kmt.ExecuteNonQuery();
                    XtraMessageBox.Show("Şifreniz Başarıyla Değiştirilmiştir !", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtSifre.Text = null;
                    txtYeniSifre = null;
                    txtYenisifreTekrar = null;
                    txtKulAdi = null;
                    var giris = new Giris();
                    giris.Show();
                    Close();
                }
            }
            else
            {
                XtraMessageBox.Show("Lütfen Boş Alan Bırakmayınız!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
            conn.Close();
        }

        private void lblGiris_Click(object sender, EventArgs e)
        {
            var giris = new Giris();
            giris.Show();
            Close();
        }
    }
}