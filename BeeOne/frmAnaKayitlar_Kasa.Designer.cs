
namespace BeeOne
{
    partial class frmAnaKayitlar_Kasa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAnaKayitlar_Kasa));
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblAnaKayitlar = new System.Windows.Forms.Label();
            this.btnClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnMinimize = new Bunifu.Framework.UI.BunifuImageButton();
            this.txtKodu = new System.Windows.Forms.TextBox();
            this.lblKodu = new System.Windows.Forms.Label();
            this.txtAdi = new System.Windows.Forms.TextBox();
            this.lblAdi = new System.Windows.Forms.Label();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.lblAciklama = new System.Windows.Forms.Label();
            this.comboBoxIsYeri = new System.Windows.Forms.ComboBox();
            this.lblIsYeri = new System.Windows.Forms.Label();
            this.comboBoxYetkiKodu = new System.Windows.Forms.ComboBox();
            this.lblYetkiKodu = new System.Windows.Forms.Label();
            this.comboBoxOzelKod = new System.Windows.Forms.ComboBox();
            this.lblOzelKod = new System.Windows.Forms.Label();
            this.comboBoxDovizTuru = new System.Windows.Forms.ComboBox();
            this.lblDovizTuru = new System.Windows.Forms.Label();
            this.lblKasa = new System.Windows.Forms.Label();
            this.lblHesapKodu = new System.Windows.Forms.Label();
            this.lblMasrafMerkezi = new System.Windows.Forms.Label();
            this.comboBoxStatu = new System.Windows.Forms.ComboBox();
            this.lblStatusu = new System.Windows.Forms.Label();
            this.btnMasrafMerkezi = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtMasrafMerkezi = new System.Windows.Forms.TextBox();
            this.btnKasaHesapKodu = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtKasaHesapKodu = new System.Windows.Forms.TextBox();
            this.btnKaydet = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnVazgec = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).BeginInit();
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
            this.pnlTop.Size = new System.Drawing.Size(581, 48);
            this.pnlTop.TabIndex = 2;
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
            this.lblAnaKayitlar.Size = new System.Drawing.Size(182, 21);
            this.lblAnaKayitlar.TabIndex = 7;
            this.lblAnaKayitlar.Text = "ANA KAYITLAR > KASA";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageActive = null;
            this.btnClose.Location = new System.Drawing.Point(551, 10);
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
            this.btnMinimize.Location = new System.Drawing.Point(525, 10);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(20, 27);
            this.btnMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimize.TabIndex = 5;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.Zoom = 10;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // txtKodu
            // 
            this.txtKodu.Location = new System.Drawing.Point(105, 65);
            this.txtKodu.Name = "txtKodu";
            this.txtKodu.Size = new System.Drawing.Size(215, 20);
            this.txtKodu.TabIndex = 7;
            // 
            // lblKodu
            // 
            this.lblKodu.AutoSize = true;
            this.lblKodu.BackColor = System.Drawing.Color.Transparent;
            this.lblKodu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKodu.Location = new System.Drawing.Point(25, 68);
            this.lblKodu.Name = "lblKodu";
            this.lblKodu.Size = new System.Drawing.Size(36, 15);
            this.lblKodu.TabIndex = 6;
            this.lblKodu.Text = "Kodu";
            // 
            // txtAdi
            // 
            this.txtAdi.Location = new System.Drawing.Point(105, 91);
            this.txtAdi.Name = "txtAdi";
            this.txtAdi.Size = new System.Drawing.Size(447, 20);
            this.txtAdi.TabIndex = 9;
            // 
            // lblAdi
            // 
            this.lblAdi.AutoSize = true;
            this.lblAdi.BackColor = System.Drawing.Color.Transparent;
            this.lblAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAdi.Location = new System.Drawing.Point(25, 94);
            this.lblAdi.Name = "lblAdi";
            this.lblAdi.Size = new System.Drawing.Size(24, 15);
            this.lblAdi.TabIndex = 8;
            this.lblAdi.Text = "Adı";
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(105, 117);
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(447, 20);
            this.txtAciklama.TabIndex = 11;
            // 
            // lblAciklama
            // 
            this.lblAciklama.AutoSize = true;
            this.lblAciklama.BackColor = System.Drawing.Color.Transparent;
            this.lblAciklama.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAciklama.Location = new System.Drawing.Point(25, 120);
            this.lblAciklama.Name = "lblAciklama";
            this.lblAciklama.Size = new System.Drawing.Size(57, 15);
            this.lblAciklama.TabIndex = 10;
            this.lblAciklama.Text = "Açıklama";
            // 
            // comboBoxIsYeri
            // 
            this.comboBoxIsYeri.FormattingEnabled = true;
            this.comboBoxIsYeri.Location = new System.Drawing.Point(106, 143);
            this.comboBoxIsYeri.Name = "comboBoxIsYeri";
            this.comboBoxIsYeri.Size = new System.Drawing.Size(214, 21);
            this.comboBoxIsYeri.TabIndex = 13;
            // 
            // lblIsYeri
            // 
            this.lblIsYeri.AutoSize = true;
            this.lblIsYeri.BackColor = System.Drawing.Color.Transparent;
            this.lblIsYeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblIsYeri.Location = new System.Drawing.Point(26, 146);
            this.lblIsYeri.Name = "lblIsYeri";
            this.lblIsYeri.Size = new System.Drawing.Size(40, 15);
            this.lblIsYeri.TabIndex = 12;
            this.lblIsYeri.Text = "İş Yeri";
            // 
            // comboBoxYetkiKodu
            // 
            this.comboBoxYetkiKodu.FormattingEnabled = true;
            this.comboBoxYetkiKodu.Location = new System.Drawing.Point(443, 195);
            this.comboBoxYetkiKodu.Name = "comboBoxYetkiKodu";
            this.comboBoxYetkiKodu.Size = new System.Drawing.Size(109, 21);
            this.comboBoxYetkiKodu.TabIndex = 25;
            // 
            // lblYetkiKodu
            // 
            this.lblYetkiKodu.AutoSize = true;
            this.lblYetkiKodu.BackColor = System.Drawing.Color.Transparent;
            this.lblYetkiKodu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYetkiKodu.Location = new System.Drawing.Point(363, 198);
            this.lblYetkiKodu.Name = "lblYetkiKodu";
            this.lblYetkiKodu.Size = new System.Drawing.Size(65, 15);
            this.lblYetkiKodu.TabIndex = 24;
            this.lblYetkiKodu.Text = "Yetki Kodu";
            // 
            // comboBoxOzelKod
            // 
            this.comboBoxOzelKod.FormattingEnabled = true;
            this.comboBoxOzelKod.Location = new System.Drawing.Point(106, 195);
            this.comboBoxOzelKod.Name = "comboBoxOzelKod";
            this.comboBoxOzelKod.Size = new System.Drawing.Size(109, 21);
            this.comboBoxOzelKod.TabIndex = 23;
            // 
            // lblOzelKod
            // 
            this.lblOzelKod.AutoSize = true;
            this.lblOzelKod.BackColor = System.Drawing.Color.Transparent;
            this.lblOzelKod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOzelKod.Location = new System.Drawing.Point(26, 198);
            this.lblOzelKod.Name = "lblOzelKod";
            this.lblOzelKod.Size = new System.Drawing.Size(57, 15);
            this.lblOzelKod.TabIndex = 22;
            this.lblOzelKod.Text = "Özel Kod";
            // 
            // comboBoxDovizTuru
            // 
            this.comboBoxDovizTuru.FormattingEnabled = true;
            this.comboBoxDovizTuru.Location = new System.Drawing.Point(106, 241);
            this.comboBoxDovizTuru.Name = "comboBoxDovizTuru";
            this.comboBoxDovizTuru.Size = new System.Drawing.Size(214, 21);
            this.comboBoxDovizTuru.TabIndex = 27;
            // 
            // lblDovizTuru
            // 
            this.lblDovizTuru.AutoSize = true;
            this.lblDovizTuru.BackColor = System.Drawing.Color.Transparent;
            this.lblDovizTuru.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDovizTuru.Location = new System.Drawing.Point(26, 244);
            this.lblDovizTuru.Name = "lblDovizTuru";
            this.lblDovizTuru.Size = new System.Drawing.Size(65, 15);
            this.lblDovizTuru.TabIndex = 26;
            this.lblDovizTuru.Text = "Döviz Türü";
            // 
            // lblKasa
            // 
            this.lblKasa.AutoSize = true;
            this.lblKasa.BackColor = System.Drawing.Color.Transparent;
            this.lblKasa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKasa.Location = new System.Drawing.Point(25, 317);
            this.lblKasa.Name = "lblKasa";
            this.lblKasa.Size = new System.Drawing.Size(35, 15);
            this.lblKasa.TabIndex = 28;
            this.lblKasa.Text = "Kasa";
            // 
            // lblHesapKodu
            // 
            this.lblHesapKodu.AutoSize = true;
            this.lblHesapKodu.BackColor = System.Drawing.Color.Transparent;
            this.lblHesapKodu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHesapKodu.Location = new System.Drawing.Point(148, 288);
            this.lblHesapKodu.Name = "lblHesapKodu";
            this.lblHesapKodu.Size = new System.Drawing.Size(108, 15);
            this.lblHesapKodu.TabIndex = 29;
            this.lblHesapKodu.Text = "Muhasebe Hesabı";
            // 
            // lblMasrafMerkezi
            // 
            this.lblMasrafMerkezi.AutoSize = true;
            this.lblMasrafMerkezi.BackColor = System.Drawing.Color.Transparent;
            this.lblMasrafMerkezi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMasrafMerkezi.Location = new System.Drawing.Point(402, 288);
            this.lblMasrafMerkezi.Name = "lblMasrafMerkezi";
            this.lblMasrafMerkezi.Size = new System.Drawing.Size(92, 15);
            this.lblMasrafMerkezi.TabIndex = 31;
            this.lblMasrafMerkezi.Text = "Masraf Merkezi";
            // 
            // comboBoxStatu
            // 
            this.comboBoxStatu.FormattingEnabled = true;
            this.comboBoxStatu.Items.AddRange(new object[] {
            "Kullanımda",
            "Kullanım dışı"});
            this.comboBoxStatu.Location = new System.Drawing.Point(443, 64);
            this.comboBoxStatu.Name = "comboBoxStatu";
            this.comboBoxStatu.Size = new System.Drawing.Size(109, 21);
            this.comboBoxStatu.TabIndex = 34;
            this.comboBoxStatu.Text = "Kullanımda";
            // 
            // lblStatusu
            // 
            this.lblStatusu.AutoSize = true;
            this.lblStatusu.BackColor = System.Drawing.Color.Transparent;
            this.lblStatusu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblStatusu.Location = new System.Drawing.Point(363, 67);
            this.lblStatusu.Name = "lblStatusu";
            this.lblStatusu.Size = new System.Drawing.Size(48, 15);
            this.lblStatusu.TabIndex = 33;
            this.lblStatusu.Text = "Statüsü";
            // 
            // btnMasrafMerkezi
            // 
            this.btnMasrafMerkezi.Activecolor = System.Drawing.Color.Khaki;
            this.btnMasrafMerkezi.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnMasrafMerkezi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMasrafMerkezi.BorderRadius = 0;
            this.btnMasrafMerkezi.ButtonText = "...";
            this.btnMasrafMerkezi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMasrafMerkezi.DisabledColor = System.Drawing.Color.Gray;
            this.btnMasrafMerkezi.Iconcolor = System.Drawing.Color.Transparent;
            this.btnMasrafMerkezi.Iconimage = null;
            this.btnMasrafMerkezi.Iconimage_right = null;
            this.btnMasrafMerkezi.Iconimage_right_Selected = null;
            this.btnMasrafMerkezi.Iconimage_Selected = null;
            this.btnMasrafMerkezi.IconMarginLeft = 0;
            this.btnMasrafMerkezi.IconMarginRight = 0;
            this.btnMasrafMerkezi.IconRightVisible = true;
            this.btnMasrafMerkezi.IconRightZoom = 0D;
            this.btnMasrafMerkezi.IconVisible = true;
            this.btnMasrafMerkezi.IconZoom = 90D;
            this.btnMasrafMerkezi.IsTab = false;
            this.btnMasrafMerkezi.Location = new System.Drawing.Point(529, 319);
            this.btnMasrafMerkezi.Name = "btnMasrafMerkezi";
            this.btnMasrafMerkezi.Normalcolor = System.Drawing.Color.DarkKhaki;
            this.btnMasrafMerkezi.OnHovercolor = System.Drawing.Color.Khaki;
            this.btnMasrafMerkezi.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnMasrafMerkezi.selected = false;
            this.btnMasrafMerkezi.Size = new System.Drawing.Size(23, 20);
            this.btnMasrafMerkezi.TabIndex = 104;
            this.btnMasrafMerkezi.Text = "...";
            this.btnMasrafMerkezi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnMasrafMerkezi.Textcolor = System.Drawing.Color.Black;
            this.btnMasrafMerkezi.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // txtMasrafMerkezi
            // 
            this.txtMasrafMerkezi.Location = new System.Drawing.Point(340, 318);
            this.txtMasrafMerkezi.Multiline = true;
            this.txtMasrafMerkezi.Name = "txtMasrafMerkezi";
            this.txtMasrafMerkezi.Size = new System.Drawing.Size(212, 21);
            this.txtMasrafMerkezi.TabIndex = 103;
            // 
            // btnKasaHesapKodu
            // 
            this.btnKasaHesapKodu.Activecolor = System.Drawing.Color.Khaki;
            this.btnKasaHesapKodu.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnKasaHesapKodu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnKasaHesapKodu.BorderRadius = 0;
            this.btnKasaHesapKodu.ButtonText = "...";
            this.btnKasaHesapKodu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKasaHesapKodu.DisabledColor = System.Drawing.Color.Gray;
            this.btnKasaHesapKodu.Iconcolor = System.Drawing.Color.Transparent;
            this.btnKasaHesapKodu.Iconimage = null;
            this.btnKasaHesapKodu.Iconimage_right = null;
            this.btnKasaHesapKodu.Iconimage_right_Selected = null;
            this.btnKasaHesapKodu.Iconimage_Selected = null;
            this.btnKasaHesapKodu.IconMarginLeft = 0;
            this.btnKasaHesapKodu.IconMarginRight = 0;
            this.btnKasaHesapKodu.IconRightVisible = true;
            this.btnKasaHesapKodu.IconRightZoom = 0D;
            this.btnKasaHesapKodu.IconVisible = true;
            this.btnKasaHesapKodu.IconZoom = 90D;
            this.btnKasaHesapKodu.IsTab = false;
            this.btnKasaHesapKodu.Location = new System.Drawing.Point(297, 318);
            this.btnKasaHesapKodu.Name = "btnKasaHesapKodu";
            this.btnKasaHesapKodu.Normalcolor = System.Drawing.Color.DarkKhaki;
            this.btnKasaHesapKodu.OnHovercolor = System.Drawing.Color.Khaki;
            this.btnKasaHesapKodu.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnKasaHesapKodu.selected = false;
            this.btnKasaHesapKodu.Size = new System.Drawing.Size(23, 20);
            this.btnKasaHesapKodu.TabIndex = 106;
            this.btnKasaHesapKodu.Text = "...";
            this.btnKasaHesapKodu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnKasaHesapKodu.Textcolor = System.Drawing.Color.Black;
            this.btnKasaHesapKodu.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // txtKasaHesapKodu
            // 
            this.txtKasaHesapKodu.Location = new System.Drawing.Point(105, 317);
            this.txtKasaHesapKodu.Multiline = true;
            this.txtKasaHesapKodu.Name = "txtKasaHesapKodu";
            this.txtKasaHesapKodu.Size = new System.Drawing.Size(215, 21);
            this.txtKasaHesapKodu.TabIndex = 105;
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
            this.btnKaydet.Location = new System.Drawing.Point(340, 356);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Normalcolor = System.Drawing.Color.DarkKhaki;
            this.btnKaydet.OnHovercolor = System.Drawing.Color.Khaki;
            this.btnKaydet.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnKaydet.selected = false;
            this.btnKaydet.Size = new System.Drawing.Size(98, 31);
            this.btnKaydet.TabIndex = 37;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnKaydet.Textcolor = System.Drawing.Color.Black;
            this.btnKaydet.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btnVazgec.Location = new System.Drawing.Point(454, 356);
            this.btnVazgec.Name = "btnVazgec";
            this.btnVazgec.Normalcolor = System.Drawing.Color.DarkKhaki;
            this.btnVazgec.OnHovercolor = System.Drawing.Color.Khaki;
            this.btnVazgec.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnVazgec.selected = false;
            this.btnVazgec.Size = new System.Drawing.Size(98, 31);
            this.btnVazgec.TabIndex = 38;
            this.btnVazgec.Text = "Vazgeç";
            this.btnVazgec.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnVazgec.Textcolor = System.Drawing.Color.Black;
            this.btnVazgec.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVazgec.Click += new System.EventHandler(this.btnVazgec_Click);
            // 
            // frmAnaKayitlar_Kasa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.BackgroundImage = global::BeeOne.Properties.Resources.background__39_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(581, 409);
            this.Controls.Add(this.btnKasaHesapKodu);
            this.Controls.Add(this.txtKasaHesapKodu);
            this.Controls.Add(this.btnMasrafMerkezi);
            this.Controls.Add(this.txtMasrafMerkezi);
            this.Controls.Add(this.btnVazgec);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.comboBoxStatu);
            this.Controls.Add(this.lblStatusu);
            this.Controls.Add(this.lblMasrafMerkezi);
            this.Controls.Add(this.lblHesapKodu);
            this.Controls.Add(this.lblKasa);
            this.Controls.Add(this.comboBoxDovizTuru);
            this.Controls.Add(this.lblDovizTuru);
            this.Controls.Add(this.comboBoxYetkiKodu);
            this.Controls.Add(this.lblYetkiKodu);
            this.Controls.Add(this.comboBoxOzelKod);
            this.Controls.Add(this.lblOzelKod);
            this.Controls.Add(this.comboBoxIsYeri);
            this.Controls.Add(this.lblIsYeri);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.lblAciklama);
            this.Controls.Add(this.txtAdi);
            this.Controls.Add(this.lblAdi);
            this.Controls.Add(this.txtKodu);
            this.Controls.Add(this.lblKodu);
            this.Controls.Add(this.pnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAnaKayitlar_Kasa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ana Kayıtlar > Kasa";
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblAnaKayitlar;
        private Bunifu.Framework.UI.BunifuImageButton btnClose;
        private Bunifu.Framework.UI.BunifuImageButton btnMinimize;
        private System.Windows.Forms.TextBox txtKodu;
        private System.Windows.Forms.Label lblKodu;
        private System.Windows.Forms.TextBox txtAdi;
        private System.Windows.Forms.Label lblAdi;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.Label lblAciklama;
        private System.Windows.Forms.ComboBox comboBoxIsYeri;
        private System.Windows.Forms.Label lblIsYeri;
        private System.Windows.Forms.ComboBox comboBoxYetkiKodu;
        private System.Windows.Forms.Label lblYetkiKodu;
        private System.Windows.Forms.ComboBox comboBoxOzelKod;
        private System.Windows.Forms.Label lblOzelKod;
        private System.Windows.Forms.ComboBox comboBoxDovizTuru;
        private System.Windows.Forms.Label lblDovizTuru;
        private System.Windows.Forms.Label lblKasa;
        private System.Windows.Forms.Label lblHesapKodu;
        private System.Windows.Forms.Label lblMasrafMerkezi;
        private System.Windows.Forms.ComboBox comboBoxStatu;
        private System.Windows.Forms.Label lblStatusu;
        private Bunifu.Framework.UI.BunifuFlatButton btnMasrafMerkezi;
        private System.Windows.Forms.TextBox txtMasrafMerkezi;
        private Bunifu.Framework.UI.BunifuFlatButton btnKasaHesapKodu;
        private System.Windows.Forms.TextBox txtKasaHesapKodu;
        private Bunifu.Framework.UI.BunifuFlatButton btnKaydet;
        private Bunifu.Framework.UI.BunifuFlatButton btnVazgec;
    }
}