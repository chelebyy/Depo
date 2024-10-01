using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraPrinting;
using System.Drawing.Printing;
using DevExpress.LookAndFeel;
using DevExpress.XtraBars.Navigation;
using DevExpress.XtraSplashScreen;
using DevExpress.XtraWaitForm;
using System.Data.SQLite;
using DevExpress.Printing.Core;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Printing;
namespace DepoProgramı
{
    public partial class BirimGoruntule : DevExpress.XtraEditors.XtraForm
    {

        //SQLiteCommand command;
        SQLiteDataAdapter da;
        private BindingSource bindingSource = null;
        private SQLiteCommandBuilder oleCommandBuilder = null;
        DataTable dataTable = new DataTable();
        DataTable tablo = new DataTable();


        private void DataBind()
        {
            gridControl1.DataSource = null;
            dataTable.Clear();

            String queryString1 = "SELECT * FROM Birimler"; // Kendi tablo isminizi yazın.

            SQLiteConnection connection = new SQLiteConnection(baglan);
            connection.Open();
            SQLiteCommand command = connection.CreateCommand();
            command.CommandText = queryString1;
            try
            {
                da = new SQLiteDataAdapter(queryString1, connection);
                oleCommandBuilder = new SQLiteCommandBuilder(da);
                da.Fill(dataTable);
                bindingSource = new BindingSource { DataSource = dataTable };
                gridControl1.DataSource = bindingSource;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        public BirimGoruntule()
        {
            InitializeComponent();
        }

        SQLiteConnection baglan = new SQLiteConnection("Data Source=Data.db;Version=3");

        private void BirimGoruntule_Load(object sender, EventArgs e)
        {
            DataBind();
        }

        private void navbarSil_ElementClick(object sender, NavElementEventArgs e)
        {
            DialogResult mesaj;
            mesaj = XtraMessageBox.Show("Seçili satırı silmek istiyor musunuz ?", "Uyarı", MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question);

            if (mesaj == DialogResult.Yes)
            {

                gridView1.DeleteRow(gridView1.FocusedRowHandle);
                bindingSource.EndEdit();
                da.Update(dataTable);
                DataBind();
                XtraMessageBox.Show("Silme İşlemi Başarılı !", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Programı Kapatmak İstiyor musunuz ? ", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                Application.Exit();

            }
        }

        private void btnMin_MouseClick(object sender, MouseEventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void navbarAnaMenu_ElementClick(object sender, NavElementEventArgs e)
        {
            var ana = new AnaMenu();
            ana.Show();
            Close();
        }

        private void navbarKaydet_ElementClick(object sender, NavElementEventArgs e)
        {
            var u = new UserLookAndFeel(this);
            u.UseDefaultLookAndFeel = false;
            u.UseWindowsXPTheme = false;
            u.Style = LookAndFeelStyle.Skin;
            u.SkinName = "Office 2016 Colorful";
            if (navbarKaydet.Caption == "Düzenlemeyi Kapat")
            {
                XtraMessageBox.Show("Lütfen önce düzenlemeyi kapatınız !", "Uyarı", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    // Validate();
                    bindingSource.EndEdit(); //very important step
                    da.Update(dataTable);
                    DataBind();
                    XtraMessageBox.Show("Güncelleme Başarılı !", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    navbarKaydet.Enabled = false;
                }
                catch (Exception)
                {
                    XtraMessageBox.Show("Güncelleme Başarısız !", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void navbarYeniEkle_ElementClick(object sender, NavElementEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(WaitForm));
            var Birimler = new Birimler();
            Birimler.Show();
            Hide();
            SplashScreenManager.CloseForm();
        }
    }
}