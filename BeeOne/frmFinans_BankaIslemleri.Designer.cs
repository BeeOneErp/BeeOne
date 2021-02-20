
namespace BeeOne
{
    partial class frmFinans_BankaIslemleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFinans_BankaIslemleri));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblFinans = new System.Windows.Forms.Label();
            this.btnClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnMinimize = new Bunifu.Framework.UI.BunifuImageButton();
            this.dataGridViewFis = new System.Windows.Forms.DataGridView();
            this.btnVazgec = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnKaydet = new Bunifu.Framework.UI.BunifuFlatButton();
            this.comboBoxYetkiKodu = new System.Windows.Forms.ComboBox();
            this.comboBoxOzelKod = new System.Windows.Forms.ComboBox();
            this.lblYetkiKodu = new System.Windows.Forms.Label();
            this.lblOzelKod = new System.Windows.Forms.Label();
            this.btnTarih = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lblTarih = new System.Windows.Forms.Label();
            this.lblFisNo = new System.Windows.Forms.Label();
            this.txtTarih = new System.Windows.Forms.TextBox();
            this.txtFisNo = new System.Windows.Forms.TextBox();
            this.comboBoxIsYeri = new System.Windows.Forms.ComboBox();
            this.lblIsYeri = new System.Windows.Forms.Label();
            this.lblKrediKodu = new System.Windows.Forms.Label();
            this.txtKrediKodu = new System.Windows.Forms.TextBox();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.lblAciklama = new System.Windows.Forms.Label();
            this.txtDovızToplamBorc = new System.Windows.Forms.TextBox();
            this.txtTLToplamBorc = new System.Windows.Forms.TextBox();
            this.lblToplamBorc = new System.Windows.Forms.Label();
            this.lblYerelParaBirimi = new System.Windows.Forms.Label();
            this.lblKurTuru = new System.Windows.Forms.Label();
            this.cbxKurTuru = new System.Windows.Forms.ComboBox();
            this.tbxKur = new System.Windows.Forms.TextBox();
            this.lblKur = new System.Windows.Forms.Label();
            this.lblislemdovizli = new System.Windows.Forms.Label();
            this.cbxFisTuru = new System.Windows.Forms.ComboBox();
            this.lblFisTuru = new System.Windows.Forms.Label();
            this.txtDovizliToplamAlacak = new System.Windows.Forms.TextBox();
            this.txtTLToplamAlacak = new System.Windows.Forms.TextBox();
            this.lblToplamAlacak = new System.Windows.Forms.Label();
            this.BankaHesKodu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Aciklama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Borc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Alacak = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DovBorc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DovAlacak = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BelgeNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFis)).BeginInit();
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
            this.pnlTop.Size = new System.Drawing.Size(870, 48);
            this.pnlTop.TabIndex = 12;
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
            this.lblFinans.Size = new System.Drawing.Size(225, 21);
            this.lblFinans.TabIndex = 7;
            this.lblFinans.Text = "FİNANS > BANKA İŞLEMLERİ";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageActive = null;
            this.btnClose.Location = new System.Drawing.Point(840, 10);
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
            this.btnMinimize.Location = new System.Drawing.Point(814, 10);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(20, 27);
            this.btnMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimize.TabIndex = 5;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.Zoom = 10;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
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
            this.BankaHesKodu,
            this.Aciklama,
            this.Borc,
            this.Alacak,
            this.DovBorc,
            this.DovAlacak,
            this.BelgeNo});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(0, 6, 0, 6);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewFis.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewFis.Location = new System.Drawing.Point(12, 142);
            this.dataGridViewFis.Name = "dataGridViewFis";
            this.dataGridViewFis.ReadOnly = true;
            this.dataGridViewFis.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.dataGridViewFis.RowTemplate.Height = 40;
            this.dataGridViewFis.Size = new System.Drawing.Size(846, 313);
            this.dataGridViewFis.TabIndex = 18;
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
            this.btnVazgec.Location = new System.Drawing.Point(760, 538);
            this.btnVazgec.Name = "btnVazgec";
            this.btnVazgec.Normalcolor = System.Drawing.Color.DarkKhaki;
            this.btnVazgec.OnHovercolor = System.Drawing.Color.Khaki;
            this.btnVazgec.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnVazgec.selected = false;
            this.btnVazgec.Size = new System.Drawing.Size(98, 31);
            this.btnVazgec.TabIndex = 200;
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
            this.btnKaydet.Location = new System.Drawing.Point(656, 538);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Normalcolor = System.Drawing.Color.DarkKhaki;
            this.btnKaydet.OnHovercolor = System.Drawing.Color.Khaki;
            this.btnKaydet.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnKaydet.selected = false;
            this.btnKaydet.Size = new System.Drawing.Size(98, 31);
            this.btnKaydet.TabIndex = 199;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnKaydet.Textcolor = System.Drawing.Color.Black;
            this.btnKaydet.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // comboBoxYetkiKodu
            // 
            this.comboBoxYetkiKodu.FormattingEnabled = true;
            this.comboBoxYetkiKodu.Location = new System.Drawing.Point(404, 83);
            this.comboBoxYetkiKodu.Name = "comboBoxYetkiKodu";
            this.comboBoxYetkiKodu.Size = new System.Drawing.Size(172, 21);
            this.comboBoxYetkiKodu.TabIndex = 209;
            // 
            // comboBoxOzelKod
            // 
            this.comboBoxOzelKod.FormattingEnabled = true;
            this.comboBoxOzelKod.Location = new System.Drawing.Point(404, 58);
            this.comboBoxOzelKod.Name = "comboBoxOzelKod";
            this.comboBoxOzelKod.Size = new System.Drawing.Size(172, 21);
            this.comboBoxOzelKod.TabIndex = 208;
            // 
            // lblYetkiKodu
            // 
            this.lblYetkiKodu.AutoSize = true;
            this.lblYetkiKodu.BackColor = System.Drawing.Color.Transparent;
            this.lblYetkiKodu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYetkiKodu.Location = new System.Drawing.Point(316, 85);
            this.lblYetkiKodu.Name = "lblYetkiKodu";
            this.lblYetkiKodu.Size = new System.Drawing.Size(65, 15);
            this.lblYetkiKodu.TabIndex = 207;
            this.lblYetkiKodu.Text = "Yetki Kodu";
            // 
            // lblOzelKod
            // 
            this.lblOzelKod.AutoSize = true;
            this.lblOzelKod.BackColor = System.Drawing.Color.Transparent;
            this.lblOzelKod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOzelKod.Location = new System.Drawing.Point(324, 60);
            this.lblOzelKod.Name = "lblOzelKod";
            this.lblOzelKod.Size = new System.Drawing.Size(57, 15);
            this.lblOzelKod.TabIndex = 206;
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
            this.btnTarih.Location = new System.Drawing.Point(249, 84);
            this.btnTarih.Name = "btnTarih";
            this.btnTarih.Normalcolor = System.Drawing.Color.DarkKhaki;
            this.btnTarih.OnHovercolor = System.Drawing.Color.Khaki;
            this.btnTarih.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnTarih.selected = false;
            this.btnTarih.Size = new System.Drawing.Size(23, 20);
            this.btnTarih.TabIndex = 205;
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
            this.lblTarih.Location = new System.Drawing.Point(13, 86);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(35, 15);
            this.lblTarih.TabIndex = 204;
            this.lblTarih.Text = "Tarih";
            // 
            // lblFisNo
            // 
            this.lblFisNo.AutoSize = true;
            this.lblFisNo.BackColor = System.Drawing.Color.Transparent;
            this.lblFisNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFisNo.Location = new System.Drawing.Point(13, 61);
            this.lblFisNo.Name = "lblFisNo";
            this.lblFisNo.Size = new System.Drawing.Size(45, 15);
            this.lblFisNo.TabIndex = 203;
            this.lblFisNo.Text = "Fiş No.";
            // 
            // txtTarih
            // 
            this.txtTarih.Location = new System.Drawing.Point(73, 83);
            this.txtTarih.Multiline = true;
            this.txtTarih.Name = "txtTarih";
            this.txtTarih.Size = new System.Drawing.Size(199, 21);
            this.txtTarih.TabIndex = 202;
            // 
            // txtFisNo
            // 
            this.txtFisNo.Location = new System.Drawing.Point(73, 59);
            this.txtFisNo.Multiline = true;
            this.txtFisNo.Name = "txtFisNo";
            this.txtFisNo.Size = new System.Drawing.Size(199, 21);
            this.txtFisNo.TabIndex = 201;
            // 
            // comboBoxIsYeri
            // 
            this.comboBoxIsYeri.FormattingEnabled = true;
            this.comboBoxIsYeri.Location = new System.Drawing.Point(698, 58);
            this.comboBoxIsYeri.Name = "comboBoxIsYeri";
            this.comboBoxIsYeri.Size = new System.Drawing.Size(160, 21);
            this.comboBoxIsYeri.TabIndex = 211;
            // 
            // lblIsYeri
            // 
            this.lblIsYeri.AutoSize = true;
            this.lblIsYeri.BackColor = System.Drawing.Color.Transparent;
            this.lblIsYeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblIsYeri.Location = new System.Drawing.Point(641, 58);
            this.lblIsYeri.Name = "lblIsYeri";
            this.lblIsYeri.Size = new System.Drawing.Size(40, 15);
            this.lblIsYeri.TabIndex = 210;
            this.lblIsYeri.Text = "İş Yeri";
            // 
            // lblKrediKodu
            // 
            this.lblKrediKodu.AutoSize = true;
            this.lblKrediKodu.BackColor = System.Drawing.Color.Transparent;
            this.lblKrediKodu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKrediKodu.Location = new System.Drawing.Point(313, 111);
            this.lblKrediKodu.Name = "lblKrediKodu";
            this.lblKrediKodu.Size = new System.Drawing.Size(68, 15);
            this.lblKrediKodu.TabIndex = 213;
            this.lblKrediKodu.Text = "Kredi Kodu";
            // 
            // txtKrediKodu
            // 
            this.txtKrediKodu.Location = new System.Drawing.Point(404, 110);
            this.txtKrediKodu.Multiline = true;
            this.txtKrediKodu.Name = "txtKrediKodu";
            this.txtKrediKodu.Size = new System.Drawing.Size(172, 21);
            this.txtKrediKodu.TabIndex = 212;
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(12, 494);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(369, 54);
            this.txtAciklama.TabIndex = 215;
            // 
            // lblAciklama
            // 
            this.lblAciklama.AutoSize = true;
            this.lblAciklama.BackColor = System.Drawing.Color.Transparent;
            this.lblAciklama.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAciklama.Location = new System.Drawing.Point(12, 475);
            this.lblAciklama.Name = "lblAciklama";
            this.lblAciklama.Size = new System.Drawing.Size(72, 16);
            this.lblAciklama.TabIndex = 214;
            this.lblAciklama.Text = "Açıklama";
            // 
            // txtDovızToplamBorc
            // 
            this.txtDovızToplamBorc.Location = new System.Drawing.Point(679, 484);
            this.txtDovızToplamBorc.Multiline = true;
            this.txtDovızToplamBorc.Name = "txtDovızToplamBorc";
            this.txtDovızToplamBorc.Size = new System.Drawing.Size(179, 21);
            this.txtDovızToplamBorc.TabIndex = 219;
            // 
            // txtTLToplamBorc
            // 
            this.txtTLToplamBorc.Location = new System.Drawing.Point(494, 484);
            this.txtTLToplamBorc.Multiline = true;
            this.txtTLToplamBorc.Name = "txtTLToplamBorc";
            this.txtTLToplamBorc.Size = new System.Drawing.Size(179, 21);
            this.txtTLToplamBorc.TabIndex = 218;
            // 
            // lblToplamBorc
            // 
            this.lblToplamBorc.AutoSize = true;
            this.lblToplamBorc.BackColor = System.Drawing.Color.Transparent;
            this.lblToplamBorc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplamBorc.Location = new System.Drawing.Point(403, 485);
            this.lblToplamBorc.Name = "lblToplamBorc";
            this.lblToplamBorc.Size = new System.Drawing.Size(88, 15);
            this.lblToplamBorc.TabIndex = 217;
            this.lblToplamBorc.Text = "Toplam Borç";
            // 
            // lblYerelParaBirimi
            // 
            this.lblYerelParaBirimi.AutoSize = true;
            this.lblYerelParaBirimi.BackColor = System.Drawing.Color.Transparent;
            this.lblYerelParaBirimi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYerelParaBirimi.Location = new System.Drawing.Point(517, 458);
            this.lblYerelParaBirimi.Name = "lblYerelParaBirimi";
            this.lblYerelParaBirimi.Size = new System.Drawing.Size(116, 15);
            this.lblYerelParaBirimi.TabIndex = 216;
            this.lblYerelParaBirimi.Text = "Yerel Para Birimi";
            // 
            // lblKurTuru
            // 
            this.lblKurTuru.AutoSize = true;
            this.lblKurTuru.BackColor = System.Drawing.Color.Transparent;
            this.lblKurTuru.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKurTuru.Location = new System.Drawing.Point(627, 86);
            this.lblKurTuru.Name = "lblKurTuru";
            this.lblKurTuru.Size = new System.Drawing.Size(54, 15);
            this.lblKurTuru.TabIndex = 223;
            this.lblKurTuru.Text = "Kur Türü";
            // 
            // cbxKurTuru
            // 
            this.cbxKurTuru.FormattingEnabled = true;
            this.cbxKurTuru.Location = new System.Drawing.Point(698, 84);
            this.cbxKurTuru.Name = "cbxKurTuru";
            this.cbxKurTuru.Size = new System.Drawing.Size(85, 21);
            this.cbxKurTuru.TabIndex = 222;
            // 
            // tbxKur
            // 
            this.tbxKur.Location = new System.Drawing.Point(698, 110);
            this.tbxKur.Multiline = true;
            this.tbxKur.Name = "tbxKur";
            this.tbxKur.Size = new System.Drawing.Size(85, 21);
            this.tbxKur.TabIndex = 221;
            // 
            // lblKur
            // 
            this.lblKur.AutoSize = true;
            this.lblKur.BackColor = System.Drawing.Color.Transparent;
            this.lblKur.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKur.Location = new System.Drawing.Point(655, 111);
            this.lblKur.Name = "lblKur";
            this.lblKur.Size = new System.Drawing.Size(26, 15);
            this.lblKur.TabIndex = 220;
            this.lblKur.Text = "Kur";
            // 
            // lblislemdovizli
            // 
            this.lblislemdovizli.AutoSize = true;
            this.lblislemdovizli.BackColor = System.Drawing.Color.Transparent;
            this.lblislemdovizli.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblislemdovizli.Location = new System.Drawing.Point(724, 458);
            this.lblislemdovizli.Name = "lblislemdovizli";
            this.lblislemdovizli.Size = new System.Drawing.Size(85, 15);
            this.lblislemdovizli.TabIndex = 224;
            this.lblislemdovizli.Text = "İşlem Dövizi";
            // 
            // cbxFisTuru
            // 
            this.cbxFisTuru.FormattingEnabled = true;
            this.cbxFisTuru.Items.AddRange(new object[] {
            "(1) Banka İşlem Fişi",
            "(3) Gelen Havale/EFT",
            "(4) Gönderilen Havale/EFT"});
            this.cbxFisTuru.Location = new System.Drawing.Point(73, 111);
            this.cbxFisTuru.Name = "cbxFisTuru";
            this.cbxFisTuru.Size = new System.Drawing.Size(172, 21);
            this.cbxFisTuru.TabIndex = 226;
            this.cbxFisTuru.Text = "(1) Banka İşlem Fişi";
            // 
            // lblFisTuru
            // 
            this.lblFisTuru.AutoSize = true;
            this.lblFisTuru.BackColor = System.Drawing.Color.Transparent;
            this.lblFisTuru.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFisTuru.Location = new System.Drawing.Point(13, 112);
            this.lblFisTuru.Name = "lblFisTuru";
            this.lblFisTuru.Size = new System.Drawing.Size(51, 15);
            this.lblFisTuru.TabIndex = 225;
            this.lblFisTuru.Text = "Fiş Türü";
            // 
            // txtDovizliToplamAlacak
            // 
            this.txtDovizliToplamAlacak.Location = new System.Drawing.Point(679, 511);
            this.txtDovizliToplamAlacak.Multiline = true;
            this.txtDovizliToplamAlacak.Name = "txtDovizliToplamAlacak";
            this.txtDovizliToplamAlacak.Size = new System.Drawing.Size(179, 21);
            this.txtDovizliToplamAlacak.TabIndex = 229;
            // 
            // txtTLToplamAlacak
            // 
            this.txtTLToplamAlacak.Location = new System.Drawing.Point(494, 511);
            this.txtTLToplamAlacak.Multiline = true;
            this.txtTLToplamAlacak.Name = "txtTLToplamAlacak";
            this.txtTLToplamAlacak.Size = new System.Drawing.Size(179, 21);
            this.txtTLToplamAlacak.TabIndex = 228;
            // 
            // lblToplamAlacak
            // 
            this.lblToplamAlacak.AutoSize = true;
            this.lblToplamAlacak.BackColor = System.Drawing.Color.Transparent;
            this.lblToplamAlacak.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplamAlacak.Location = new System.Drawing.Point(390, 517);
            this.lblToplamAlacak.Name = "lblToplamAlacak";
            this.lblToplamAlacak.Size = new System.Drawing.Size(101, 15);
            this.lblToplamAlacak.TabIndex = 227;
            this.lblToplamAlacak.Text = "Toplam Alacak";
            // 
            // BankaHesKodu
            // 
            this.BankaHesKodu.HeaderText = "Banka Hesap Kodu";
            this.BankaHesKodu.Name = "BankaHesKodu";
            this.BankaHesKodu.ReadOnly = true;
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
            // BelgeNo
            // 
            this.BelgeNo.HeaderText = "Belge No";
            this.BelgeNo.Name = "BelgeNo";
            this.BelgeNo.ReadOnly = true;
            // 
            // frmFinans_BankaIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.BackgroundImage = global::BeeOne.Properties.Resources.background__39_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(870, 595);
            this.Controls.Add(this.txtDovizliToplamAlacak);
            this.Controls.Add(this.txtTLToplamAlacak);
            this.Controls.Add(this.lblToplamAlacak);
            this.Controls.Add(this.cbxFisTuru);
            this.Controls.Add(this.lblFisTuru);
            this.Controls.Add(this.lblislemdovizli);
            this.Controls.Add(this.lblKurTuru);
            this.Controls.Add(this.cbxKurTuru);
            this.Controls.Add(this.tbxKur);
            this.Controls.Add(this.lblKur);
            this.Controls.Add(this.txtDovızToplamBorc);
            this.Controls.Add(this.txtTLToplamBorc);
            this.Controls.Add(this.lblToplamBorc);
            this.Controls.Add(this.lblYerelParaBirimi);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.lblAciklama);
            this.Controls.Add(this.lblKrediKodu);
            this.Controls.Add(this.txtKrediKodu);
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
            this.Controls.Add(this.btnVazgec);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.dataGridViewFis);
            this.Controls.Add(this.pnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmFinans_BankaIslemleri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Finans > Banka İşlemleri";
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
        private System.Windows.Forms.Label lblFinans;
        private Bunifu.Framework.UI.BunifuImageButton btnClose;
        private Bunifu.Framework.UI.BunifuImageButton btnMinimize;
        private System.Windows.Forms.DataGridView dataGridViewFis;
        private Bunifu.Framework.UI.BunifuFlatButton btnVazgec;
        private Bunifu.Framework.UI.BunifuFlatButton btnKaydet;
        private System.Windows.Forms.ComboBox comboBoxYetkiKodu;
        private System.Windows.Forms.ComboBox comboBoxOzelKod;
        private System.Windows.Forms.Label lblYetkiKodu;
        private System.Windows.Forms.Label lblOzelKod;
        private Bunifu.Framework.UI.BunifuFlatButton btnTarih;
        private System.Windows.Forms.Label lblTarih;
        private System.Windows.Forms.Label lblFisNo;
        private System.Windows.Forms.TextBox txtTarih;
        private System.Windows.Forms.TextBox txtFisNo;
        private System.Windows.Forms.ComboBox comboBoxIsYeri;
        private System.Windows.Forms.Label lblIsYeri;
        private System.Windows.Forms.Label lblKrediKodu;
        private System.Windows.Forms.TextBox txtKrediKodu;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.Label lblAciklama;
        private System.Windows.Forms.TextBox txtDovızToplamBorc;
        private System.Windows.Forms.TextBox txtTLToplamBorc;
        private System.Windows.Forms.Label lblToplamBorc;
        private System.Windows.Forms.Label lblYerelParaBirimi;
        private System.Windows.Forms.Label lblKurTuru;
        private System.Windows.Forms.ComboBox cbxKurTuru;
        private System.Windows.Forms.TextBox tbxKur;
        private System.Windows.Forms.Label lblKur;
        private System.Windows.Forms.Label lblislemdovizli;
        private System.Windows.Forms.ComboBox cbxFisTuru;
        private System.Windows.Forms.Label lblFisTuru;
        private System.Windows.Forms.TextBox txtDovizliToplamAlacak;
        private System.Windows.Forms.TextBox txtTLToplamAlacak;
        private System.Windows.Forms.Label lblToplamAlacak;
        private System.Windows.Forms.DataGridViewTextBoxColumn BankaHesKodu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Aciklama;
        private System.Windows.Forms.DataGridViewTextBoxColumn Borc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Alacak;
        private System.Windows.Forms.DataGridViewTextBoxColumn DovBorc;
        private System.Windows.Forms.DataGridViewTextBoxColumn DovAlacak;
        private System.Windows.Forms.DataGridViewTextBoxColumn BelgeNo;
    }
}