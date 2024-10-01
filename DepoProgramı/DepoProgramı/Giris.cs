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
using System.Threading;


namespace DepoProgramı
{
    public partial class Giris : DevExpress.XtraEditors.XtraForm
    {
        public Giris()
        {
            InitializeComponent();
        }

        //private readonly OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + @"\Data.accdb");
        SQLiteConnection conn = new SQLiteConnection("Data Source=Data.db;Version=3;Read Only=False;Journal Mode=off;Pooling=true;Cache Size=10000;Page Size=4096;Synchronous=off");
        SQLiteCommand cmd = new SQLiteCommand();

        private Point mouseDownPoint = Point.Empty;

        private bool Validate(string text1, string text2)
        {

            return string.IsNullOrEmpty(text1) == false && text1 == text2;
        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        private void labelControl2_Click(object sender, EventArgs e)
        {
            var yenikullanici = new YeniKullanici();
            yenikullanici.Show();
            Hide();

        }

        private void lblSifreDegistir_Click(object sender, EventArgs e)
        {
            var sifredegistir = new SifreDegistir();
            sifredegistir.Show();
            Hide();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {

                       
            try
            {

                conn.Open();
                var sql = "SELECT * FROM Kullanicilar WHERE KulAdi= @KAdi AND Sifre=@KSifre";
                var prm1 = new SQLiteParameter("@KAdi", txtKulAdi.Text);
                var prm2 = new SQLiteParameter("@KSifre", txtSifre.Text);
                var kmt = new SQLiteCommand(sql,conn);
                kmt.Parameters.Add(prm1);
                kmt.Parameters.Add(prm2);
                var dt = new DataTable();
                var da = new SQLiteDataAdapter(kmt);
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    var ana = new AnaMenu();
                    ana.Show();
                    Hide();
                }
                else
                {


                    if (string.IsNullOrWhiteSpace(txtKulAdi.Text)|| string.IsNullOrWhiteSpace(txtSifre.Text))
                    {
                        XtraMessageBox.Show("Lütfen tüm alanları doldurunuz ! ", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }

                    else
                    {
                        lblHata.Visible = true;
                    }

                }



            }
            catch (Exception ex)
            {

                XtraMessageBox.Show(ex.Message);
            }

            conn.Close();


        }

        private void Giris_Load(object sender, EventArgs e)
        {
            Thread.Sleep(4000);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Programı Kapatmak İstiyor musunuz ? ", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                Application.Exit();

            }
        }

        bool Mov;

        int MovX, MovY;

        private void Giris_MouseDown(object sender, MouseEventArgs e)
        {
            Mov = true;
            MovX = e.X;
            MovY = e.Y;
        }

        private void Giris_MouseUp(object sender, MouseEventArgs e)
        {
            Mov = false;
        }

        private void Giris_MouseMove(object sender, MouseEventArgs e)
        {
            if (Mov)
            {
                this.SetDesktopLocation(MousePosition.X - MovX, MousePosition.Y - MovY);
            }
        }
    }
}
