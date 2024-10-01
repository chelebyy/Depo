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
    public partial class YeniCihazEkle : DevExpress.XtraEditors.XtraForm
    {
        public YeniCihazEkle()
        {
            InitializeComponent();
        }

        SQLiteConnection conn = new SQLiteConnection("Data Source=Data.db;Version=3;Read Only=False;Journal Mode=off;Pooling=true;Cache Size=10000;Page Size=4096;Synchronous=off");
        SQLiteCommand kmt = new SQLiteCommand();

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Programı Kapatmak İstiyor musunuz ? ", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                Application.Exit();

            }
        }

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

        private void navButton2_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {

        }

        private void navbtnYeniEkle_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            cmbxKasaBirimAdi.Text = null;
            cmbxKasaMarka.Text = null;
            txtKasaModel.Text = null;
            txtKasaSeriNo.Text = null;
            txtKasaNotlar.Text = null;
            cmbxKasaDurumu.Text = null;
            txtKasaAdi.Text = null;
            txtIpAdresi.Text = null;
            txtMacAdresi.Text = null;
            txtKasaKullanici.Text = null;


            cmbxLaptopBirimAdi.Text = null;
            cmbxLaptopMarkasi.Text = null;
            txtLaptopModel.Text = null;
            txtLaptopSeriNo.Text = null;
            cmbxLaptopDrm.Text = null;                       
            txtLaptopAdi.Text = null;
            txtLaptopIpAdresi.Text = null;
            txtLAptopMacAdresi.Text = null;
            txtLaptopKullanici.Text = null;
            txtLaptopNotlar.Text = null;


            cmbxMonitorBirimAdi.Text = null;
            cmbxMonitorMarkasi.Text = null;
            txtMonitorModeli.Text = null;
            txtMonitorSeriNo.Text = null;
            txtMonitorNotlar.Text = null;
            cmbxMonitorDurumu.Text = null;
            txtMonitorKullanici.Text = null;

            cmbxYaziciBirimAdi.Text = null;
            cmbxYaziciMarkasi.Text = null;
            txtYaziciModeli.Text = null;
            txtYaziciSeriNo.Text = null;
            cmbxYaziciDurumu.Text = null;
            txtYaziciIpAdresi.Text = null;
            txtYaziciMacAdresi.Text = null;
            txtYaziciKullanici.Text = null;


            cmbxTarayiciBirimAdi.Text = null;
            cmbxTarayiciMarkasi.Text = null;
            txtTarayiciModeli.Text = null;
            txtTarayiciSeriNo.Text = null;
            cmbxTarayiciDurumu.Text = null;
            txtTarayiciIpAdresi.Text = null;
            txtTarayiciMacAdresi.Text = null;
            txtTarayiciKullanici.Text = null;


            cmbxOemBirimAdi.Text = null;
            txtOemMarkasi.Text = null;
            txtOemModeli.Text = null;
            txtOemSeriNo.Text = null;
            txtOemTuru.Text = null;
            cmbxOemDurumu.Text = null;
            txtOemNotlar.Text = null;
            


            cmbxKlavyeBirimAdi.Text = null;
            cmbxKlavyeMarkasi.Text = null;
            txtKlavyeModeli.Text = null;
            txtKlavyeSeriNo.Text = null;
            txtKlavyeNotlar.Text = null;
            cmbxKlavyeDurumu.Text = null;


            cmbxMouseBirimAdi.Text = null;
            cmbxMouseMarkasi.Text = null;
            txtMouseModeli.Text = null;
            txtMouseSeriNo.Text = null;
            txtMouseNotlar.Text = null;
            cmbxMouseDurumu.Text = null;

            cmbxTonerBirimAdi.Text = null;
            cmbxTonerYaziciMarkasi.Text = null;
            txtTonerYaziciModeli.Text = null;
            txtTonerStok.Text = null;
            cmbxTonerDurumu.Text = null;
            txtTonerNotlar.Text = null;

            cmbxKabloBirimAdi.Text = null;
            txtKabloMarkasi.Text = null;
            txtKabloOzellik.Text = null;
            txtKabloUzunluk.Text = null;
            txtKabloNotlar.Text = null;


            cmbxYaziciParcasiBirimAdi.Text = null;
            cmbxYaziciParcaYaziciMarka.Text = null;
            txtYaziciParcaYaziciModeli.Text = null;
            txtYaziciParcaParcaTuru.Text = null;
            txtYaziciParcaStok.Text = null;
            cmbxYaziciParcaDurumu.Text = null;
            txtYaziciParcaNotlar.Text = null;


            cmbxTarayiciParcaBirimAdi.Text = null;
            cmbxTarayiciTarayiciParcaMarkasi.Text = null;
            txtTarayiciParcaTarayiciModeli.Text = null;
            txtTarayiciParcaTuru.Text = null;
            txtStok.Text = null;
            cmbxTarayiciParcaDurumu.Text = null;
            txtTarayiciParcaNotlar.Text = null;

            cmbxNetworkBirimAdi.Text = null;
            txtNetworkMarkasi.Text = null;
            txtNetworkModeli.Text = null;
            txtNetworkSeriNo.Text = null;
            txtNetworkTur.Text = null;
            cmbxNetworkDurumu.Text = null;
            txtNetworkNotlar.Text = null;

            cmbxDigerBirimAdi.Text = null;
            txtDigerUrunAdi.Text = null;
            txtDigerMarkasi.Text = null;
            txtDigerModeli.Text = null;
            txtDigerSeriNo.Text = null;
            txtDigerStok.Text = null;
            cmbxDigerDurumu.Text = null;
            txtDigerNotlar.Text = null;


            cmbxTelsizBirimAdi.Text = null;
            cmbxTelsizMarkasi.Text = null;
            txtTelsizModeli.Text = null;
            txtTelsizSeriNo.Text = null;
            cmbxTelsizDurumu.Text = null;

            cmbxProjeBirimAdi.Text = null;
            txtProjeMarkasi.Text = null;
            txtProjeModeli.Text = null;
            txtProjeSeriNo.Text = null;
            cmbxProjeDurumu.Text = null;
            TxtProjeNotlar.Text = null;




        }

        private void navbtnAnamenu_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            var ana = new AnaMenu();
            ana.Show();
            Close();
        }

        private void YeniCihazEkle_Load(object sender, EventArgs e)
        {

            conn.Open();

            var cmd = new SQLiteCommand("SELECT * FROM Markalar",conn);
            var dr = cmd.ExecuteReader();

            while (dr.Read())
            {

                cmbxKasaMarka.Properties.Items.Add(dr[1]);
                cmbxLaptopMarkasi.Properties.Items.Add(dr[1]);
                cmbxMonitorMarkasi.Properties.Items.Add(dr[1]);
                cmbxYaziciMarkasi.Properties.Items.Add(dr[1]);
                cmbxTarayiciMarkasi.Properties.Items.Add(dr[1]);
                cmbxKlavyeMarkasi.Properties.Items.Add(dr[1]);
                cmbxMouseMarkasi.Properties.Items.Add(dr[1]);
                cmbxYaziciParcaYaziciMarka.Properties.Items.Add(dr[1]);
                cmbxTarayiciTarayiciParcaMarkasi.Properties.Items.Add(dr[1]);
                cmbxTonerYaziciMarkasi.Properties.Items.Add(dr[1]);
                cmbxTelsizMarkasi.Properties.Items.Add(dr[1]);
                

            }

            var cmd1 = new SQLiteCommand("SELECT * FROM Birimler", conn);
            var dr1 = cmd1.ExecuteReader();

            while (dr1.Read())
            {

                cmbxKasaBirimAdi.Properties.Items.Add(dr1[1]);
                cmbxLaptopBirimAdi.Properties.Items.Add(dr1[1]);
                cmbxMonitorBirimAdi.Properties.Items.Add(dr1[1]);
                cmbxYaziciBirimAdi.Properties.Items.Add(dr1[1]);
                cmbxTarayiciBirimAdi.Properties.Items.Add(dr1[1]);
                cmbxOemBirimAdi.Properties.Items.Add(dr1[1]);
                cmbxKlavyeBirimAdi.Properties.Items.Add(dr1[1]);
                cmbxMouseBirimAdi.Properties.Items.Add(dr1[1]);
                cmbxKabloBirimAdi.Properties.Items.Add(dr1[1]);
                cmbxYaziciParcasiBirimAdi.Properties.Items.Add(dr1[1]);
                cmbxTarayiciParcaBirimAdi.Properties.Items.Add(dr1[1]);
                cmbxNetworkBirimAdi.Properties.Items.Add(dr1[1]);
                cmbxDigerBirimAdi.Properties.Items.Add(dr1[1]);
                cmbxTonerBirimAdi.Properties.Items.Add(dr1[1]);
                cmbxTelsizBirimAdi.Properties.Items.Add(dr1[1]);
                cmbxProjeBirimAdi.Properties.Items.Add(dr1[1]);

            }






            conn.Close();

        }

        private void navbtnKaydet_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {

            try
            {
                if (cmbxKasaBirimAdi.Text.Trim() != string.Empty && cmbxKasaMarka.Text.Trim() != string.Empty)
                {
                    conn.Open();

                    kmt.Connection = conn;
                    kmt.CommandText = "INSERT INTO CihazEkleBilgisayarKasasi (BirimAdi,Markasi,Modeli,SeriNo,Notlar,Durumu,Adi,IpAdresi,MacAdresi,Kullanici)  VALUES ('" +
                        cmbxKasaBirimAdi.Text + "','" + cmbxKasaMarka.Text + "','" + txtKasaModel.Text + "','" + txtKasaSeriNo.Text + "','" + txtKasaNotlar.Text + "','" + cmbxKasaDurumu.Text + "','" + txtKasaAdi.Text + "','" + txtIpAdresi.Text + "','" + txtMacAdresi.Text + "','" + txtKasaKullanici.Text + "')";
                    kmt.ExecuteNonQuery();
                    conn.Close();
                    XtraMessageBox.Show("Kaydetme İşlemi Başarılı !", "Durum", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }



                else if (cmbxLaptopBirimAdi.Text.Trim() != string.Empty && cmbxLaptopMarkasi.Text.Trim() != string.Empty)

                {


                    conn.Open();

                    kmt.Connection = conn;
                    kmt.CommandText = "INSERT INTO CihazEkleLaptop (BirimAdi,Markasi,Modeli,SeriNo,Notlar,Durumu,Adi,IpAdresi,MacAdresi,Kullanici)  VALUES ('" +
                        cmbxLaptopBirimAdi.Text + "','" + cmbxLaptopMarkasi.Text + "','" + txtLaptopModel.Text + "','" + txtLaptopSeriNo.Text + "','" + cmbxLaptopDrm.Text + "','" + txtLaptopAdi.Text + "','" + txtLaptopIpAdresi.Text + "','" + txtLAptopMacAdresi.Text + "','" + txtLaptopKullanici.Text + "','" + txtLaptopNotlar.Text + "')";
                    kmt.ExecuteNonQuery();
                    conn.Close();
                    XtraMessageBox.Show("Kaydetme İşlemi Başarılı !", "Durum", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    





                }

                else if (cmbxMonitorBirimAdi.Text.Trim() != string.Empty && cmbxMonitorMarkasi.Text.Trim() != string.Empty)

                {


                    conn.Open();

                    kmt.Connection = conn;
                    kmt.CommandText = "INSERT INTO CihazEkleMonitor (BirimAdi,Markasi,Modeli,SeriNo,Notlar,Durumu,Kullanici)  VALUES ('" +
                        cmbxMonitorBirimAdi.Text + "','" + cmbxMonitorMarkasi.Text + "','" + txtMonitorModeli.Text + "','" + txtMonitorSeriNo.Text + "','" + txtMonitorNotlar.Text + "','" + cmbxMonitorDurumu.Text + "','" + txtMonitorKullanici.Text + "')";
                    kmt.ExecuteNonQuery();
                    conn.Close();
                    XtraMessageBox.Show("Kaydetme İşlemi Başarılı !", "Durum", MessageBoxButtons.OK, MessageBoxIcon.Information);


                }

                else if (cmbxYaziciBirimAdi.Text.Trim() != string.Empty && cmbxYaziciMarkasi.Text.Trim() != string.Empty)

                {


                    conn.Open();

                    kmt.Connection = conn;
                    kmt.CommandText = "INSERT INTO CihazEkleYazici (BirimAdi,Markasi,Modeli,SeriNo,Notlar,Durumu,IpAdresi,MacAdresi,Kullanici)  VALUES ('" +
                        cmbxYaziciBirimAdi.Text + "','" + cmbxYaziciMarkasi.Text + "','" + txtYaziciModeli.Text + "','" + txtYaziciSeriNo.Text + "','" + txtYaziciNotlar.Text + "','" + cmbxYaziciDurumu.Text + "','" + txtYaziciIpAdresi.Text + "','" + txtYaziciMacAdresi.Text + "','" + txtYaziciKullanici.Text + "')";
                    kmt.ExecuteNonQuery();
                    conn.Close();
                    XtraMessageBox.Show("Kaydetme İşlemi Başarılı !", "Durum", MessageBoxButtons.OK, MessageBoxIcon.Information);


                }

                else if (cmbxTarayiciBirimAdi.Text.Trim() != string.Empty && cmbxTarayiciMarkasi.Text.Trim() != string.Empty)

                {


                    conn.Open();

                    kmt.Connection = conn;
                    kmt.CommandText = "INSERT INTO CihazEkleTarayici (BirimAdi,Markasi,Modeli,SeriNo,Notlar,Durumu,IpAdresi,MacAdresi,Kullanici)  VALUES ('" +
                        cmbxTarayiciBirimAdi.Text + "','" + cmbxTarayiciMarkasi.Text + "','" + txtTarayiciModeli.Text + "','" + txtTarayiciSeriNo.Text + "','" + txtTarayiciNotlar.Text + "','" + cmbxTarayiciDurumu.Text + "','" + txtTarayiciIpAdresi.Text + "','" + txtTarayiciMacAdresi.Text + "','" + txtTarayiciKullanici.Text + "')";
                    kmt.ExecuteNonQuery();
                    conn.Close();
                    XtraMessageBox.Show("Kaydetme İşlemi Başarılı !", "Durum", MessageBoxButtons.OK, MessageBoxIcon.Information);


                }

                else if (cmbxOemBirimAdi.Text.Trim() != string.Empty )

                {


                    conn.Open();

                    kmt.Connection = conn;
                    kmt.CommandText = "INSERT INTO CihazEkleOem (BirimAdi,Markasi,Modeli,SeriNo,Turu,Notlar,Durumu)  VALUES ('" +
                        cmbxOemBirimAdi.Text + "','" + txtOemMarkasi.Text + "','" + txtOemModeli.Text + "','" + txtOemSeriNo.Text + "','" + txtOemTuru.Text + "','" + txtOemNotlar.Text + "','" + cmbxOemDurumu.Text + "')";
                    kmt.ExecuteNonQuery();
                    conn.Close();
                    XtraMessageBox.Show("Kaydetme İşlemi Başarılı !", "Durum", MessageBoxButtons.OK, MessageBoxIcon.Information);


                }


                else if (cmbxKlavyeBirimAdi.Text.Trim() != string.Empty && cmbxKlavyeMarkasi.Text.Trim() != string.Empty)

                {


                    conn.Open();

                    kmt.Connection = conn;
                    kmt.CommandText = "INSERT INTO CihazEkleKlavye(BirimAdi,Markasi,Modeli,Tur,SeriNo,Notlar,Durumu)  VALUES ('" +
                        cmbxKlavyeBirimAdi.Text + "','" + cmbxKlavyeMarkasi.Text + "','" + txtKlavyeModeli.Text + "','" + cmbxKlavyeTur.Text + "','" + txtKlavyeSeriNo.Text + "','" + txtKlavyeNotlar.Text + "','" + cmbxKlavyeDurumu.Text + "')";
                    kmt.ExecuteNonQuery();
                    conn.Close();
                    XtraMessageBox.Show("Kaydetme İşlemi Başarılı !", "Durum", MessageBoxButtons.OK, MessageBoxIcon.Information);


                }

                else if (cmbxMouseBirimAdi.Text.Trim() != string.Empty && cmbxMouseMarkasi.Text.Trim() != string.Empty)

                {


                    conn.Open();

                    kmt.Connection = conn;
                    kmt.CommandText = "INSERT INTO CihazEkleMouse(BirimAdi,Markasi,Modeli,SeriNo,Notlar,Durumu)  VALUES ('" +
                        cmbxMouseBirimAdi.Text + "','" + cmbxMouseMarkasi.Text + "','" + txtMouseModeli.Text + "','" + txtMouseSeriNo.Text + "','" + txtMouseNotlar.Text + "','" + cmbxMouseDurumu.Text + "')";
                    kmt.ExecuteNonQuery();
                    conn.Close();
                    XtraMessageBox.Show("Kaydetme İşlemi Başarılı !", "Durum", MessageBoxButtons.OK, MessageBoxIcon.Information);


                }


                else if (cmbxKabloBirimAdi.Text.Trim() != string.Empty)

                {


                    conn.Open();

                    kmt.Connection = conn;
                    kmt.CommandText = "INSERT INTO CihazEkleKablo(BirimAdi,Ozelligi,Uzunluk,Notlar)  VALUES ('" +
                        cmbxKabloBirimAdi.Text + "','" + txtKabloOzellik.Text + "','" + txtKabloUzunluk.Text + "','" + txtKabloNotlar.Text + "')";
                    kmt.ExecuteNonQuery();
                    conn.Close();
                    XtraMessageBox.Show("Kaydetme İşlemi Başarılı !", "Durum", MessageBoxButtons.OK, MessageBoxIcon.Information);


                }

                else if (cmbxYaziciParcasiBirimAdi.Text.Trim() != string.Empty && cmbxYaziciParcaYaziciMarka.Text.Trim() != string.Empty)

                {


                    conn.Open();

                    kmt.Connection = conn;
                    kmt.CommandText = "INSERT INTO CihazEkleYaziciParcalari(BirimAdi,Markasi,Modeli,ParcaAdi,Stok,Notlar,Durumu)  VALUES ('" +
                        cmbxYaziciParcasiBirimAdi.Text + "','" + cmbxYaziciParcaYaziciMarka.Text + "','" + txtYaziciParcaYaziciModeli.Text + "','" + txtYaziciParcaParcaTuru.Text + "','" + txtYaziciParcaStok.Text + "','" + txtYaziciParcaParcaTuru.Text + "','" + txtYaziciParcaNotlar.Text + "')";
                    kmt.ExecuteNonQuery();
                    conn.Close();
                    XtraMessageBox.Show("Kaydetme İşlemi Başarılı !", "Durum", MessageBoxButtons.OK, MessageBoxIcon.Information);


                }

                else if (cmbxTarayiciParcaBirimAdi.Text.Trim() != string.Empty && cmbxTarayiciTarayiciParcaMarkasi.Text.Trim() != string.Empty)

                {


                    conn.Open();

                    kmt.Connection = conn;
                    kmt.CommandText = "INSERT INTO CihazEkleTarayiciParcalari(BirimAdi,Markasi,Modeli,ParcaAdi,Stok,Notlar,Durumu)  VALUES ('" +
                        cmbxTarayiciParcaBirimAdi.Text + "','" + cmbxTarayiciTarayiciParcaMarkasi.Text + "','" + txtTarayiciParcaTarayiciModeli.Text + "','" + txtTarayiciParcaTuru.Text + "','" + txtStok.Text + "','" +cmbxTarayiciParcaDurumu.Text+"','"+ txtTarayiciParcaNotlar.Text + "')";
                    kmt.ExecuteNonQuery();
                    conn.Close();
                    XtraMessageBox.Show("Kaydetme İşlemi Başarılı !", "Durum", MessageBoxButtons.OK, MessageBoxIcon.Information);


                }


                else if (cmbxNetworkBirimAdi.Text.Trim() != string.Empty)

                {


                    conn.Open();

                    kmt.Connection = conn;
                    kmt.CommandText = "INSERT INTO CihazEkleNetwork(BirimAdi,Markasi,Modeli,SeriNo,Tur,Notlar,Durumu)  VALUES ('" +
                        cmbxNetworkBirimAdi.Text + "','" + txtNetworkMarkasi.Text + "','" + txtNetworkModeli.Text + "','" + txtNetworkSeriNo.Text + "','" + txtNetworkTur.Text + "','" + txtNetworkNotlar.Text + "','" + cmbxNetworkDurumu.Text + "')";
                    kmt.ExecuteNonQuery();
                    conn.Close();
                    XtraMessageBox.Show("Kaydetme İşlemi Başarılı !", "Durum", MessageBoxButtons.OK, MessageBoxIcon.Information);


                }

                else if (cmbxDigerBirimAdi.Text.Trim() != string.Empty)

                {


                    conn.Open();

                    kmt.Connection = conn;
                    kmt.CommandText = "INSERT INTO CihazEkleDiger(BirimAdi,UrunAdi,Markasi,Modeli,SeriNo,Stok,Notlar,Durumu)  VALUES ('" +
                        cmbxDigerBirimAdi.Text + "','" + txtDigerUrunAdi.Text + "','" + txtDigerMarkasi.Text + "','" + txtDigerModeli.Text + "','" + txtDigerSeriNo.Text + "','" + txtDigerStok.Text + "','" + txtDigerNotlar.Text + "','" + cmbxDigerDurumu.Text + "')";
                    kmt.ExecuteNonQuery();
                    conn.Close();
                    XtraMessageBox.Show("Kaydetme İşlemi Başarılı !", "Durum", MessageBoxButtons.OK, MessageBoxIcon.Information);


                }


                else if (cmbxTonerBirimAdi.Text.Trim() != string.Empty)

                {


                    conn.Open();

                    kmt.Connection = conn;
                    kmt.CommandText = "INSERT INTO Toner(BirimAdi,Marka,Model,Stok,Durumu,Notlar)  VALUES ('" +
                        cmbxTonerBirimAdi.Text + "','" + cmbxTonerYaziciMarkasi.Text + "','" + txtTonerYaziciModeli.Text + "','" + txtTonerStok.Text + "','" + cmbxTonerDurumu.Text + "','" + txtTonerNotlar.Text + "')";
                    kmt.ExecuteNonQuery();
                    conn.Close();
                    XtraMessageBox.Show("Kaydetme İşlemi Başarılı !", "Durum", MessageBoxButtons.OK, MessageBoxIcon.Information);


                }


                else if (cmbxTelsizBirimAdi.Text.Trim() != string.Empty)

                {


                    conn.Open();

                    kmt.Connection = conn;
                    kmt.CommandText = "INSERT INTO CihazEkleTelsiz(BirimAdi,Markasi,Modeli,SeriNo,Durumu)  VALUES ('" +
                        cmbxTelsizBirimAdi.Text + "','" + cmbxTelsizMarkasi.Text + "','" + txtTelsizModeli.Text + "','" + txtTelsizSeriNo.Text + "','" + cmbxTelsizDurumu.Text + "')";
                    kmt.ExecuteNonQuery();
                    conn.Close();
                    XtraMessageBox.Show("Kaydetme İşlemi Başarılı !", "Durum", MessageBoxButtons.OK, MessageBoxIcon.Information);


                }

                else if (cmbxProjeBirimAdi.Text.Trim() != string.Empty)

                {


                    conn.Open();

                    kmt.Connection = conn;
                    kmt.CommandText = "INSERT INTO CihazEkleProjeksiyon(BirimAdi,Markasi,Modeli,SeriNo,Durumu,Notlar)  VALUES ('" +
                        cmbxProjeBirimAdi.Text + "','" + txtProjeMarkasi.Text + "','" + txtProjeModeli.Text + "','" + txtProjeSeriNo.Text + "','" + cmbxProjeDurumu.Text + "','" + TxtProjeNotlar.Text + "')";
                    kmt.ExecuteNonQuery();
                    conn.Close();
                    XtraMessageBox.Show("Kaydetme İşlemi Başarılı !", "Durum", MessageBoxButtons.OK, MessageBoxIcon.Information);


                }



                else
                {
                    XtraMessageBox.Show("Lütfen Birim Adı ve Markası Bilgilerini Seçiniz !", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }




            }

                
            
            catch (Exception ex)
            {

                XtraMessageBox.Show(ex.Message);
            }


           


        }

        
    }
}
