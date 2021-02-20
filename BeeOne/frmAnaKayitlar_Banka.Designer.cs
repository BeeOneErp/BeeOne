
namespace BeeOne
{
    partial class frmAnaKayitlar_Banka
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAnaKayitlar_Banka));
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblAnaKayitlar = new System.Windows.Forms.Label();
            this.btnClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnMinimize = new Bunifu.Framework.UI.BunifuImageButton();
            this.lblHesapKodu = new System.Windows.Forms.Label();
            this.lblHesapAdi = new System.Windows.Forms.Label();
            this.lblDovizTuru = new System.Windows.Forms.Label();
            this.txtHesapKodu = new System.Windows.Forms.TextBox();
            this.txtHesapAdi = new System.Windows.Forms.TextBox();
            this.txtHesapNo = new System.Windows.Forms.TextBox();
            this.lblHesapNo = new System.Windows.Forms.Label();
            this.comboBoxDovizTuru = new System.Windows.Forms.ComboBox();
            this.lblIBAN = new System.Windows.Forms.Label();
            this.txtIBAN = new System.Windows.Forms.TextBox();
            this.comboBoxOzelKod = new System.Windows.Forms.ComboBox();
            this.lblOzelKod = new System.Windows.Forms.Label();
            this.comboBoxYetkiKodu = new System.Windows.Forms.ComboBox();
            this.lblYetkiKodu = new System.Windows.Forms.Label();
            this.comboBoxStatu = new System.Windows.Forms.ComboBox();
            this.lblStatusu = new System.Windows.Forms.Label();
            this.lblBankaKodu = new System.Windows.Forms.Label();
            this.lblBankaAdi = new System.Windows.Forms.Label();
            this.txtBankaAdi = new System.Windows.Forms.TextBox();
            this.btnKaydet = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnVazgec = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtBankaKodu = new System.Windows.Forms.TextBox();
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
            this.pnlTop.Size = new System.Drawing.Size(662, 48);
            this.pnlTop.TabIndex = 1;
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
            this.lblAnaKayitlar.Size = new System.Drawing.Size(196, 21);
            this.lblAnaKayitlar.TabIndex = 7;
            this.lblAnaKayitlar.Text = "ANA KAYITLAR > BANKA";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageActive = null;
            this.btnClose.Location = new System.Drawing.Point(632, 10);
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
            this.btnMinimize.Location = new System.Drawing.Point(606, 10);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(20, 27);
            this.btnMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimize.TabIndex = 5;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.Zoom = 10;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // lblHesapKodu
            // 
            this.lblHesapKodu.AutoSize = true;
            this.lblHesapKodu.BackColor = System.Drawing.Color.Transparent;
            this.lblHesapKodu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHesapKodu.Location = new System.Drawing.Point(25, 69);
            this.lblHesapKodu.Name = "lblHesapKodu";
            this.lblHesapKodu.Size = new System.Drawing.Size(75, 15);
            this.lblHesapKodu.TabIndex = 2;
            this.lblHesapKodu.Text = "Hesap Kodu";
            // 
            // lblHesapAdi
            // 
            this.lblHesapAdi.AutoSize = true;
            this.lblHesapAdi.BackColor = System.Drawing.Color.Transparent;
            this.lblHesapAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHesapAdi.Location = new System.Drawing.Point(25, 97);
            this.lblHesapAdi.Name = "lblHesapAdi";
            this.lblHesapAdi.Size = new System.Drawing.Size(63, 15);
            this.lblHesapAdi.TabIndex = 3;
            this.lblHesapAdi.Text = "Hesap Adı";
            // 
            // lblDovizTuru
            // 
            this.lblDovizTuru.AutoSize = true;
            this.lblDovizTuru.BackColor = System.Drawing.Color.Transparent;
            this.lblDovizTuru.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDovizTuru.Location = new System.Drawing.Point(25, 122);
            this.lblDovizTuru.Name = "lblDovizTuru";
            this.lblDovizTuru.Size = new System.Drawing.Size(65, 15);
            this.lblDovizTuru.TabIndex = 4;
            this.lblDovizTuru.Text = "Döviz Türü";
            // 
            // txtHesapKodu
            // 
            this.txtHesapKodu.Location = new System.Drawing.Point(105, 66);
            this.txtHesapKodu.Name = "txtHesapKodu";
            this.txtHesapKodu.Size = new System.Drawing.Size(215, 20);
            this.txtHesapKodu.TabIndex = 5;
            // 
            // txtHesapAdi
            // 
            this.txtHesapAdi.Location = new System.Drawing.Point(105, 94);
            this.txtHesapAdi.Name = "txtHesapAdi";
            this.txtHesapAdi.Size = new System.Drawing.Size(528, 20);
            this.txtHesapAdi.TabIndex = 6;
            // 
            // txtHesapNo
            // 
            this.txtHesapNo.Location = new System.Drawing.Point(104, 146);
            this.txtHesapNo.Name = "txtHesapNo";
            this.txtHesapNo.Size = new System.Drawing.Size(215, 20);
            this.txtHesapNo.TabIndex = 7;
            // 
            // lblHesapNo
            // 
            this.lblHesapNo.AutoSize = true;
            this.lblHesapNo.BackColor = System.Drawing.Color.Transparent;
            this.lblHesapNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHesapNo.Location = new System.Drawing.Point(25, 149);
            this.lblHesapNo.Name = "lblHesapNo";
            this.lblHesapNo.Size = new System.Drawing.Size(65, 15);
            this.lblHesapNo.TabIndex = 8;
            this.lblHesapNo.Text = "Hesap No.";
            // 
            // comboBoxDovizTuru
            // 
            this.comboBoxDovizTuru.FormattingEnabled = true;
            this.comboBoxDovizTuru.Location = new System.Drawing.Point(105, 119);
            this.comboBoxDovizTuru.Name = "comboBoxDovizTuru";
            this.comboBoxDovizTuru.Size = new System.Drawing.Size(214, 21);
            this.comboBoxDovizTuru.TabIndex = 9;
            // 
            // lblIBAN
            // 
            this.lblIBAN.AutoSize = true;
            this.lblIBAN.BackColor = System.Drawing.Color.Transparent;
            this.lblIBAN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblIBAN.Location = new System.Drawing.Point(25, 174);
            this.lblIBAN.Name = "lblIBAN";
            this.lblIBAN.Size = new System.Drawing.Size(34, 15);
            this.lblIBAN.TabIndex = 11;
            this.lblIBAN.Text = "IBAN";
            // 
            // txtIBAN
            // 
            this.txtIBAN.Location = new System.Drawing.Point(104, 172);
            this.txtIBAN.Name = "txtIBAN";
            this.txtIBAN.Size = new System.Drawing.Size(215, 20);
            this.txtIBAN.TabIndex = 10;
            // 
            // comboBoxOzelKod
            // 
            this.comboBoxOzelKod.FormattingEnabled = true;
            this.comboBoxOzelKod.Location = new System.Drawing.Point(104, 212);
            this.comboBoxOzelKod.Name = "comboBoxOzelKod";
            this.comboBoxOzelKod.Size = new System.Drawing.Size(109, 21);
            this.comboBoxOzelKod.TabIndex = 15;
            // 
            // lblOzelKod
            // 
            this.lblOzelKod.AutoSize = true;
            this.lblOzelKod.BackColor = System.Drawing.Color.Transparent;
            this.lblOzelKod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOzelKod.Location = new System.Drawing.Point(26, 215);
            this.lblOzelKod.Name = "lblOzelKod";
            this.lblOzelKod.Size = new System.Drawing.Size(57, 15);
            this.lblOzelKod.TabIndex = 14;
            this.lblOzelKod.Text = "Özel Kod";
            // 
            // comboBoxYetkiKodu
            // 
            this.comboBoxYetkiKodu.FormattingEnabled = true;
            this.comboBoxYetkiKodu.Location = new System.Drawing.Point(314, 212);
            this.comboBoxYetkiKodu.Name = "comboBoxYetkiKodu";
            this.comboBoxYetkiKodu.Size = new System.Drawing.Size(109, 21);
            this.comboBoxYetkiKodu.TabIndex = 17;
            // 
            // lblYetkiKodu
            // 
            this.lblYetkiKodu.AutoSize = true;
            this.lblYetkiKodu.BackColor = System.Drawing.Color.Transparent;
            this.lblYetkiKodu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYetkiKodu.Location = new System.Drawing.Point(234, 215);
            this.lblYetkiKodu.Name = "lblYetkiKodu";
            this.lblYetkiKodu.Size = new System.Drawing.Size(65, 15);
            this.lblYetkiKodu.TabIndex = 16;
            this.lblYetkiKodu.Text = "Yetki Kodu";
            // 
            // comboBoxStatu
            // 
            this.comboBoxStatu.FormattingEnabled = true;
            this.comboBoxStatu.Items.AddRange(new object[] {
            "Kullanımda",
            "Kullanım dışı"});
            this.comboBoxStatu.Location = new System.Drawing.Point(524, 212);
            this.comboBoxStatu.Name = "comboBoxStatu";
            this.comboBoxStatu.Size = new System.Drawing.Size(109, 21);
            this.comboBoxStatu.TabIndex = 19;
            this.comboBoxStatu.Text = "Kullanımda";
            // 
            // lblStatusu
            // 
            this.lblStatusu.AutoSize = true;
            this.lblStatusu.BackColor = System.Drawing.Color.Transparent;
            this.lblStatusu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblStatusu.Location = new System.Drawing.Point(444, 215);
            this.lblStatusu.Name = "lblStatusu";
            this.lblStatusu.Size = new System.Drawing.Size(48, 15);
            this.lblStatusu.TabIndex = 18;
            this.lblStatusu.Text = "Statüsü";
            // 
            // lblBankaKodu
            // 
            this.lblBankaKodu.AutoSize = true;
            this.lblBankaKodu.BackColor = System.Drawing.Color.Transparent;
            this.lblBankaKodu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBankaKodu.Location = new System.Drawing.Point(24, 262);
            this.lblBankaKodu.Name = "lblBankaKodu";
            this.lblBankaKodu.Size = new System.Drawing.Size(74, 15);
            this.lblBankaKodu.TabIndex = 20;
            this.lblBankaKodu.Text = "Banka Kodu";
            // 
            // lblBankaAdi
            // 
            this.lblBankaAdi.AutoSize = true;
            this.lblBankaAdi.BackColor = System.Drawing.Color.Transparent;
            this.lblBankaAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBankaAdi.Location = new System.Drawing.Point(25, 287);
            this.lblBankaAdi.Name = "lblBankaAdi";
            this.lblBankaAdi.Size = new System.Drawing.Size(62, 15);
            this.lblBankaAdi.TabIndex = 23;
            this.lblBankaAdi.Text = "Banka Adı";
            // 
            // txtBankaAdi
            // 
            this.txtBankaAdi.Location = new System.Drawing.Point(104, 286);
            this.txtBankaAdi.Name = "txtBankaAdi";
            this.txtBankaAdi.Size = new System.Drawing.Size(215, 20);
            this.txtBankaAdi.TabIndex = 22;
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
            this.btnKaydet.Location = new System.Drawing.Point(423, 366);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Normalcolor = System.Drawing.Color.DarkKhaki;
            this.btnKaydet.OnHovercolor = System.Drawing.Color.Khaki;
            this.btnKaydet.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnKaydet.selected = false;
            this.btnKaydet.Size = new System.Drawing.Size(98, 31);
            this.btnKaydet.TabIndex = 35;
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
            this.btnVazgec.Location = new System.Drawing.Point(537, 366);
            this.btnVazgec.Name = "btnVazgec";
            this.btnVazgec.Normalcolor = System.Drawing.Color.DarkKhaki;
            this.btnVazgec.OnHovercolor = System.Drawing.Color.Khaki;
            this.btnVazgec.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnVazgec.selected = false;
            this.btnVazgec.Size = new System.Drawing.Size(98, 31);
            this.btnVazgec.TabIndex = 36;
            this.btnVazgec.Text = "Vazgeç";
            this.btnVazgec.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnVazgec.Textcolor = System.Drawing.Color.Black;
            this.btnVazgec.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVazgec.Click += new System.EventHandler(this.btnVazgec_Click);
            // 
            // txtBankaKodu
            // 
            this.txtBankaKodu.Location = new System.Drawing.Point(104, 261);
            this.txtBankaKodu.Name = "txtBankaKodu";
            this.txtBankaKodu.Size = new System.Drawing.Size(215, 20);
            this.txtBankaKodu.TabIndex = 37;
            // 
            // frmAnaKayitlar_Banka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(662, 419);
            this.Controls.Add(this.txtBankaKodu);
            this.Controls.Add(this.btnVazgec);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.lblBankaAdi);
            this.Controls.Add(this.txtBankaAdi);
            this.Controls.Add(this.lblBankaKodu);
            this.Controls.Add(this.comboBoxStatu);
            this.Controls.Add(this.lblStatusu);
            this.Controls.Add(this.comboBoxYetkiKodu);
            this.Controls.Add(this.lblYetkiKodu);
            this.Controls.Add(this.comboBoxOzelKod);
            this.Controls.Add(this.lblOzelKod);
            this.Controls.Add(this.lblIBAN);
            this.Controls.Add(this.txtIBAN);
            this.Controls.Add(this.comboBoxDovizTuru);
            this.Controls.Add(this.lblHesapNo);
            this.Controls.Add(this.txtHesapNo);
            this.Controls.Add(this.txtHesapAdi);
            this.Controls.Add(this.txtHesapKodu);
            this.Controls.Add(this.lblDovizTuru);
            this.Controls.Add(this.lblHesapAdi);
            this.Controls.Add(this.lblHesapKodu);
            this.Controls.Add(this.pnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAnaKayitlar_Banka";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ana Kayıtlar > Banka";
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
        private System.Windows.Forms.Label lblHesapKodu;
        private System.Windows.Forms.Label lblHesapAdi;
        private System.Windows.Forms.Label lblDovizTuru;
        private System.Windows.Forms.TextBox txtHesapKodu;
        private System.Windows.Forms.TextBox txtHesapAdi;
        private System.Windows.Forms.TextBox txtHesapNo;
        private System.Windows.Forms.Label lblHesapNo;
        private System.Windows.Forms.ComboBox comboBoxDovizTuru;
        private System.Windows.Forms.Label lblIBAN;
        private System.Windows.Forms.TextBox txtIBAN;
        private System.Windows.Forms.ComboBox comboBoxOzelKod;
        private System.Windows.Forms.Label lblOzelKod;
        private System.Windows.Forms.ComboBox comboBoxYetkiKodu;
        private System.Windows.Forms.Label lblYetkiKodu;
        private System.Windows.Forms.ComboBox comboBoxStatu;
        private System.Windows.Forms.Label lblStatusu;
        private System.Windows.Forms.Label lblBankaKodu;
        private System.Windows.Forms.Label lblBankaAdi;
        private System.Windows.Forms.TextBox txtBankaAdi;
        private Bunifu.Framework.UI.BunifuFlatButton btnKaydet;
        private Bunifu.Framework.UI.BunifuFlatButton btnVazgec;
        private System.Windows.Forms.TextBox txtBankaKodu;
    }
}