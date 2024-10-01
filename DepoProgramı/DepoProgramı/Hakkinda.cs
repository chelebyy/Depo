using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace DepoProgramı
{
    public partial class Hakkinda : DevExpress.XtraEditors.XtraForm
    {
        public Hakkinda()
        {
            InitializeComponent();
        }

        private void btnAnaMenu_Click(object sender, EventArgs e)
        {

        }

        private void btnAnaMenu_Click_1(object sender, EventArgs e)
        {
            var ana = new AnaMenu();
            ana.Show();
            Close();
        }
    }
}