namespace DepoProgramı
{
    partial class SifreDegistir
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SifreDegistir));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnExit = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lblGiris = new DevExpress.XtraEditors.LabelControl();
            this.btnDegistir = new DevExpress.XtraEditors.SimpleButton();
            this.txtYeniSifre = new DevExpress.XtraEditors.TextEdit();
            this.txtSifre = new DevExpress.XtraEditors.TextEdit();
            this.txtKulAdi = new DevExpress.XtraEditors.TextEdit();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.txtYenisifreTekrar = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtYeniSifre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSifre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKulAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYenisifreTekrar.Properties)).BeginInit();
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
            this.panelControl1.TabIndex = 9;
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
            this.labelControl1.Size = new System.Drawing.Size(77, 17);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Şifre Değiştir";
            // 
            // lblGiris
            // 
            this.lblGiris.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGiris.Appearance.Options.UseFont = true;
            this.lblGiris.AppearancePressed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.lblGiris.AppearancePressed.Options.UseForeColor = true;
            this.lblGiris.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblGiris.Location = new System.Drawing.Point(140, 401);
            this.lblGiris.Name = "lblGiris";
            this.lblGiris.Size = new System.Drawing.Size(67, 13);
            this.lblGiris.TabIndex = 15;
            this.lblGiris.Text = "<< Girişe Dön";
            this.lblGiris.Click += new System.EventHandler(this.lblGiris_Click);
            // 
            // btnDegistir
            // 
            this.btnDegistir.Appearance.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDegistir.Appearance.Options.UseFont = true;
            this.btnDegistir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDegistir.Location = new System.Drawing.Point(135, 359);
            this.btnDegistir.LookAndFeel.SkinName = "Office 2010 Black";
            this.btnDegistir.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnDegistir.Name = "btnDegistir";
            this.btnDegistir.Size = new System.Drawing.Size(75, 23);
            this.btnDegistir.TabIndex = 14;
            this.btnDegistir.Text = "Değiştir";
            this.btnDegistir.Click += new System.EventHandler(this.btnDegistir_Click);
            // 
            // txtYeniSifre
            // 
            this.txtYeniSifre.Location = new System.Drawing.Point(76, 264);
            this.txtYeniSifre.Name = "txtYeniSifre";
            this.txtYeniSifre.Properties.Appearance.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtYeniSifre.Properties.Appearance.Options.UseFont = true;
            this.txtYeniSifre.Properties.ContextImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("txtYeniSifre.Properties.ContextImageOptions.Image")));
            this.txtYeniSifre.Properties.NullText = "Yeni Şifreniz";
            this.txtYeniSifre.Properties.NullValuePrompt = "Yeni Şifreniz";
            this.txtYeniSifre.Properties.PasswordChar = '*';
            this.txtYeniSifre.Size = new System.Drawing.Size(210, 28);
            this.txtYeniSifre.TabIndex = 13;
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(76, 219);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Properties.Appearance.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSifre.Properties.Appearance.Options.UseFont = true;
            this.txtSifre.Properties.ContextImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("txtSifre.Properties.ContextImageOptions.Image")));
            this.txtSifre.Properties.NullText = "Şifreniz";
            this.txtSifre.Properties.NullValuePrompt = "Şifreniz";
            this.txtSifre.Properties.PasswordChar = '*';
            this.txtSifre.Size = new System.Drawing.Size(210, 28);
            this.txtSifre.TabIndex = 12;
            // 
            // txtKulAdi
            // 
            this.txtKulAdi.Location = new System.Drawing.Point(76, 174);
            this.txtKulAdi.Name = "txtKulAdi";
            this.txtKulAdi.Properties.Appearance.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKulAdi.Properties.Appearance.Options.UseFont = true;
            this.txtKulAdi.Properties.ContextImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("txtKulAdi.Properties.ContextImageOptions.Image")));
            this.txtKulAdi.Properties.NullText = "Kullanıcı Adınız";
            this.txtKulAdi.Properties.NullValuePrompt = "Kullanıcı Adınız";
            this.txtKulAdi.Size = new System.Drawing.Size(210, 28);
            this.txtKulAdi.TabIndex = 11;
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
            this.pictureEdit1.TabIndex = 10;
            // 
            // txtYenisifreTekrar
            // 
            this.txtYenisifreTekrar.Location = new System.Drawing.Point(76, 309);
            this.txtYenisifreTekrar.Name = "txtYenisifreTekrar";
            this.txtYenisifreTekrar.Properties.Appearance.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtYenisifreTekrar.Properties.Appearance.Options.UseFont = true;
            this.txtYenisifreTekrar.Properties.ContextImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("txtYenisifreTekrar.Properties.ContextImageOptions.Image")));
            this.txtYenisifreTekrar.Properties.NullText = "Yeni Şifreniz Tekrar";
            this.txtYenisifreTekrar.Properties.NullValuePrompt = "Yeni Şifreniz Tekrar";
            this.txtYenisifreTekrar.Properties.PasswordChar = '*';
            this.txtYenisifreTekrar.Size = new System.Drawing.Size(210, 28);
            this.txtYenisifreTekrar.TabIndex = 16;
            // 
            // SifreDegistir
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 426);
            this.Controls.Add(this.txtYenisifreTekrar);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.lblGiris);
            this.Controls.Add(this.btnDegistir);
            this.Controls.Add(this.txtYeniSifre);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.txtKulAdi);
            this.Controls.Add(this.pictureEdit1);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.LookAndFeel.SkinName = "Metropolis Dark";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SifreDegistir";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Şifre Değiştir";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtYeniSifre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSifre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKulAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYenisifreTekrar.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnExit;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl lblGiris;
        private DevExpress.XtraEditors.SimpleButton btnDegistir;
        private DevExpress.XtraEditors.TextEdit txtYeniSifre;
        private DevExpress.XtraEditors.TextEdit txtSifre;
        private DevExpress.XtraEditors.TextEdit txtKulAdi;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.TextEdit txtYenisifreTekrar;
    }
}