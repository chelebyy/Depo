﻿using System;
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
    public partial class IsEkle : DevExpress.XtraEditors.XtraForm
    {
        public IsEkle()
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

        private void navbarYeniEkle_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            
            cmbxBirimEkle.Text = null;
            txtIsınAdi.Text = null;
            cmbxIsınDurumu.Text = null;
            txtAciklama.Text = null;
            txtIsEkleNot.Text = null;
        }

        private void navbarKaydet_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            try
            {
                if (cmbxBirimEkle.Text.Trim() !=string.Empty )
                {
                    conn.Open();
                    cmd.Connection = conn;
                    cmd.CommandText = "INSERT INTO IsListesi (BirimAdi,BaslangicTarihi,IsinAdi,Aciklama,BitisTarihi,IsinDurumu,Notlar) VALUES('" + cmbxBirimEkle.Text+ "',@talepTarihi,'" + txtIsınAdi.Text + "','" + txtAciklama.Text + "',@bitisTarihi,'" + cmbxIsınDurumu.Text + "','"+txtIsEkleNot.Text+"')";
                    cmd.Parameters.AddWithValue("@talepTarihi",dtTalepTarihi.EditValue);
                    

                    cmd.Parameters.AddWithValue("@bitisTarihi", Convert.ToDateTime(dtBitisTarihi.EditValue).ToString("dd.MM.yyyy"));

                    


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

        private void IsEkle_Load(object sender, EventArgs e)
        {
            conn.Open();

            var cmd = new SQLiteCommand("SELECT * FROM Birimler", conn);
            var dr = cmd.ExecuteReader();

            while (dr.Read())
            {

                cmbxBirimEkle.Properties.Items.Add(dr[1]);
                

            }

            conn.Close();

        }

        private void dtTalepTarihi_EditValueChanged(object sender, EventArgs e)
        {
           
        }

        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}