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
using DevExpress.XtraSplashScreen;
using DevExpress.XtraWaitForm;
using DevExpress.XtraBars.Navigation;
using DevExpress.XtraPrinting;
using System.Drawing.Printing;
using DevExpress.LookAndFeel;

namespace DepoProgramı
{
    public partial class Laptop : DevExpress.XtraEditors.XtraForm
    {

#pragma warning disable CS0169 // The field 'Laptop.command' is never used
        SQLiteCommand command;
#pragma warning restore CS0169 // The field 'Laptop.command' is never used
        SQLiteDataAdapter da;
        private BindingSource bindingSource = null;
        private SQLiteCommandBuilder oleCommandBuilder = null;
        DataTable dataTable = new DataTable();
        DataTable tablo = new DataTable();





        public Laptop()
        {
            InitializeComponent();
        }

        SQLiteConnection baglan = new SQLiteConnection("Data Source=Data.db;Version=3");

        public void DataBind()//data grid için listele metodu
        {
            gridControl1.DataSource = null;
            dataTable.Clear();

            String queryString1 = "SELECT * FROM CihazEkleLaptop"; // Kendi tablo isminizi yazın.

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

        private void gridControl1_Load(object sender, EventArgs e)
        {
            DataBind();
        }

        private void navButton2_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(WaitForm));
            var cihazekle = new YeniCihazEkle();
            cihazekle.Show();
            Hide();
            SplashScreenManager.CloseForm();
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

        private void btnMin_Click_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void navBarAnaMenu_ElementClick(object sender, NavElementEventArgs e)
        {
            var ana = new AnaMenu();
            ana.Show();
            Close();
        }

        private void navBarSil_ElementClick(object sender, NavElementEventArgs e)
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

        private void navBarKaydet_ElementClick(object sender, NavElementEventArgs e)
        {
            var u = new UserLookAndFeel(this);
            u.UseDefaultLookAndFeel = false;
            u.UseWindowsXPTheme = false;
            u.Style = LookAndFeelStyle.Skin;
            u.SkinName = "Office 2016 Colorful";
            if (navBarKaydet.Caption == "Düzenlemeyi Kapat")
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
                    navBarKaydet.Enabled = false;
                }
                catch (Exception)
                {
                    XtraMessageBox.Show("Güncelleme Başarısız !", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void navBarExcel_ElementClick(object sender, NavElementEventArgs e)
        {
            var save = new SaveFileDialog();
            if (save.ShowDialog() == DialogResult.OK)
            {
                gridView1.ExportToXlsx(save.FileName + ".xlsx");
            }
        }

        private void navBarYazdir_ElementClick(object sender, NavElementEventArgs e)
        {
            var link = new PrintableComponentLink(new PrintingSystem());

            link.Component = gridControl1;
            link.PrintingSystem.Document.AutoFitToPagesWidth = 1;
            link.PaperKind = PaperKind.A4;
            link.Landscape = true;
            link.ShowPreview();
        }
    }
}