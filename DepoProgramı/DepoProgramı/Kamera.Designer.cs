namespace DepoProgramı
{
    partial class Kamera
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kamera));
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.navbarAnaMenu = new DevExpress.XtraBars.Navigation.NavButton();
            this.navbarYazdir = new DevExpress.XtraBars.Navigation.NavButton();
            this.navbarExcel = new DevExpress.XtraBars.Navigation.NavButton();
            this.navbarKaydet = new DevExpress.XtraBars.Navigation.NavButton();
            this.navbarSil = new DevExpress.XtraBars.Navigation.NavButton();
            this.sqlDataSource2 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnMin = new DevExpress.XtraEditors.SimpleButton();
            this.btnMax = new DevExpress.XtraEditors.SimpleButton();
            this.btnExit = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.tileNavPane1 = new DevExpress.XtraBars.Navigation.TileNavPane();
            this.navbarYeniEkle = new DevExpress.XtraBars.Navigation.NavButton();
            this.navSil = new DevExpress.XtraBars.Navigation.NavButton();
            this.navKaydet = new DevExpress.XtraBars.Navigation.NavButton();
            this.navExcel = new DevExpress.XtraBars.Navigation.NavButton();
            this.navYazdir = new DevExpress.XtraBars.Navigation.NavButton();
            this.navAnaMenu = new DevExpress.XtraBars.Navigation.NavButton();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tileNavPane1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.Name = "sqlDataSource1";
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditForm;
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsFind.FindNullPrompt = "Ara...";
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2);
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(284, 261);
            this.gridControl1.TabIndex = 11;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // navbarAnaMenu
            // 
            this.navbarAnaMenu.Alignment = DevExpress.XtraBars.Navigation.NavButtonAlignment.Right;
            this.navbarAnaMenu.Caption = "Ana Menü";
            this.navbarAnaMenu.Glyph = ((System.Drawing.Image)(resources.GetObject("navbarAnaMenu.Glyph")));
            this.navbarAnaMenu.Name = "navbarAnaMenu";
            // 
            // navbarYazdir
            // 
            this.navbarYazdir.Alignment = DevExpress.XtraBars.Navigation.NavButtonAlignment.Right;
            this.navbarYazdir.Caption = "Yazdır";
            this.navbarYazdir.Glyph = ((System.Drawing.Image)(resources.GetObject("navbarYazdir.Glyph")));
            this.navbarYazdir.Name = "navbarYazdir";
            // 
            // navbarExcel
            // 
            this.navbarExcel.Alignment = DevExpress.XtraBars.Navigation.NavButtonAlignment.Right;
            this.navbarExcel.Caption = "Excel";
            this.navbarExcel.Glyph = ((System.Drawing.Image)(resources.GetObject("navbarExcel.Glyph")));
            this.navbarExcel.Name = "navbarExcel";
            // 
            // navbarKaydet
            // 
            this.navbarKaydet.Alignment = DevExpress.XtraBars.Navigation.NavButtonAlignment.Left;
            this.navbarKaydet.Caption = "Kaydet";
            this.navbarKaydet.Glyph = ((System.Drawing.Image)(resources.GetObject("navbarKaydet.Glyph")));
            this.navbarKaydet.Name = "navbarKaydet";
            // 
            // navbarSil
            // 
            this.navbarSil.Alignment = DevExpress.XtraBars.Navigation.NavButtonAlignment.Left;
            this.navbarSil.Caption = "Sil";
            this.navbarSil.Glyph = ((System.Drawing.Image)(resources.GetObject("navbarSil.Glyph")));
            this.navbarSil.Name = "navbarSil";
            // 
            // sqlDataSource2
            // 
            this.sqlDataSource2.Name = "sqlDataSource2";
            // 
            // panelControl1
            // 
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.btnMin);
            this.panelControl1.Controls.Add(this.btnMax);
            this.panelControl1.Controls.Add(this.btnExit);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(834, 31);
            this.panelControl1.TabIndex = 3;
            // 
            // btnMin
            // 
            this.btnMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMin.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.btnMin.Appearance.Options.UseBackColor = true;
            this.btnMin.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnMin.AppearanceHovered.Options.UseBackColor = true;
            this.btnMin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMin.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnMin.ImageOptions.Image")));
            this.btnMin.Location = new System.Drawing.Point(747, 5);
            this.btnMin.LookAndFeel.SkinName = "Metropolis Dark";
            this.btnMin.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat;
            this.btnMin.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(24, 23);
            this.btnMin.TabIndex = 3;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btnMax
            // 
            this.btnMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMax.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.btnMax.Appearance.Options.UseBackColor = true;
            this.btnMax.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnMax.AppearanceHovered.Options.UseBackColor = true;
            this.btnMax.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMax.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnMax.ImageOptions.Image")));
            this.btnMax.Location = new System.Drawing.Point(777, 5);
            this.btnMax.LookAndFeel.SkinName = "Metropolis Dark";
            this.btnMax.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat;
            this.btnMax.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(24, 23);
            this.btnMax.TabIndex = 2;
            this.btnMax.Click += new System.EventHandler(this.btnMax_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.Appearance.Options.UseBackColor = true;
            this.btnExit.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.btnExit.AppearanceHovered.Options.UseBackColor = true;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.ImageOptions.Image")));
            this.btnExit.Location = new System.Drawing.Point(807, 5);
            this.btnExit.LookAndFeel.SkinName = "Metropolis Dark";
            this.btnExit.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat;
            this.btnExit.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(24, 23);
            this.btnExit.TabIndex = 1;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(10)))));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(9, 5);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(51, 17);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Kamera";
            // 
            // tileNavPane1
            // 
            this.tileNavPane1.BackColor = System.Drawing.Color.Transparent;
            this.tileNavPane1.Buttons.Add(this.navbarYeniEkle);
            this.tileNavPane1.Buttons.Add(this.navSil);
            this.tileNavPane1.Buttons.Add(this.navKaydet);
            this.tileNavPane1.Buttons.Add(this.navExcel);
            this.tileNavPane1.Buttons.Add(this.navYazdir);
            this.tileNavPane1.Buttons.Add(this.navAnaMenu);
            this.tileNavPane1.Cursor = System.Windows.Forms.Cursors.Hand;
            // 
            // tileNavCategory1
            // 
            this.tileNavPane1.DefaultCategory.Name = "tileNavCategory1";
            this.tileNavPane1.DefaultCategory.OwnerCollection = null;
            // 
            // 
            // 
            this.tileNavPane1.DefaultCategory.Tile.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            this.tileNavPane1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tileNavPane1.Location = new System.Drawing.Point(0, 635);
            this.tileNavPane1.LookAndFeel.SkinName = "Metropolis Dark";
            this.tileNavPane1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.tileNavPane1.Name = "tileNavPane1";
            this.tileNavPane1.Size = new System.Drawing.Size(834, 38);
            this.tileNavPane1.TabIndex = 4;
            this.tileNavPane1.Text = "tileNavPane1";
            // 
            // navbarYeniEkle
            // 
            this.navbarYeniEkle.Alignment = DevExpress.XtraBars.Navigation.NavButtonAlignment.Left;
            this.navbarYeniEkle.Caption = "Yeni Ekle";
            this.navbarYeniEkle.Glyph = ((System.Drawing.Image)(resources.GetObject("navbarYeniEkle.Glyph")));
            this.navbarYeniEkle.Name = "navbarYeniEkle";
            this.navbarYeniEkle.ElementClick += new DevExpress.XtraBars.Navigation.NavElementClickEventHandler(this.navbarYeniEkle_ElementClick);
            // 
            // navSil
            // 
            this.navSil.Alignment = DevExpress.XtraBars.Navigation.NavButtonAlignment.Left;
            this.navSil.Caption = "Sil";
            this.navSil.Glyph = ((System.Drawing.Image)(resources.GetObject("navSil.Glyph")));
            this.navSil.Name = "navSil";
            this.navSil.ElementClick += new DevExpress.XtraBars.Navigation.NavElementClickEventHandler(this.navSil_ElementClick);
            // 
            // navKaydet
            // 
            this.navKaydet.Alignment = DevExpress.XtraBars.Navigation.NavButtonAlignment.Left;
            this.navKaydet.Caption = "Kaydet";
            this.navKaydet.Glyph = ((System.Drawing.Image)(resources.GetObject("navKaydet.Glyph")));
            this.navKaydet.Name = "navKaydet";
            this.navKaydet.ElementClick += new DevExpress.XtraBars.Navigation.NavElementClickEventHandler(this.navKaydet_ElementClick);
            // 
            // navExcel
            // 
            this.navExcel.Alignment = DevExpress.XtraBars.Navigation.NavButtonAlignment.Right;
            this.navExcel.Caption = "Excel";
            this.navExcel.Glyph = ((System.Drawing.Image)(resources.GetObject("navExcel.Glyph")));
            this.navExcel.Name = "navExcel";
            this.navExcel.ElementClick += new DevExpress.XtraBars.Navigation.NavElementClickEventHandler(this.navExcel_ElementClick);
            // 
            // navYazdir
            // 
            this.navYazdir.Alignment = DevExpress.XtraBars.Navigation.NavButtonAlignment.Right;
            this.navYazdir.Caption = "Yazdır";
            this.navYazdir.Glyph = ((System.Drawing.Image)(resources.GetObject("navYazdir.Glyph")));
            this.navYazdir.Name = "navYazdir";
            this.navYazdir.ElementClick += new DevExpress.XtraBars.Navigation.NavElementClickEventHandler(this.navYazdir_ElementClick);
            // 
            // navAnaMenu
            // 
            this.navAnaMenu.Alignment = DevExpress.XtraBars.Navigation.NavButtonAlignment.Right;
            this.navAnaMenu.Caption = "Ana Menü";
            this.navAnaMenu.Glyph = ((System.Drawing.Image)(resources.GetObject("navAnaMenu.Glyph")));
            this.navAnaMenu.Name = "navAnaMenu";
            this.navAnaMenu.ElementClick += new DevExpress.XtraBars.Navigation.NavElementClickEventHandler(this.navAnaMenu_ElementClick);
            // 
            // gridControl2
            // 
            this.gridControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl2.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2);
            this.gridControl2.Location = new System.Drawing.Point(0, 31);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(834, 604);
            this.gridControl2.TabIndex = 9;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            this.gridControl2.Load += new System.EventHandler(this.gridControl2_Load);
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditForm;
            this.gridView2.OptionsFind.AlwaysVisible = true;
            this.gridView2.OptionsFind.FindNullPrompt = "Ara...";
            // 
            // Kamera
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 673);
            this.Controls.Add(this.gridControl2);
            this.Controls.Add(this.tileNavPane1);
            this.Controls.Add(this.panelControl1);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.LookAndFeel.SkinName = "Metropolis Dark";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Kamera";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kamera";
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tileNavPane1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraBars.Navigation.NavButton navbarAnaMenu;
        private DevExpress.XtraBars.Navigation.NavButton navbarYazdir;
        private DevExpress.XtraBars.Navigation.NavButton navbarExcel;
        private DevExpress.XtraBars.Navigation.NavButton navbarKaydet;
        private DevExpress.XtraBars.Navigation.NavButton navbarSil;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource2;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnMin;
        private DevExpress.XtraEditors.SimpleButton btnMax;
        private DevExpress.XtraEditors.SimpleButton btnExit;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraBars.Navigation.TileNavPane tileNavPane1;
        private DevExpress.XtraBars.Navigation.NavButton navbarYeniEkle;
        private DevExpress.XtraBars.Navigation.NavButton navSil;
        private DevExpress.XtraBars.Navigation.NavButton navKaydet;
        private DevExpress.XtraBars.Navigation.NavButton navExcel;
        private DevExpress.XtraBars.Navigation.NavButton navYazdir;
        private DevExpress.XtraBars.Navigation.NavButton navAnaMenu;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
    }
}