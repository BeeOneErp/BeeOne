
namespace BeeOne
{
    partial class frmFinans_KasaIslemleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFinans_KasaIslemleri));
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblFinans = new System.Windows.Forms.Label();
            this.btnClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnMinimize = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnKasaKodu = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lblKasaKodu = new System.Windows.Forms.Label();
            this.txtKasaKodu = new System.Windows.Forms.TextBox();
            this.lblIslemNo = new System.Windows.Forms.Label();
            this.txtIslemNo = new System.Windows.Forms.TextBox();
            this.lblMakbuzNo = new System.Windows.Forms.Label();
            this.txtMakbuzNo = new System.Windows.Forms.TextBox();
            this.btnTarih = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lblTarih = new System.Windows.Forms.Label();
            this.txtTarih = new System.Windows.Forms.TextBox();
            this.btnDuzenlenmeTarihi = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lblDuzenlenmeTarihi = new System.Windows.Forms.Label();
            this.txtDuzenlenmeTarihi = new System.Windows.Forms.TextBox();
            this.comboBoxYetkiKodu = new System.Windows.Forms.ComboBox();
            this.comboBoxOzelKod = new System.Windows.Forms.ComboBox();
            this.lblYetkiKodu = new System.Windows.Forms.Label();
            this.lblOzelKod = new System.Windows.Forms.Label();
            this.comboBoxIsYeri = new System.Windows.Forms.ComboBox();
            this.lblIsYeri = new System.Windows.Forms.Label();
            this.comboBoxFisTuru = new System.Windows.Forms.ComboBox();
            this.lblFisTuru = new System.Windows.Forms.Label();
            this.comboBoxSatisElemaniKodu = new System.Windows.Forms.ComboBox();
            this.lblSatisElemaniKodu = new System.Windows.Forms.Label();
            this.btnVazgec = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnKaydet = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lblTicariIslemGrubu = new System.Windows.Forms.Label();
            this.btnCariHesapKodu = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lblCariHesapKodu = new System.Windows.Forms.Label();
            this.txtCariHesapKodu = new System.Windows.Forms.TextBox();
            this.lblKasaAciklamasi = new System.Windows.Forms.Label();
            this.txtKasaAciklamasi = new System.Windows.Forms.TextBox();
            this.comboBoxDoviz = new System.Windows.Forms.ComboBox();
            this.lblDoviz = new System.Windows.Forms.Label();
            this.lblKur = new System.Windows.Forms.Label();
            this.lblDovizliTutar = new System.Windows.Forms.Label();
            this.lblTutar = new System.Windows.Forms.Label();
            this.txtKur = new System.Windows.Forms.TextBox();
            this.txtDovizliTutar = new System.Windows.Forms.TextBox();
            this.txtTutar = new System.Windows.Forms.TextBox();
            this.txtTicIslemGrb = new System.Windows.Forms.TextBox();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.lblFinans);
            this.pnlTop.Controls.Add(this.btnClose);
            this.pnlTop.Controls.Add(this.btnMinimize);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(755, 48);
            this.pnlTop.TabIndex = 13;
            this.pnlTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTop_MouseDown);
            this.pnlTop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlTop_MouseMove);
            this.pnlTop.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlTop_MouseUp);
            // 
            // lblFinans
            // 
            this.lblFinans.AutoSize = true;
            this.lblFinans.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFinans.ForeColor = System.Drawing.Color.DarkKhaki;
            this.lblFinans.Location = new System.Drawing.Point(12, 13);
            this.lblFinans.Name = "lblFinans";
            this.lblFinans.Size = new System.Drawing.Size(211, 21);
            this.lblFinans.TabIndex = 7;
            this.lblFinans.Text = "FİNANS > KASA İŞLEMLERİ";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageActive = null;
            this.btnClose.Location = new System.Drawing.Point(725, 10);
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
            this.btnMinimize.Location = new System.Drawing.Point(699, 10);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(20, 27);
            this.btnMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimize.TabIndex = 5;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.Zoom = 10;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnKasaKodu
            // 
            this.btnKasaKodu.Activecolor = System.Drawing.Color.Khaki;
            this.btnKasaKodu.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnKasaKodu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnKasaKodu.BorderRadius = 0;
            this.btnKasaKodu.ButtonText = "...";
            this.btnKasaKodu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKasaKodu.DisabledColor = System.Drawing.Color.Gray;
            this.btnKasaKodu.Iconcolor = System.Drawing.Color.Transparent;
            this.btnKasaKodu.Iconimage = null;
            this.btnKasaKodu.Iconimage_right = null;
            this.btnKasaKodu.Iconimage_right_Selected = null;
            this.btnKasaKodu.Iconimage_Selected = null;
            this.btnKasaKodu.IconMarginLeft = 0;
            this.btnKasaKodu.IconMarginRight = 0;
            this.btnKasaKodu.IconRightVisible = true;
            this.btnKasaKodu.IconRightZoom = 0D;
            this.btnKasaKodu.IconVisible = true;
            this.btnKasaKodu.IconZoom = 90D;
            this.btnKasaKodu.IsTab = false;
            this.btnKasaKodu.Location = new System.Drawing.Point(320, 65);
            this.btnKasaKodu.Name = "btnKasaKodu";
            this.btnKasaKodu.Normalcolor = System.Drawing.Color.DarkKhaki;
            this.btnKasaKodu.OnHovercolor = System.Drawing.Color.Khaki;
            this.btnKasaKodu.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnKasaKodu.selected = false;
            this.btnKasaKodu.Size = new System.Drawing.Size(23, 20);
            this.btnKasaKodu.TabIndex = 208;
            this.btnKasaKodu.Text = "...";
            this.btnKasaKodu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnKasaKodu.Textcolor = System.Drawing.Color.Black;
            this.btnKasaKodu.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // lblKasaKodu
            // 
            this.lblKasaKodu.AutoSize = true;
            this.lblKasaKodu.BackColor = System.Drawing.Color.Transparent;
            this.lblKasaKodu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKasaKodu.Location = new System.Drawing.Point(13, 65);
            this.lblKasaKodu.Name = "lblKasaKodu";
            this.lblKasaKodu.Size = new System.Drawing.Size(67, 15);
            this.lblKasaKodu.TabIndex = 207;
            this.lblKasaKodu.Text = "Kasa Kodu";
            // 
            // txtKasaKodu
            // 
            this.txtKasaKodu.Location = new System.Drawing.Point(144, 64);
            this.txtKasaKodu.Multiline = true;
            this.txtKasaKodu.Name = "txtKasaKodu";
            this.txtKasaKodu.Size = new System.Drawing.Size(199, 21);
            this.txtKasaKodu.TabIndex = 206;
            // 
            // lblIslemNo
            // 
            this.lblIslemNo.AutoSize = true;
            this.lblIslemNo.BackColor = System.Drawing.Color.Transparent;
            this.lblIslemNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblIslemNo.Location = new System.Drawing.Point(13, 91);
            this.lblIslemNo.Name = "lblIslemNo";
            this.lblIslemNo.Size = new System.Drawing.Size(59, 15);
            this.lblIslemNo.TabIndex = 210;
            this.lblIslemNo.Text = "İşlem No.";
            // 
            // txtIslemNo
            // 
            this.txtIslemNo.Location = new System.Drawing.Point(144, 90);
            this.txtIslemNo.Multiline = true;
            this.txtIslemNo.Name = "txtIslemNo";
            this.txtIslemNo.Size = new System.Drawing.Size(199, 21);
            this.txtIslemNo.TabIndex = 209;
            // 
            // lblMakbuzNo
            // 
            this.lblMakbuzNo.AutoSize = true;
            this.lblMakbuzNo.BackColor = System.Drawing.Color.Transparent;
            this.lblMakbuzNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMakbuzNo.Location = new System.Drawing.Point(12, 117);
            this.lblMakbuzNo.Name = "lblMakbuzNo";
            this.lblMakbuzNo.Size = new System.Drawing.Size(73, 15);
            this.lblMakbuzNo.TabIndex = 212;
            this.lblMakbuzNo.Text = "Makbuz No.";
            // 
            // txtMakbuzNo
            // 
            this.txtMakbuzNo.Location = new System.Drawing.Point(143, 116);
            this.txtMakbuzNo.Multiline = true;
            this.txtMakbuzNo.Name = "txtMakbuzNo";
            this.txtMakbuzNo.Size = new System.Drawing.Size(199, 21);
            this.txtMakbuzNo.TabIndex = 211;
            // 
            // btnTarih
            // 
            this.btnTarih.Activecolor = System.Drawing.Color.Khaki;
            this.btnTarih.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnTarih.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTarih.BorderRadius = 0;
            this.btnTarih.ButtonText = "...";
            this.btnTarih.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTarih.DisabledColor = System.Drawing.Color.Gray;
            this.btnTarih.Iconcolor = System.Drawing.Color.Transparent;
            this.btnTarih.Iconimage = null;
            this.btnTarih.Iconimage_right = null;
            this.btnTarih.Iconimage_right_Selected = null;
            this.btnTarih.Iconimage_Selected = null;
            this.btnTarih.IconMarginLeft = 0;
            this.btnTarih.IconMarginRight = 0;
            this.btnTarih.IconRightVisible = true;
            this.btnTarih.IconRightZoom = 0D;
            this.btnTarih.IconVisible = true;
            this.btnTarih.IconZoom = 90D;
            this.btnTarih.IsTab = false;
            this.btnTarih.Location = new System.Drawing.Point(319, 144);
            this.btnTarih.Name = "btnTarih";
            this.btnTarih.Normalcolor = System.Drawing.Color.DarkKhaki;
            this.btnTarih.OnHovercolor = System.Drawing.Color.Khaki;
            this.btnTarih.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnTarih.selected = false;
            this.btnTarih.Size = new System.Drawing.Size(23, 20);
            this.btnTarih.TabIndex = 215;
            this.btnTarih.Text = "...";
            this.btnTarih.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnTarih.Textcolor = System.Drawing.Color.Black;
            this.btnTarih.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // lblTarih
            // 
            this.lblTarih.AutoSize = true;
            this.lblTarih.BackColor = System.Drawing.Color.Transparent;
            this.lblTarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTarih.Location = new System.Drawing.Point(12, 144);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(35, 15);
            this.lblTarih.TabIndex = 214;
            this.lblTarih.Text = "Tarih";
            // 
            // txtTarih
            // 
            this.txtTarih.Location = new System.Drawing.Point(143, 143);
            this.txtTarih.Multiline = true;
            this.txtTarih.Name = "txtTarih";
            this.txtTarih.Size = new System.Drawing.Size(199, 21);
            this.txtTarih.TabIndex = 213;
            // 
            // btnDuzenlenmeTarihi
            // 
            this.btnDuzenlenmeTarihi.Activecolor = System.Drawing.Color.Khaki;
            this.btnDuzenlenmeTarihi.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnDuzenlenmeTarihi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDuzenlenmeTarihi.BorderRadius = 0;
            this.btnDuzenlenmeTarihi.ButtonText = "...";
            this.btnDuzenlenmeTarihi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDuzenlenmeTarihi.DisabledColor = System.Drawing.Color.Gray;
            this.btnDuzenlenmeTarihi.Iconcolor = System.Drawing.Color.Transparent;
            this.btnDuzenlenmeTarihi.Iconimage = null;
            this.btnDuzenlenmeTarihi.Iconimage_right = null;
            this.btnDuzenlenmeTarihi.Iconimage_right_Selected = null;
            this.btnDuzenlenmeTarihi.Iconimage_Selected = null;
            this.btnDuzenlenmeTarihi.IconMarginLeft = 0;
            this.btnDuzenlenmeTarihi.IconMarginRight = 0;
            this.btnDuzenlenmeTarihi.IconRightVisible = true;
            this.btnDuzenlenmeTarihi.IconRightZoom = 0D;
            this.btnDuzenlenmeTarihi.IconVisible = true;
            this.btnDuzenlenmeTarihi.IconZoom = 90D;
            this.btnDuzenlenmeTarihi.IsTab = false;
            this.btnDuzenlenmeTarihi.Location = new System.Drawing.Point(319, 171);
            this.btnDuzenlenmeTarihi.Name = "btnDuzenlenmeTarihi";
            this.btnDuzenlenmeTarihi.Normalcolor = System.Drawing.Color.DarkKhaki;
            this.btnDuzenlenmeTarihi.OnHovercolor = System.Drawing.Color.Khaki;
            this.btnDuzenlenmeTarihi.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnDuzenlenmeTarihi.selected = false;
            this.btnDuzenlenmeTarihi.Size = new System.Drawing.Size(23, 20);
            this.btnDuzenlenmeTarihi.TabIndex = 218;
            this.btnDuzenlenmeTarihi.Text = "...";
            this.btnDuzenlenmeTarihi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDuzenlenmeTarihi.Textcolor = System.Drawing.Color.Black;
            this.btnDuzenlenmeTarihi.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // lblDuzenlenmeTarihi
            // 
            this.lblDuzenlenmeTarihi.AutoSize = true;
            this.lblDuzenlenmeTarihi.BackColor = System.Drawing.Color.Transparent;
            this.lblDuzenlenmeTarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDuzenlenmeTarihi.Location = new System.Drawing.Point(12, 171);
            this.lblDuzenlenmeTarihi.Name = "lblDuzenlenmeTarihi";
            this.lblDuzenlenmeTarihi.Size = new System.Drawing.Size(112, 15);
            this.lblDuzenlenmeTarihi.TabIndex = 217;
            this.lblDuzenlenmeTarihi.Text = "Düzenlenme Tarihi";
            // 
            // txtDuzenlenmeTarihi
            // 
            this.txtDuzenlenmeTarihi.Location = new System.Drawing.Point(143, 170);
            this.txtDuzenlenmeTarihi.Multiline = true;
            this.txtDuzenlenmeTarihi.Name = "txtDuzenlenmeTarihi";
            this.txtDuzenlenmeTarihi.Size = new System.Drawing.Size(199, 21);
            this.txtDuzenlenmeTarihi.TabIndex = 216;
            // 
            // comboBoxYetkiKodu
            // 
            this.comboBoxYetkiKodu.FormattingEnabled = true;
            this.comboBoxYetkiKodu.Location = new System.Drawing.Point(556, 90);
            this.comboBoxYetkiKodu.Name = "comboBoxYetkiKodu";
            this.comboBoxYetkiKodu.Size = new System.Drawing.Size(172, 21);
            this.comboBoxYetkiKodu.TabIndex = 222;
            // 
            // comboBoxOzelKod
            // 
            this.comboBoxOzelKod.FormattingEnabled = true;
            this.comboBoxOzelKod.Location = new System.Drawing.Point(556, 64);
            this.comboBoxOzelKod.Name = "comboBoxOzelKod";
            this.comboBoxOzelKod.Size = new System.Drawing.Size(172, 21);
            this.comboBoxOzelKod.TabIndex = 221;
            // 
            // lblYetkiKodu
            // 
            this.lblYetkiKodu.AutoSize = true;
            this.lblYetkiKodu.BackColor = System.Drawing.Color.Transparent;
            this.lblYetkiKodu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYetkiKodu.Location = new System.Drawing.Point(420, 91);
            this.lblYetkiKodu.Name = "lblYetkiKodu";
            this.lblYetkiKodu.Size = new System.Drawing.Size(65, 15);
            this.lblYetkiKodu.TabIndex = 220;
            this.lblYetkiKodu.Text = "Yetki Kodu";
            // 
            // lblOzelKod
            // 
            this.lblOzelKod.AutoSize = true;
            this.lblOzelKod.BackColor = System.Drawing.Color.Transparent;
            this.lblOzelKod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOzelKod.Location = new System.Drawing.Point(420, 65);
            this.lblOzelKod.Name = "lblOzelKod";
            this.lblOzelKod.Size = new System.Drawing.Size(57, 15);
            this.lblOzelKod.TabIndex = 219;
            this.lblOzelKod.Text = "Özel Kod";
            // 
            // comboBoxIsYeri
            // 
            this.comboBoxIsYeri.FormattingEnabled = true;
            this.comboBoxIsYeri.Location = new System.Drawing.Point(556, 117);
            this.comboBoxIsYeri.Name = "comboBoxIsYeri";
            this.comboBoxIsYeri.Size = new System.Drawing.Size(172, 21);
            this.comboBoxIsYeri.TabIndex = 224;
            // 
            // lblIsYeri
            // 
            this.lblIsYeri.AutoSize = true;
            this.lblIsYeri.BackColor = System.Drawing.Color.Transparent;
            this.lblIsYeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblIsYeri.Location = new System.Drawing.Point(420, 117);
            this.lblIsYeri.Name = "lblIsYeri";
            this.lblIsYeri.Size = new System.Drawing.Size(40, 15);
            this.lblIsYeri.TabIndex = 223;
            this.lblIsYeri.Text = "İş Yeri";
            // 
            // comboBoxFisTuru
            // 
            this.comboBoxFisTuru.FormattingEnabled = true;
            this.comboBoxFisTuru.Items.AddRange(new object[] {
            "(11) CH Ödeme",
            "(12) CH Tahsilat"});
            this.comboBoxFisTuru.Location = new System.Drawing.Point(556, 170);
            this.comboBoxFisTuru.Name = "comboBoxFisTuru";
            this.comboBoxFisTuru.Size = new System.Drawing.Size(172, 21);
            this.comboBoxFisTuru.TabIndex = 228;
            this.comboBoxFisTuru.Text = "(11) CH Ödeme";
            // 
            // lblFisTuru
            // 
            this.lblFisTuru.AutoSize = true;
            this.lblFisTuru.BackColor = System.Drawing.Color.Transparent;
            this.lblFisTuru.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFisTuru.Location = new System.Drawing.Point(420, 170);
            this.lblFisTuru.Name = "lblFisTuru";
            this.lblFisTuru.Size = new System.Drawing.Size(51, 15);
            this.lblFisTuru.TabIndex = 227;
            this.lblFisTuru.Text = "Fiş Türü";
            // 
            // comboBoxSatisElemaniKodu
            // 
            this.comboBoxSatisElemaniKodu.FormattingEnabled = true;
            this.comboBoxSatisElemaniKodu.Location = new System.Drawing.Point(556, 143);
            this.comboBoxSatisElemaniKodu.Name = "comboBoxSatisElemaniKodu";
            this.comboBoxSatisElemaniKodu.Size = new System.Drawing.Size(172, 21);
            this.comboBoxSatisElemaniKodu.TabIndex = 226;
            // 
            // lblSatisElemaniKodu
            // 
            this.lblSatisElemaniKodu.AutoSize = true;
            this.lblSatisElemaniKodu.BackColor = System.Drawing.Color.Transparent;
            this.lblSatisElemaniKodu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSatisElemaniKodu.Location = new System.Drawing.Point(420, 144);
            this.lblSatisElemaniKodu.Name = "lblSatisElemaniKodu";
            this.lblSatisElemaniKodu.Size = new System.Drawing.Size(115, 15);
            this.lblSatisElemaniKodu.TabIndex = 225;
            this.lblSatisElemaniKodu.Text = "Satış Elemanı Kodu";
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
            this.btnVazgec.Location = new System.Drawing.Point(630, 406);
            this.btnVazgec.Name = "btnVazgec";
            this.btnVazgec.Normalcolor = System.Drawing.Color.DarkKhaki;
            this.btnVazgec.OnHovercolor = System.Drawing.Color.Khaki;
            this.btnVazgec.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnVazgec.selected = false;
            this.btnVazgec.Size = new System.Drawing.Size(98, 31);
            this.btnVazgec.TabIndex = 230;
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
            this.btnKaydet.Location = new System.Drawing.Point(526, 406);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Normalcolor = System.Drawing.Color.DarkKhaki;
            this.btnKaydet.OnHovercolor = System.Drawing.Color.Khaki;
            this.btnKaydet.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnKaydet.selected = false;
            this.btnKaydet.Size = new System.Drawing.Size(98, 31);
            this.btnKaydet.TabIndex = 229;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnKaydet.Textcolor = System.Drawing.Color.Black;
            this.btnKaydet.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // lblTicariIslemGrubu
            // 
            this.lblTicariIslemGrubu.AutoSize = true;
            this.lblTicariIslemGrubu.BackColor = System.Drawing.Color.Transparent;
            this.lblTicariIslemGrubu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTicariIslemGrubu.Location = new System.Drawing.Point(13, 241);
            this.lblTicariIslemGrubu.Name = "lblTicariIslemGrubu";
            this.lblTicariIslemGrubu.Size = new System.Drawing.Size(107, 15);
            this.lblTicariIslemGrubu.TabIndex = 235;
            this.lblTicariIslemGrubu.Text = "Ticari İşlem Grubu";
            // 
            // btnCariHesapKodu
            // 
            this.btnCariHesapKodu.Activecolor = System.Drawing.Color.Khaki;
            this.btnCariHesapKodu.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnCariHesapKodu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCariHesapKodu.BorderRadius = 0;
            this.btnCariHesapKodu.ButtonText = "...";
            this.btnCariHesapKodu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCariHesapKodu.DisabledColor = System.Drawing.Color.Gray;
            this.btnCariHesapKodu.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCariHesapKodu.Iconimage = null;
            this.btnCariHesapKodu.Iconimage_right = null;
            this.btnCariHesapKodu.Iconimage_right_Selected = null;
            this.btnCariHesapKodu.Iconimage_Selected = null;
            this.btnCariHesapKodu.IconMarginLeft = 0;
            this.btnCariHesapKodu.IconMarginRight = 0;
            this.btnCariHesapKodu.IconRightVisible = true;
            this.btnCariHesapKodu.IconRightZoom = 0D;
            this.btnCariHesapKodu.IconVisible = true;
            this.btnCariHesapKodu.IconZoom = 90D;
            this.btnCariHesapKodu.IsTab = false;
            this.btnCariHesapKodu.Location = new System.Drawing.Point(320, 214);
            this.btnCariHesapKodu.Name = "btnCariHesapKodu";
            this.btnCariHesapKodu.Normalcolor = System.Drawing.Color.DarkKhaki;
            this.btnCariHesapKodu.OnHovercolor = System.Drawing.Color.Khaki;
            this.btnCariHesapKodu.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnCariHesapKodu.selected = false;
            this.btnCariHesapKodu.Size = new System.Drawing.Size(23, 20);
            this.btnCariHesapKodu.TabIndex = 233;
            this.btnCariHesapKodu.Text = "...";
            this.btnCariHesapKodu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCariHesapKodu.Textcolor = System.Drawing.Color.Black;
            this.btnCariHesapKodu.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // lblCariHesapKodu
            // 
            this.lblCariHesapKodu.AutoSize = true;
            this.lblCariHesapKodu.BackColor = System.Drawing.Color.Transparent;
            this.lblCariHesapKodu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCariHesapKodu.Location = new System.Drawing.Point(13, 214);
            this.lblCariHesapKodu.Name = "lblCariHesapKodu";
            this.lblCariHesapKodu.Size = new System.Drawing.Size(100, 15);
            this.lblCariHesapKodu.TabIndex = 232;
            this.lblCariHesapKodu.Text = "Cari Hesap Kodu";
            // 
            // txtCariHesapKodu
            // 
            this.txtCariHesapKodu.Location = new System.Drawing.Point(144, 213);
            this.txtCariHesapKodu.Multiline = true;
            this.txtCariHesapKodu.Name = "txtCariHesapKodu";
            this.txtCariHesapKodu.Size = new System.Drawing.Size(199, 21);
            this.txtCariHesapKodu.TabIndex = 231;
            // 
            // lblKasaAciklamasi
            // 
            this.lblKasaAciklamasi.AutoSize = true;
            this.lblKasaAciklamasi.BackColor = System.Drawing.Color.Transparent;
            this.lblKasaAciklamasi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKasaAciklamasi.Location = new System.Drawing.Point(13, 278);
            this.lblKasaAciklamasi.Name = "lblKasaAciklamasi";
            this.lblKasaAciklamasi.Size = new System.Drawing.Size(112, 15);
            this.lblKasaAciklamasi.TabIndex = 238;
            this.lblKasaAciklamasi.Text = "Kasa Açıklaması";
            // 
            // txtKasaAciklamasi
            // 
            this.txtKasaAciklamasi.Location = new System.Drawing.Point(14, 304);
            this.txtKasaAciklamasi.Multiline = true;
            this.txtKasaAciklamasi.Name = "txtKasaAciklamasi";
            this.txtKasaAciklamasi.Size = new System.Drawing.Size(327, 92);
            this.txtKasaAciklamasi.TabIndex = 237;
            // 
            // comboBoxDoviz
            // 
            this.comboBoxDoviz.FormattingEnabled = true;
            this.comboBoxDoviz.Items.AddRange(new object[] {
            "CH Ödeme",
            "CH Tahsilat"});
            this.comboBoxDoviz.Location = new System.Drawing.Point(556, 214);
            this.comboBoxDoviz.Name = "comboBoxDoviz";
            this.comboBoxDoviz.Size = new System.Drawing.Size(100, 21);
            this.comboBoxDoviz.TabIndex = 240;
            // 
            // lblDoviz
            // 
            this.lblDoviz.AutoSize = true;
            this.lblDoviz.BackColor = System.Drawing.Color.Transparent;
            this.lblDoviz.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDoviz.Location = new System.Drawing.Point(420, 214);
            this.lblDoviz.Name = "lblDoviz";
            this.lblDoviz.Size = new System.Drawing.Size(37, 15);
            this.lblDoviz.TabIndex = 239;
            this.lblDoviz.Text = "Döviz";
            // 
            // lblKur
            // 
            this.lblKur.AutoSize = true;
            this.lblKur.BackColor = System.Drawing.Color.Transparent;
            this.lblKur.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKur.Location = new System.Drawing.Point(420, 241);
            this.lblKur.Name = "lblKur";
            this.lblKur.Size = new System.Drawing.Size(26, 15);
            this.lblKur.TabIndex = 241;
            this.lblKur.Text = "Kur";
            // 
            // lblDovizliTutar
            // 
            this.lblDovizliTutar.AutoSize = true;
            this.lblDovizliTutar.BackColor = System.Drawing.Color.Transparent;
            this.lblDovizliTutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDovizliTutar.Location = new System.Drawing.Point(420, 295);
            this.lblDovizliTutar.Name = "lblDovizliTutar";
            this.lblDovizliTutar.Size = new System.Drawing.Size(74, 15);
            this.lblDovizliTutar.TabIndex = 245;
            this.lblDovizliTutar.Text = "Dövizli Tutar";
            // 
            // lblTutar
            // 
            this.lblTutar.AutoSize = true;
            this.lblTutar.BackColor = System.Drawing.Color.Transparent;
            this.lblTutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTutar.Location = new System.Drawing.Point(420, 268);
            this.lblTutar.Name = "lblTutar";
            this.lblTutar.Size = new System.Drawing.Size(35, 15);
            this.lblTutar.TabIndex = 243;
            this.lblTutar.Text = "Tutar";
            // 
            // txtKur
            // 
            this.txtKur.Location = new System.Drawing.Point(556, 240);
            this.txtKur.Multiline = true;
            this.txtKur.Name = "txtKur";
            this.txtKur.Size = new System.Drawing.Size(172, 21);
            this.txtKur.TabIndex = 247;
            // 
            // txtDovizliTutar
            // 
            this.txtDovizliTutar.Location = new System.Drawing.Point(555, 293);
            this.txtDovizliTutar.Multiline = true;
            this.txtDovizliTutar.Name = "txtDovizliTutar";
            this.txtDovizliTutar.Size = new System.Drawing.Size(172, 21);
            this.txtDovizliTutar.TabIndex = 249;
            // 
            // txtTutar
            // 
            this.txtTutar.Location = new System.Drawing.Point(556, 267);
            this.txtTutar.Multiline = true;
            this.txtTutar.Name = "txtTutar";
            this.txtTutar.Size = new System.Drawing.Size(172, 21);
            this.txtTutar.TabIndex = 248;
            // 
            // txtTicIslemGrb
            // 
            this.txtTicIslemGrb.Location = new System.Drawing.Point(143, 240);
            this.txtTicIslemGrb.Name = "txtTicIslemGrb";
            this.txtTicIslemGrb.Size = new System.Drawing.Size(198, 20);
            this.txtTicIslemGrb.TabIndex = 250;
            // 
            // frmFinans_KasaIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.BackgroundImage = global::BeeOne.Properties.Resources.background__39_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(755, 465);
            this.Controls.Add(this.txtTicIslemGrb);
            this.Controls.Add(this.txtDovizliTutar);
            this.Controls.Add(this.txtTutar);
            this.Controls.Add(this.txtKur);
            this.Controls.Add(this.lblDovizliTutar);
            this.Controls.Add(this.lblTutar);
            this.Controls.Add(this.lblKur);
            this.Controls.Add(this.comboBoxDoviz);
            this.Controls.Add(this.lblDoviz);
            this.Controls.Add(this.lblKasaAciklamasi);
            this.Controls.Add(this.txtKasaAciklamasi);
            this.Controls.Add(this.lblTicariIslemGrubu);
            this.Controls.Add(this.btnCariHesapKodu);
            this.Controls.Add(this.lblCariHesapKodu);
            this.Controls.Add(this.txtCariHesapKodu);
            this.Controls.Add(this.btnVazgec);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.comboBoxFisTuru);
            this.Controls.Add(this.lblFisTuru);
            this.Controls.Add(this.comboBoxSatisElemaniKodu);
            this.Controls.Add(this.lblSatisElemaniKodu);
            this.Controls.Add(this.comboBoxIsYeri);
            this.Controls.Add(this.lblIsYeri);
            this.Controls.Add(this.comboBoxYetkiKodu);
            this.Controls.Add(this.comboBoxOzelKod);
            this.Controls.Add(this.lblYetkiKodu);
            this.Controls.Add(this.lblOzelKod);
            this.Controls.Add(this.btnDuzenlenmeTarihi);
            this.Controls.Add(this.lblDuzenlenmeTarihi);
            this.Controls.Add(this.txtDuzenlenmeTarihi);
            this.Controls.Add(this.btnTarih);
            this.Controls.Add(this.lblTarih);
            this.Controls.Add(this.txtTarih);
            this.Controls.Add(this.lblMakbuzNo);
            this.Controls.Add(this.txtMakbuzNo);
            this.Controls.Add(this.lblIslemNo);
            this.Controls.Add(this.txtIslemNo);
            this.Controls.Add(this.btnKasaKodu);
            this.Controls.Add(this.lblKasaKodu);
            this.Controls.Add(this.txtKasaKodu);
            this.Controls.Add(this.pnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmFinans_KasaIslemleri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Finans > Kasa İşlemleri";
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblFinans;
        private Bunifu.Framework.UI.BunifuImageButton btnClose;
        private Bunifu.Framework.UI.BunifuImageButton btnMinimize;
        private Bunifu.Framework.UI.BunifuFlatButton btnKasaKodu;
        private System.Windows.Forms.Label lblKasaKodu;
        private System.Windows.Forms.TextBox txtKasaKodu;
        private System.Windows.Forms.Label lblIslemNo;
        private System.Windows.Forms.TextBox txtIslemNo;
        private System.Windows.Forms.Label lblMakbuzNo;
        private System.Windows.Forms.TextBox txtMakbuzNo;
        private Bunifu.Framework.UI.BunifuFlatButton btnTarih;
        private System.Windows.Forms.Label lblTarih;
        private System.Windows.Forms.TextBox txtTarih;
        private Bunifu.Framework.UI.BunifuFlatButton btnDuzenlenmeTarihi;
        private System.Windows.Forms.Label lblDuzenlenmeTarihi;
        private System.Windows.Forms.TextBox txtDuzenlenmeTarihi;
        private System.Windows.Forms.ComboBox comboBoxYetkiKodu;
        private System.Windows.Forms.ComboBox comboBoxOzelKod;
        private System.Windows.Forms.Label lblYetkiKodu;
        private System.Windows.Forms.Label lblOzelKod;
        private System.Windows.Forms.ComboBox comboBoxIsYeri;
        private System.Windows.Forms.Label lblIsYeri;
        private System.Windows.Forms.ComboBox comboBoxFisTuru;
        private System.Windows.Forms.Label lblFisTuru;
        private System.Windows.Forms.ComboBox comboBoxSatisElemaniKodu;
        private System.Windows.Forms.Label lblSatisElemaniKodu;
        private Bunifu.Framework.UI.BunifuFlatButton btnVazgec;
        private Bunifu.Framework.UI.BunifuFlatButton btnKaydet;
        private System.Windows.Forms.Label lblTicariIslemGrubu;
        private Bunifu.Framework.UI.BunifuFlatButton btnCariHesapKodu;
        private System.Windows.Forms.Label lblCariHesapKodu;
        private System.Windows.Forms.TextBox txtCariHesapKodu;
        private System.Windows.Forms.Label lblKasaAciklamasi;
        private System.Windows.Forms.TextBox txtKasaAciklamasi;
        private System.Windows.Forms.ComboBox comboBoxDoviz;
        private System.Windows.Forms.Label lblDoviz;
        private System.Windows.Forms.Label lblKur;
        private System.Windows.Forms.Label lblDovizliTutar;
        private System.Windows.Forms.Label lblTutar;
        private System.Windows.Forms.TextBox txtKur;
        private System.Windows.Forms.TextBox txtDovizliTutar;
        private System.Windows.Forms.TextBox txtTutar;
        private System.Windows.Forms.TextBox txtTicIslemGrb;
    }
}