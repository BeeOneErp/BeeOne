
namespace BeeOne
{
    partial class frmStokIslemleri_MaliyetFisleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStokIslemleri_MaliyetFisleri));
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblStokIslemleri = new System.Windows.Forms.Label();
            this.btnClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnMinimize = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnVazgec = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnKaydet = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lblMaliyetTutari = new System.Windows.Forms.Label();
            this.txtMaliyetTutari = new System.Windows.Forms.TextBox();
            this.lblMalzemeKodu = new System.Windows.Forms.Label();
            this.lblCHKodu = new System.Windows.Forms.Label();
            this.txtCHKodu = new System.Windows.Forms.TextBox();
            this.txtMaliyetNo = new System.Windows.Forms.TextBox();
            this.lblTarih = new System.Windows.Forms.Label();
            this.lblMaliyetNo = new System.Windows.Forms.Label();
            this.txtMalzemeKodu = new System.Windows.Forms.TextBox();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.lblAciklama = new System.Windows.Forms.Label();
            this.txtFaturaNo = new System.Windows.Forms.TextBox();
            this.lblFaturaNo = new System.Windows.Forms.Label();
            this.dateTimePickerTarih = new System.Windows.Forms.DateTimePicker();
            this.btnCHKodu = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnFaturaNo = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.lblStokIslemleri);
            this.pnlTop.Controls.Add(this.btnClose);
            this.pnlTop.Controls.Add(this.btnMinimize);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(524, 48);
            this.pnlTop.TabIndex = 13;
            this.pnlTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTop_MouseDown);
            this.pnlTop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlTop_MouseMove);
            this.pnlTop.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlTop_MouseUp);
            // 
            // lblStokIslemleri
            // 
            this.lblStokIslemleri.AutoSize = true;
            this.lblStokIslemleri.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblStokIslemleri.ForeColor = System.Drawing.Color.DarkKhaki;
            this.lblStokIslemleri.Location = new System.Drawing.Point(12, 13);
            this.lblStokIslemleri.Name = "lblStokIslemleri";
            this.lblStokIslemleri.Size = new System.Drawing.Size(275, 42);
            this.lblStokIslemleri.TabIndex = 7;
            this.lblStokIslemleri.Text = "STOK İŞLEMLERİ > MALİYET FİŞLERİ\r\n\r\n";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageActive = null;
            this.btnClose.Location = new System.Drawing.Point(494, 10);
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
            this.btnMinimize.Location = new System.Drawing.Point(468, 10);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(20, 27);
            this.btnMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimize.TabIndex = 5;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.Zoom = 10;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
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
            this.btnVazgec.Location = new System.Drawing.Point(311, 453);
            this.btnVazgec.Name = "btnVazgec";
            this.btnVazgec.Normalcolor = System.Drawing.Color.DarkKhaki;
            this.btnVazgec.OnHovercolor = System.Drawing.Color.Khaki;
            this.btnVazgec.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnVazgec.selected = false;
            this.btnVazgec.Size = new System.Drawing.Size(98, 31);
            this.btnVazgec.TabIndex = 56;
            this.btnVazgec.Text = "Vazgeç";
            this.btnVazgec.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnVazgec.Textcolor = System.Drawing.Color.Black;
            this.btnVazgec.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btnKaydet.Location = new System.Drawing.Point(197, 453);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Normalcolor = System.Drawing.Color.DarkKhaki;
            this.btnKaydet.OnHovercolor = System.Drawing.Color.Khaki;
            this.btnKaydet.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnKaydet.selected = false;
            this.btnKaydet.Size = new System.Drawing.Size(98, 31);
            this.btnKaydet.TabIndex = 55;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnKaydet.Textcolor = System.Drawing.Color.Black;
            this.btnKaydet.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // lblMaliyetTutari
            // 
            this.lblMaliyetTutari.AutoSize = true;
            this.lblMaliyetTutari.BackColor = System.Drawing.Color.Transparent;
            this.lblMaliyetTutari.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMaliyetTutari.Location = new System.Drawing.Point(89, 220);
            this.lblMaliyetTutari.Name = "lblMaliyetTutari";
            this.lblMaliyetTutari.Size = new System.Drawing.Size(80, 15);
            this.lblMaliyetTutari.TabIndex = 279;
            this.lblMaliyetTutari.Text = "Maliyet Tutarı";
            // 
            // txtMaliyetTutari
            // 
            this.txtMaliyetTutari.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMaliyetTutari.Location = new System.Drawing.Point(205, 219);
            this.txtMaliyetTutari.Multiline = true;
            this.txtMaliyetTutari.Name = "txtMaliyetTutari";
            this.txtMaliyetTutari.Size = new System.Drawing.Size(204, 21);
            this.txtMaliyetTutari.TabIndex = 278;
            // 
            // lblMalzemeKodu
            // 
            this.lblMalzemeKodu.AutoSize = true;
            this.lblMalzemeKodu.BackColor = System.Drawing.Color.Transparent;
            this.lblMalzemeKodu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMalzemeKodu.Location = new System.Drawing.Point(87, 192);
            this.lblMalzemeKodu.Name = "lblMalzemeKodu";
            this.lblMalzemeKodu.Size = new System.Drawing.Size(91, 15);
            this.lblMalzemeKodu.TabIndex = 277;
            this.lblMalzemeKodu.Text = "Malzeme Kodu";
            // 
            // lblCHKodu
            // 
            this.lblCHKodu.AutoSize = true;
            this.lblCHKodu.BackColor = System.Drawing.Color.Transparent;
            this.lblCHKodu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCHKodu.Location = new System.Drawing.Point(87, 139);
            this.lblCHKodu.Name = "lblCHKodu";
            this.lblCHKodu.Size = new System.Drawing.Size(100, 15);
            this.lblCHKodu.TabIndex = 275;
            this.lblCHKodu.Text = "Cari Hesap Kodu";
            // 
            // txtCHKodu
            // 
            this.txtCHKodu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtCHKodu.Location = new System.Drawing.Point(205, 138);
            this.txtCHKodu.Multiline = true;
            this.txtCHKodu.Name = "txtCHKodu";
            this.txtCHKodu.Size = new System.Drawing.Size(204, 21);
            this.txtCHKodu.TabIndex = 274;
            // 
            // txtMaliyetNo
            // 
            this.txtMaliyetNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMaliyetNo.Location = new System.Drawing.Point(205, 85);
            this.txtMaliyetNo.Multiline = true;
            this.txtMaliyetNo.Name = "txtMaliyetNo";
            this.txtMaliyetNo.Size = new System.Drawing.Size(204, 21);
            this.txtMaliyetNo.TabIndex = 272;
            // 
            // lblTarih
            // 
            this.lblTarih.AutoSize = true;
            this.lblTarih.BackColor = System.Drawing.Color.Transparent;
            this.lblTarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTarih.Location = new System.Drawing.Point(87, 112);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(38, 15);
            this.lblTarih.TabIndex = 271;
            this.lblTarih.Text = "Tarihi";
            // 
            // lblMaliyetNo
            // 
            this.lblMaliyetNo.AutoSize = true;
            this.lblMaliyetNo.BackColor = System.Drawing.Color.Transparent;
            this.lblMaliyetNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMaliyetNo.Location = new System.Drawing.Point(87, 87);
            this.lblMaliyetNo.Name = "lblMaliyetNo";
            this.lblMaliyetNo.Size = new System.Drawing.Size(65, 15);
            this.lblMaliyetNo.TabIndex = 270;
            this.lblMaliyetNo.Text = "Maliyet No";
            // 
            // txtMalzemeKodu
            // 
            this.txtMalzemeKodu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMalzemeKodu.Location = new System.Drawing.Point(205, 192);
            this.txtMalzemeKodu.Multiline = true;
            this.txtMalzemeKodu.Name = "txtMalzemeKodu";
            this.txtMalzemeKodu.Size = new System.Drawing.Size(204, 21);
            this.txtMalzemeKodu.TabIndex = 280;
            // 
            // txtAciklama
            // 
            this.txtAciklama.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAciklama.Location = new System.Drawing.Point(90, 294);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(319, 135);
            this.txtAciklama.TabIndex = 282;
            // 
            // lblAciklama
            // 
            this.lblAciklama.AutoSize = true;
            this.lblAciklama.BackColor = System.Drawing.Color.Transparent;
            this.lblAciklama.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAciklama.Location = new System.Drawing.Point(87, 262);
            this.lblAciklama.Name = "lblAciklama";
            this.lblAciklama.Size = new System.Drawing.Size(72, 16);
            this.lblAciklama.TabIndex = 281;
            this.lblAciklama.Text = "Açıklama";
            // 
            // txtFaturaNo
            // 
            this.txtFaturaNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtFaturaNo.Location = new System.Drawing.Point(205, 165);
            this.txtFaturaNo.Multiline = true;
            this.txtFaturaNo.Name = "txtFaturaNo";
            this.txtFaturaNo.Size = new System.Drawing.Size(204, 21);
            this.txtFaturaNo.TabIndex = 284;
            // 
            // lblFaturaNo
            // 
            this.lblFaturaNo.AutoSize = true;
            this.lblFaturaNo.BackColor = System.Drawing.Color.Transparent;
            this.lblFaturaNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFaturaNo.Location = new System.Drawing.Point(87, 165);
            this.lblFaturaNo.Name = "lblFaturaNo";
            this.lblFaturaNo.Size = new System.Drawing.Size(61, 15);
            this.lblFaturaNo.TabIndex = 283;
            this.lblFaturaNo.Text = "Fatura No";
            // 
            // dateTimePickerTarih
            // 
            this.dateTimePickerTarih.Location = new System.Drawing.Point(205, 112);
            this.dateTimePickerTarih.Name = "dateTimePickerTarih";
            this.dateTimePickerTarih.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerTarih.TabIndex = 285;
            // 
            // btnCHKodu
            // 
            this.btnCHKodu.Activecolor = System.Drawing.Color.Khaki;
            this.btnCHKodu.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnCHKodu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCHKodu.BorderRadius = 0;
            this.btnCHKodu.ButtonText = "...";
            this.btnCHKodu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCHKodu.DisabledColor = System.Drawing.Color.Gray;
            this.btnCHKodu.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCHKodu.Iconimage = null;
            this.btnCHKodu.Iconimage_right = null;
            this.btnCHKodu.Iconimage_right_Selected = null;
            this.btnCHKodu.Iconimage_Selected = null;
            this.btnCHKodu.IconMarginLeft = 0;
            this.btnCHKodu.IconMarginRight = 0;
            this.btnCHKodu.IconRightVisible = true;
            this.btnCHKodu.IconRightZoom = 0D;
            this.btnCHKodu.IconVisible = true;
            this.btnCHKodu.IconZoom = 90D;
            this.btnCHKodu.IsTab = false;
            this.btnCHKodu.Location = new System.Drawing.Point(386, 139);
            this.btnCHKodu.Name = "btnCHKodu";
            this.btnCHKodu.Normalcolor = System.Drawing.Color.DarkKhaki;
            this.btnCHKodu.OnHovercolor = System.Drawing.Color.Khaki;
            this.btnCHKodu.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnCHKodu.selected = false;
            this.btnCHKodu.Size = new System.Drawing.Size(23, 20);
            this.btnCHKodu.TabIndex = 286;
            this.btnCHKodu.Text = "...";
            this.btnCHKodu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCHKodu.Textcolor = System.Drawing.Color.Black;
            this.btnCHKodu.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnFaturaNo
            // 
            this.btnFaturaNo.Activecolor = System.Drawing.Color.Khaki;
            this.btnFaturaNo.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnFaturaNo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFaturaNo.BorderRadius = 0;
            this.btnFaturaNo.ButtonText = "...";
            this.btnFaturaNo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFaturaNo.DisabledColor = System.Drawing.Color.Gray;
            this.btnFaturaNo.Iconcolor = System.Drawing.Color.Transparent;
            this.btnFaturaNo.Iconimage = null;
            this.btnFaturaNo.Iconimage_right = null;
            this.btnFaturaNo.Iconimage_right_Selected = null;
            this.btnFaturaNo.Iconimage_Selected = null;
            this.btnFaturaNo.IconMarginLeft = 0;
            this.btnFaturaNo.IconMarginRight = 0;
            this.btnFaturaNo.IconRightVisible = true;
            this.btnFaturaNo.IconRightZoom = 0D;
            this.btnFaturaNo.IconVisible = true;
            this.btnFaturaNo.IconZoom = 90D;
            this.btnFaturaNo.IsTab = false;
            this.btnFaturaNo.Location = new System.Drawing.Point(386, 166);
            this.btnFaturaNo.Name = "btnFaturaNo";
            this.btnFaturaNo.Normalcolor = System.Drawing.Color.DarkKhaki;
            this.btnFaturaNo.OnHovercolor = System.Drawing.Color.Khaki;
            this.btnFaturaNo.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnFaturaNo.selected = false;
            this.btnFaturaNo.Size = new System.Drawing.Size(23, 20);
            this.btnFaturaNo.TabIndex = 287;
            this.btnFaturaNo.Text = "...";
            this.btnFaturaNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnFaturaNo.Textcolor = System.Drawing.Color.Black;
            this.btnFaturaNo.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // frmStokIslemleri_MaliyetFisleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.BackgroundImage = global::BeeOne.Properties.Resources.background__39_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(524, 542);
            this.Controls.Add(this.btnFaturaNo);
            this.Controls.Add(this.btnCHKodu);
            this.Controls.Add(this.dateTimePickerTarih);
            this.Controls.Add(this.txtFaturaNo);
            this.Controls.Add(this.lblFaturaNo);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.lblAciklama);
            this.Controls.Add(this.txtMalzemeKodu);
            this.Controls.Add(this.lblMaliyetTutari);
            this.Controls.Add(this.txtMaliyetTutari);
            this.Controls.Add(this.lblMalzemeKodu);
            this.Controls.Add(this.lblCHKodu);
            this.Controls.Add(this.txtCHKodu);
            this.Controls.Add(this.txtMaliyetNo);
            this.Controls.Add(this.lblTarih);
            this.Controls.Add(this.lblMaliyetNo);
            this.Controls.Add(this.btnVazgec);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.pnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmStokIslemleri_MaliyetFisleri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stok İşlemleri > Maliyet Fişleri";
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblStokIslemleri;
        private Bunifu.Framework.UI.BunifuImageButton btnClose;
        private Bunifu.Framework.UI.BunifuImageButton btnMinimize;
        private Bunifu.Framework.UI.BunifuFlatButton btnVazgec;
        private Bunifu.Framework.UI.BunifuFlatButton btnKaydet;
        private System.Windows.Forms.Label lblMaliyetTutari;
        private System.Windows.Forms.TextBox txtMaliyetTutari;
        private System.Windows.Forms.Label lblMalzemeKodu;
        private System.Windows.Forms.Label lblCHKodu;
        private System.Windows.Forms.TextBox txtCHKodu;
        private System.Windows.Forms.TextBox txtMaliyetNo;
        private System.Windows.Forms.Label lblTarih;
        private System.Windows.Forms.Label lblMaliyetNo;
        private System.Windows.Forms.TextBox txtMalzemeKodu;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.Label lblAciklama;
        private System.Windows.Forms.TextBox txtFaturaNo;
        private System.Windows.Forms.Label lblFaturaNo;
        private System.Windows.Forms.DateTimePicker dateTimePickerTarih;
        private Bunifu.Framework.UI.BunifuFlatButton btnCHKodu;
        private Bunifu.Framework.UI.BunifuFlatButton btnFaturaNo;
    }
}