﻿namespace DepoProgramı
{
    partial class MarkaGoruntule
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MarkaGoruntule));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnMin = new DevExpress.XtraEditors.SimpleButton();
            this.btnExit = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.tileNavPane1 = new DevExpress.XtraBars.Navigation.TileNavPane();
            this.navbarYeniEkle = new DevExpress.XtraBars.Navigation.NavButton();
            this.navbarSil = new DevExpress.XtraBars.Navigation.NavButton();
            this.navbarKaydet = new DevExpress.XtraBars.Navigation.NavButton();
            this.navbarAnaMenu = new DevExpress.XtraBars.Navigation.NavButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tileNavPane1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.btnMin);
            this.panelControl1.Controls.Add(this.btnExit);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(400, 31);
            this.panelControl1.TabIndex = 6;
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
            this.btnMin.Location = new System.Drawing.Point(340, 5);
            this.btnMin.LookAndFeel.SkinName = "Metropolis Dark";
            this.btnMin.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat;
            this.btnMin.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(24, 23);
            this.btnMin.TabIndex = 3;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
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
            this.btnExit.Location = new System.Drawing.Point(373, 5);
            this.btnExit.LookAndFeel.SkinName = "Metropolis Dark";
            this.btnExit.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat;
            this.btnExit.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(24, 23);
            this.btnExit.TabIndex = 1;
            this.btnExit.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnExit_MouseClick);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(12, 8);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(57, 17);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Markalar";
            // 
            // tileNavPane1
            // 
            this.tileNavPane1.BackColor = System.Drawing.Color.Transparent;
            this.tileNavPane1.Buttons.Add(this.navbarYeniEkle);
            this.tileNavPane1.Buttons.Add(this.navbarSil);
            this.tileNavPane1.Buttons.Add(this.navbarKaydet);
            this.tileNavPane1.Buttons.Add(this.navbarAnaMenu);
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
            this.tileNavPane1.Location = new System.Drawing.Point(0, 462);
            this.tileNavPane1.LookAndFeel.SkinName = "Metropolis Dark";
            this.tileNavPane1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.tileNavPane1.Name = "tileNavPane1";
            this.tileNavPane1.Size = new System.Drawing.Size(400, 38);
            this.tileNavPane1.TabIndex = 7;
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
            // navbarSil
            // 
            this.navbarSil.Alignment = DevExpress.XtraBars.Navigation.NavButtonAlignment.Left;
            this.navbarSil.Caption = "Sil";
            this.navbarSil.Glyph = ((System.Drawing.Image)(resources.GetObject("navbarSil.Glyph")));
            this.navbarSil.Name = "navbarSil";
            this.navbarSil.ElementClick += new DevExpress.XtraBars.Navigation.NavElementClickEventHandler(this.navbarSil_ElementClick);
            // 
            // navbarKaydet
            // 
            this.navbarKaydet.Alignment = DevExpress.XtraBars.Navigation.NavButtonAlignment.Left;
            this.navbarKaydet.Caption = "Kaydet";
            this.navbarKaydet.Glyph = ((System.Drawing.Image)(resources.GetObject("navbarKaydet.Glyph")));
            this.navbarKaydet.Name = "navbarKaydet";
            this.navbarKaydet.ElementClick += new DevExpress.XtraBars.Navigation.NavElementClickEventHandler(this.navbarKaydet_ElementClick);
            // 
            // navbarAnaMenu
            // 
            this.navbarAnaMenu.Alignment = DevExpress.XtraBars.Navigation.NavButtonAlignment.Right;
            this.navbarAnaMenu.Caption = "Ana Menü";
            this.navbarAnaMenu.Glyph = ((System.Drawing.Image)(resources.GetObject("navbarAnaMenu.Glyph")));
            this.navbarAnaMenu.Name = "navbarAnaMenu";
            this.navbarAnaMenu.ElementClick += new DevExpress.XtraBars.Navigation.NavElementClickEventHandler(this.navbarAnaMenu_ElementClick);
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2);
            this.gridControl1.Location = new System.Drawing.Point(0, 31);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(400, 431);
            this.gridControl1.TabIndex = 8;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.Load += new System.EventHandler(this.gridControl1_Load);
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditForm;
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsFind.FindNullPrompt = "Ara...";
            // 
            // MarkaGoruntule
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 500);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.tileNavPane1);
            this.Controls.Add(this.panelControl1);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.LookAndFeel.SkinName = "DevExpress Dark Style";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MarkaGoruntule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Markalar";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tileNavPane1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnMin;
        private DevExpress.XtraEditors.SimpleButton btnExit;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraBars.Navigation.TileNavPane tileNavPane1;
        private DevExpress.XtraBars.Navigation.NavButton navbarYeniEkle;
        private DevExpress.XtraBars.Navigation.NavButton navbarSil;
        private DevExpress.XtraBars.Navigation.NavButton navbarKaydet;
        private DevExpress.XtraBars.Navigation.NavButton navbarAnaMenu;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}