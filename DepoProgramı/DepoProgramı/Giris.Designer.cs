namespace DepoProgramı
{
    partial class Giris
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
            DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::DepoProgramı.SplashScreen1), true, true);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Giris));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnExit = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.txtKulAdi = new DevExpress.XtraEditors.TextEdit();
            this.txtSifre = new DevExpress.XtraEditors.TextEdit();
            this.btnGiris = new DevExpress.XtraEditors.SimpleButton();
            this.lblYeniKullanici = new DevExpress.XtraEditors.LabelControl();
            this.lblSifreDegistir = new DevExpress.XtraEditors.LabelControl();
            this.lblHata = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKulAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSifre.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // splashScreenManager1
            // 
            splashScreenManager1.ClosingDelay = 500;
            // 
            // panelControl1
            // 
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.btnExit);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(348, 31);
            this.panelControl1.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.Appearance.Options.UseBackColor = true;
            this.btnExit.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.btnExit.AppearanceHovered.Options.UseBackColor = true;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.ImageOptions.Image")));
            this.btnExit.Location = new System.Drawing.Point(321, 5);
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
            this.labelControl1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Azure;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(165, 8);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(35, 16);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Depo";
            this.labelControl1.Click += new System.EventHandler(this.labelControl1_Click);
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
            this.pictureEdit1.Location = new System.Drawing.Point(112, 53);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit1.Properties.ErrorImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("pictureEdit1.Properties.ErrorImageOptions.Image")));
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.pictureEdit1.Size = new System.Drawing.Size(130, 131);
            this.pictureEdit1.TabIndex = 1;
            // 
            // txtKulAdi
            // 
            this.txtKulAdi.Location = new System.Drawing.Point(69, 208);
            this.txtKulAdi.Name = "txtKulAdi";
            this.txtKulAdi.Properties.Appearance.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKulAdi.Properties.Appearance.Options.UseFont = true;
            this.txtKulAdi.Properties.ContextImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("txtKulAdi.Properties.ContextImageOptions.Image")));
            this.txtKulAdi.Size = new System.Drawing.Size(210, 28);
            this.txtKulAdi.TabIndex = 2;
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(69, 254);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Properties.Appearance.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSifre.Properties.Appearance.Options.UseFont = true;
            this.txtSifre.Properties.ContextImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("txtSifre.Properties.ContextImageOptions.Image")));
            this.txtSifre.Properties.PasswordChar = '*';
            this.txtSifre.Size = new System.Drawing.Size(210, 28);
            this.txtSifre.TabIndex = 3;
            // 
            // btnGiris
            // 
            this.btnGiris.Appearance.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGiris.Appearance.Options.UseFont = true;
            this.btnGiris.Location = new System.Drawing.Point(139, 321);
            this.btnGiris.LookAndFeel.SkinName = "Office 2010 Black";
            this.btnGiris.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(75, 23);
            this.btnGiris.TabIndex = 4;
            this.btnGiris.Text = "Giriş";
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // lblYeniKullanici
            // 
            this.lblYeniKullanici.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYeniKullanici.Appearance.Options.UseFont = true;
            this.lblYeniKullanici.AppearancePressed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.lblYeniKullanici.AppearancePressed.Options.UseForeColor = true;
            this.lblYeniKullanici.Location = new System.Drawing.Point(69, 288);
            this.lblYeniKullanici.Name = "lblYeniKullanici";
            this.lblYeniKullanici.Size = new System.Drawing.Size(60, 13);
            this.lblYeniKullanici.TabIndex = 2;
            this.lblYeniKullanici.Text = "Yeni Kullanıcı";
            this.lblYeniKullanici.Click += new System.EventHandler(this.labelControl2_Click);
            // 
            // lblSifreDegistir
            // 
            this.lblSifreDegistir.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSifreDegistir.Appearance.Options.UseFont = true;
            this.lblSifreDegistir.AppearancePressed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.lblSifreDegistir.AppearancePressed.Options.UseForeColor = true;
            this.lblSifreDegistir.Location = new System.Drawing.Point(219, 288);
            this.lblSifreDegistir.Name = "lblSifreDegistir";
            this.lblSifreDegistir.Size = new System.Drawing.Size(61, 13);
            this.lblSifreDegistir.TabIndex = 5;
            this.lblSifreDegistir.Text = "Şifre Değiştir";
            this.lblSifreDegistir.Click += new System.EventHandler(this.lblSifreDegistir_Click);
            // 
            // lblHata
            // 
            this.lblHata.Appearance.BackColor = System.Drawing.Color.Red;
            this.lblHata.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHata.Appearance.ForeColor = System.Drawing.Color.White;
            this.lblHata.Appearance.Options.UseBackColor = true;
            this.lblHata.Appearance.Options.UseFont = true;
            this.lblHata.Appearance.Options.UseForeColor = true;
            this.lblHata.Appearance.Options.UseTextOptions = true;
            this.lblHata.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblHata.AppearancePressed.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHata.AppearancePressed.ForeColor = System.Drawing.Color.White;
            this.lblHata.AppearancePressed.Options.UseFont = true;
            this.lblHata.AppearancePressed.Options.UseForeColor = true;
            this.lblHata.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblHata.Location = new System.Drawing.Point(39, 366);
            this.lblHata.Name = "lblHata";
            this.lblHata.Size = new System.Drawing.Size(277, 22);
            this.lblHata.TabIndex = 6;
            this.lblHata.Text = "Kullanıcı Adı ve Şifrenizi Kontrol Ediniz";
            this.lblHata.Visible = false;
            // 
            // Giris
            // 
            this.AcceptButton = this.btnGiris;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(348, 400);
            this.Controls.Add(this.lblHata);
            this.Controls.Add(this.lblSifreDegistir);
            this.Controls.Add(this.lblYeniKullanici);
            this.Controls.Add(this.btnGiris);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.txtKulAdi);
            this.Controls.Add(this.pictureEdit1);
            this.Controls.Add(this.panelControl1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.LookAndFeel.SkinName = "Metropolis Dark";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Giris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Depo Programı";
            this.Load += new System.EventHandler(this.Giris_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Giris_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Giris_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Giris_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKulAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSifre.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnExit;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.TextEdit txtKulAdi;
        private DevExpress.XtraEditors.TextEdit txtSifre;
        private DevExpress.XtraEditors.SimpleButton btnGiris;
        private DevExpress.XtraEditors.LabelControl lblYeniKullanici;
        private DevExpress.XtraEditors.LabelControl lblSifreDegistir;
        private DevExpress.XtraEditors.LabelControl lblHata;
    }
}

