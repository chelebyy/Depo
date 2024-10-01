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
    public partial class TesellumEkle : DevExpress.XtraEditors.XtraForm
    {
        public TesellumEkle()
        {
            InitializeComponent();
        }

        SQLiteConnection conn = new SQLiteConnection("Data Source=Data.db;Version=3;Read Only=False;Journal Mode=off;Pooling=true;Cache Size=10000;Page Size=4096;Synchronous=off");
        SQLiteCommand cmd = new SQLiteCommand();

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Programı Kapatmak İstiyor musunuz ? ", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                Application.Exit();

            }
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {


                WindowState = FormWindowState.Maximized;

            }
            else
            {
                WindowState = FormWindowState.Normal;

            }
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void navbarAnaMenu_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            var ana = new AnaMenu();
            ana.Show();
            Close();
        }

        private void navbarKaydet_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            try
            {
                if (cmbxBirimEkle.Text.Trim() != string.Empty)
                {
                    conn.Open();
                    cmd.Connection = conn;
                    cmd.CommandText = "INSERT INTO Teslim (Markasi,Modeli,Urun,Birimi,Adedi,TeslimEden,TeslimEdenSicil,TeslimAlan,TeslimAlanSicil,Tarih,Aciklama) VALUES('" + cmbxTeslimMarkasi.Text + "','" + txtTeslimModeli.Text + "','" + txtUrun.Text + "','" + cmbxBirimEkle.Text + "','" + txtAdet.Text + "','" + txtTeslimEden.Text + "','" + txtVerenSicil.Text + "','" + txtTeslimAlan.Text + "','" + txtAlanSicil.Text + "',@dtTeslimTarihi,'" + txtTeslimAciklama.Text + "' )";
                    cmd.Parameters.AddWithValue("@dtTeslimTarihi", dtTeslimTarihi.EditValue);


                    //cmd.Parameters.AddWithValue("@dtTeslimTarihi", Convert.ToDateTime(dtTeslimTarihi.EditValue).ToString("dd.MM.yyyy"));




                    cmd.ExecuteNonQuery();
                    conn.Close();
                    XtraMessageBox.Show("Kaydetme İşlemi Başarılı !", "Durum", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    XtraMessageBox.Show("Lütfen Birim Adı Seçiniz !", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }



            catch (Exception ex)
            {

                XtraMessageBox.Show(ex.Message);
            }
        }

        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TesellumEkle_Load(object sender, EventArgs e)
        {
            conn.Open();

            var cmd1 = new SQLiteCommand("SELECT * FROM Markalar", conn);
            var dr1 = cmd1.ExecuteReader();

            while (dr1.Read())
            {

                cmbxTeslimMarkasi.Properties.Items.Add(dr1[1]);


            }



            var cmd = new SQLiteCommand("SELECT * FROM Birimler", conn);
            var dr = cmd.ExecuteReader();

            while (dr.Read())
            {

                cmbxBirimEkle.Properties.Items.Add(dr[1]);


            }
           




            conn.Close();

        }

        private void navbarYeniEkle_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            cmbxTeslimMarkasi.Text = null;
            txtTeslimModeli.Text = null;
            txtUrun.Text = null;
            cmbxBirimEkle.Text = null;
            txtAdet.Text = null;
            txtTeslimEden.Text = null;
            txtVerenSicil.Text = null;
            txtTeslimEden.Text = null;
            txtAlanSicil.Text = null;
            txtTeslimAciklama.Text = null;
        }
    }
    }
