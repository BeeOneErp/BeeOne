
namespace BeeOne
{
    partial class frmAnaKayitlar_Stok
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAnaKayitlar_Stok));
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblAnaKayitlar = new System.Windows.Forms.Label();
            this.btnClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnMinimize = new Bunifu.Framework.UI.BunifuImageButton();
            this.pnlIslem = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.pnlSekme = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.btnFiyatBilgisi = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnMuhasebeHesaplari = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnAlternatifMalzemeler = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnGenelBilgiler = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtAciklama2 = new System.Windows.Forms.TextBox();
            this.lblMalzemeKodu = new System.Windows.Forms.Label();
            this.txtMalzemeKodu = new System.Windows.Forms.TextBox();
            this.lblAciklama2 = new System.Windows.Forms.Label();
            this.lblAciklamasi = new System.Windows.Forms.Label();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.lblKullanimDurumu = new System.Windows.Forms.Label();
            this.checkBoxAktif = new System.Windows.Forms.CheckBox();
            this.lblKartTuru = new System.Windows.Forms.Label();
            this.comboBoxKartTuru = new System.Windows.Forms.ComboBox();
            this.btnVazgec = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnKaydet = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).BeginInit();
            this.pnlSekme.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.lblAnaKayitlar);
            this.pnlTop.Controls.Add(this.btnClose);
            this.pnlTop.Controls.Add(this.btnMinimize);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(977, 48);
            this.pnlTop.TabIndex = 15;
            this.pnlTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTop_MouseDown);
            this.pnlTop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlTop_MouseMove);
            this.pnlTop.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlTop_MouseUp);
            // 
            // lblAnaKayitlar
            // 
            this.lblAnaKayitlar.AutoSize = true;
            this.lblAnaKayitlar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAnaKayitlar.ForeColor = System.Drawing.Color.DarkKhaki;
            this.lblAnaKayitlar.Location = new System.Drawing.Point(12, 13);
            this.lblAnaKayitlar.Name = "lblAnaKayitlar";
            this.lblAnaKayitlar.Size = new System.Drawing.Size(180, 21);
            this.lblAnaKayitlar.TabIndex = 7;
            this.lblAnaKayitlar.Text = "ANA KAYITLAR > STOK";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageActive = null;
            this.btnClose.Location = new System.Drawing.Point(947, 10);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(20, 27);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 6;
            this.btnClose.TabStop = false;
            this.btnClose.Zoom = 10;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
            this.btnMinimize.ImageActive = null;
            this.btnMinimize.Location = new System.Drawing.Point(921, 10);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(20, 27);
            this.btnMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimize.TabIndex = 5;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.Zoom = 10;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // pnlIslem
            // 
            this.pnlIslem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlIslem.BackgroundImage")));
            this.pnlIslem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlIslem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlIslem.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.pnlIslem.GradientBottomRight = System.Drawing.Color.Khaki;
            this.pnlIslem.GradientTopLeft = System.Drawing.Color.DarkKhaki;
            this.pnlIslem.GradientTopRight = System.Drawing.Color.DarkKhaki;
            this.pnlIslem.Location = new System.Drawing.Point(16, 200);
            this.pnlIslem.Name = "pnlIslem";
            this.pnlIslem.Quality = 10;
            this.pnlIslem.Size = new System.Drawing.Size(944, 296);
            this.pnlIslem.TabIndex = 51;
            // 
            // pnlSekme
            // 
            this.pnlSekme.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlSekme.BackgroundImage")));
            this.pnlSekme.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlSekme.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSekme.Controls.Add(this.btnFiyatBilgisi);
            this.pnlSekme.Controls.Add(this.btnMuhasebeHesaplari);
            this.pnlSekme.Controls.Add(this.btnAlternatifMalzemeler);
            this.pnlSekme.Controls.Add(this.btnGenelBilgiler);
            this.pnlSekme.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.pnlSekme.GradientBottomRight = System.Drawing.Color.DarkKhaki;
            this.pnlSekme.GradientTopLeft = System.Drawing.Color.DarkKhaki;
            this.pnlSekme.GradientTopRight = System.Drawing.Color.DarkKhaki;
            this.pnlSekme.Location = new System.Drawing.Point(16, 163);
            this.pnlSekme.Name = "pnlSekme";
            this.pnlSekme.Quality = 10;
            this.pnlSekme.Size = new System.Drawing.Size(945, 31);
            this.pnlSekme.TabIndex = 50;
            // 
            // btnFiyatBilgisi
            // 
            this.btnFiyatBilgisi.Activecolor = System.Drawing.Color.Khaki;
            this.btnFiyatBilgisi.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnFiyatBilgisi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFiyatBilgisi.BorderRadius = 0;
            this.btnFiyatBilgisi.ButtonText = "Fiyat Bilgisi";
            this.btnFiyatBilgisi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFiyatBilgisi.DisabledColor = System.Drawing.Color.Gray;
            this.btnFiyatBilgisi.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnFiyatBilgisi.Iconcolor = System.Drawing.Color.Transparent;
            this.btnFiyatBilgisi.Iconimage = null;
            this.btnFiyatBilgisi.Iconimage_right = null;
            this.btnFiyatBilgisi.Iconimage_right_Selected = null;
            this.btnFiyatBilgisi.Iconimage_Selected = null;
            this.btnFiyatBilgisi.IconMarginLeft = 0;
            this.btnFiyatBilgisi.IconMarginRight = 0;
            this.btnFiyatBilgisi.IconRightVisible = true;
            this.btnFiyatBilgisi.IconRightZoom = 0D;
            this.btnFiyatBilgisi.IconVisible = true;
            this.btnFiyatBilgisi.IconZoom = 90D;
            this.btnFiyatBilgisi.IsTab = false;
            this.btnFiyatBilgisi.Location = new System.Drawing.Point(437, 0);
            this.btnFiyatBilgisi.Name = "btnFiyatBilgisi";
            this.btnFiyatBilgisi.Normalcolor = System.Drawing.Color.DarkKhaki;
            this.btnFiyatBilgisi.OnHovercolor = System.Drawing.Color.Khaki;
            this.btnFiyatBilgisi.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnFiyatBilgisi.selected = false;
            this.btnFiyatBilgisi.Size = new System.Drawing.Size(136, 29);
            this.btnFiyatBilgisi.TabIndex = 49;
            this.btnFiyatBilgisi.Text = "Fiyat Bilgisi";
            this.btnFiyatBilgisi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnFiyatBilgisi.Textcolor = System.Drawing.Color.Black;
            this.btnFiyatBilgisi.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiyatBilgisi.Click += new System.EventHandler(this.btnFiyatBilgisi_Click);
            // 
            // btnMuhasebeHesaplari
            // 
            this.btnMuhasebeHesaplari.Activecolor = System.Drawing.Color.Khaki;
            this.btnMuhasebeHesaplari.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnMuhasebeHesaplari.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMuhasebeHesaplari.BorderRadius = 0;
            this.btnMuhasebeHesaplari.ButtonText = "Muhasebe Hesapları";
            this.btnMuhasebeHesaplari.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMuhasebeHesaplari.DisabledColor = System.Drawing.Color.Gray;
            this.btnMuhasebeHesaplari.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnMuhasebeHesaplari.Iconcolor = System.Drawing.Color.Transparent;
            this.btnMuhasebeHesaplari.Iconimage = null;
            this.btnMuhasebeHesaplari.Iconimage_right = null;
            this.btnMuhasebeHesaplari.Iconimage_right_Selected = null;
            this.btnMuhasebeHesaplari.Iconimage_Selected = null;
            this.btnMuhasebeHesaplari.IconMarginLeft = 0;
            this.btnMuhasebeHesaplari.IconMarginRight = 0;
            this.btnMuhasebeHesaplari.IconRightVisible = true;
            this.btnMuhasebeHesaplari.IconRightZoom = 0D;
            this.btnMuhasebeHesaplari.IconVisible = true;
            this.btnMuhasebeHesaplari.IconZoom = 90D;
            this.btnMuhasebeHesaplari.IsTab = false;
            this.btnMuhasebeHesaplari.Location = new System.Drawing.Point(270, 0);
            this.btnMuhasebeHesaplari.Name = "btnMuhasebeHesaplari";
            this.btnMuhasebeHesaplari.Normalcolor = System.Drawing.Color.DarkKhaki;
            this.btnMuhasebeHesaplari.OnHovercolor = System.Drawing.Color.Khaki;
            this.btnMuhasebeHesaplari.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnMuhasebeHesaplari.selected = false;
            this.btnMuhasebeHesaplari.Size = new System.Drawing.Size(167, 29);
            this.btnMuhasebeHesaplari.TabIndex = 48;
            this.btnMuhasebeHesaplari.Text = "Muhasebe Hesapları";
            this.btnMuhasebeHesaplari.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnMuhasebeHesaplari.Textcolor = System.Drawing.Color.Black;
            this.btnMuhasebeHesaplari.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMuhasebeHesaplari.Click += new System.EventHandler(this.btnMuhasebeHesaplari_Click);
            // 
            // btnAlternatifMalzemeler
            // 
            this.btnAlternatifMalzemeler.Activecolor = System.Drawing.Color.Khaki;
            this.btnAlternatifMalzemeler.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnAlternatifMalzemeler.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAlternatifMalzemeler.BorderRadius = 0;
            this.btnAlternatifMalzemeler.ButtonText = "Alternatif Malzemeler";
            this.btnAlternatifMalzemeler.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAlternatifMalzemeler.DisabledColor = System.Drawing.Color.Gray;
            this.btnAlternatifMalzemeler.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAlternatifMalzemeler.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAlternatifMalzemeler.Iconimage = null;
            this.btnAlternatifMalzemeler.Iconimage_right = null;
            this.btnAlternatifMalzemeler.Iconimage_right_Selected = null;
            this.btnAlternatifMalzemeler.Iconimage_Selected = null;
            this.btnAlternatifMalzemeler.IconMarginLeft = 0;
            this.btnAlternatifMalzemeler.IconMarginRight = 0;
            this.btnAlternatifMalzemeler.IconRightVisible = true;
            this.btnAlternatifMalzemeler.IconRightZoom = 0D;
            this.btnAlternatifMalzemeler.IconVisible = true;
            this.btnAlternatifMalzemeler.IconZoom = 90D;
            this.btnAlternatifMalzemeler.IsTab = false;
            this.btnAlternatifMalzemeler.Location = new System.Drawing.Point(108, 0);
            this.btnAlternatifMalzemeler.Name = "btnAlternatifMalzemeler";
            this.btnAlternatifMalzemeler.Normalcolor = System.Drawing.Color.DarkKhaki;
            this.btnAlternatifMalzemeler.OnHovercolor = System.Drawing.Color.Khaki;
            this.btnAlternatifMalzemeler.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnAlternatifMalzemeler.selected = false;
            this.btnAlternatifMalzemeler.Size = new System.Drawing.Size(162, 29);
            this.btnAlternatifMalzemeler.TabIndex = 47;
            this.btnAlternatifMalzemeler.Text = "Alternatif Malzemeler";
            this.btnAlternatifMalzemeler.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAlternatifMalzemeler.Textcolor = System.Drawing.Color.Black;
            this.btnAlternatifMalzemeler.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlternatifMalzemeler.Click += new System.EventHandler(this.btnAlternatifMalzemeler_Click);
            // 
            // btnGenelBilgiler
            // 
            this.btnGenelBilgiler.Activecolor = System.Drawing.Color.Khaki;
            this.btnGenelBilgiler.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnGenelBilgiler.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGenelBilgiler.BorderRadius = 0;
            this.btnGenelBilgiler.ButtonText = "Genel Bilgiler";
            this.btnGenelBilgiler.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenelBilgiler.DisabledColor = System.Drawing.Color.Gray;
            this.btnGenelBilgiler.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnGenelBilgiler.Iconcolor = System.Drawing.Color.Transparent;
            this.btnGenelBilgiler.Iconimage = null;
            this.btnGenelBilgiler.Iconimage_right = null;
            this.btnGenelBilgiler.Iconimage_right_Selected = null;
            this.btnGenelBilgiler.Iconimage_Selected = null;
            this.btnGenelBilgiler.IconMarginLeft = 0;
            this.btnGenelBilgiler.IconMarginRight = 0;
            this.btnGenelBilgiler.IconRightVisible = true;
            this.btnGenelBilgiler.IconRightZoom = 0D;
            this.btnGenelBilgiler.IconVisible = true;
            this.btnGenelBilgiler.IconZoom = 90D;
            this.btnGenelBilgiler.IsTab = false;
            this.btnGenelBilgiler.Location = new System.Drawing.Point(0, 0);
            this.btnGenelBilgiler.Name = "btnGenelBilgiler";
            this.btnGenelBilgiler.Normalcolor = System.Drawing.Color.DarkKhaki;
            this.btnGenelBilgiler.OnHovercolor = System.Drawing.Color.Khaki;
            this.btnGenelBilgiler.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnGenelBilgiler.selected = false;
            this.btnGenelBilgiler.Size = new System.Drawing.Size(108, 29);
            this.btnGenelBilgiler.TabIndex = 46;
            this.btnGenelBilgiler.Text = "Genel Bilgiler";
            this.btnGenelBilgiler.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnGenelBilgiler.Textcolor = System.Drawing.Color.Black;
            this.btnGenelBilgiler.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenelBilgiler.Click += new System.EventHandler(this.btnGenelBilgiler_Click);
            // 
            // txtAciklama2
            // 
            this.txtAciklama2.Location = new System.Drawing.Point(111, 116);
            this.txtAciklama2.Name = "txtAciklama2";
            this.txtAciklama2.Size = new System.Drawing.Size(447, 20);
            this.txtAciklama2.TabIndex = 57;
            // 
            // lblMalzemeKodu
            // 
            this.lblMalzemeKodu.AutoSize = true;
            this.lblMalzemeKodu.BackColor = System.Drawing.Color.Transparent;
            this.lblMalzemeKodu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMalzemeKodu.Location = new System.Drawing.Point(13, 67);
            this.lblMalzemeKodu.Name = "lblMalzemeKodu";
            this.lblMalzemeKodu.Size = new System.Drawing.Size(91, 15);
            this.lblMalzemeKodu.TabIndex = 52;
            this.lblMalzemeKodu.Text = "Malzeme Kodu";
            // 
            // txtMalzemeKodu
            // 
            this.txtMalzemeKodu.Location = new System.Drawing.Point(111, 64);
            this.txtMalzemeKodu.Name = "txtMalzemeKodu";
            this.txtMalzemeKodu.Size = new System.Drawing.Size(215, 20);
            this.txtMalzemeKodu.TabIndex = 53;
            // 
            // lblAciklama2
            // 
            this.lblAciklama2.AutoSize = true;
            this.lblAciklama2.BackColor = System.Drawing.Color.Transparent;
            this.lblAciklama2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAciklama2.Location = new System.Drawing.Point(13, 119);
            this.lblAciklama2.Name = "lblAciklama2";
            this.lblAciklama2.Size = new System.Drawing.Size(76, 15);
            this.lblAciklama2.TabIndex = 56;
            this.lblAciklama2.Text = "Açıklaması 2";
            // 
            // lblAciklamasi
            // 
            this.lblAciklamasi.AutoSize = true;
            this.lblAciklamasi.BackColor = System.Drawing.Color.Transparent;
            this.lblAciklamasi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAciklamasi.Location = new System.Drawing.Point(13, 93);
            this.lblAciklamasi.Name = "lblAciklamasi";
            this.lblAciklamasi.Size = new System.Drawing.Size(66, 15);
            this.lblAciklamasi.TabIndex = 54;
            this.lblAciklamasi.Text = "Açıklaması";
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(111, 90);
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(447, 20);
            this.txtAciklama.TabIndex = 55;
            // 
            // lblKullanimDurumu
            // 
            this.lblKullanimDurumu.AutoSize = true;
            this.lblKullanimDurumu.BackColor = System.Drawing.Color.Transparent;
            this.lblKullanimDurumu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKullanimDurumu.Location = new System.Drawing.Point(602, 67);
            this.lblKullanimDurumu.Name = "lblKullanimDurumu";
            this.lblKullanimDurumu.Size = new System.Drawing.Size(104, 15);
            this.lblKullanimDurumu.TabIndex = 58;
            this.lblKullanimDurumu.Text = "Kullanım Durumu";
            // 
            // checkBoxAktif
            // 
            this.checkBoxAktif.AutoSize = true;
            this.checkBoxAktif.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxAktif.Checked = true;
            this.checkBoxAktif.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxAktif.Location = new System.Drawing.Point(730, 66);
            this.checkBoxAktif.Name = "checkBoxAktif";
            this.checkBoxAktif.Size = new System.Drawing.Size(47, 17);
            this.checkBoxAktif.TabIndex = 59;
            this.checkBoxAktif.Text = "Aktif";
            this.checkBoxAktif.UseVisualStyleBackColor = false;
            // 
            // lblKartTuru
            // 
            this.lblKartTuru.AutoSize = true;
            this.lblKartTuru.BackColor = System.Drawing.Color.Transparent;
            this.lblKartTuru.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKartTuru.Location = new System.Drawing.Point(602, 117);
            this.lblKartTuru.Name = "lblKartTuru";
            this.lblKartTuru.Size = new System.Drawing.Size(57, 15);
            this.lblKartTuru.TabIndex = 60;
            this.lblKartTuru.Text = "Kart Türü";
            // 
            // comboBoxKartTuru
            // 
            this.comboBoxKartTuru.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBoxKartTuru.FormattingEnabled = true;
            this.comboBoxKartTuru.Items.AddRange(new object[] {
            "(1) Ticari mal",
            "(2) Hammade",
            "(3) Yarı mamul",
            "(4) Sabit Kıymet",
            "(5) Mamul"});
            this.comboBoxKartTuru.Location = new System.Drawing.Point(730, 115);
            this.comboBoxKartTuru.Name = "comboBoxKartTuru";
            this.comboBoxKartTuru.Size = new System.Drawing.Size(161, 23);
            this.comboBoxKartTuru.TabIndex = 61;
            this.comboBoxKartTuru.Text = "(1) Ticari mal";
            // 
            // btnVazgec
            // 
            this.btnVazgec.Activecolor = System.Drawing.Color.Khaki;
            this.btnVazgec.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnVazgec.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVazgec.BorderRadius = 0;
            this.btnVazgec.ButtonText = "Vazgeç";
            this.btnVazgec.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVazgec.DisabledColor = System.Drawing.Color.Gray;
            this.btnVazgec.Iconcolor = System.Drawing.Color.Transparent;
            this.btnVazgec.Iconimage = null;
            this.btnVazgec.Iconimage_right = null;
            this.btnVazgec.Iconimage_right_Selected = null;
            this.btnVazgec.Iconimage_Selected = null;
            this.btnVazgec.IconMarginLeft = 0;
            this.btnVazgec.IconMarginRight = 0;
            this.btnVazgec.IconRightVisible = true;
            this.btnVazgec.IconRightZoom = 0D;
            this.btnVazgec.IconVisible = true;
            this.btnVazgec.IconZoom = 90D;
            this.btnVazgec.IsTab = false;
            this.btnVazgec.Location = new System.Drawing.Point(862, 520);
            this.btnVazgec.Name = "btnVazgec";
            this.btnVazgec.Normalcolor = System.Drawing.Color.DarkKhaki;
            this.btnVazgec.OnHovercolor = System.Drawing.Color.Khaki;
            this.btnVazgec.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnVazgec.selected = false;
            this.btnVazgec.Size = new System.Drawing.Size(98, 31);
            this.btnVazgec.TabIndex = 63;
            this.btnVazgec.Text = "Vazgeç";
            this.btnVazgec.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnVazgec.Textcolor = System.Drawing.Color.Black;
            this.btnVazgec.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVazgec.Click += new System.EventHandler(this.btnVazgec_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Activecolor = System.Drawing.Color.Khaki;
            this.btnKaydet.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnKaydet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnKaydet.BorderRadius = 0;
            this.btnKaydet.ButtonText = "Kaydet";
            this.btnKaydet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKaydet.DisabledColor = System.Drawing.Color.Gray;
            this.btnKaydet.Iconcolor = System.Drawing.Color.Transparent;
            this.btnKaydet.Iconimage = null;
            this.btnKaydet.Iconimage_right = null;
            this.btnKaydet.Iconimage_right_Selected = null;
            this.btnKaydet.Iconimage_Selected = null;
            this.btnKaydet.IconMarginLeft = 0;
            this.btnKaydet.IconMarginRight = 0;
            this.btnKaydet.IconRightVisible = true;
            this.btnKaydet.IconRightZoom = 0D;
            this.btnKaydet.IconVisible = true;
            this.btnKaydet.IconZoom = 90D;
            this.btnKaydet.IsTab = false;
            this.btnKaydet.Location = new System.Drawing.Point(748, 520);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Normalcolor = System.Drawing.Color.DarkKhaki;
            this.btnKaydet.OnHovercolor = System.Drawing.Color.Khaki;
            this.btnKaydet.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnKaydet.selected = false;
            this.btnKaydet.Size = new System.Drawing.Size(98, 31);
            this.btnKaydet.TabIndex = 62;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnKaydet.Textcolor = System.Drawing.Color.Black;
            this.btnKaydet.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // frmAnaKayitlar_Stok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.BackgroundImage = global::BeeOne.Properties.Resources.background__39_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(977, 573);
            this.Controls.Add(this.btnVazgec);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.comboBoxKartTuru);
            this.Controls.Add(this.lblKartTuru);
            this.Controls.Add(this.checkBoxAktif);
            this.Controls.Add(this.lblKullanimDurumu);
            this.Controls.Add(this.txtAciklama2);
            this.Controls.Add(this.lblMalzemeKodu);
            this.Controls.Add(this.txtMalzemeKodu);
            this.Controls.Add(this.lblAciklama2);
            this.Controls.Add(this.lblAciklamasi);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.pnlIslem);
            this.Controls.Add(this.pnlSekme);
            this.Controls.Add(this.pnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAnaKayitlar_Stok";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ana Kayıtlar > Stok";
            this.Load += new System.EventHandler(this.frmAnaKayitlar_Stok_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).EndInit();
            this.pnlSekme.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblAnaKayitlar;
        private Bunifu.Framework.UI.BunifuImageButton btnClose;
        private Bunifu.Framework.UI.BunifuImageButton btnMinimize;
        private Bunifu.Framework.UI.BunifuGradientPanel pnlIslem;
        private Bunifu.Framework.UI.BunifuGradientPanel pnlSekme;
        private Bunifu.Framework.UI.BunifuFlatButton btnMuhasebeHesaplari;
        private Bunifu.Framework.UI.BunifuFlatButton btnAlternatifMalzemeler;
        private Bunifu.Framework.UI.BunifuFlatButton btnGenelBilgiler;
        private Bunifu.Framework.UI.BunifuFlatButton btnFiyatBilgisi;
        private System.Windows.Forms.TextBox txtAciklama2;
        private System.Windows.Forms.Label lblMalzemeKodu;
        private System.Windows.Forms.TextBox txtMalzemeKodu;
        private System.Windows.Forms.Label lblAciklama2;
        private System.Windows.Forms.Label lblAciklamasi;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.Label lblKullanimDurumu;
        private System.Windows.Forms.CheckBox checkBoxAktif;
        private System.Windows.Forms.Label lblKartTuru;
        private System.Windows.Forms.ComboBox comboBoxKartTuru;
        private Bunifu.Framework.UI.BunifuFlatButton btnVazgec;
        private Bunifu.Framework.UI.BunifuFlatButton btnKaydet;
    }
}