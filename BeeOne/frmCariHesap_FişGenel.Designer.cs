
namespace BeeOne
{
    partial class frmCariHesap_FişGenel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCariHesap_FişGenel));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblCariHesap = new System.Windows.Forms.Label();
            this.btnClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnMinimize = new Bunifu.Framework.UI.BunifuImageButton();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.lblAciklama = new System.Windows.Forms.Label();
            this.lblYerelParaBirimi = new System.Windows.Forms.Label();
            this.btnVazgec = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnKaydet = new Bunifu.Framework.UI.BunifuFlatButton();
            this.dataGridViewFis = new System.Windows.Forms.DataGridView();
            this.comboBoxIsYeri = new System.Windows.Forms.ComboBox();
            this.lblIsYeri = new System.Windows.Forms.Label();
            this.comboBoxYetkiKodu = new System.Windows.Forms.ComboBox();
            this.comboBoxOzelKod = new System.Windows.Forms.ComboBox();
            this.lblYetkiKodu = new System.Windows.Forms.Label();
            this.lblOzelKod = new System.Windows.Forms.Label();
            this.btnTarih = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lblTarih = new System.Windows.Forms.Label();
            this.lblFisNo = new System.Windows.Forms.Label();
            this.txtTarih = new System.Windows.Forms.TextBox();
            this.txtFisNo = new System.Windows.Forms.TextBox();
            this.lblSatisElemaniKodu = new System.Windows.Forms.Label();
            this.lblislemdovizli = new System.Windows.Forms.Label();
            this.cbxSatisElemani = new System.Windows.Forms.ComboBox();
            this.lblKur = new System.Windows.Forms.Label();
            this.tbxKur = new System.Windows.Forms.TextBox();
            this.cbxKurTuru = new System.Windows.Forms.ComboBox();
            this.lblKurTuru = new System.Windows.Forms.Label();
            this.cbxFisTuru = new System.Windows.Forms.ComboBox();
            this.lblFisTuru = new System.Windows.Forms.Label();
            this.txtDovizliToplamAlacak = new System.Windows.Forms.TextBox();
            this.txtTLToplamAlacak = new System.Windows.Forms.TextBox();
            this.lblToplamAlacak = new System.Windows.Forms.Label();
            this.txtDovızToplamBorc = new System.Windows.Forms.TextBox();
            this.txtTLToplamBorc = new System.Windows.Forms.TextBox();
            this.lblToplamBorc = new System.Windows.Forms.Label();
            this.CHKodu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TicIslemGrb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Aciklama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tutar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DovTutar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MakbuzNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFis)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.lblCariHesap);
            this.pnlTop.Controls.Add(this.btnClose);
            this.pnlTop.Controls.Add(this.btnMinimize);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1113, 48);
            this.pnlTop.TabIndex = 2;
            this.pnlTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTop_MouseDown);
            this.pnlTop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlTop_MouseMove);
            this.pnlTop.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlTop_MouseUp);
            // 
            // lblCariHesap
            // 
            this.lblCariHesap.AutoSize = true;
            this.lblCariHesap.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCariHesap.ForeColor = System.Drawing.Color.DarkKhaki;
            this.lblCariHesap.Location = new System.Drawing.Point(12, 13);
            this.lblCariHesap.Name = "lblCariHesap";
            this.lblCariHesap.Size = new System.Drawing.Size(224, 21);
            this.lblCariHesap.TabIndex = 7;
            this.lblCariHesap.Text = "CARİ HESAP İŞLEMLERİ > FİŞ";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageActive = null;
            this.btnClose.Location = new System.Drawing.Point(1083, 10);
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
            this.btnMinimize.Location = new System.Drawing.Point(1057, 10);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(20, 27);
            this.btnMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimize.TabIndex = 5;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.Zoom = 10;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(34, 417);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(437, 43);
            this.txtAciklama.TabIndex = 195;
            // 
            // lblAciklama
            // 
            this.lblAciklama.AutoSize = true;
            this.lblAciklama.BackColor = System.Drawing.Color.Transparent;
            this.lblAciklama.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAciklama.Location = new System.Drawing.Point(31, 392);
            this.lblAciklama.Name = "lblAciklama";
            this.lblAciklama.Size = new System.Drawing.Size(72, 16);
            this.lblAciklama.TabIndex = 194;
            this.lblAciklama.Text = "Açıklama";
            // 
            // lblYerelParaBirimi
            // 
            this.lblYerelParaBirimi.AutoSize = true;
            this.lblYerelParaBirimi.BackColor = System.Drawing.Color.Transparent;
            this.lblYerelParaBirimi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYerelParaBirimi.Location = new System.Drawing.Point(673, 392);
            this.lblYerelParaBirimi.Name = "lblYerelParaBirimi";
            this.lblYerelParaBirimi.Size = new System.Drawing.Size(116, 15);
            this.lblYerelParaBirimi.TabIndex = 187;
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
            this.btnVazgec.Location = new System.Drawing.Point(970, 493);
            this.btnVazgec.Name = "btnVazgec";
            this.btnVazgec.Normalcolor = System.Drawing.Color.DarkKhaki;
            this.btnVazgec.OnHovercolor = System.Drawing.Color.Khaki;
            this.btnVazgec.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnVazgec.selected = false;
            this.btnVazgec.Size = new System.Drawing.Size(98, 31);
            this.btnVazgec.TabIndex = 186;
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
            this.btnKaydet.Location = new System.Drawing.Point(864, 493);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Normalcolor = System.Drawing.Color.DarkKhaki;
            this.btnKaydet.OnHovercolor = System.Drawing.Color.Khaki;
            this.btnKaydet.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnKaydet.selected = false;
            this.btnKaydet.Size = new System.Drawing.Size(98, 31);
            this.btnKaydet.TabIndex = 185;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnKaydet.Textcolor = System.Drawing.Color.Black;
            this.btnKaydet.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.CHKodu,
            this.CHAdi,
            this.TicIslemGrb,
            this.Aciklama,
            this.Tutar,
            this.DovTutar,
            this.MakbuzNo});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(0, 6, 0, 6);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewFis.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewFis.Location = new System.Drawing.Point(34, 160);
            this.dataGridViewFis.Name = "dataGridViewFis";
            this.dataGridViewFis.ReadOnly = true;
            this.dataGridViewFis.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.dataGridViewFis.RowTemplate.Height = 40;
            this.dataGridViewFis.Size = new System.Drawing.Size(1034, 212);
            this.dataGridViewFis.TabIndex = 184;
            // 
            // comboBoxIsYeri
            // 
            this.comboBoxIsYeri.FormattingEnabled = true;
            this.comboBoxIsYeri.Location = new System.Drawing.Point(908, 63);
            this.comboBoxIsYeri.Name = "comboBoxIsYeri";
            this.comboBoxIsYeri.Size = new System.Drawing.Size(160, 21);
            this.comboBoxIsYeri.TabIndex = 183;
            // 
            // lblIsYeri
            // 
            this.lblIsYeri.AutoSize = true;
            this.lblIsYeri.BackColor = System.Drawing.Color.Transparent;
            this.lblIsYeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblIsYeri.Location = new System.Drawing.Point(851, 65);
            this.lblIsYeri.Name = "lblIsYeri";
            this.lblIsYeri.Size = new System.Drawing.Size(40, 15);
            this.lblIsYeri.TabIndex = 182;
            this.lblIsYeri.Text = "İş Yeri";
            // 
            // comboBoxYetkiKodu
            // 
            this.comboBoxYetkiKodu.FormattingEnabled = true;
            this.comboBoxYetkiKodu.Location = new System.Drawing.Point(617, 88);
            this.comboBoxYetkiKodu.Name = "comboBoxYetkiKodu";
            this.comboBoxYetkiKodu.Size = new System.Drawing.Size(172, 21);
            this.comboBoxYetkiKodu.TabIndex = 178;
            // 
            // comboBoxOzelKod
            // 
            this.comboBoxOzelKod.FormattingEnabled = true;
            this.comboBoxOzelKod.Location = new System.Drawing.Point(617, 63);
            this.comboBoxOzelKod.Name = "comboBoxOzelKod";
            this.comboBoxOzelKod.Size = new System.Drawing.Size(172, 21);
            this.comboBoxOzelKod.TabIndex = 177;
            // 
            // lblYetkiKodu
            // 
            this.lblYetkiKodu.AutoSize = true;
            this.lblYetkiKodu.BackColor = System.Drawing.Color.Transparent;
            this.lblYetkiKodu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYetkiKodu.Location = new System.Drawing.Point(536, 87);
            this.lblYetkiKodu.Name = "lblYetkiKodu";
            this.lblYetkiKodu.Size = new System.Drawing.Size(65, 15);
            this.lblYetkiKodu.TabIndex = 176;
            this.lblYetkiKodu.Text = "Yetki Kodu";
            // 
            // lblOzelKod
            // 
            this.lblOzelKod.AutoSize = true;
            this.lblOzelKod.BackColor = System.Drawing.Color.Transparent;
            this.lblOzelKod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOzelKod.Location = new System.Drawing.Point(544, 62);
            this.lblOzelKod.Name = "lblOzelKod";
            this.lblOzelKod.Size = new System.Drawing.Size(57, 15);
            this.lblOzelKod.TabIndex = 175;
            this.lblOzelKod.Text = "Özel Kod";
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
            this.btnTarih.Location = new System.Drawing.Point(347, 89);
            this.btnTarih.Name = "btnTarih";
            this.btnTarih.Normalcolor = System.Drawing.Color.DarkKhaki;
            this.btnTarih.OnHovercolor = System.Drawing.Color.Khaki;
            this.btnTarih.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnTarih.selected = false;
            this.btnTarih.Size = new System.Drawing.Size(23, 20);
            this.btnTarih.TabIndex = 169;
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
            this.lblTarih.Location = new System.Drawing.Point(31, 90);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(35, 15);
            this.lblTarih.TabIndex = 167;
            this.lblTarih.Text = "Tarih";
            // 
            // lblFisNo
            // 
            this.lblFisNo.AutoSize = true;
            this.lblFisNo.BackColor = System.Drawing.Color.Transparent;
            this.lblFisNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFisNo.Location = new System.Drawing.Point(31, 65);
            this.lblFisNo.Name = "lblFisNo";
            this.lblFisNo.Size = new System.Drawing.Size(45, 15);
            this.lblFisNo.TabIndex = 166;
            this.lblFisNo.Text = "Fiş No.";
            // 
            // txtTarih
            // 
            this.txtTarih.Location = new System.Drawing.Point(171, 88);
            this.txtTarih.Multiline = true;
            this.txtTarih.Name = "txtTarih";
            this.txtTarih.Size = new System.Drawing.Size(199, 21);
            this.txtTarih.TabIndex = 164;
            // 
            // txtFisNo
            // 
            this.txtFisNo.Location = new System.Drawing.Point(171, 64);
            this.txtFisNo.Multiline = true;
            this.txtFisNo.Name = "txtFisNo";
            this.txtFisNo.Size = new System.Drawing.Size(320, 21);
            this.txtFisNo.TabIndex = 163;
            // 
            // lblSatisElemaniKodu
            // 
            this.lblSatisElemaniKodu.AutoSize = true;
            this.lblSatisElemaniKodu.BackColor = System.Drawing.Color.Transparent;
            this.lblSatisElemaniKodu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSatisElemaniKodu.Location = new System.Drawing.Point(486, 114);
            this.lblSatisElemaniKodu.Name = "lblSatisElemaniKodu";
            this.lblSatisElemaniKodu.Size = new System.Drawing.Size(115, 15);
            this.lblSatisElemaniKodu.TabIndex = 196;
            this.lblSatisElemaniKodu.Text = "Satış Elemanı Kodu";
            // 
            // lblislemdovizli
            // 
            this.lblislemdovizli.AutoSize = true;
            this.lblislemdovizli.BackColor = System.Drawing.Color.Transparent;
            this.lblislemdovizli.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblislemdovizli.Location = new System.Drawing.Point(905, 394);
            this.lblislemdovizli.Name = "lblislemdovizli";
            this.lblislemdovizli.Size = new System.Drawing.Size(85, 15);
            this.lblislemdovizli.TabIndex = 199;
            this.lblislemdovizli.Text = "İşlem Dövizi";
            // 
            // cbxSatisElemani
            // 
            this.cbxSatisElemani.FormattingEnabled = true;
            this.cbxSatisElemani.Location = new System.Drawing.Point(617, 113);
            this.cbxSatisElemani.Name = "cbxSatisElemani";
            this.cbxSatisElemani.Size = new System.Drawing.Size(172, 21);
            this.cbxSatisElemani.TabIndex = 200;
            // 
            // lblKur
            // 
            this.lblKur.AutoSize = true;
            this.lblKur.BackColor = System.Drawing.Color.Transparent;
            this.lblKur.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKur.Location = new System.Drawing.Point(865, 115);
            this.lblKur.Name = "lblKur";
            this.lblKur.Size = new System.Drawing.Size(26, 15);
            this.lblKur.TabIndex = 201;
            this.lblKur.Text = "Kur";
            // 
            // tbxKur
            // 
            this.tbxKur.Location = new System.Drawing.Point(908, 114);
            this.tbxKur.Multiline = true;
            this.tbxKur.Name = "tbxKur";
            this.tbxKur.Size = new System.Drawing.Size(85, 21);
            this.tbxKur.TabIndex = 202;
            // 
            // cbxKurTuru
            // 
            this.cbxKurTuru.FormattingEnabled = true;
            this.cbxKurTuru.Location = new System.Drawing.Point(908, 88);
            this.cbxKurTuru.Name = "cbxKurTuru";
            this.cbxKurTuru.Size = new System.Drawing.Size(85, 21);
            this.cbxKurTuru.TabIndex = 203;
            // 
            // lblKurTuru
            // 
            this.lblKurTuru.AutoSize = true;
            this.lblKurTuru.BackColor = System.Drawing.Color.Transparent;
            this.lblKurTuru.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKurTuru.Location = new System.Drawing.Point(837, 90);
            this.lblKurTuru.Name = "lblKurTuru";
            this.lblKurTuru.Size = new System.Drawing.Size(54, 15);
            this.lblKurTuru.TabIndex = 204;
            this.lblKurTuru.Text = "Kur Türü";
            // 
            // cbxFisTuru
            // 
            this.cbxFisTuru.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbxFisTuru.FormattingEnabled = true;
            this.cbxFisTuru.Items.AddRange(new object[] {
            "(1) Nakit Tahsilat",
            "(2) Nakit Ödeme",
            "(3) Borç Dekontu",
            "(4) Alacak Dekontu"});
            this.cbxFisTuru.Location = new System.Drawing.Point(171, 115);
            this.cbxFisTuru.Name = "cbxFisTuru";
            this.cbxFisTuru.Size = new System.Drawing.Size(172, 23);
            this.cbxFisTuru.TabIndex = 206;
            this.cbxFisTuru.Text = "(1) Nakit Tahsilat";
            // 
            // lblFisTuru
            // 
            this.lblFisTuru.AutoSize = true;
            this.lblFisTuru.BackColor = System.Drawing.Color.Transparent;
            this.lblFisTuru.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFisTuru.Location = new System.Drawing.Point(31, 116);
            this.lblFisTuru.Name = "lblFisTuru";
            this.lblFisTuru.Size = new System.Drawing.Size(51, 15);
            this.lblFisTuru.TabIndex = 205;
            this.lblFisTuru.Text = "Fiş Türü";
            // 
            // txtDovizliToplamAlacak
            // 
            this.txtDovizliToplamAlacak.Location = new System.Drawing.Point(864, 444);
            this.txtDovizliToplamAlacak.Multiline = true;
            this.txtDovizliToplamAlacak.Name = "txtDovizliToplamAlacak";
            this.txtDovizliToplamAlacak.Size = new System.Drawing.Size(179, 21);
            this.txtDovizliToplamAlacak.TabIndex = 235;
            // 
            // txtTLToplamAlacak
            // 
            this.txtTLToplamAlacak.Location = new System.Drawing.Point(654, 444);
            this.txtTLToplamAlacak.Multiline = true;
            this.txtTLToplamAlacak.Name = "txtTLToplamAlacak";
            this.txtTLToplamAlacak.Size = new System.Drawing.Size(179, 21);
            this.txtTLToplamAlacak.TabIndex = 234;
            // 
            // lblToplamAlacak
            // 
            this.lblToplamAlacak.AutoSize = true;
            this.lblToplamAlacak.BackColor = System.Drawing.Color.Transparent;
            this.lblToplamAlacak.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplamAlacak.Location = new System.Drawing.Point(550, 450);
            this.lblToplamAlacak.Name = "lblToplamAlacak";
            this.lblToplamAlacak.Size = new System.Drawing.Size(101, 15);
            this.lblToplamAlacak.TabIndex = 233;
            this.lblToplamAlacak.Text = "Toplam Alacak";
            // 
            // txtDovızToplamBorc
            // 
            this.txtDovızToplamBorc.Location = new System.Drawing.Point(864, 417);
            this.txtDovızToplamBorc.Multiline = true;
            this.txtDovızToplamBorc.Name = "txtDovızToplamBorc";
            this.txtDovızToplamBorc.Size = new System.Drawing.Size(179, 21);
            this.txtDovızToplamBorc.TabIndex = 232;
            // 
            // txtTLToplamBorc
            // 
            this.txtTLToplamBorc.Location = new System.Drawing.Point(654, 417);
            this.txtTLToplamBorc.Multiline = true;
            this.txtTLToplamBorc.Name = "txtTLToplamBorc";
            this.txtTLToplamBorc.Size = new System.Drawing.Size(179, 21);
            this.txtTLToplamBorc.TabIndex = 231;
            // 
            // lblToplamBorc
            // 
            this.lblToplamBorc.AutoSize = true;
            this.lblToplamBorc.BackColor = System.Drawing.Color.Transparent;
            this.lblToplamBorc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplamBorc.Location = new System.Drawing.Point(563, 418);
            this.lblToplamBorc.Name = "lblToplamBorc";
            this.lblToplamBorc.Size = new System.Drawing.Size(88, 15);
            this.lblToplamBorc.TabIndex = 230;
            this.lblToplamBorc.Text = "Toplam Borç";
            // 
            // CHKodu
            // 
            this.CHKodu.HeaderText = "Cari Hesap Kodu";
            this.CHKodu.Name = "CHKodu";
            this.CHKodu.ReadOnly = true;
            // 
            // CHAdi
            // 
            this.CHAdi.HeaderText = "Cari Hesap Unvanı";
            this.CHAdi.Name = "CHAdi";
            this.CHAdi.ReadOnly = true;
            // 
            // TicIslemGrb
            // 
            this.TicIslemGrb.HeaderText = "Ticari İşlem Grubu";
            this.TicIslemGrb.Name = "TicIslemGrb";
            this.TicIslemGrb.ReadOnly = true;
            // 
            // Aciklama
            // 
            this.Aciklama.HeaderText = "Açıklama";
            this.Aciklama.Name = "Aciklama";
            this.Aciklama.ReadOnly = true;
            // 
            // Tutar
            // 
            this.Tutar.HeaderText = "Tutar";
            this.Tutar.Name = "Tutar";
            this.Tutar.ReadOnly = true;
            // 
            // DovTutar
            // 
            this.DovTutar.HeaderText = "Dövizli Tutar";
            this.DovTutar.Name = "DovTutar";
            this.DovTutar.ReadOnly = true;
            // 
            // MakbuzNo
            // 
            this.MakbuzNo.HeaderText = "Makbuz No";
            this.MakbuzNo.Name = "MakbuzNo";
            this.MakbuzNo.ReadOnly = true;
            // 
            // frmCariHesap_FişGenel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.BackgroundImage = global::BeeOne.Properties.Resources.background__39_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1113, 548);
            this.Controls.Add(this.txtDovizliToplamAlacak);
            this.Controls.Add(this.txtTLToplamAlacak);
            this.Controls.Add(this.lblToplamAlacak);
            this.Controls.Add(this.txtDovızToplamBorc);
            this.Controls.Add(this.txtTLToplamBorc);
            this.Controls.Add(this.lblToplamBorc);
            this.Controls.Add(this.cbxFisTuru);
            this.Controls.Add(this.lblFisTuru);
            this.Controls.Add(this.lblKurTuru);
            this.Controls.Add(this.cbxKurTuru);
            this.Controls.Add(this.tbxKur);
            this.Controls.Add(this.lblKur);
            this.Controls.Add(this.cbxSatisElemani);
            this.Controls.Add(this.lblislemdovizli);
            this.Controls.Add(this.lblSatisElemaniKodu);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.lblAciklama);
            this.Controls.Add(this.lblYerelParaBirimi);
            this.Controls.Add(this.btnVazgec);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.dataGridViewFis);
            this.Controls.Add(this.comboBoxIsYeri);
            this.Controls.Add(this.lblIsYeri);
            this.Controls.Add(this.comboBoxYetkiKodu);
            this.Controls.Add(this.comboBoxOzelKod);
            this.Controls.Add(this.lblYetkiKodu);
            this.Controls.Add(this.lblOzelKod);
            this.Controls.Add(this.btnTarih);
            this.Controls.Add(this.lblTarih);
            this.Controls.Add(this.lblFisNo);
            this.Controls.Add(this.txtTarih);
            this.Controls.Add(this.txtFisNo);
            this.Controls.Add(this.pnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCariHesap_FişGenel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cari Hesap > Fiş";
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
        private System.Windows.Forms.Label lblCariHesap;
        private Bunifu.Framework.UI.BunifuImageButton btnClose;
        private Bunifu.Framework.UI.BunifuImageButton btnMinimize;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.Label lblAciklama;
        private System.Windows.Forms.Label lblYerelParaBirimi;
        private Bunifu.Framework.UI.BunifuFlatButton btnVazgec;
        private Bunifu.Framework.UI.BunifuFlatButton btnKaydet;
        private System.Windows.Forms.DataGridView dataGridViewFis;
        private System.Windows.Forms.ComboBox comboBoxIsYeri;
        private System.Windows.Forms.Label lblIsYeri;
        private System.Windows.Forms.ComboBox comboBoxYetkiKodu;
        private System.Windows.Forms.ComboBox comboBoxOzelKod;
        private System.Windows.Forms.Label lblYetkiKodu;
        private System.Windows.Forms.Label lblOzelKod;
        private Bunifu.Framework.UI.BunifuFlatButton btnTarih;
        private System.Windows.Forms.Label lblTarih;
        private System.Windows.Forms.Label lblFisNo;
        private System.Windows.Forms.TextBox txtTarih;
        private System.Windows.Forms.TextBox txtFisNo;
        private System.Windows.Forms.Label lblSatisElemaniKodu;
        private System.Windows.Forms.Label lblislemdovizli;
        private System.Windows.Forms.ComboBox cbxSatisElemani;
        private System.Windows.Forms.Label lblKur;
        private System.Windows.Forms.TextBox tbxKur;
        private System.Windows.Forms.ComboBox cbxKurTuru;
        private System.Windows.Forms.Label lblKurTuru;
        private System.Windows.Forms.ComboBox cbxFisTuru;
        private System.Windows.Forms.Label lblFisTuru;
        private System.Windows.Forms.TextBox txtDovizliToplamAlacak;
        private System.Windows.Forms.TextBox txtTLToplamAlacak;
        private System.Windows.Forms.Label lblToplamAlacak;
        private System.Windows.Forms.TextBox txtDovızToplamBorc;
        private System.Windows.Forms.TextBox txtTLToplamBorc;
        private System.Windows.Forms.Label lblToplamBorc;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHKodu;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn TicIslemGrb;
        private System.Windows.Forms.DataGridViewTextBoxColumn Aciklama;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tutar;
        private System.Windows.Forms.DataGridViewTextBoxColumn DovTutar;
        private System.Windows.Forms.DataGridViewTextBoxColumn MakbuzNo;
    }
}