
namespace BeeOne
{
    partial class frmMuhasebe_MuhasebeFisleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMuhasebe_MuhasebeFisleri));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblMuhasebe = new System.Windows.Forms.Label();
            this.btnClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnMinimize = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnTarih = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lblDuzenlemeTarihi = new System.Windows.Forms.Label();
            this.lblTarih = new System.Windows.Forms.Label();
            this.lblFisNo = new System.Windows.Forms.Label();
            this.txtDuzenlemeTarihi = new System.Windows.Forms.TextBox();
            this.txtTarih = new System.Windows.Forms.TextBox();
            this.txtFisNo = new System.Windows.Forms.TextBox();
            this.btnDuzenlemeTarihi = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lblBelgeNo = new System.Windows.Forms.Label();
            this.lblYevNo = new System.Windows.Forms.Label();
            this.txtBelgeNo = new System.Windows.Forms.TextBox();
            this.txtYevNo = new System.Windows.Forms.TextBox();
            this.comboBoxYetkiKodu = new System.Windows.Forms.ComboBox();
            this.comboBoxOzelKod = new System.Windows.Forms.ComboBox();
            this.lblYetkiKodu = new System.Windows.Forms.Label();
            this.lblOzelKod = new System.Windows.Forms.Label();
            this.btnProjeKodu = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lblProjeKodu = new System.Windows.Forms.Label();
            this.txtProjeKodu = new System.Windows.Forms.TextBox();
            this.comboBoxIsYeri = new System.Windows.Forms.ComboBox();
            this.lblIsYeri = new System.Windows.Forms.Label();
            this.dataGridViewFis = new System.Windows.Forms.DataGridView();
            this.MuhHesKodu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HesapAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Aciklama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Borc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Alacak = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DovBorc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DovAlacak = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MasrafMerk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Miktar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FaturaNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHUnvan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHKodu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MuhAnaHes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTLToplamAlacak = new System.Windows.Forms.TextBox();
            this.txtDovizToplamAlacak = new System.Windows.Forms.TextBox();
            this.txtDovizToplamBorc = new System.Windows.Forms.TextBox();
            this.txtTLToplamBorc = new System.Windows.Forms.TextBox();
            this.lblYerelParaBirimi = new System.Windows.Forms.Label();
            this.btnVazgec = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnKaydet = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lblDetayliBilgi = new System.Windows.Forms.Label();
            this.txtDetayliBilgi = new System.Windows.Forms.TextBox();
            this.lblKurTuru = new System.Windows.Forms.Label();
            this.cbxKurTuru = new System.Windows.Forms.ComboBox();
            this.tbxKur = new System.Windows.Forms.TextBox();
            this.lblKur = new System.Windows.Forms.Label();
            this.lblislemdovizli = new System.Windows.Forms.Label();
            this.lblToplamAlacak = new System.Windows.Forms.Label();
            this.lblToplamBorc = new System.Windows.Forms.Label();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFis)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.lblMuhasebe);
            this.pnlTop.Controls.Add(this.btnClose);
            this.pnlTop.Controls.Add(this.btnMinimize);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1222, 48);
            this.pnlTop.TabIndex = 12;
            this.pnlTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTop_MouseDown);
            this.pnlTop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlTop_MouseMove);
            this.pnlTop.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlTop_MouseUp);
            // 
            // lblMuhasebe
            // 
            this.lblMuhasebe.AutoSize = true;
            this.lblMuhasebe.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMuhasebe.ForeColor = System.Drawing.Color.DarkKhaki;
            this.lblMuhasebe.Location = new System.Drawing.Point(12, 13);
            this.lblMuhasebe.Name = "lblMuhasebe";
            this.lblMuhasebe.Size = new System.Drawing.Size(261, 21);
            this.lblMuhasebe.TabIndex = 7;
            this.lblMuhasebe.Text = "MUHASEBE > MUHASEBE FİŞLERİ";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageActive = null;
            this.btnClose.Location = new System.Drawing.Point(1192, 10);
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
            this.btnMinimize.Location = new System.Drawing.Point(1166, 10);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(20, 27);
            this.btnMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimize.TabIndex = 5;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.Zoom = 10;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
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
            this.btnTarih.Location = new System.Drawing.Point(350, 88);
            this.btnTarih.Name = "btnTarih";
            this.btnTarih.Normalcolor = System.Drawing.Color.DarkKhaki;
            this.btnTarih.OnHovercolor = System.Drawing.Color.Khaki;
            this.btnTarih.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnTarih.selected = false;
            this.btnTarih.Size = new System.Drawing.Size(23, 20);
            this.btnTarih.TabIndex = 120;
            this.btnTarih.Text = "...";
            this.btnTarih.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnTarih.Textcolor = System.Drawing.Color.Black;
            this.btnTarih.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // lblDuzenlemeTarihi
            // 
            this.lblDuzenlemeTarihi.AutoSize = true;
            this.lblDuzenlemeTarihi.BackColor = System.Drawing.Color.Transparent;
            this.lblDuzenlemeTarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDuzenlemeTarihi.Location = new System.Drawing.Point(34, 113);
            this.lblDuzenlemeTarihi.Name = "lblDuzenlemeTarihi";
            this.lblDuzenlemeTarihi.Size = new System.Drawing.Size(105, 15);
            this.lblDuzenlemeTarihi.TabIndex = 119;
            this.lblDuzenlemeTarihi.Text = "Düzenleme Tarihi";
            // 
            // lblTarih
            // 
            this.lblTarih.AutoSize = true;
            this.lblTarih.BackColor = System.Drawing.Color.Transparent;
            this.lblTarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTarih.Location = new System.Drawing.Point(34, 89);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(35, 15);
            this.lblTarih.TabIndex = 118;
            this.lblTarih.Text = "Tarih";
            // 
            // lblFisNo
            // 
            this.lblFisNo.AutoSize = true;
            this.lblFisNo.BackColor = System.Drawing.Color.Transparent;
            this.lblFisNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFisNo.Location = new System.Drawing.Point(34, 64);
            this.lblFisNo.Name = "lblFisNo";
            this.lblFisNo.Size = new System.Drawing.Size(45, 15);
            this.lblFisNo.TabIndex = 117;
            this.lblFisNo.Text = "Fiş No.";
            // 
            // txtDuzenlemeTarihi
            // 
            this.txtDuzenlemeTarihi.Location = new System.Drawing.Point(174, 112);
            this.txtDuzenlemeTarihi.Multiline = true;
            this.txtDuzenlemeTarihi.Name = "txtDuzenlemeTarihi";
            this.txtDuzenlemeTarihi.Size = new System.Drawing.Size(199, 21);
            this.txtDuzenlemeTarihi.TabIndex = 116;
            // 
            // txtTarih
            // 
            this.txtTarih.Location = new System.Drawing.Point(174, 87);
            this.txtTarih.Multiline = true;
            this.txtTarih.Name = "txtTarih";
            this.txtTarih.Size = new System.Drawing.Size(199, 21);
            this.txtTarih.TabIndex = 115;
            // 
            // txtFisNo
            // 
            this.txtFisNo.Location = new System.Drawing.Point(174, 63);
            this.txtFisNo.Multiline = true;
            this.txtFisNo.Name = "txtFisNo";
            this.txtFisNo.Size = new System.Drawing.Size(320, 21);
            this.txtFisNo.TabIndex = 114;
            // 
            // btnDuzenlemeTarihi
            // 
            this.btnDuzenlemeTarihi.Activecolor = System.Drawing.Color.Khaki;
            this.btnDuzenlemeTarihi.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnDuzenlemeTarihi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDuzenlemeTarihi.BorderRadius = 0;
            this.btnDuzenlemeTarihi.ButtonText = "...";
            this.btnDuzenlemeTarihi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDuzenlemeTarihi.DisabledColor = System.Drawing.Color.Gray;
            this.btnDuzenlemeTarihi.Iconcolor = System.Drawing.Color.Transparent;
            this.btnDuzenlemeTarihi.Iconimage = null;
            this.btnDuzenlemeTarihi.Iconimage_right = null;
            this.btnDuzenlemeTarihi.Iconimage_right_Selected = null;
            this.btnDuzenlemeTarihi.Iconimage_Selected = null;
            this.btnDuzenlemeTarihi.IconMarginLeft = 0;
            this.btnDuzenlemeTarihi.IconMarginRight = 0;
            this.btnDuzenlemeTarihi.IconRightVisible = true;
            this.btnDuzenlemeTarihi.IconRightZoom = 0D;
            this.btnDuzenlemeTarihi.IconVisible = true;
            this.btnDuzenlemeTarihi.IconZoom = 90D;
            this.btnDuzenlemeTarihi.IsTab = false;
            this.btnDuzenlemeTarihi.Location = new System.Drawing.Point(350, 113);
            this.btnDuzenlemeTarihi.Name = "btnDuzenlemeTarihi";
            this.btnDuzenlemeTarihi.Normalcolor = System.Drawing.Color.DarkKhaki;
            this.btnDuzenlemeTarihi.OnHovercolor = System.Drawing.Color.Khaki;
            this.btnDuzenlemeTarihi.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnDuzenlemeTarihi.selected = false;
            this.btnDuzenlemeTarihi.Size = new System.Drawing.Size(23, 20);
            this.btnDuzenlemeTarihi.TabIndex = 121;
            this.btnDuzenlemeTarihi.Text = "...";
            this.btnDuzenlemeTarihi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDuzenlemeTarihi.Textcolor = System.Drawing.Color.Black;
            this.btnDuzenlemeTarihi.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // lblBelgeNo
            // 
            this.lblBelgeNo.AutoSize = true;
            this.lblBelgeNo.BackColor = System.Drawing.Color.Transparent;
            this.lblBelgeNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBelgeNo.Location = new System.Drawing.Point(592, 89);
            this.lblBelgeNo.Name = "lblBelgeNo";
            this.lblBelgeNo.Size = new System.Drawing.Size(61, 15);
            this.lblBelgeNo.TabIndex = 125;
            this.lblBelgeNo.Text = "Belge No.";
            // 
            // lblYevNo
            // 
            this.lblYevNo.AutoSize = true;
            this.lblYevNo.BackColor = System.Drawing.Color.Transparent;
            this.lblYevNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYevNo.Location = new System.Drawing.Point(592, 64);
            this.lblYevNo.Name = "lblYevNo";
            this.lblYevNo.Size = new System.Drawing.Size(48, 15);
            this.lblYevNo.TabIndex = 124;
            this.lblYevNo.Text = "Yev No.";
            // 
            // txtBelgeNo
            // 
            this.txtBelgeNo.Location = new System.Drawing.Point(676, 88);
            this.txtBelgeNo.Multiline = true;
            this.txtBelgeNo.Name = "txtBelgeNo";
            this.txtBelgeNo.Size = new System.Drawing.Size(160, 21);
            this.txtBelgeNo.TabIndex = 123;
            // 
            // txtYevNo
            // 
            this.txtYevNo.Enabled = false;
            this.txtYevNo.Location = new System.Drawing.Point(676, 64);
            this.txtYevNo.Multiline = true;
            this.txtYevNo.Name = "txtYevNo";
            this.txtYevNo.Size = new System.Drawing.Size(160, 21);
            this.txtYevNo.TabIndex = 122;
            // 
            // comboBoxYetkiKodu
            // 
            this.comboBoxYetkiKodu.FormattingEnabled = true;
            this.comboBoxYetkiKodu.Location = new System.Drawing.Point(951, 89);
            this.comboBoxYetkiKodu.Name = "comboBoxYetkiKodu";
            this.comboBoxYetkiKodu.Size = new System.Drawing.Size(172, 21);
            this.comboBoxYetkiKodu.TabIndex = 129;
            // 
            // comboBoxOzelKod
            // 
            this.comboBoxOzelKod.FormattingEnabled = true;
            this.comboBoxOzelKod.Location = new System.Drawing.Point(951, 64);
            this.comboBoxOzelKod.Name = "comboBoxOzelKod";
            this.comboBoxOzelKod.Size = new System.Drawing.Size(172, 21);
            this.comboBoxOzelKod.TabIndex = 128;
            // 
            // lblYetkiKodu
            // 
            this.lblYetkiKodu.AutoSize = true;
            this.lblYetkiKodu.BackColor = System.Drawing.Color.Transparent;
            this.lblYetkiKodu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYetkiKodu.Location = new System.Drawing.Point(863, 91);
            this.lblYetkiKodu.Name = "lblYetkiKodu";
            this.lblYetkiKodu.Size = new System.Drawing.Size(65, 15);
            this.lblYetkiKodu.TabIndex = 127;
            this.lblYetkiKodu.Text = "Yetki Kodu";
            // 
            // lblOzelKod
            // 
            this.lblOzelKod.AutoSize = true;
            this.lblOzelKod.BackColor = System.Drawing.Color.Transparent;
            this.lblOzelKod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOzelKod.Location = new System.Drawing.Point(863, 66);
            this.lblOzelKod.Name = "lblOzelKod";
            this.lblOzelKod.Size = new System.Drawing.Size(57, 15);
            this.lblOzelKod.TabIndex = 126;
            this.lblOzelKod.Text = "Özel Kod";
            // 
            // btnProjeKodu
            // 
            this.btnProjeKodu.Activecolor = System.Drawing.Color.Khaki;
            this.btnProjeKodu.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnProjeKodu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnProjeKodu.BorderRadius = 0;
            this.btnProjeKodu.ButtonText = "...";
            this.btnProjeKodu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProjeKodu.DisabledColor = System.Drawing.Color.Gray;
            this.btnProjeKodu.Iconcolor = System.Drawing.Color.Transparent;
            this.btnProjeKodu.Iconimage = null;
            this.btnProjeKodu.Iconimage_right = null;
            this.btnProjeKodu.Iconimage_right_Selected = null;
            this.btnProjeKodu.Iconimage_Selected = null;
            this.btnProjeKodu.IconMarginLeft = 0;
            this.btnProjeKodu.IconMarginRight = 0;
            this.btnProjeKodu.IconRightVisible = true;
            this.btnProjeKodu.IconRightZoom = 0D;
            this.btnProjeKodu.IconVisible = true;
            this.btnProjeKodu.IconZoom = 90D;
            this.btnProjeKodu.IsTab = false;
            this.btnProjeKodu.Location = new System.Drawing.Point(1100, 116);
            this.btnProjeKodu.Name = "btnProjeKodu";
            this.btnProjeKodu.Normalcolor = System.Drawing.Color.DarkKhaki;
            this.btnProjeKodu.OnHovercolor = System.Drawing.Color.Khaki;
            this.btnProjeKodu.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnProjeKodu.selected = false;
            this.btnProjeKodu.Size = new System.Drawing.Size(23, 20);
            this.btnProjeKodu.TabIndex = 132;
            this.btnProjeKodu.Text = "...";
            this.btnProjeKodu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnProjeKodu.Textcolor = System.Drawing.Color.Black;
            this.btnProjeKodu.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // lblProjeKodu
            // 
            this.lblProjeKodu.AutoSize = true;
            this.lblProjeKodu.BackColor = System.Drawing.Color.Transparent;
            this.lblProjeKodu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblProjeKodu.Location = new System.Drawing.Point(863, 117);
            this.lblProjeKodu.Name = "lblProjeKodu";
            this.lblProjeKodu.Size = new System.Drawing.Size(68, 15);
            this.lblProjeKodu.TabIndex = 131;
            this.lblProjeKodu.Text = "Proje Kodu";
            // 
            // txtProjeKodu
            // 
            this.txtProjeKodu.Location = new System.Drawing.Point(951, 115);
            this.txtProjeKodu.Multiline = true;
            this.txtProjeKodu.Name = "txtProjeKodu";
            this.txtProjeKodu.Size = new System.Drawing.Size(172, 21);
            this.txtProjeKodu.TabIndex = 130;
            // 
            // comboBoxIsYeri
            // 
            this.comboBoxIsYeri.FormattingEnabled = true;
            this.comboBoxIsYeri.Location = new System.Drawing.Point(676, 115);
            this.comboBoxIsYeri.Name = "comboBoxIsYeri";
            this.comboBoxIsYeri.Size = new System.Drawing.Size(160, 21);
            this.comboBoxIsYeri.TabIndex = 134;
            // 
            // lblIsYeri
            // 
            this.lblIsYeri.AutoSize = true;
            this.lblIsYeri.BackColor = System.Drawing.Color.Transparent;
            this.lblIsYeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblIsYeri.Location = new System.Drawing.Point(592, 117);
            this.lblIsYeri.Name = "lblIsYeri";
            this.lblIsYeri.Size = new System.Drawing.Size(40, 15);
            this.lblIsYeri.TabIndex = 133;
            this.lblIsYeri.Text = "İş Yeri";
            // 
            // dataGridViewFis
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewFis.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewFis.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewFis.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewFis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFis.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MuhHesKodu,
            this.HesapAdi,
            this.Aciklama,
            this.Borc,
            this.Alacak,
            this.DovBorc,
            this.DovAlacak,
            this.MasrafMerk,
            this.Miktar,
            this.FaturaNo,
            this.CHUnvan,
            this.CHKodu,
            this.MuhAnaHes});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(0, 6, 0, 6);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewFis.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewFis.Location = new System.Drawing.Point(37, 159);
            this.dataGridViewFis.Name = "dataGridViewFis";
            this.dataGridViewFis.ReadOnly = true;
            this.dataGridViewFis.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.dataGridViewFis.RowTemplate.Height = 40;
            this.dataGridViewFis.Size = new System.Drawing.Size(1143, 369);
            this.dataGridViewFis.TabIndex = 135;
            // 
            // MuhHesKodu
            // 
            this.MuhHesKodu.HeaderText = "Hesap Kodu";
            this.MuhHesKodu.Name = "MuhHesKodu";
            this.MuhHesKodu.ReadOnly = true;
            // 
            // HesapAdi
            // 
            this.HesapAdi.HeaderText = "Hesap Adı";
            this.HesapAdi.Name = "HesapAdi";
            this.HesapAdi.ReadOnly = true;
            // 
            // Aciklama
            // 
            this.Aciklama.HeaderText = "Açıklama";
            this.Aciklama.Name = "Aciklama";
            this.Aciklama.ReadOnly = true;
            // 
            // Borc
            // 
            this.Borc.HeaderText = "Borç";
            this.Borc.Name = "Borc";
            this.Borc.ReadOnly = true;
            // 
            // Alacak
            // 
            this.Alacak.HeaderText = "Alacak";
            this.Alacak.Name = "Alacak";
            this.Alacak.ReadOnly = true;
            // 
            // DovBorc
            // 
            this.DovBorc.HeaderText = "Dövizli Borç";
            this.DovBorc.Name = "DovBorc";
            this.DovBorc.ReadOnly = true;
            // 
            // DovAlacak
            // 
            this.DovAlacak.HeaderText = "Dövizli Alacak";
            this.DovAlacak.Name = "DovAlacak";
            this.DovAlacak.ReadOnly = true;
            // 
            // MasrafMerk
            // 
            this.MasrafMerk.HeaderText = "Masraf Merkezi";
            this.MasrafMerk.Name = "MasrafMerk";
            this.MasrafMerk.ReadOnly = true;
            // 
            // Miktar
            // 
            this.Miktar.HeaderText = "Miktar";
            this.Miktar.Name = "Miktar";
            this.Miktar.ReadOnly = true;
            // 
            // FaturaNo
            // 
            this.FaturaNo.HeaderText = "Fatura No";
            this.FaturaNo.Name = "FaturaNo";
            this.FaturaNo.ReadOnly = true;
            // 
            // CHUnvan
            // 
            this.CHUnvan.HeaderText = "Cari Hesap Unvanı";
            this.CHUnvan.Name = "CHUnvan";
            this.CHUnvan.ReadOnly = true;
            // 
            // CHKodu
            // 
            this.CHKodu.HeaderText = "Cari Hesap Kodu";
            this.CHKodu.Name = "CHKodu";
            this.CHKodu.ReadOnly = true;
            // 
            // MuhAnaHes
            // 
            this.MuhAnaHes.HeaderText = "Ana Muhasebe Hesabı (Kebir Kodu)";
            this.MuhAnaHes.Name = "MuhAnaHes";
            this.MuhAnaHes.ReadOnly = true;
            // 
            // txtTLToplamAlacak
            // 
            this.txtTLToplamAlacak.Location = new System.Drawing.Point(636, 614);
            this.txtTLToplamAlacak.Multiline = true;
            this.txtTLToplamAlacak.Name = "txtTLToplamAlacak";
            this.txtTLToplamAlacak.Size = new System.Drawing.Size(207, 21);
            this.txtTLToplamAlacak.TabIndex = 160;
            // 
            // txtDovizToplamAlacak
            // 
            this.txtDovizToplamAlacak.Location = new System.Drawing.Point(864, 614);
            this.txtDovizToplamAlacak.Multiline = true;
            this.txtDovizToplamAlacak.Name = "txtDovizToplamAlacak";
            this.txtDovizToplamAlacak.Size = new System.Drawing.Size(207, 21);
            this.txtDovizToplamAlacak.TabIndex = 159;
            // 
            // txtDovizToplamBorc
            // 
            this.txtDovizToplamBorc.Location = new System.Drawing.Point(864, 590);
            this.txtDovizToplamBorc.Multiline = true;
            this.txtDovizToplamBorc.Name = "txtDovizToplamBorc";
            this.txtDovizToplamBorc.Size = new System.Drawing.Size(207, 21);
            this.txtDovizToplamBorc.TabIndex = 158;
            // 
            // txtTLToplamBorc
            // 
            this.txtTLToplamBorc.Location = new System.Drawing.Point(636, 590);
            this.txtTLToplamBorc.Multiline = true;
            this.txtTLToplamBorc.Name = "txtTLToplamBorc";
            this.txtTLToplamBorc.Size = new System.Drawing.Size(207, 21);
            this.txtTLToplamBorc.TabIndex = 157;
            // 
            // lblYerelParaBirimi
            // 
            this.lblYerelParaBirimi.AutoSize = true;
            this.lblYerelParaBirimi.BackColor = System.Drawing.Color.Transparent;
            this.lblYerelParaBirimi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYerelParaBirimi.Location = new System.Drawing.Point(684, 567);
            this.lblYerelParaBirimi.Name = "lblYerelParaBirimi";
            this.lblYerelParaBirimi.Size = new System.Drawing.Size(100, 13);
            this.lblYerelParaBirimi.TabIndex = 154;
            this.lblYerelParaBirimi.Text = "Yerel Para Birimi";
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
            this.btnVazgec.Location = new System.Drawing.Point(1082, 664);
            this.btnVazgec.Name = "btnVazgec";
            this.btnVazgec.Normalcolor = System.Drawing.Color.DarkKhaki;
            this.btnVazgec.OnHovercolor = System.Drawing.Color.Khaki;
            this.btnVazgec.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnVazgec.selected = false;
            this.btnVazgec.Size = new System.Drawing.Size(98, 31);
            this.btnVazgec.TabIndex = 153;
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
            this.btnKaydet.Location = new System.Drawing.Point(976, 664);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Normalcolor = System.Drawing.Color.DarkKhaki;
            this.btnKaydet.OnHovercolor = System.Drawing.Color.Khaki;
            this.btnKaydet.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnKaydet.selected = false;
            this.btnKaydet.Size = new System.Drawing.Size(98, 31);
            this.btnKaydet.TabIndex = 152;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnKaydet.Textcolor = System.Drawing.Color.Black;
            this.btnKaydet.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // lblDetayliBilgi
            // 
            this.lblDetayliBilgi.AutoSize = true;
            this.lblDetayliBilgi.BackColor = System.Drawing.Color.Transparent;
            this.lblDetayliBilgi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDetayliBilgi.Location = new System.Drawing.Point(34, 567);
            this.lblDetayliBilgi.Name = "lblDetayliBilgi";
            this.lblDetayliBilgi.Size = new System.Drawing.Size(92, 16);
            this.lblDetayliBilgi.TabIndex = 161;
            this.lblDetayliBilgi.Text = "Detaylı Bilgi";
            // 
            // txtDetayliBilgi
            // 
            this.txtDetayliBilgi.Location = new System.Drawing.Point(37, 592);
            this.txtDetayliBilgi.Multiline = true;
            this.txtDetayliBilgi.Name = "txtDetayliBilgi";
            this.txtDetayliBilgi.Size = new System.Drawing.Size(437, 43);
            this.txtDetayliBilgi.TabIndex = 162;
            // 
            // lblKurTuru
            // 
            this.lblKurTuru.AutoSize = true;
            this.lblKurTuru.BackColor = System.Drawing.Color.Transparent;
            this.lblKurTuru.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKurTuru.Location = new System.Drawing.Point(378, 92);
            this.lblKurTuru.Name = "lblKurTuru";
            this.lblKurTuru.Size = new System.Drawing.Size(54, 15);
            this.lblKurTuru.TabIndex = 227;
            this.lblKurTuru.Text = "Kur Türü";
            // 
            // cbxKurTuru
            // 
            this.cbxKurTuru.FormattingEnabled = true;
            this.cbxKurTuru.Location = new System.Drawing.Point(449, 90);
            this.cbxKurTuru.Name = "cbxKurTuru";
            this.cbxKurTuru.Size = new System.Drawing.Size(85, 21);
            this.cbxKurTuru.TabIndex = 226;
            // 
            // tbxKur
            // 
            this.tbxKur.Location = new System.Drawing.Point(449, 117);
            this.tbxKur.Multiline = true;
            this.tbxKur.Name = "tbxKur";
            this.tbxKur.Size = new System.Drawing.Size(85, 21);
            this.tbxKur.TabIndex = 225;
            // 
            // lblKur
            // 
            this.lblKur.AutoSize = true;
            this.lblKur.BackColor = System.Drawing.Color.Transparent;
            this.lblKur.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKur.Location = new System.Drawing.Point(406, 118);
            this.lblKur.Name = "lblKur";
            this.lblKur.Size = new System.Drawing.Size(26, 15);
            this.lblKur.TabIndex = 224;
            this.lblKur.Text = "Kur";
            // 
            // lblislemdovizli
            // 
            this.lblislemdovizli.AutoSize = true;
            this.lblislemdovizli.BackColor = System.Drawing.Color.Transparent;
            this.lblislemdovizli.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblislemdovizli.Location = new System.Drawing.Point(928, 565);
            this.lblislemdovizli.Name = "lblislemdovizli";
            this.lblislemdovizli.Size = new System.Drawing.Size(85, 15);
            this.lblislemdovizli.TabIndex = 228;
            this.lblislemdovizli.Text = "İşlem Dövizi";
            // 
            // lblToplamAlacak
            // 
            this.lblToplamAlacak.AutoSize = true;
            this.lblToplamAlacak.BackColor = System.Drawing.Color.Transparent;
            this.lblToplamAlacak.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplamAlacak.Location = new System.Drawing.Point(529, 615);
            this.lblToplamAlacak.Name = "lblToplamAlacak";
            this.lblToplamAlacak.Size = new System.Drawing.Size(101, 15);
            this.lblToplamAlacak.TabIndex = 230;
            this.lblToplamAlacak.Text = "Toplam Alacak";
            // 
            // lblToplamBorc
            // 
            this.lblToplamBorc.AutoSize = true;
            this.lblToplamBorc.BackColor = System.Drawing.Color.Transparent;
            this.lblToplamBorc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplamBorc.Location = new System.Drawing.Point(542, 593);
            this.lblToplamBorc.Name = "lblToplamBorc";
            this.lblToplamBorc.Size = new System.Drawing.Size(88, 15);
            this.lblToplamBorc.TabIndex = 229;
            this.lblToplamBorc.Text = "Toplam Borç";
            // 
            // frmMuhasebe_MuhasebeFisleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.BackgroundImage = global::BeeOne.Properties.Resources.background__39_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1222, 726);
            this.Controls.Add(this.lblToplamAlacak);
            this.Controls.Add(this.lblToplamBorc);
            this.Controls.Add(this.lblislemdovizli);
            this.Controls.Add(this.lblKurTuru);
            this.Controls.Add(this.cbxKurTuru);
            this.Controls.Add(this.tbxKur);
            this.Controls.Add(this.lblKur);
            this.Controls.Add(this.txtDetayliBilgi);
            this.Controls.Add(this.lblDetayliBilgi);
            this.Controls.Add(this.txtTLToplamAlacak);
            this.Controls.Add(this.txtDovizToplamAlacak);
            this.Controls.Add(this.txtDovizToplamBorc);
            this.Controls.Add(this.txtTLToplamBorc);
            this.Controls.Add(this.lblYerelParaBirimi);
            this.Controls.Add(this.btnVazgec);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.dataGridViewFis);
            this.Controls.Add(this.comboBoxIsYeri);
            this.Controls.Add(this.lblIsYeri);
            this.Controls.Add(this.btnProjeKodu);
            this.Controls.Add(this.lblProjeKodu);
            this.Controls.Add(this.txtProjeKodu);
            this.Controls.Add(this.comboBoxYetkiKodu);
            this.Controls.Add(this.comboBoxOzelKod);
            this.Controls.Add(this.lblYetkiKodu);
            this.Controls.Add(this.lblOzelKod);
            this.Controls.Add(this.lblBelgeNo);
            this.Controls.Add(this.lblYevNo);
            this.Controls.Add(this.txtBelgeNo);
            this.Controls.Add(this.txtYevNo);
            this.Controls.Add(this.btnDuzenlemeTarihi);
            this.Controls.Add(this.btnTarih);
            this.Controls.Add(this.lblDuzenlemeTarihi);
            this.Controls.Add(this.lblTarih);
            this.Controls.Add(this.lblFisNo);
            this.Controls.Add(this.txtDuzenlemeTarihi);
            this.Controls.Add(this.txtTarih);
            this.Controls.Add(this.txtFisNo);
            this.Controls.Add(this.pnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMuhasebe_MuhasebeFisleri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Muhasebe > Muhasebe Fişleri";
            this.Load += new System.EventHandler(this.frmMuhasebe_MuhasebeFisleri_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblMuhasebe;
        private Bunifu.Framework.UI.BunifuImageButton btnClose;
        private Bunifu.Framework.UI.BunifuImageButton btnMinimize;
        private Bunifu.Framework.UI.BunifuFlatButton btnTarih;
        private System.Windows.Forms.Label lblDuzenlemeTarihi;
        private System.Windows.Forms.Label lblTarih;
        private System.Windows.Forms.Label lblFisNo;
        private System.Windows.Forms.TextBox txtDuzenlemeTarihi;
        private System.Windows.Forms.TextBox txtTarih;
        private System.Windows.Forms.TextBox txtFisNo;
        private Bunifu.Framework.UI.BunifuFlatButton btnDuzenlemeTarihi;
        private System.Windows.Forms.Label lblBelgeNo;
        private System.Windows.Forms.Label lblYevNo;
        private System.Windows.Forms.TextBox txtBelgeNo;
        private System.Windows.Forms.TextBox txtYevNo;
        private System.Windows.Forms.ComboBox comboBoxYetkiKodu;
        private System.Windows.Forms.ComboBox comboBoxOzelKod;
        private System.Windows.Forms.Label lblYetkiKodu;
        private System.Windows.Forms.Label lblOzelKod;
        private Bunifu.Framework.UI.BunifuFlatButton btnProjeKodu;
        private System.Windows.Forms.Label lblProjeKodu;
        private System.Windows.Forms.TextBox txtProjeKodu;
        private System.Windows.Forms.ComboBox comboBoxIsYeri;
        private System.Windows.Forms.Label lblIsYeri;
        private System.Windows.Forms.DataGridView dataGridViewFis;
        private System.Windows.Forms.TextBox txtTLToplamAlacak;
        private System.Windows.Forms.TextBox txtDovizToplamAlacak;
        private System.Windows.Forms.TextBox txtDovizToplamBorc;
        private System.Windows.Forms.TextBox txtTLToplamBorc;
        private System.Windows.Forms.Label lblYerelParaBirimi;
        private Bunifu.Framework.UI.BunifuFlatButton btnVazgec;
        private Bunifu.Framework.UI.BunifuFlatButton btnKaydet;
        private System.Windows.Forms.Label lblDetayliBilgi;
        private System.Windows.Forms.TextBox txtDetayliBilgi;
        private System.Windows.Forms.Label lblKurTuru;
        private System.Windows.Forms.ComboBox cbxKurTuru;
        private System.Windows.Forms.TextBox tbxKur;
        private System.Windows.Forms.Label lblKur;
        private System.Windows.Forms.Label lblislemdovizli;
        private System.Windows.Forms.Label lblToplamAlacak;
        private System.Windows.Forms.Label lblToplamBorc;
        private System.Windows.Forms.DataGridViewTextBoxColumn MuhHesKodu;
        private System.Windows.Forms.DataGridViewTextBoxColumn HesapAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Aciklama;
        private System.Windows.Forms.DataGridViewTextBoxColumn Borc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Alacak;
        private System.Windows.Forms.DataGridViewTextBoxColumn DovBorc;
        private System.Windows.Forms.DataGridViewTextBoxColumn DovAlacak;
        private System.Windows.Forms.DataGridViewTextBoxColumn MasrafMerk;
        private System.Windows.Forms.DataGridViewTextBoxColumn Miktar;
        private System.Windows.Forms.DataGridViewTextBoxColumn FaturaNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHUnvan;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHKodu;
        private System.Windows.Forms.DataGridViewTextBoxColumn MuhAnaHes;
    }
}