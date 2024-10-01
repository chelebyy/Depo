namespace DepoProgramı
{
    partial class YeniKullanici
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YeniKullanici));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnExit = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.txtSifre = new DevExpress.XtraEditors.TextEdit();
            this.txtKulAdi = new DevExpress.XtraEditors.TextEdit();
            this.txtSifreTekrar = new DevExpress.XtraEditors.TextEdit();
            this.btnOlustur = new DevExpress.XtraEditors.SimpleButton();
            this.lblGiris = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSifre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKulAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSifreTekrar.Properties)).BeginInit();
            this.SuspendLayout();
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
            this.panelControl1.TabIndex = 1;
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
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(21, 8);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(83, 17);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Yeni Kullanıcı";
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
            this.pictureEdit1.Location = new System.Drawing.Point(111, 37);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.pictureEdit1.Size = new System.Drawing.Size(130, 131);
            this.pictureEdit1.TabIndex = 2;
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(76, 229);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Properties.Appearance.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSifre.Properties.Appearance.Options.UseFont = true;
            this.txtSifre.Properties.ContextImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("txtSifre.Properties.ContextImageOptions.Image")));
            this.txtSifre.Properties.NullText = "Şifreniz";
            this.txtSifre.Properties.NullValuePrompt = "Şifreniz";
            this.txtSifre.Properties.PasswordChar = '*';
            this.txtSifre.Size = new System.Drawing.Size(210, 28);
            this.txtSifre.TabIndex = 5;
            // 
            // txtKulAdi
            // 
            this.txtKulAdi.Location = new System.Drawing.Point(76, 185);
            this.txtKulAdi.Name = "txtKulAdi";
            this.txtKulAdi.Properties.Appearance.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKulAdi.Properties.Appearance.Options.UseFont = true;
            this.txtKulAdi.Properties.ContextImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("txtKulAdi.Properties.ContextImageOptions.Image")));
            this.txtKulAdi.Properties.NullText = "Kullanıcı Adınız";
            this.txtKulAdi.Properties.NullValuePrompt = "Kullanıcı Adınız";
            this.txtKulAdi.Size = new System.Drawing.Size(210, 28);
            this.txtKulAdi.TabIndex = 4;
            // 
            // txtSifreTekrar
            // 
            this.txtSifreTekrar.Location = new System.Drawing.Point(76, 273);
            this.txtSifreTekrar.Name = "txtSifreTekrar";
            this.txtSifreTekrar.Properties.Appearance.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSifreTekrar.Properties.Appearance.Options.UseFont = true;
            this.txtSifreTekrar.Properties.ContextImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("txtSifreTekrar.Properties.ContextImageOptions.Image")));
            this.txtSifreTekrar.Properties.NullText = "Şifreniz Tekrar";
            this.txtSifreTekrar.Properties.NullValuePrompt = "Şifreniz Tekrar";
            this.txtSifreTekrar.Properties.PasswordChar = '*';
            this.txtSifreTekrar.Size = new System.Drawing.Size(210, 28);
            this.txtSifreTekrar.TabIndex = 6;
            // 
            // btnOlustur
            // 
            this.btnOlustur.Appearance.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOlustur.Appearance.Options.UseFont = true;
            this.btnOlustur.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOlustur.Location = new System.Drawing.Point(135, 316);
            this.btnOlustur.LookAndFeel.SkinName = "Office 2010 Black";
            this.btnOlustur.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnOlustur.Name = "btnOlustur";
            this.btnOlustur.Size = new System.Drawing.Size(75, 23);
            this.btnOlustur.TabIndex = 7;
            this.btnOlustur.Text = "Oluştur";
            this.btnOlustur.Click += new System.EventHandler(this.btnOlustur_Click);
            // 
            // lblGiris
            // 
            this.lblGiris.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGiris.Appearance.Options.UseFont = true;
            this.lblGiris.AppearancePressed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.lblGiris.AppearancePressed.Options.UseForeColor = true;
            this.lblGiris.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblGiris.Location = new System.Drawing.Point(135, 360);
            this.lblGiris.Name = "lblGiris";
            this.lblGiris.Size = new System.Drawing.Size(67, 13);
            this.lblGiris.TabIndex = 8;
            this.lblGiris.Text = "<< Girişe Dön";
            this.lblGiris.Click += new System.EventHandler(this.lblGiris_Click);
            // 
            // YeniKullanici
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 400);
            this.Controls.Add(this.lblGiris);
            this.Controls.Add(this.btnOlustur);
            this.Controls.Add(this.txtSifreTekrar);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.txtKulAdi);
            this.Controls.Add(this.pictureEdit1);
            this.Controls.Add(this.panelControl1);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.LookAndFeel.SkinName = "Metropolis Dark";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "YeniKullanici";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yeni Kullanıcı";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSifre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKulAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSifreTekrar.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnExit;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.TextEdit txtSifre;
        private DevExpress.XtraEditors.TextEdit txtKulAdi;
        private DevExpress.XtraEditors.TextEdit txtSifreTekrar;
        private DevExpress.XtraEditors.SimpleButton btnOlustur;
        private DevExpress.XtraEditors.LabelControl lblGiris;
    }
}