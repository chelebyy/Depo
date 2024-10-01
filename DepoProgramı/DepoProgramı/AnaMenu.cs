using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Net;
using System.Data.SQLite;
using DevExpress.XtraSplashScreen;

namespace DepoProgramı
{
    public partial class AnaMenu : DevExpress.XtraEditors.XtraForm
    {
        private Point mouseDownPoint = Point.Empty;



        public AnaMenu()
        {
            InitializeComponent();
            
    }

        //private readonly OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + @"\Data.accdb");
        SQLiteConnection conn = new SQLiteConnection("Data Source=Data.db;Version=3;Read Only=False;Journal Mode=off;Pooling=true;Cache Size=10000;Page Size=4096;Synchronous=off");

        



        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Programı Kapatmak İstiyor musunuz ? " , "Dikkat",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
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

        private void AnaMenu_Load(object sender, EventArgs e)
        {
            conn.Open();
            var cmd = new SQLiteCommand("SELECT COUNT (*) FROM CihazEkleBilgisayarKasasi", conn);
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {

                lblKasa.Text = dr.GetInt32(0).ToString();
            }

            var cmd2 = new SQLiteCommand("SELECT COUNT (*) FROM CihazEkleTelsiz", conn);
            var dr2 = cmd2.ExecuteReader();
            while (dr2.Read())
            {

                lblKablo.Text = dr2.GetInt32(0).ToString();
            }

            var cmd3 = new SQLiteCommand("SELECT COUNT (*) FROM CihazEkleKlavye ", conn);
            var dr3 = cmd3.ExecuteReader();
            while (dr3.Read())
            {

                lblKlavye.Text = dr3.GetInt32(0).ToString();
            }

            var cmd4 = new SQLiteCommand("SELECT COUNT (*) FROM CihazEkleLaptop", conn);
            var dr4 = cmd4.ExecuteReader();
            while (dr4.Read())
            {

                lblLaptop.Text = dr4.GetInt32(0).ToString();
            }

            var cmd5 = new SQLiteCommand("SELECT COUNT (*) FROM CihazEkleMonitor", conn);
            var dr5 = cmd5.ExecuteReader();
            while (dr5.Read())
            {

                lblMonitor.Text = dr5.GetInt32(0).ToString();
            }

            var cmd6 = new SQLiteCommand("SELECT COUNT (*) FROM CihazEkleMouse", conn);
            var dr6 = cmd6.ExecuteReader();
            while (dr6.Read())
            {

                lblMouse.Text = dr6.GetInt32(0).ToString();
            }

            var cmd7 = new SQLiteCommand("SELECT COUNT (*) FROM Toner", conn);
            var dr7 = cmd7.ExecuteReader();
            while (dr7.Read())
            {

                lblToner.Text = dr7.GetInt32(0).ToString();
            }

            var cmd8 = new SQLiteCommand("SELECT COUNT (*) FROM CihazEkleProjeksiyon", conn);
            var dr8 = cmd8.ExecuteReader();
            while (dr8.Read())
            {

                lblOem.Text = dr8.GetInt32(0).ToString();
            }

            var cmd9 = new SQLiteCommand("SELECT COUNT (*) FROM CihazEkleTarayici", conn);
            var dr9 = cmd9.ExecuteReader();
            while (dr9.Read())
            {

                lblTarayici.Text = dr9.GetInt32(0).ToString();
            }

            var cmd10 = new SQLiteCommand("SELECT COUNT (*) FROM CihazEkleTarayiciParcalari", conn);
            var dr10 = cmd10.ExecuteReader();
            while (dr10.Read())
            {

                lblTarayiciParcalari.Text = dr10.GetInt32(0).ToString();
            }

            var cmd11 = new SQLiteCommand("SELECT COUNT (*) FROM CihazEkleYazici", conn);
            var dr11 = cmd11.ExecuteReader();
            while (dr11.Read())
            {

                lblYazici.Text = dr11.GetInt32(0).ToString();
            }

            var cmd12 = new SQLiteCommand("SELECT COUNT (*) FROM CihazEkleYaziciParcalari", conn);
            var dr12 = cmd12.ExecuteReader();
            while (dr12.Read())
            {

                lblYaziciParcalari.Text = dr12.GetInt32(0).ToString();
            }

            timer1.Start();
            conn.Close();
        }

        private void navbarKasa_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(WaitForm1));
            var masaustu = new BilgisayarKasasi();
            masaustu.Show();
            //Close();
            Hide();
            SplashScreenManager.CloseForm();
        }

        private void navbarLaptop_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {

            SplashScreenManager.ShowForm(typeof(WaitForm1));
            var laptop = new Laptop();
            laptop.Show();
            Close();
            SplashScreenManager.CloseForm();
        }

        private void navbarMonitor_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(WaitForm1));
            var monitor = new Monitor();
            monitor.Show();
            Close();
            SplashScreenManager.CloseForm();
        }

        private void navbarYazici_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(WaitForm1));
            var yazici = new Yazici();
            yazici.Show();
            Close();
            SplashScreenManager.CloseForm();
        }

        private void navbarTarayici_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(WaitForm1));
            var tarayici = new Tarayici();
            tarayici.Show();
            Close();
            SplashScreenManager.CloseForm();
        }

        private void navbarOem_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(WaitForm1));
            var oem = new OEM();
            oem.Show();
            Close();
            SplashScreenManager.CloseForm();
        }

        private void navbarKlavye_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(WaitForm1));
            var klavye = new Klavye();
            klavye.Show();
            Close();
            SplashScreenManager.CloseForm();
        }

        private void navbarKablo_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(WaitForm1));
            var kablo = new Kablo();
            kablo.Show();
            Close();
            SplashScreenManager.CloseForm();
        }

        private void navbarYaziciParcalari_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(WaitForm1));
            var yaziciparcalari = new YaziciParcalari();
            yaziciparcalari.Show();
            Close();
            SplashScreenManager.CloseForm();
        }

        private void navbarTarayiciParcalari_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(WaitForm1));
            var tarayiciparcalari = new TarayiciParcalari();
            tarayiciparcalari.Show();
            Close();
            SplashScreenManager.CloseForm();
        }

        private void navbarNetwork_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(WaitForm1));
            var network = new Network();
            network.Show();
            Close();
            SplashScreenManager.CloseForm();
        }

        private void navbarDiger_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(WaitForm1));
            var diger = new Diger();
            diger.Show();
            Close();
            SplashScreenManager.CloseForm();
        }

        private void Mouse_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(WaitForm1));
            var mouse = new Mouse();
            mouse.Show();
            Close();
            SplashScreenManager.CloseForm();
        }

        private void navbarCihazEkle_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(WaitForm1));
            var cihazekle = new YeniCihazEkle();
            cihazekle.Show();
            Close();
            SplashScreenManager.CloseForm();
        }

        private void navbarYeniIsEkle_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(WaitForm1));
            var isekle = new IsEkle();
            isekle.Show();
            Close();
            SplashScreenManager.CloseForm();
        }

        private void navbarIsListesi_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(WaitForm1));
            var islistesi = new IsListesi();
            islistesi.Show();
            Close();
            SplashScreenManager.CloseForm();
        }

        private void navbarHakkinda_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            var hakkinda = new Hakkinda();
            hakkinda.Show();
            Close();
            
        }

        private void navbarProgramAyarlari_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            var ayarlar = new ProgramAyarlari();
            ayarlar.Show();
            Close();
        }

        private void navbarYedekleme_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {

            var yedekle = new Yedekle();
            yedekle.Show();
            Close();
        }

        private void navbarGeriYukleme_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            var geriyukle = new GeriYukle();
            geriyukle.Show();
            Close();
        }

        private void navbarToner(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(WaitForm1));
            var Toner = new Toner();
            Toner.Show();
            Close();
            SplashScreenManager.CloseForm();

        }

        private void navbarBirimEkle_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            var Birimler = new Birimler();
            Birimler.Show();
            Close();
        }

        private void navbarMarkaEkle_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            var Markalar = new Markalar();
            Markalar.Show();
            Close();

        }

        private void navbarZimmetEkle_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            var TesellumEkle = new TesellumEkle();
            TesellumEkle.Show();
            Close();
        }

        private void navbarZimmetGörüntüle_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(WaitForm1));
            var TesellumGoruntule = new TesellumGoruntule();
            TesellumGoruntule.Show();
            Close();
            SplashScreenManager.CloseForm();
        }

        private void navbarTelsiz_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            var Telsiz = new Telsiz();
            Telsiz.Show();
            Close();
        }

        private void MarkaGoruntule_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            var MarkaGoruntule = new MarkaGoruntule();
            MarkaGoruntule.Show();
            Close();
        }

        private void BirimGoruntule_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            var BirimGoruntule = new BirimGoruntule();
            BirimGoruntule.Show();
            Close();
        }
        private void navbarProjeksiyon_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            var Projeksiyon = new CihazEkleProjeksiyon();
            Projeksiyon.Show();
            Close();
        }
        private void navKamera_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            var Kamera = new Kamera();
            Kamera.Show();
            Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblSaat.Text = DateTime.Now.ToLongTimeString();
            lblTarih.Text = DateTime.Now.ToShortDateString();
        }

        bool Mov;

        int MovX, MovY;

        private void AnaMenu_MouseDown(object sender, MouseEventArgs e)
        {
            Mov = true;
            MovX = e.X;
            MovY = e.Y;
        }

        private void AnaMenu_MouseUp(object sender, MouseEventArgs e)
        {
            Mov = false;
        }

        private void panelControl1_MouseDown(object sender, MouseEventArgs e)
        {
            Mov = true;
            MovX = e.X;
            MovY = e.Y;
        }

        private void panelControl1_MouseUp(object sender, MouseEventArgs e)
        {
            Mov = false;
        }

        private void panelControl1_MouseMove(object sender, MouseEventArgs e)
        {
            if (Mov)
            {
                this.SetDesktopLocation(MousePosition.X - MovX, MousePosition.Y - MovY);
            }
        }

       

        private void AnaMenu_MouseMove(object sender, MouseEventArgs e)
        {
            if (Mov)
            {
                this.SetDesktopLocation(MousePosition.X - MovX, MousePosition.Y - MovY);
            }



        }

        
    }
    }
    
    
    

