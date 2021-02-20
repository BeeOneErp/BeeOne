
namespace BeeOne
{
    partial class frmArayuz
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmArayuz));
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblKullaniciAdi = new System.Windows.Forms.Label();
            this.btnKullanici = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnRestoreDown = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnMinimize = new Bunifu.Framework.UI.BunifuImageButton();
            this.picBeeOneIsim = new System.Windows.Forms.PictureBox();
            this.picBeeOne = new System.Windows.Forms.PictureBox();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.lblSaat = new System.Windows.Forms.Label();
            this.lblFirmaAdi = new System.Windows.Forms.Label();
            this.lblTarih = new System.Windows.Forms.Label();
            this.pnlKullanici = new System.Windows.Forms.Panel();
            this.btnSistemKodlari = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnOturumKapat = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnYardim = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnSifreDegistir = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnFirmaDegistir = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnKullaniciDegistir = new Bunifu.Framework.UI.BunifuThinButton2();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnRapor = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnSabitKiymet = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnMuhasebe = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnFinans = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnFatura = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnCariHesap = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnStokIslemi = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnAnaKayit = new Bunifu.Framework.UI.BunifuTileButton();
            this.pnlAnaMenu = new System.Windows.Forms.Panel();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnKullanici)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestoreDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBeeOneIsim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBeeOne)).BeginInit();
            this.pnlBottom.SuspendLayout();
            this.pnlKullanici.SuspendLayout();
            this.pnlAnaMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.lblKullaniciAdi);
            this.pnlTop.Controls.Add(this.btnKullanici);
            this.pnlTop.Controls.Add(this.btnClose);
            this.pnlTop.Controls.Add(this.btnRestoreDown);
            this.pnlTop.Controls.Add(this.btnMinimize);
            this.pnlTop.Controls.Add(this.picBeeOneIsim);
            this.pnlTop.Controls.Add(this.picBeeOne);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1044, 74);
            this.pnlTop.TabIndex = 0;
            this.pnlTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTop_MouseDown);
            this.pnlTop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlTop_MouseMove);
            this.pnlTop.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlTop_MouseUp);
            // 
            // lblKullaniciAdi
            // 
            this.lblKullaniciAdi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblKullaniciAdi.AutoSize = true;
            this.lblKullaniciAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKullaniciAdi.ForeColor = System.Drawing.Color.Gold;
            this.lblKullaniciAdi.Location = new System.Drawing.Point(920, 43);
            this.lblKullaniciAdi.Name = "lblKullaniciAdi";
            this.lblKullaniciAdi.Size = new System.Drawing.Size(79, 16);
            this.lblKullaniciAdi.TabIndex = 6;
            this.lblKullaniciAdi.Text = "Kullanıcı adı";
            // 
            // btnKullanici
            // 
            this.btnKullanici.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKullanici.BackColor = System.Drawing.Color.Transparent;
            this.btnKullanici.Image = ((System.Drawing.Image)(resources.GetObject("btnKullanici.Image")));
            this.btnKullanici.ImageActive = null;
            this.btnKullanici.Location = new System.Drawing.Point(874, 31);
            this.btnKullanici.Name = "btnKullanici";
            this.btnKullanici.Size = new System.Drawing.Size(40, 40);
            this.btnKullanici.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnKullanici.TabIndex = 5;
            this.btnKullanici.TabStop = false;
            this.btnKullanici.Zoom = 10;
            this.btnKullanici.Click += new System.EventHandler(this.btnKullanici_Click);
            this.btnKullanici.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnKullanici_MouseMove);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageActive = null;
            this.btnClose.Location = new System.Drawing.Point(1017, 6);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(21, 18);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 4;
            this.btnClose.TabStop = false;
            this.btnClose.Zoom = 10;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnRestoreDown
            // 
            this.btnRestoreDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestoreDown.BackColor = System.Drawing.Color.Transparent;
            this.btnRestoreDown.Image = ((System.Drawing.Image)(resources.GetObject("btnRestoreDown.Image")));
            this.btnRestoreDown.ImageActive = null;
            this.btnRestoreDown.Location = new System.Drawing.Point(991, 6);
            this.btnRestoreDown.Name = "btnRestoreDown";
            this.btnRestoreDown.Size = new System.Drawing.Size(21, 18);
            this.btnRestoreDown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnRestoreDown.TabIndex = 3;
            this.btnRestoreDown.TabStop = false;
            this.btnRestoreDown.Zoom = 10;
            this.btnRestoreDown.Click += new System.EventHandler(this.btnRestoreDown_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
            this.btnMinimize.ImageActive = null;
            this.btnMinimize.Location = new System.Drawing.Point(964, 6);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(21, 18);
            this.btnMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimize.TabIndex = 2;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.Zoom = 10;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // picBeeOneIsim
            // 
            this.picBeeOneIsim.Dock = System.Windows.Forms.DockStyle.Left;
            this.picBeeOneIsim.Image = ((System.Drawing.Image)(resources.GetObject("picBeeOneIsim.Image")));
            this.picBeeOneIsim.Location = new System.Drawing.Point(82, 0);
            this.picBeeOneIsim.Name = "picBeeOneIsim";
            this.picBeeOneIsim.Size = new System.Drawing.Size(130, 74);
            this.picBeeOneIsim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBeeOneIsim.TabIndex = 1;
            this.picBeeOneIsim.TabStop = false;
            // 
            // picBeeOne
            // 
            this.picBeeOne.Dock = System.Windows.Forms.DockStyle.Left;
            this.picBeeOne.Image = ((System.Drawing.Image)(resources.GetObject("picBeeOne.Image")));
            this.picBeeOne.Location = new System.Drawing.Point(0, 0);
            this.picBeeOne.Name = "picBeeOne";
            this.picBeeOne.Size = new System.Drawing.Size(82, 74);
            this.picBeeOne.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBeeOne.TabIndex = 0;
            this.picBeeOne.TabStop = false;
            // 
            // pnlBottom
            // 
            this.pnlBottom.Controls.Add(this.lblSaat);
            this.pnlBottom.Controls.Add(this.lblFirmaAdi);
            this.pnlBottom.Controls.Add(this.lblTarih);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 675);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(1044, 65);
            this.pnlBottom.TabIndex = 2;
            // 
            // lblSaat
            // 
            this.lblSaat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSaat.AutoSize = true;
            this.lblSaat.ForeColor = System.Drawing.Color.DarkKhaki;
            this.lblSaat.Location = new System.Drawing.Point(977, 28);
            this.lblSaat.Name = "lblSaat";
            this.lblSaat.Size = new System.Drawing.Size(29, 13);
            this.lblSaat.TabIndex = 1;
            this.lblSaat.Text = "Saat";
            // 
            // lblFirmaAdi
            // 
            this.lblFirmaAdi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblFirmaAdi.AutoSize = true;
            this.lblFirmaAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFirmaAdi.ForeColor = System.Drawing.Color.Gold;
            this.lblFirmaAdi.Location = new System.Drawing.Point(21, 24);
            this.lblFirmaAdi.Name = "lblFirmaAdi";
            this.lblFirmaAdi.Size = new System.Drawing.Size(64, 16);
            this.lblFirmaAdi.TabIndex = 7;
            this.lblFirmaAdi.Text = "Firma adı";
            // 
            // lblTarih
            // 
            this.lblTarih.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTarih.AutoSize = true;
            this.lblTarih.ForeColor = System.Drawing.Color.DarkKhaki;
            this.lblTarih.Location = new System.Drawing.Point(835, 28);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(31, 13);
            this.lblTarih.TabIndex = 0;
            this.lblTarih.Text = "Tarih";
            // 
            // pnlKullanici
            // 
            this.pnlKullanici.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlKullanici.Controls.Add(this.btnSistemKodlari);
            this.pnlKullanici.Controls.Add(this.btnOturumKapat);
            this.pnlKullanici.Controls.Add(this.btnYardim);
            this.pnlKullanici.Controls.Add(this.btnSifreDegistir);
            this.pnlKullanici.Controls.Add(this.btnFirmaDegistir);
            this.pnlKullanici.Controls.Add(this.btnKullaniciDegistir);
            this.pnlKullanici.Location = new System.Drawing.Point(875, 74);
            this.pnlKullanici.Name = "pnlKullanici";
            this.pnlKullanici.Size = new System.Drawing.Size(169, 198);
            this.pnlKullanici.TabIndex = 3;
            // 
            // btnSistemKodlari
            // 
            this.btnSistemKodlari.ActiveBorderThickness = 1;
            this.btnSistemKodlari.ActiveCornerRadius = 20;
            this.btnSistemKodlari.ActiveFillColor = System.Drawing.Color.Transparent;
            this.btnSistemKodlari.ActiveForecolor = System.Drawing.Color.Khaki;
            this.btnSistemKodlari.ActiveLineColor = System.Drawing.Color.Transparent;
            this.btnSistemKodlari.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnSistemKodlari.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSistemKodlari.BackgroundImage")));
            this.btnSistemKodlari.ButtonText = "Sistem Kodları";
            this.btnSistemKodlari.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSistemKodlari.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSistemKodlari.ForeColor = System.Drawing.Color.White;
            this.btnSistemKodlari.IdleBorderThickness = 1;
            this.btnSistemKodlari.IdleCornerRadius = 20;
            this.btnSistemKodlari.IdleFillColor = System.Drawing.Color.Transparent;
            this.btnSistemKodlari.IdleForecolor = System.Drawing.Color.White;
            this.btnSistemKodlari.IdleLineColor = System.Drawing.Color.Transparent;
            this.btnSistemKodlari.Location = new System.Drawing.Point(2, 96);
            this.btnSistemKodlari.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSistemKodlari.Name = "btnSistemKodlari";
            this.btnSistemKodlari.Size = new System.Drawing.Size(165, 29);
            this.btnSistemKodlari.TabIndex = 25;
            this.btnSistemKodlari.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSistemKodlari.Click += new System.EventHandler(this.btnSistemKodlari_Click);
            // 
            // btnOturumKapat
            // 
            this.btnOturumKapat.ActiveBorderThickness = 1;
            this.btnOturumKapat.ActiveCornerRadius = 20;
            this.btnOturumKapat.ActiveFillColor = System.Drawing.Color.Transparent;
            this.btnOturumKapat.ActiveForecolor = System.Drawing.Color.Khaki;
            this.btnOturumKapat.ActiveLineColor = System.Drawing.Color.Transparent;
            this.btnOturumKapat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnOturumKapat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnOturumKapat.BackgroundImage")));
            this.btnOturumKapat.ButtonText = "Oturumu Kapat";
            this.btnOturumKapat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOturumKapat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOturumKapat.ForeColor = System.Drawing.Color.White;
            this.btnOturumKapat.IdleBorderThickness = 1;
            this.btnOturumKapat.IdleCornerRadius = 20;
            this.btnOturumKapat.IdleFillColor = System.Drawing.Color.Transparent;
            this.btnOturumKapat.IdleForecolor = System.Drawing.Color.White;
            this.btnOturumKapat.IdleLineColor = System.Drawing.Color.Transparent;
            this.btnOturumKapat.Location = new System.Drawing.Point(2, 159);
            this.btnOturumKapat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOturumKapat.Name = "btnOturumKapat";
            this.btnOturumKapat.Size = new System.Drawing.Size(165, 29);
            this.btnOturumKapat.TabIndex = 4;
            this.btnOturumKapat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnOturumKapat.Click += new System.EventHandler(this.btnOturumKapat_Click);
            // 
            // btnYardim
            // 
            this.btnYardim.ActiveBorderThickness = 1;
            this.btnYardim.ActiveCornerRadius = 20;
            this.btnYardim.ActiveFillColor = System.Drawing.Color.Transparent;
            this.btnYardim.ActiveForecolor = System.Drawing.Color.Khaki;
            this.btnYardim.ActiveLineColor = System.Drawing.Color.Transparent;
            this.btnYardim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnYardim.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnYardim.BackgroundImage")));
            this.btnYardim.ButtonText = "Yardım";
            this.btnYardim.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnYardim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYardim.ForeColor = System.Drawing.Color.White;
            this.btnYardim.IdleBorderThickness = 1;
            this.btnYardim.IdleCornerRadius = 20;
            this.btnYardim.IdleFillColor = System.Drawing.Color.Transparent;
            this.btnYardim.IdleForecolor = System.Drawing.Color.White;
            this.btnYardim.IdleLineColor = System.Drawing.Color.Transparent;
            this.btnYardim.Location = new System.Drawing.Point(2, 128);
            this.btnYardim.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnYardim.Name = "btnYardim";
            this.btnYardim.Size = new System.Drawing.Size(165, 29);
            this.btnYardim.TabIndex = 3;
            this.btnYardim.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnYardim.Click += new System.EventHandler(this.btnYardim_Click);
            // 
            // btnSifreDegistir
            // 
            this.btnSifreDegistir.ActiveBorderThickness = 1;
            this.btnSifreDegistir.ActiveCornerRadius = 20;
            this.btnSifreDegistir.ActiveFillColor = System.Drawing.Color.Transparent;
            this.btnSifreDegistir.ActiveForecolor = System.Drawing.Color.Khaki;
            this.btnSifreDegistir.ActiveLineColor = System.Drawing.Color.Transparent;
            this.btnSifreDegistir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnSifreDegistir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSifreDegistir.BackgroundImage")));
            this.btnSifreDegistir.ButtonText = "Şifre Değiştir";
            this.btnSifreDegistir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSifreDegistir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSifreDegistir.ForeColor = System.Drawing.Color.White;
            this.btnSifreDegistir.IdleBorderThickness = 1;
            this.btnSifreDegistir.IdleCornerRadius = 20;
            this.btnSifreDegistir.IdleFillColor = System.Drawing.Color.Transparent;
            this.btnSifreDegistir.IdleForecolor = System.Drawing.Color.White;
            this.btnSifreDegistir.IdleLineColor = System.Drawing.Color.Transparent;
            this.btnSifreDegistir.Location = new System.Drawing.Point(2, 63);
            this.btnSifreDegistir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSifreDegistir.Name = "btnSifreDegistir";
            this.btnSifreDegistir.Size = new System.Drawing.Size(165, 29);
            this.btnSifreDegistir.TabIndex = 2;
            this.btnSifreDegistir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSifreDegistir.Click += new System.EventHandler(this.btnSifreDegistir_Click);
            // 
            // btnFirmaDegistir
            // 
            this.btnFirmaDegistir.ActiveBorderThickness = 1;
            this.btnFirmaDegistir.ActiveCornerRadius = 20;
            this.btnFirmaDegistir.ActiveFillColor = System.Drawing.Color.Transparent;
            this.btnFirmaDegistir.ActiveForecolor = System.Drawing.Color.Khaki;
            this.btnFirmaDegistir.ActiveLineColor = System.Drawing.Color.Transparent;
            this.btnFirmaDegistir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnFirmaDegistir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFirmaDegistir.BackgroundImage")));
            this.btnFirmaDegistir.ButtonText = "Firma Değiştir";
            this.btnFirmaDegistir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFirmaDegistir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFirmaDegistir.ForeColor = System.Drawing.Color.White;
            this.btnFirmaDegistir.IdleBorderThickness = 1;
            this.btnFirmaDegistir.IdleCornerRadius = 20;
            this.btnFirmaDegistir.IdleFillColor = System.Drawing.Color.Transparent;
            this.btnFirmaDegistir.IdleForecolor = System.Drawing.Color.White;
            this.btnFirmaDegistir.IdleLineColor = System.Drawing.Color.Transparent;
            this.btnFirmaDegistir.Location = new System.Drawing.Point(2, 35);
            this.btnFirmaDegistir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnFirmaDegistir.Name = "btnFirmaDegistir";
            this.btnFirmaDegistir.Size = new System.Drawing.Size(165, 29);
            this.btnFirmaDegistir.TabIndex = 1;
            this.btnFirmaDegistir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnKullaniciDegistir
            // 
            this.btnKullaniciDegistir.ActiveBorderThickness = 1;
            this.btnKullaniciDegistir.ActiveCornerRadius = 20;
            this.btnKullaniciDegistir.ActiveFillColor = System.Drawing.Color.Transparent;
            this.btnKullaniciDegistir.ActiveForecolor = System.Drawing.Color.Khaki;
            this.btnKullaniciDegistir.ActiveLineColor = System.Drawing.Color.Transparent;
            this.btnKullaniciDegistir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnKullaniciDegistir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnKullaniciDegistir.BackgroundImage")));
            this.btnKullaniciDegistir.ButtonText = "Kullanıcı Değiştir";
            this.btnKullaniciDegistir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKullaniciDegistir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKullaniciDegistir.ForeColor = System.Drawing.Color.White;
            this.btnKullaniciDegistir.IdleBorderThickness = 1;
            this.btnKullaniciDegistir.IdleCornerRadius = 20;
            this.btnKullaniciDegistir.IdleFillColor = System.Drawing.Color.Transparent;
            this.btnKullaniciDegistir.IdleForecolor = System.Drawing.Color.White;
            this.btnKullaniciDegistir.IdleLineColor = System.Drawing.Color.Transparent;
            this.btnKullaniciDegistir.Location = new System.Drawing.Point(2, 5);
            this.btnKullaniciDegistir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnKullaniciDegistir.Name = "btnKullaniciDegistir";
            this.btnKullaniciDegistir.Size = new System.Drawing.Size(165, 29);
            this.btnKullaniciDegistir.TabIndex = 0;
            this.btnKullaniciDegistir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnRapor
            // 
            this.btnRapor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRapor.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnRapor.color = System.Drawing.Color.DarkKhaki;
            this.btnRapor.colorActive = System.Drawing.Color.Khaki;
            this.btnRapor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRapor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRapor.ForeColor = System.Drawing.Color.Black;
            this.btnRapor.Image = ((System.Drawing.Image)(resources.GetObject("btnRapor.Image")));
            this.btnRapor.ImagePosition = 14;
            this.btnRapor.ImageZoom = 50;
            this.btnRapor.LabelPosition = 29;
            this.btnRapor.LabelText = "Raporlarım";
            this.btnRapor.Location = new System.Drawing.Point(519, 197);
            this.btnRapor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRapor.Name = "btnRapor";
            this.btnRapor.Size = new System.Drawing.Size(134, 119);
            this.btnRapor.TabIndex = 23;
            this.btnRapor.Click += new System.EventHandler(this.btnRapor_Click);
            // 
            // btnSabitKiymet
            // 
            this.btnSabitKiymet.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSabitKiymet.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnSabitKiymet.color = System.Drawing.Color.DarkKhaki;
            this.btnSabitKiymet.colorActive = System.Drawing.Color.Khaki;
            this.btnSabitKiymet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSabitKiymet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSabitKiymet.ForeColor = System.Drawing.Color.Black;
            this.btnSabitKiymet.Image = ((System.Drawing.Image)(resources.GetObject("btnSabitKiymet.Image")));
            this.btnSabitKiymet.ImagePosition = 14;
            this.btnSabitKiymet.ImageZoom = 50;
            this.btnSabitKiymet.LabelPosition = 29;
            this.btnSabitKiymet.LabelText = "Sabit Kıymet";
            this.btnSabitKiymet.Location = new System.Drawing.Point(358, 197);
            this.btnSabitKiymet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSabitKiymet.Name = "btnSabitKiymet";
            this.btnSabitKiymet.Size = new System.Drawing.Size(134, 119);
            this.btnSabitKiymet.TabIndex = 22;
            this.btnSabitKiymet.Click += new System.EventHandler(this.btnSabitKiymet_Click);
            // 
            // btnMuhasebe
            // 
            this.btnMuhasebe.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnMuhasebe.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnMuhasebe.color = System.Drawing.Color.DarkKhaki;
            this.btnMuhasebe.colorActive = System.Drawing.Color.Khaki;
            this.btnMuhasebe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMuhasebe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMuhasebe.ForeColor = System.Drawing.Color.Black;
            this.btnMuhasebe.Image = ((System.Drawing.Image)(resources.GetObject("btnMuhasebe.Image")));
            this.btnMuhasebe.ImagePosition = 14;
            this.btnMuhasebe.ImageZoom = 50;
            this.btnMuhasebe.LabelPosition = 29;
            this.btnMuhasebe.LabelText = "Muhasebe İşlemleri";
            this.btnMuhasebe.Location = new System.Drawing.Point(196, 197);
            this.btnMuhasebe.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMuhasebe.Name = "btnMuhasebe";
            this.btnMuhasebe.Size = new System.Drawing.Size(134, 119);
            this.btnMuhasebe.TabIndex = 21;
            this.btnMuhasebe.Click += new System.EventHandler(this.btnMuhasebe_Click);
            // 
            // btnFinans
            // 
            this.btnFinans.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnFinans.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnFinans.color = System.Drawing.Color.DarkKhaki;
            this.btnFinans.colorActive = System.Drawing.Color.Khaki;
            this.btnFinans.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFinans.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFinans.ForeColor = System.Drawing.Color.Black;
            this.btnFinans.Image = ((System.Drawing.Image)(resources.GetObject("btnFinans.Image")));
            this.btnFinans.ImagePosition = 14;
            this.btnFinans.ImageZoom = 50;
            this.btnFinans.LabelPosition = 29;
            this.btnFinans.LabelText = "Finans";
            this.btnFinans.Location = new System.Drawing.Point(35, 197);
            this.btnFinans.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnFinans.Name = "btnFinans";
            this.btnFinans.Size = new System.Drawing.Size(134, 119);
            this.btnFinans.TabIndex = 20;
            this.btnFinans.Click += new System.EventHandler(this.btnFinans_Click);
            // 
            // btnFatura
            // 
            this.btnFatura.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnFatura.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnFatura.color = System.Drawing.Color.DarkKhaki;
            this.btnFatura.colorActive = System.Drawing.Color.Khaki;
            this.btnFatura.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFatura.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFatura.ForeColor = System.Drawing.Color.Black;
            this.btnFatura.Image = ((System.Drawing.Image)(resources.GetObject("btnFatura.Image")));
            this.btnFatura.ImagePosition = 14;
            this.btnFatura.ImageZoom = 50;
            this.btnFatura.LabelPosition = 29;
            this.btnFatura.LabelText = "Fatura";
            this.btnFatura.Location = new System.Drawing.Point(519, 35);
            this.btnFatura.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnFatura.Name = "btnFatura";
            this.btnFatura.Size = new System.Drawing.Size(134, 119);
            this.btnFatura.TabIndex = 19;
            this.btnFatura.Click += new System.EventHandler(this.btnFatura_Click);
            // 
            // btnCariHesap
            // 
            this.btnCariHesap.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCariHesap.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnCariHesap.color = System.Drawing.Color.DarkKhaki;
            this.btnCariHesap.colorActive = System.Drawing.Color.Khaki;
            this.btnCariHesap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCariHesap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCariHesap.ForeColor = System.Drawing.Color.Black;
            this.btnCariHesap.Image = ((System.Drawing.Image)(resources.GetObject("btnCariHesap.Image")));
            this.btnCariHesap.ImagePosition = 14;
            this.btnCariHesap.ImageZoom = 50;
            this.btnCariHesap.LabelPosition = 29;
            this.btnCariHesap.LabelText = "Cari Hesap İşlemleri";
            this.btnCariHesap.Location = new System.Drawing.Point(358, 35);
            this.btnCariHesap.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCariHesap.Name = "btnCariHesap";
            this.btnCariHesap.Size = new System.Drawing.Size(134, 119);
            this.btnCariHesap.TabIndex = 18;
            this.btnCariHesap.Click += new System.EventHandler(this.btnCariHesap_Click);
            // 
            // btnStokIslemi
            // 
            this.btnStokIslemi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnStokIslemi.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnStokIslemi.color = System.Drawing.Color.DarkKhaki;
            this.btnStokIslemi.colorActive = System.Drawing.Color.Khaki;
            this.btnStokIslemi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStokIslemi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnStokIslemi.ForeColor = System.Drawing.Color.Black;
            this.btnStokIslemi.Image = ((System.Drawing.Image)(resources.GetObject("btnStokIslemi.Image")));
            this.btnStokIslemi.ImagePosition = 14;
            this.btnStokIslemi.ImageZoom = 50;
            this.btnStokIslemi.LabelPosition = 29;
            this.btnStokIslemi.LabelText = "Stok İşlemleri";
            this.btnStokIslemi.Location = new System.Drawing.Point(196, 35);
            this.btnStokIslemi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnStokIslemi.Name = "btnStokIslemi";
            this.btnStokIslemi.Size = new System.Drawing.Size(134, 119);
            this.btnStokIslemi.TabIndex = 17;
            this.btnStokIslemi.Click += new System.EventHandler(this.btnStokIslemi_Click);
            // 
            // btnAnaKayit
            // 
            this.btnAnaKayit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAnaKayit.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnAnaKayit.color = System.Drawing.Color.DarkKhaki;
            this.btnAnaKayit.colorActive = System.Drawing.Color.Khaki;
            this.btnAnaKayit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAnaKayit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAnaKayit.ForeColor = System.Drawing.Color.Black;
            this.btnAnaKayit.Image = ((System.Drawing.Image)(resources.GetObject("btnAnaKayit.Image")));
            this.btnAnaKayit.ImagePosition = 14;
            this.btnAnaKayit.ImageZoom = 50;
            this.btnAnaKayit.LabelPosition = 29;
            this.btnAnaKayit.LabelText = "Ana Kayıtlar";
            this.btnAnaKayit.Location = new System.Drawing.Point(35, 35);
            this.btnAnaKayit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAnaKayit.Name = "btnAnaKayit";
            this.btnAnaKayit.Size = new System.Drawing.Size(134, 119);
            this.btnAnaKayit.TabIndex = 16;
            this.btnAnaKayit.Click += new System.EventHandler(this.btnAnaKayit_Click);
            // 
            // pnlAnaMenu
            // 
            this.pnlAnaMenu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlAnaMenu.Controls.Add(this.btnRapor);
            this.pnlAnaMenu.Controls.Add(this.btnAnaKayit);
            this.pnlAnaMenu.Controls.Add(this.btnSabitKiymet);
            this.pnlAnaMenu.Controls.Add(this.btnStokIslemi);
            this.pnlAnaMenu.Controls.Add(this.btnMuhasebe);
            this.pnlAnaMenu.Controls.Add(this.btnCariHesap);
            this.pnlAnaMenu.Controls.Add(this.btnFinans);
            this.pnlAnaMenu.Controls.Add(this.btnFatura);
            this.pnlAnaMenu.Location = new System.Drawing.Point(172, 192);
            this.pnlAnaMenu.Name = "pnlAnaMenu";
            this.pnlAnaMenu.Size = new System.Drawing.Size(684, 350);
            this.pnlAnaMenu.TabIndex = 24;
            // 
            // frmArayuz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1044, 740);
            this.Controls.Add(this.pnlAnaMenu);
            this.Controls.Add(this.pnlKullanici);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.pnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmArayuz";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BeeOne";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmArayuz_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmArayuz_MouseMove);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnKullanici)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestoreDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBeeOneIsim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBeeOne)).EndInit();
            this.pnlBottom.ResumeLayout(false);
            this.pnlBottom.PerformLayout();
            this.pnlKullanici.ResumeLayout(false);
            this.pnlAnaMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.PictureBox picBeeOne;
        private Bunifu.Framework.UI.BunifuImageButton btnRestoreDown;
        private Bunifu.Framework.UI.BunifuImageButton btnMinimize;
        private System.Windows.Forms.PictureBox picBeeOneIsim;
        private Bunifu.Framework.UI.BunifuImageButton btnClose;
        private System.Windows.Forms.Panel pnlBottom;
        private Bunifu.Framework.UI.BunifuImageButton btnKullanici;
        private System.Windows.Forms.Label lblKullaniciAdi;
        private System.Windows.Forms.Panel pnlKullanici;
        private Bunifu.Framework.UI.BunifuThinButton2 btnOturumKapat;
        private Bunifu.Framework.UI.BunifuThinButton2 btnYardim;
        private Bunifu.Framework.UI.BunifuThinButton2 btnSifreDegistir;
        private Bunifu.Framework.UI.BunifuThinButton2 btnFirmaDegistir;
        private Bunifu.Framework.UI.BunifuThinButton2 btnKullaniciDegistir;
        private System.Windows.Forms.Label lblFirmaAdi;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblSaat;
        private System.Windows.Forms.Label lblTarih;
        private Bunifu.Framework.UI.BunifuTileButton btnRapor;
        private Bunifu.Framework.UI.BunifuTileButton btnSabitKiymet;
        private Bunifu.Framework.UI.BunifuTileButton btnMuhasebe;
        private Bunifu.Framework.UI.BunifuTileButton btnFinans;
        private Bunifu.Framework.UI.BunifuTileButton btnFatura;
        private Bunifu.Framework.UI.BunifuTileButton btnCariHesap;
        private Bunifu.Framework.UI.BunifuTileButton btnStokIslemi;
        private Bunifu.Framework.UI.BunifuTileButton btnAnaKayit;
        private System.Windows.Forms.Panel pnlAnaMenu;
        private Bunifu.Framework.UI.BunifuThinButton2 btnSistemKodlari;
    }
}