
namespace BeeOne
{
    partial class frmKayit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKayit));
            this.pnlTop = new System.Windows.Forms.Panel();
            this.btnCikis = new Bunifu.Framework.UI.BunifuImageButton();
            this.picBeeOne = new System.Windows.Forms.PictureBox();
            this.pnlKayit = new System.Windows.Forms.Panel();
            this.dropdownYetki = new Bunifu.Framework.UI.BunifuDropdown();
            this.lblYetki = new System.Windows.Forms.Label();
            this.lblFirma = new System.Windows.Forms.Label();
            this.linklblfrmGiris = new System.Windows.Forms.LinkLabel();
            this.dropdownFirma = new Bunifu.Framework.UI.BunifuDropdown();
            this.btnHesapOlustur = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txtSifre = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtMailAdresi = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtKullaniciAdi = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.lblKayitOlCizgi = new System.Windows.Forms.Label();
            this.lblKayitOl = new System.Windows.Forms.Label();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCikis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBeeOne)).BeginInit();
            this.pnlKayit.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.pnlTop.Controls.Add(this.btnCikis);
            this.pnlTop.Controls.Add(this.picBeeOne);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(728, 65);
            this.pnlTop.TabIndex = 0;
            this.pnlTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTop_MouseDown);
            this.pnlTop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlTop_MouseMove);
            this.pnlTop.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlTop_MouseUp);
            // 
            // btnCikis
            // 
            this.btnCikis.BackColor = System.Drawing.Color.Transparent;
            this.btnCikis.Image = ((System.Drawing.Image)(resources.GetObject("btnCikis.Image")));
            this.btnCikis.ImageActive = null;
            this.btnCikis.Location = new System.Drawing.Point(688, 16);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(30, 30);
            this.btnCikis.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCikis.TabIndex = 1;
            this.btnCikis.TabStop = false;
            this.btnCikis.Zoom = 10;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // picBeeOne
            // 
            this.picBeeOne.BackColor = System.Drawing.Color.Transparent;
            this.picBeeOne.Dock = System.Windows.Forms.DockStyle.Left;
            this.picBeeOne.Image = ((System.Drawing.Image)(resources.GetObject("picBeeOne.Image")));
            this.picBeeOne.Location = new System.Drawing.Point(0, 0);
            this.picBeeOne.Name = "picBeeOne";
            this.picBeeOne.Size = new System.Drawing.Size(82, 65);
            this.picBeeOne.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBeeOne.TabIndex = 0;
            this.picBeeOne.TabStop = false;
            // 
            // pnlKayit
            // 
            this.pnlKayit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.pnlKayit.Controls.Add(this.dropdownYetki);
            this.pnlKayit.Controls.Add(this.lblYetki);
            this.pnlKayit.Controls.Add(this.lblFirma);
            this.pnlKayit.Controls.Add(this.linklblfrmGiris);
            this.pnlKayit.Controls.Add(this.dropdownFirma);
            this.pnlKayit.Controls.Add(this.btnHesapOlustur);
            this.pnlKayit.Controls.Add(this.txtSifre);
            this.pnlKayit.Controls.Add(this.txtMailAdresi);
            this.pnlKayit.Controls.Add(this.txtKullaniciAdi);
            this.pnlKayit.Controls.Add(this.lblKayitOlCizgi);
            this.pnlKayit.Controls.Add(this.lblKayitOl);
            this.pnlKayit.Location = new System.Drawing.Point(128, 111);
            this.pnlKayit.Name = "pnlKayit";
            this.pnlKayit.Size = new System.Drawing.Size(471, 489);
            this.pnlKayit.TabIndex = 1;
            // 
            // dropdownYetki
            // 
            this.dropdownYetki.BackColor = System.Drawing.Color.Transparent;
            this.dropdownYetki.BorderRadius = 3;
            this.dropdownYetki.DisabledColor = System.Drawing.Color.Gray;
            this.dropdownYetki.ForeColor = System.Drawing.Color.White;
            this.dropdownYetki.Items = new string[] {
        "Tam Yetkili",
        "Satış",
        "Satınalma",
        "Finans",
        "Lojistik",
        "Muhasebe"};
            this.dropdownYetki.Location = new System.Drawing.Point(85, 296);
            this.dropdownYetki.Name = "dropdownYetki";
            this.dropdownYetki.NomalColor = System.Drawing.Color.Gray;
            this.dropdownYetki.onHoverColor = System.Drawing.Color.Khaki;
            this.dropdownYetki.selectedIndex = -1;
            this.dropdownYetki.Size = new System.Drawing.Size(344, 25);
            this.dropdownYetki.TabIndex = 12;
            // 
            // lblYetki
            // 
            this.lblYetki.AutoSize = true;
            this.lblYetki.BackColor = System.Drawing.Color.Transparent;
            this.lblYetki.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYetki.ForeColor = System.Drawing.Color.Gray;
            this.lblYetki.Location = new System.Drawing.Point(32, 297);
            this.lblYetki.Name = "lblYetki";
            this.lblYetki.Size = new System.Drawing.Size(40, 18);
            this.lblYetki.TabIndex = 11;
            this.lblYetki.Text = "Yetki";
            // 
            // lblFirma
            // 
            this.lblFirma.AutoSize = true;
            this.lblFirma.BackColor = System.Drawing.Color.Transparent;
            this.lblFirma.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFirma.ForeColor = System.Drawing.Color.Gray;
            this.lblFirma.Location = new System.Drawing.Point(28, 255);
            this.lblFirma.Name = "lblFirma";
            this.lblFirma.Size = new System.Drawing.Size(46, 18);
            this.lblFirma.TabIndex = 9;
            this.lblFirma.Text = "Firma";
            // 
            // linklblfrmGiris
            // 
            this.linklblfrmGiris.ActiveLinkColor = System.Drawing.Color.Khaki;
            this.linklblfrmGiris.AutoSize = true;
            this.linklblfrmGiris.DisabledLinkColor = System.Drawing.Color.Gray;
            this.linklblfrmGiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.linklblfrmGiris.ForeColor = System.Drawing.Color.Gray;
            this.linklblfrmGiris.LinkColor = System.Drawing.Color.Gray;
            this.linklblfrmGiris.Location = new System.Drawing.Point(309, 441);
            this.linklblfrmGiris.Name = "linklblfrmGiris";
            this.linklblfrmGiris.Size = new System.Drawing.Size(120, 16);
            this.linklblfrmGiris.TabIndex = 6;
            this.linklblfrmGiris.TabStop = true;
            this.linklblfrmGiris.Text = "Buradan oturum aç";
            this.linklblfrmGiris.VisitedLinkColor = System.Drawing.Color.Khaki;
            this.linklblfrmGiris.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklblfrmGiris_LinkClicked);
            // 
            // dropdownFirma
            // 
            this.dropdownFirma.BackColor = System.Drawing.Color.Transparent;
            this.dropdownFirma.BorderRadius = 3;
            this.dropdownFirma.DisabledColor = System.Drawing.Color.Gray;
            this.dropdownFirma.ForeColor = System.Drawing.Color.White;
            this.dropdownFirma.Items = new string[0];
            this.dropdownFirma.Location = new System.Drawing.Point(85, 255);
            this.dropdownFirma.Name = "dropdownFirma";
            this.dropdownFirma.NomalColor = System.Drawing.Color.Gray;
            this.dropdownFirma.onHoverColor = System.Drawing.Color.Khaki;
            this.dropdownFirma.selectedIndex = -1;
            this.dropdownFirma.Size = new System.Drawing.Size(344, 25);
            this.dropdownFirma.TabIndex = 8;
            // 
            // btnHesapOlustur
            // 
            this.btnHesapOlustur.ActiveBorderThickness = 1;
            this.btnHesapOlustur.ActiveCornerRadius = 20;
            this.btnHesapOlustur.ActiveFillColor = System.Drawing.Color.Khaki;
            this.btnHesapOlustur.ActiveForecolor = System.Drawing.Color.Black;
            this.btnHesapOlustur.ActiveLineColor = System.Drawing.Color.Gray;
            this.btnHesapOlustur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnHesapOlustur.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHesapOlustur.BackgroundImage")));
            this.btnHesapOlustur.ButtonText = "Hesap Oluştur";
            this.btnHesapOlustur.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHesapOlustur.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHesapOlustur.ForeColor = System.Drawing.Color.White;
            this.btnHesapOlustur.IdleBorderThickness = 1;
            this.btnHesapOlustur.IdleCornerRadius = 20;
            this.btnHesapOlustur.IdleFillColor = System.Drawing.Color.Gray;
            this.btnHesapOlustur.IdleForecolor = System.Drawing.Color.White;
            this.btnHesapOlustur.IdleLineColor = System.Drawing.Color.Khaki;
            this.btnHesapOlustur.Location = new System.Drawing.Point(135, 358);
            this.btnHesapOlustur.Margin = new System.Windows.Forms.Padding(5);
            this.btnHesapOlustur.Name = "btnHesapOlustur";
            this.btnHesapOlustur.Size = new System.Drawing.Size(181, 41);
            this.btnHesapOlustur.TabIndex = 5;
            this.btnHesapOlustur.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSifre
            // 
            this.txtSifre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtSifre.ForeColor = System.Drawing.Color.Gray;
            this.txtSifre.HintForeColor = System.Drawing.Color.Gray;
            this.txtSifre.HintText = "";
            this.txtSifre.isPassword = false;
            this.txtSifre.LineFocusedColor = System.Drawing.Color.Khaki;
            this.txtSifre.LineIdleColor = System.Drawing.Color.Gray;
            this.txtSifre.LineMouseHoverColor = System.Drawing.Color.Khaki;
            this.txtSifre.LineThickness = 3;
            this.txtSifre.Location = new System.Drawing.Point(37, 195);
            this.txtSifre.Margin = new System.Windows.Forms.Padding(4);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(379, 33);
            this.txtSifre.TabIndex = 4;
            this.txtSifre.Text = "Şifre";
            this.txtSifre.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSifre.Enter += new System.EventHandler(this.txtSifre_Enter);
            this.txtSifre.Leave += new System.EventHandler(this.txtSifre_Leave);
            // 
            // txtMailAdresi
            // 
            this.txtMailAdresi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMailAdresi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtMailAdresi.ForeColor = System.Drawing.Color.Gray;
            this.txtMailAdresi.HintForeColor = System.Drawing.Color.Gray;
            this.txtMailAdresi.HintText = "";
            this.txtMailAdresi.isPassword = false;
            this.txtMailAdresi.LineFocusedColor = System.Drawing.Color.Khaki;
            this.txtMailAdresi.LineIdleColor = System.Drawing.Color.Gray;
            this.txtMailAdresi.LineMouseHoverColor = System.Drawing.Color.Khaki;
            this.txtMailAdresi.LineThickness = 3;
            this.txtMailAdresi.Location = new System.Drawing.Point(37, 92);
            this.txtMailAdresi.Margin = new System.Windows.Forms.Padding(4);
            this.txtMailAdresi.Name = "txtMailAdresi";
            this.txtMailAdresi.Size = new System.Drawing.Size(379, 33);
            this.txtMailAdresi.TabIndex = 3;
            this.txtMailAdresi.Text = "E-Posta";
            this.txtMailAdresi.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtMailAdresi.Enter += new System.EventHandler(this.txtMailAdresi_Enter);
            this.txtMailAdresi.Leave += new System.EventHandler(this.txtMailAdresi_Leave);
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtKullaniciAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtKullaniciAdi.ForeColor = System.Drawing.Color.Gray;
            this.txtKullaniciAdi.HintForeColor = System.Drawing.Color.Gray;
            this.txtKullaniciAdi.HintText = "";
            this.txtKullaniciAdi.isPassword = false;
            this.txtKullaniciAdi.LineFocusedColor = System.Drawing.Color.Khaki;
            this.txtKullaniciAdi.LineIdleColor = System.Drawing.Color.Gray;
            this.txtKullaniciAdi.LineMouseHoverColor = System.Drawing.Color.Khaki;
            this.txtKullaniciAdi.LineThickness = 3;
            this.txtKullaniciAdi.Location = new System.Drawing.Point(37, 144);
            this.txtKullaniciAdi.Margin = new System.Windows.Forms.Padding(4);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(379, 33);
            this.txtKullaniciAdi.TabIndex = 2;
            this.txtKullaniciAdi.Text = "Kullanıcı adı";
            this.txtKullaniciAdi.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtKullaniciAdi.Enter += new System.EventHandler(this.txtKullaniciAdi_Enter);
            this.txtKullaniciAdi.Leave += new System.EventHandler(this.txtKullaniciAdi_Leave);
            // 
            // lblKayitOlCizgi
            // 
            this.lblKayitOlCizgi.BackColor = System.Drawing.Color.Gray;
            this.lblKayitOlCizgi.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKayitOlCizgi.ForeColor = System.Drawing.Color.White;
            this.lblKayitOlCizgi.Location = new System.Drawing.Point(29, 61);
            this.lblKayitOlCizgi.Name = "lblKayitOlCizgi";
            this.lblKayitOlCizgi.Size = new System.Drawing.Size(400, 1);
            this.lblKayitOlCizgi.TabIndex = 1;
            // 
            // lblKayitOl
            // 
            this.lblKayitOl.AutoSize = true;
            this.lblKayitOl.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKayitOl.ForeColor = System.Drawing.Color.White;
            this.lblKayitOl.Location = new System.Drawing.Point(29, 21);
            this.lblKayitOl.Name = "lblKayitOl";
            this.lblKayitOl.Size = new System.Drawing.Size(103, 25);
            this.lblKayitOl.TabIndex = 0;
            this.lblKayitOl.Text = "KAYIT OL";
            // 
            // frmKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(728, 694);
            this.Controls.Add(this.pnlKayit);
            this.Controls.Add(this.pnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmKayit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BeeOne";
            this.pnlTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnCikis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBeeOne)).EndInit();
            this.pnlKayit.ResumeLayout(false);
            this.pnlKayit.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Panel pnlKayit;
        private System.Windows.Forms.PictureBox picBeeOne;
        private System.Windows.Forms.Label lblKayitOl;
        private System.Windows.Forms.Label lblKayitOlCizgi;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtKullaniciAdi;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtMailAdresi;
        private Bunifu.Framework.UI.BunifuThinButton2 btnHesapOlustur;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtSifre;
        private System.Windows.Forms.LinkLabel linklblfrmGiris;
        private Bunifu.Framework.UI.BunifuImageButton btnCikis;
        private System.Windows.Forms.Label lblFirma;
        private Bunifu.Framework.UI.BunifuDropdown dropdownFirma;
        private Bunifu.Framework.UI.BunifuDropdown dropdownYetki;
        private System.Windows.Forms.Label lblYetki;
    }
}