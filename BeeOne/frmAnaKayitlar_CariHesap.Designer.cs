
namespace BeeOne
{
    partial class frmAnaKayitlar_CariHesap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAnaKayitlar_CariHesap));
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblAnaKayitlar = new System.Windows.Forms.Label();
            this.btnClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnMinimize = new Bunifu.Framework.UI.BunifuImageButton();
            this.comboBoxStatu = new System.Windows.Forms.ComboBox();
            this.lblStatusu = new System.Windows.Forms.Label();
            this.lblEIsKodu = new System.Windows.Forms.Label();
            this.txtUnvan2 = new System.Windows.Forms.TextBox();
            this.lblUnvan2 = new System.Windows.Forms.Label();
            this.txtUnvan = new System.Windows.Forms.TextBox();
            this.lblUnvan = new System.Windows.Forms.Label();
            this.txtKodu = new System.Windows.Forms.TextBox();
            this.lblKodu = new System.Windows.Forms.Label();
            this.txtIsKodu = new System.Windows.Forms.TextBox();
            this.pnlSekme = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.btnDiger = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnTicariBilgiler = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnIletisim = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pnlIslem = new Bunifu.Framework.UI.BunifuGradientPanel();
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
            this.pnlTop.Size = new System.Drawing.Size(729, 48);
            this.pnlTop.TabIndex = 10;
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
            this.lblAnaKayitlar.Size = new System.Drawing.Size(232, 21);
            this.lblAnaKayitlar.TabIndex = 7;
            this.lblAnaKayitlar.Text = "ANA KAYITLAR > CARİ HESAP";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageActive = null;
            this.btnClose.Location = new System.Drawing.Point(699, 10);
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
            this.btnMinimize.Location = new System.Drawing.Point(673, 10);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(20, 27);
            this.btnMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimize.TabIndex = 5;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.Zoom = 10;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // comboBoxStatu
            // 
            this.comboBoxStatu.FormattingEnabled = true;
            this.comboBoxStatu.Items.AddRange(new object[] {
            "Kullanımda",
            "Kullanım Dışı"});
            this.comboBoxStatu.Location = new System.Drawing.Point(444, 63);
            this.comboBoxStatu.Name = "comboBoxStatu";
            this.comboBoxStatu.Size = new System.Drawing.Size(109, 21);
            this.comboBoxStatu.TabIndex = 43;
            this.comboBoxStatu.Text = "Kullanımda";
            // 
            // lblStatusu
            // 
            this.lblStatusu.AutoSize = true;
            this.lblStatusu.BackColor = System.Drawing.Color.Transparent;
            this.lblStatusu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblStatusu.Location = new System.Drawing.Point(364, 66);
            this.lblStatusu.Name = "lblStatusu";
            this.lblStatusu.Size = new System.Drawing.Size(48, 15);
            this.lblStatusu.TabIndex = 42;
            this.lblStatusu.Text = "Statüsü";
            // 
            // lblEIsKodu
            // 
            this.lblEIsKodu.AutoSize = true;
            this.lblEIsKodu.BackColor = System.Drawing.Color.Transparent;
            this.lblEIsKodu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEIsKodu.Location = new System.Drawing.Point(27, 145);
            this.lblEIsKodu.Name = "lblEIsKodu";
            this.lblEIsKodu.Size = new System.Drawing.Size(60, 15);
            this.lblEIsKodu.TabIndex = 41;
            this.lblEIsKodu.Text = "E-İş Kodu";
            // 
            // txtUnvan2
            // 
            this.txtUnvan2.Location = new System.Drawing.Point(106, 116);
            this.txtUnvan2.Name = "txtUnvan2";
            this.txtUnvan2.Size = new System.Drawing.Size(447, 20);
            this.txtUnvan2.TabIndex = 40;
            // 
            // lblUnvan2
            // 
            this.lblUnvan2.AutoSize = true;
            this.lblUnvan2.BackColor = System.Drawing.Color.Transparent;
            this.lblUnvan2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUnvan2.Location = new System.Drawing.Point(26, 119);
            this.lblUnvan2.Name = "lblUnvan2";
            this.lblUnvan2.Size = new System.Drawing.Size(55, 15);
            this.lblUnvan2.TabIndex = 39;
            this.lblUnvan2.Text = "Unvanı 2";
            // 
            // txtUnvan
            // 
            this.txtUnvan.Location = new System.Drawing.Point(106, 90);
            this.txtUnvan.Name = "txtUnvan";
            this.txtUnvan.Size = new System.Drawing.Size(447, 20);
            this.txtUnvan.TabIndex = 38;
            // 
            // lblUnvan
            // 
            this.lblUnvan.AutoSize = true;
            this.lblUnvan.BackColor = System.Drawing.Color.Transparent;
            this.lblUnvan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUnvan.Location = new System.Drawing.Point(26, 93);
            this.lblUnvan.Name = "lblUnvan";
            this.lblUnvan.Size = new System.Drawing.Size(42, 15);
            this.lblUnvan.TabIndex = 37;
            this.lblUnvan.Text = "Unvan";
            // 
            // txtKodu
            // 
            this.txtKodu.Location = new System.Drawing.Point(106, 64);
            this.txtKodu.Name = "txtKodu";
            this.txtKodu.Size = new System.Drawing.Size(215, 20);
            this.txtKodu.TabIndex = 36;
            // 
            // lblKodu
            // 
            this.lblKodu.AutoSize = true;
            this.lblKodu.BackColor = System.Drawing.Color.Transparent;
            this.lblKodu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKodu.Location = new System.Drawing.Point(26, 67);
            this.lblKodu.Name = "lblKodu";
            this.lblKodu.Size = new System.Drawing.Size(36, 15);
            this.lblKodu.TabIndex = 35;
            this.lblKodu.Text = "Kodu";
            // 
            // txtIsKodu
            // 
            this.txtIsKodu.Location = new System.Drawing.Point(106, 143);
            this.txtIsKodu.Name = "txtIsKodu";
            this.txtIsKodu.Size = new System.Drawing.Size(215, 20);
            this.txtIsKodu.TabIndex = 44;
            // 
            // pnlSekme
            // 
            this.pnlSekme.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlSekme.BackgroundImage")));
            this.pnlSekme.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlSekme.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSekme.Controls.Add(this.btnDiger);
            this.pnlSekme.Controls.Add(this.btnTicariBilgiler);
            this.pnlSekme.Controls.Add(this.btnIletisim);
            this.pnlSekme.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.pnlSekme.GradientBottomRight = System.Drawing.Color.DarkKhaki;
            this.pnlSekme.GradientTopLeft = System.Drawing.Color.DarkKhaki;
            this.pnlSekme.GradientTopRight = System.Drawing.Color.DarkKhaki;
            this.pnlSekme.Location = new System.Drawing.Point(29, 171);
            this.pnlSekme.Name = "pnlSekme";
            this.pnlSekme.Quality = 10;
            this.pnlSekme.Size = new System.Drawing.Size(672, 31);
            this.pnlSekme.TabIndex = 45;
            // 
            // btnDiger
            // 
            this.btnDiger.Activecolor = System.Drawing.Color.Khaki;
            this.btnDiger.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnDiger.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDiger.BorderRadius = 0;
            this.btnDiger.ButtonText = "Diğer";
            this.btnDiger.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDiger.DisabledColor = System.Drawing.Color.Gray;
            this.btnDiger.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnDiger.Iconcolor = System.Drawing.Color.Transparent;
            this.btnDiger.Iconimage = null;
            this.btnDiger.Iconimage_right = null;
            this.btnDiger.Iconimage_right_Selected = null;
            this.btnDiger.Iconimage_Selected = null;
            this.btnDiger.IconMarginLeft = 0;
            this.btnDiger.IconMarginRight = 0;
            this.btnDiger.IconRightVisible = true;
            this.btnDiger.IconRightZoom = 0D;
            this.btnDiger.IconVisible = true;
            this.btnDiger.IconZoom = 90D;
            this.btnDiger.IsTab = false;
            this.btnDiger.Location = new System.Drawing.Point(200, 0);
            this.btnDiger.Name = "btnDiger";
            this.btnDiger.Normalcolor = System.Drawing.Color.DarkKhaki;
            this.btnDiger.OnHovercolor = System.Drawing.Color.Khaki;
            this.btnDiger.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnDiger.selected = false;
            this.btnDiger.Size = new System.Drawing.Size(100, 29);
            this.btnDiger.TabIndex = 48;
            this.btnDiger.Text = "Diğer";
            this.btnDiger.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDiger.Textcolor = System.Drawing.Color.Black;
            this.btnDiger.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiger.Click += new System.EventHandler(this.btnDiger_Click);
            // 
            // btnTicariBilgiler
            // 
            this.btnTicariBilgiler.Activecolor = System.Drawing.Color.Khaki;
            this.btnTicariBilgiler.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnTicariBilgiler.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTicariBilgiler.BorderRadius = 0;
            this.btnTicariBilgiler.ButtonText = "Ticari Bilgiler";
            this.btnTicariBilgiler.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTicariBilgiler.DisabledColor = System.Drawing.Color.Gray;
            this.btnTicariBilgiler.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnTicariBilgiler.Iconcolor = System.Drawing.Color.Transparent;
            this.btnTicariBilgiler.Iconimage = null;
            this.btnTicariBilgiler.Iconimage_right = null;
            this.btnTicariBilgiler.Iconimage_right_Selected = null;
            this.btnTicariBilgiler.Iconimage_Selected = null;
            this.btnTicariBilgiler.IconMarginLeft = 0;
            this.btnTicariBilgiler.IconMarginRight = 0;
            this.btnTicariBilgiler.IconRightVisible = true;
            this.btnTicariBilgiler.IconRightZoom = 0D;
            this.btnTicariBilgiler.IconVisible = true;
            this.btnTicariBilgiler.IconZoom = 90D;
            this.btnTicariBilgiler.IsTab = false;
            this.btnTicariBilgiler.Location = new System.Drawing.Point(100, 0);
            this.btnTicariBilgiler.Name = "btnTicariBilgiler";
            this.btnTicariBilgiler.Normalcolor = System.Drawing.Color.DarkKhaki;
            this.btnTicariBilgiler.OnHovercolor = System.Drawing.Color.Khaki;
            this.btnTicariBilgiler.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnTicariBilgiler.selected = false;
            this.btnTicariBilgiler.Size = new System.Drawing.Size(100, 29);
            this.btnTicariBilgiler.TabIndex = 47;
            this.btnTicariBilgiler.Text = "Ticari Bilgiler";
            this.btnTicariBilgiler.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnTicariBilgiler.Textcolor = System.Drawing.Color.Black;
            this.btnTicariBilgiler.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTicariBilgiler.Click += new System.EventHandler(this.btnTicariBilgiler_Click);
            // 
            // btnIletisim
            // 
            this.btnIletisim.Activecolor = System.Drawing.Color.Khaki;
            this.btnIletisim.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnIletisim.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnIletisim.BorderRadius = 0;
            this.btnIletisim.ButtonText = "İletişim";
            this.btnIletisim.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIletisim.DisabledColor = System.Drawing.Color.Gray;
            this.btnIletisim.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnIletisim.Iconcolor = System.Drawing.Color.Transparent;
            this.btnIletisim.Iconimage = null;
            this.btnIletisim.Iconimage_right = null;
            this.btnIletisim.Iconimage_right_Selected = null;
            this.btnIletisim.Iconimage_Selected = null;
            this.btnIletisim.IconMarginLeft = 0;
            this.btnIletisim.IconMarginRight = 0;
            this.btnIletisim.IconRightVisible = true;
            this.btnIletisim.IconRightZoom = 0D;
            this.btnIletisim.IconVisible = true;
            this.btnIletisim.IconZoom = 90D;
            this.btnIletisim.IsTab = false;
            this.btnIletisim.Location = new System.Drawing.Point(0, 0);
            this.btnIletisim.Name = "btnIletisim";
            this.btnIletisim.Normalcolor = System.Drawing.Color.DarkKhaki;
            this.btnIletisim.OnHovercolor = System.Drawing.Color.Khaki;
            this.btnIletisim.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnIletisim.selected = false;
            this.btnIletisim.Size = new System.Drawing.Size(100, 29);
            this.btnIletisim.TabIndex = 46;
            this.btnIletisim.Text = "İletişim";
            this.btnIletisim.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnIletisim.Textcolor = System.Drawing.Color.Black;
            this.btnIletisim.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIletisim.Click += new System.EventHandler(this.btnIletisim_Click);
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
            this.pnlIslem.Location = new System.Drawing.Point(30, 208);
            this.pnlIslem.Name = "pnlIslem";
            this.pnlIslem.Quality = 10;
            this.pnlIslem.Size = new System.Drawing.Size(671, 470);
            this.pnlIslem.TabIndex = 49;
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
            this.btnVazgec.Location = new System.Drawing.Point(603, 698);
            this.btnVazgec.Name = "btnVazgec";
            this.btnVazgec.Normalcolor = System.Drawing.Color.DarkKhaki;
            this.btnVazgec.OnHovercolor = System.Drawing.Color.Khaki;
            this.btnVazgec.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnVazgec.selected = false;
            this.btnVazgec.Size = new System.Drawing.Size(98, 31);
            this.btnVazgec.TabIndex = 51;
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
            this.btnKaydet.Location = new System.Drawing.Point(489, 698);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Normalcolor = System.Drawing.Color.DarkKhaki;
            this.btnKaydet.OnHovercolor = System.Drawing.Color.Khaki;
            this.btnKaydet.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnKaydet.selected = false;
            this.btnKaydet.Size = new System.Drawing.Size(98, 31);
            this.btnKaydet.TabIndex = 50;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnKaydet.Textcolor = System.Drawing.Color.Black;
            this.btnKaydet.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // frmAnaKayitlar_CariHesap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.BackgroundImage = global::BeeOne.Properties.Resources.background__39_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(729, 747);
            this.Controls.Add(this.btnVazgec);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.pnlIslem);
            this.Controls.Add(this.pnlSekme);
            this.Controls.Add(this.txtIsKodu);
            this.Controls.Add(this.comboBoxStatu);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.lblStatusu);
            this.Controls.Add(this.txtUnvan2);
            this.Controls.Add(this.lblEIsKodu);
            this.Controls.Add(this.lblKodu);
            this.Controls.Add(this.txtKodu);
            this.Controls.Add(this.lblUnvan2);
            this.Controls.Add(this.lblUnvan);
            this.Controls.Add(this.txtUnvan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAnaKayitlar_CariHesap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ana Kayıtlar > Cari Hesap";
            this.Load += new System.EventHandler(this.frmAnaKayitlar_CariHesap_Load);
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
        private System.Windows.Forms.ComboBox comboBoxStatu;
        private System.Windows.Forms.Label lblStatusu;
        private System.Windows.Forms.Label lblEIsKodu;
        private System.Windows.Forms.TextBox txtUnvan2;
        private System.Windows.Forms.Label lblUnvan2;
        private System.Windows.Forms.TextBox txtUnvan;
        private System.Windows.Forms.Label lblUnvan;
        private System.Windows.Forms.TextBox txtKodu;
        private System.Windows.Forms.Label lblKodu;
        private System.Windows.Forms.TextBox txtIsKodu;
        private Bunifu.Framework.UI.BunifuGradientPanel pnlSekme;
        private Bunifu.Framework.UI.BunifuFlatButton btnDiger;
        private Bunifu.Framework.UI.BunifuFlatButton btnTicariBilgiler;
        private Bunifu.Framework.UI.BunifuFlatButton btnIletisim;
        private Bunifu.Framework.UI.BunifuGradientPanel pnlIslem;
        private Bunifu.Framework.UI.BunifuFlatButton btnVazgec;
        private Bunifu.Framework.UI.BunifuFlatButton btnKaydet;
    }
}