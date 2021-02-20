
namespace BeeOne
{
    partial class frmStokIslemleri_SatinAlmaIrsaliye_Irsaliye
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.comboBoxIrsaliyeTipi = new System.Windows.Forms.ComboBox();
            this.lblIrsaliyeTipi = new System.Windows.Forms.Label();
            this.btnDuzenlemeTarihi = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lblDuzenlemeTarihi = new System.Windows.Forms.Label();
            this.txtDuzenlemeTarihi = new System.Windows.Forms.TextBox();
            this.txtParaBirimiToplamIndirim = new System.Windows.Forms.TextBox();
            this.txtIslemDoviziToplam = new System.Windows.Forms.TextBox();
            this.txtIslemDoviziToplamIndirim = new System.Windows.Forms.TextBox();
            this.txtIslemDoviziNet = new System.Windows.Forms.TextBox();
            this.txtIslemDoviziToplamKDV = new System.Windows.Forms.TextBox();
            this.txtParaBirimiToplam = new System.Windows.Forms.TextBox();
            this.txtParaBirimiNet = new System.Windows.Forms.TextBox();
            this.txtParaBirimiToplamKDV = new System.Windows.Forms.TextBox();
            this.lblNet = new System.Windows.Forms.Label();
            this.lblToplamKDV = new System.Windows.Forms.Label();
            this.lblToplam = new System.Windows.Forms.Label();
            this.lblToplamIndirim = new System.Windows.Forms.Label();
            this.lblIslemDovizi = new System.Windows.Forms.Label();
            this.lblYerelParaBirimi = new System.Windows.Forms.Label();
            this.dataGridViewFis = new System.Windows.Forms.DataGridView();
            this.Satir_Turu = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.MlzKodu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MlzAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Miktar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Birim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Birim_Fiyat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DovBfiyat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KDVOrani = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KDVTutari = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tutar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DovTutar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Net_tutar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Aciklama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblCHBilgileri = new System.Windows.Forms.Label();
            this.comboBoxIsYeri = new System.Windows.Forms.ComboBox();
            this.lblIsYeri = new System.Windows.Forms.Label();
            this.comboBoxAmbar = new System.Windows.Forms.ComboBox();
            this.lblAmbar = new System.Windows.Forms.Label();
            this.lblSatisElemaniKodu = new System.Windows.Forms.Label();
            this.comboBoxYetkiKodu = new System.Windows.Forms.ComboBox();
            this.comboBoxOzelKod = new System.Windows.Forms.ComboBox();
            this.lblYetkiKodu = new System.Windows.Forms.Label();
            this.lblOzelKod = new System.Windows.Forms.Label();
            this.btnTarih = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtBelgeNo = new System.Windows.Forms.TextBox();
            this.lblBelgeNo = new System.Windows.Forms.Label();
            this.lblZaman = new System.Windows.Forms.Label();
            this.lblTarih = new System.Windows.Forms.Label();
            this.lblFisNo = new System.Windows.Forms.Label();
            this.txtZaman = new System.Windows.Forms.TextBox();
            this.txtTarih = new System.Windows.Forms.TextBox();
            this.txtFisNo = new System.Windows.Forms.TextBox();
            this.cbxSatisElemani = new System.Windows.Forms.ComboBox();
            this.lblTicariIslemGrubu = new System.Windows.Forms.Label();
            this.btnUnvan = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnKod = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtTicIslemGrb = new System.Windows.Forms.TextBox();
            this.txtUnvan = new System.Windows.Forms.TextBox();
            this.txtKod = new System.Windows.Forms.TextBox();
            this.lblUnvanı = new System.Windows.Forms.Label();
            this.lblKodu = new System.Windows.Forms.Label();
            this.btnEkle = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFis)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxIrsaliyeTipi
            // 
            this.comboBoxIrsaliyeTipi.FormattingEnabled = true;
            this.comboBoxIrsaliyeTipi.Items.AddRange(new object[] {
            "(1) Satınalma İrsaliyesi",
            "(6) Satınalma İade İrsaliyesi"});
            this.comboBoxIrsaliyeTipi.Location = new System.Drawing.Point(1105, 140);
            this.comboBoxIrsaliyeTipi.Name = "comboBoxIrsaliyeTipi";
            this.comboBoxIrsaliyeTipi.Size = new System.Drawing.Size(204, 21);
            this.comboBoxIrsaliyeTipi.TabIndex = 272;
            this.comboBoxIrsaliyeTipi.Text = "(1) Satınalma İrsaliyesi";
            // 
            // lblIrsaliyeTipi
            // 
            this.lblIrsaliyeTipi.AutoSize = true;
            this.lblIrsaliyeTipi.BackColor = System.Drawing.Color.Transparent;
            this.lblIrsaliyeTipi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblIrsaliyeTipi.Location = new System.Drawing.Point(1031, 142);
            this.lblIrsaliyeTipi.Name = "lblIrsaliyeTipi";
            this.lblIrsaliyeTipi.Size = new System.Drawing.Size(68, 15);
            this.lblIrsaliyeTipi.TabIndex = 271;
            this.lblIrsaliyeTipi.Text = "İrsaliye Tipi";
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
            this.btnDuzenlemeTarihi.Location = new System.Drawing.Point(823, 146);
            this.btnDuzenlemeTarihi.Name = "btnDuzenlemeTarihi";
            this.btnDuzenlemeTarihi.Normalcolor = System.Drawing.Color.DarkKhaki;
            this.btnDuzenlemeTarihi.OnHovercolor = System.Drawing.Color.Khaki;
            this.btnDuzenlemeTarihi.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnDuzenlemeTarihi.selected = false;
            this.btnDuzenlemeTarihi.Size = new System.Drawing.Size(23, 20);
            this.btnDuzenlemeTarihi.TabIndex = 270;
            this.btnDuzenlemeTarihi.Text = "...";
            this.btnDuzenlemeTarihi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDuzenlemeTarihi.Textcolor = System.Drawing.Color.Black;
            this.btnDuzenlemeTarihi.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // lblDuzenlemeTarihi
            // 
            this.lblDuzenlemeTarihi.AutoSize = true;
            this.lblDuzenlemeTarihi.BackColor = System.Drawing.Color.Transparent;
            this.lblDuzenlemeTarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDuzenlemeTarihi.Location = new System.Drawing.Point(526, 146);
            this.lblDuzenlemeTarihi.Name = "lblDuzenlemeTarihi";
            this.lblDuzenlemeTarihi.Size = new System.Drawing.Size(105, 15);
            this.lblDuzenlemeTarihi.TabIndex = 269;
            this.lblDuzenlemeTarihi.Text = "Düzenleme Tarihi";
            // 
            // txtDuzenlemeTarihi
            // 
            this.txtDuzenlemeTarihi.Location = new System.Drawing.Point(642, 145);
            this.txtDuzenlemeTarihi.Multiline = true;
            this.txtDuzenlemeTarihi.Name = "txtDuzenlemeTarihi";
            this.txtDuzenlemeTarihi.Size = new System.Drawing.Size(204, 21);
            this.txtDuzenlemeTarihi.TabIndex = 268;
            // 
            // txtParaBirimiToplamIndirim
            // 
            this.txtParaBirimiToplamIndirim.Location = new System.Drawing.Point(142, 582);
            this.txtParaBirimiToplamIndirim.Multiline = true;
            this.txtParaBirimiToplamIndirim.Name = "txtParaBirimiToplamIndirim";
            this.txtParaBirimiToplamIndirim.Size = new System.Drawing.Size(207, 21);
            this.txtParaBirimiToplamIndirim.TabIndex = 267;
            // 
            // txtIslemDoviziToplam
            // 
            this.txtIslemDoviziToplam.Location = new System.Drawing.Point(370, 606);
            this.txtIslemDoviziToplam.Multiline = true;
            this.txtIslemDoviziToplam.Name = "txtIslemDoviziToplam";
            this.txtIslemDoviziToplam.Size = new System.Drawing.Size(207, 21);
            this.txtIslemDoviziToplam.TabIndex = 265;
            // 
            // txtIslemDoviziToplamIndirim
            // 
            this.txtIslemDoviziToplamIndirim.Location = new System.Drawing.Point(370, 582);
            this.txtIslemDoviziToplamIndirim.Multiline = true;
            this.txtIslemDoviziToplamIndirim.Name = "txtIslemDoviziToplamIndirim";
            this.txtIslemDoviziToplamIndirim.Size = new System.Drawing.Size(207, 21);
            this.txtIslemDoviziToplamIndirim.TabIndex = 264;
            // 
            // txtIslemDoviziNet
            // 
            this.txtIslemDoviziNet.Location = new System.Drawing.Point(370, 654);
            this.txtIslemDoviziNet.Multiline = true;
            this.txtIslemDoviziNet.Name = "txtIslemDoviziNet";
            this.txtIslemDoviziNet.Size = new System.Drawing.Size(207, 21);
            this.txtIslemDoviziNet.TabIndex = 262;
            // 
            // txtIslemDoviziToplamKDV
            // 
            this.txtIslemDoviziToplamKDV.Location = new System.Drawing.Point(370, 630);
            this.txtIslemDoviziToplamKDV.Multiline = true;
            this.txtIslemDoviziToplamKDV.Name = "txtIslemDoviziToplamKDV";
            this.txtIslemDoviziToplamKDV.Size = new System.Drawing.Size(207, 21);
            this.txtIslemDoviziToplamKDV.TabIndex = 261;
            // 
            // txtParaBirimiToplam
            // 
            this.txtParaBirimiToplam.Location = new System.Drawing.Point(142, 606);
            this.txtParaBirimiToplam.Multiline = true;
            this.txtParaBirimiToplam.Name = "txtParaBirimiToplam";
            this.txtParaBirimiToplam.Size = new System.Drawing.Size(207, 21);
            this.txtParaBirimiToplam.TabIndex = 259;
            // 
            // txtParaBirimiNet
            // 
            this.txtParaBirimiNet.Location = new System.Drawing.Point(142, 654);
            this.txtParaBirimiNet.Multiline = true;
            this.txtParaBirimiNet.Name = "txtParaBirimiNet";
            this.txtParaBirimiNet.Size = new System.Drawing.Size(207, 21);
            this.txtParaBirimiNet.TabIndex = 257;
            // 
            // txtParaBirimiToplamKDV
            // 
            this.txtParaBirimiToplamKDV.Location = new System.Drawing.Point(142, 630);
            this.txtParaBirimiToplamKDV.Multiline = true;
            this.txtParaBirimiToplamKDV.Name = "txtParaBirimiToplamKDV";
            this.txtParaBirimiToplamKDV.Size = new System.Drawing.Size(207, 21);
            this.txtParaBirimiToplamKDV.TabIndex = 256;
            // 
            // lblNet
            // 
            this.lblNet.AutoSize = true;
            this.lblNet.BackColor = System.Drawing.Color.Transparent;
            this.lblNet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblNet.Location = new System.Drawing.Point(35, 656);
            this.lblNet.Name = "lblNet";
            this.lblNet.Size = new System.Drawing.Size(27, 13);
            this.lblNet.TabIndex = 255;
            this.lblNet.Text = "Net";
            // 
            // lblToplamKDV
            // 
            this.lblToplamKDV.AutoSize = true;
            this.lblToplamKDV.BackColor = System.Drawing.Color.Transparent;
            this.lblToplamKDV.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplamKDV.Location = new System.Drawing.Point(35, 632);
            this.lblToplamKDV.Name = "lblToplamKDV";
            this.lblToplamKDV.Size = new System.Drawing.Size(77, 13);
            this.lblToplamKDV.TabIndex = 254;
            this.lblToplamKDV.Text = "Toplam KDV";
            // 
            // lblToplam
            // 
            this.lblToplam.AutoSize = true;
            this.lblToplam.BackColor = System.Drawing.Color.Transparent;
            this.lblToplam.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplam.Location = new System.Drawing.Point(35, 608);
            this.lblToplam.Name = "lblToplam";
            this.lblToplam.Size = new System.Drawing.Size(48, 13);
            this.lblToplam.TabIndex = 252;
            this.lblToplam.Text = "Toplam";
            // 
            // lblToplamIndirim
            // 
            this.lblToplamIndirim.AutoSize = true;
            this.lblToplamIndirim.BackColor = System.Drawing.Color.Transparent;
            this.lblToplamIndirim.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplamIndirim.Location = new System.Drawing.Point(35, 584);
            this.lblToplamIndirim.Name = "lblToplamIndirim";
            this.lblToplamIndirim.Size = new System.Drawing.Size(89, 13);
            this.lblToplamIndirim.TabIndex = 251;
            this.lblToplamIndirim.Text = "Toplam İndirim";
            // 
            // lblIslemDovizi
            // 
            this.lblIslemDovizi.AutoSize = true;
            this.lblIslemDovizi.BackColor = System.Drawing.Color.Transparent;
            this.lblIslemDovizi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblIslemDovizi.Location = new System.Drawing.Point(439, 535);
            this.lblIslemDovizi.Name = "lblIslemDovizi";
            this.lblIslemDovizi.Size = new System.Drawing.Size(75, 13);
            this.lblIslemDovizi.TabIndex = 249;
            this.lblIslemDovizi.Text = "İşlem Dövizi";
            // 
            // lblYerelParaBirimi
            // 
            this.lblYerelParaBirimi.AutoSize = true;
            this.lblYerelParaBirimi.BackColor = System.Drawing.Color.Transparent;
            this.lblYerelParaBirimi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYerelParaBirimi.Location = new System.Drawing.Point(206, 535);
            this.lblYerelParaBirimi.Name = "lblYerelParaBirimi";
            this.lblYerelParaBirimi.Size = new System.Drawing.Size(100, 13);
            this.lblYerelParaBirimi.TabIndex = 248;
            this.lblYerelParaBirimi.Text = "Yerel Para Birimi";
            // 
            // dataGridViewFis
            // 
            this.dataGridViewFis.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewFis.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewFis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFis.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Satir_Turu,
            this.MlzKodu,
            this.MlzAdi,
            this.Miktar,
            this.Birim,
            this.Birim_Fiyat,
            this.DovBfiyat,
            this.KDVOrani,
            this.KDVTutari,
            this.Tutar,
            this.DovTutar,
            this.Net_tutar,
            this.Aciklama});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 6, 0, 6);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewFis.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewFis.Location = new System.Drawing.Point(36, 210);
            this.dataGridViewFis.Name = "dataGridViewFis";
            this.dataGridViewFis.ReadOnly = true;
            this.dataGridViewFis.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.dataGridViewFis.RowTemplate.Height = 40;
            this.dataGridViewFis.Size = new System.Drawing.Size(1273, 297);
            this.dataGridViewFis.TabIndex = 247;
            // 
            // Satir_Turu
            // 
            this.Satir_Turu.HeaderText = "Satır Türü";
            this.Satir_Turu.Items.AddRange(new object[] {
            "Malzeme",
            "İndirim"});
            this.Satir_Turu.Name = "Satir_Turu";
            this.Satir_Turu.ReadOnly = true;
            // 
            // MlzKodu
            // 
            this.MlzKodu.HeaderText = "Malzeme Kodu";
            this.MlzKodu.Name = "MlzKodu";
            this.MlzKodu.ReadOnly = true;
            this.MlzKodu.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.MlzKodu.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // MlzAdi
            // 
            this.MlzAdi.HeaderText = "Malzeme Adı";
            this.MlzAdi.Name = "MlzAdi";
            this.MlzAdi.ReadOnly = true;
            // 
            // Miktar
            // 
            this.Miktar.HeaderText = "Miktar";
            this.Miktar.Name = "Miktar";
            this.Miktar.ReadOnly = true;
            // 
            // Birim
            // 
            this.Birim.HeaderText = "Birim";
            this.Birim.Name = "Birim";
            this.Birim.ReadOnly = true;
            // 
            // Birim_Fiyat
            // 
            this.Birim_Fiyat.HeaderText = "Birim Fiyat";
            this.Birim_Fiyat.Name = "Birim_Fiyat";
            this.Birim_Fiyat.ReadOnly = true;
            // 
            // DovBfiyat
            // 
            this.DovBfiyat.HeaderText = "Dövizli Birim Fiyat";
            this.DovBfiyat.Name = "DovBfiyat";
            this.DovBfiyat.ReadOnly = true;
            // 
            // KDVOrani
            // 
            this.KDVOrani.HeaderText = "KDV Oranı";
            this.KDVOrani.Name = "KDVOrani";
            this.KDVOrani.ReadOnly = true;
            // 
            // KDVTutari
            // 
            this.KDVTutari.HeaderText = "KDV Tutarı";
            this.KDVTutari.Name = "KDVTutari";
            this.KDVTutari.ReadOnly = true;
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
            // Net_tutar
            // 
            this.Net_tutar.HeaderText = "Net Tutar";
            this.Net_tutar.Name = "Net_tutar";
            this.Net_tutar.ReadOnly = true;
            // 
            // Aciklama
            // 
            this.Aciklama.HeaderText = "Açıklama";
            this.Aciklama.Name = "Aciklama";
            this.Aciklama.ReadOnly = true;
            // 
            // lblCHBilgileri
            // 
            this.lblCHBilgileri.AutoSize = true;
            this.lblCHBilgileri.BackColor = System.Drawing.Color.Transparent;
            this.lblCHBilgileri.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCHBilgileri.Location = new System.Drawing.Point(563, 9);
            this.lblCHBilgileri.Name = "lblCHBilgileri";
            this.lblCHBilgileri.Size = new System.Drawing.Size(143, 16);
            this.lblCHBilgileri.TabIndex = 246;
            this.lblCHBilgileri.Text = "Cari Hesap Bilgileri";
            // 
            // comboBoxIsYeri
            // 
            this.comboBoxIsYeri.FormattingEnabled = true;
            this.comboBoxIsYeri.Location = new System.Drawing.Point(1105, 41);
            this.comboBoxIsYeri.Name = "comboBoxIsYeri";
            this.comboBoxIsYeri.Size = new System.Drawing.Size(204, 21);
            this.comboBoxIsYeri.TabIndex = 243;
            // 
            // lblIsYeri
            // 
            this.lblIsYeri.AutoSize = true;
            this.lblIsYeri.BackColor = System.Drawing.Color.Transparent;
            this.lblIsYeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblIsYeri.Location = new System.Drawing.Point(1031, 43);
            this.lblIsYeri.Name = "lblIsYeri";
            this.lblIsYeri.Size = new System.Drawing.Size(40, 15);
            this.lblIsYeri.TabIndex = 242;
            this.lblIsYeri.Text = "İş Yeri";
            // 
            // comboBoxAmbar
            // 
            this.comboBoxAmbar.FormattingEnabled = true;
            this.comboBoxAmbar.Location = new System.Drawing.Point(1105, 90);
            this.comboBoxAmbar.Name = "comboBoxAmbar";
            this.comboBoxAmbar.Size = new System.Drawing.Size(204, 21);
            this.comboBoxAmbar.TabIndex = 241;
            // 
            // lblAmbar
            // 
            this.lblAmbar.AutoSize = true;
            this.lblAmbar.BackColor = System.Drawing.Color.Transparent;
            this.lblAmbar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAmbar.Location = new System.Drawing.Point(1031, 92);
            this.lblAmbar.Name = "lblAmbar";
            this.lblAmbar.Size = new System.Drawing.Size(43, 15);
            this.lblAmbar.TabIndex = 240;
            this.lblAmbar.Text = "Ambar";
            // 
            // lblSatisElemaniKodu
            // 
            this.lblSatisElemaniKodu.AutoSize = true;
            this.lblSatisElemaniKodu.BackColor = System.Drawing.Color.Transparent;
            this.lblSatisElemaniKodu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSatisElemaniKodu.Location = new System.Drawing.Point(516, 119);
            this.lblSatisElemaniKodu.Name = "lblSatisElemaniKodu";
            this.lblSatisElemaniKodu.Size = new System.Drawing.Size(115, 15);
            this.lblSatisElemaniKodu.TabIndex = 237;
            this.lblSatisElemaniKodu.Text = "Satış Elemanı Kodu";
            // 
            // comboBoxYetkiKodu
            // 
            this.comboBoxYetkiKodu.FormattingEnabled = true;
            this.comboBoxYetkiKodu.Location = new System.Drawing.Point(123, 166);
            this.comboBoxYetkiKodu.Name = "comboBoxYetkiKodu";
            this.comboBoxYetkiKodu.Size = new System.Drawing.Size(172, 21);
            this.comboBoxYetkiKodu.TabIndex = 236;
            // 
            // comboBoxOzelKod
            // 
            this.comboBoxOzelKod.FormattingEnabled = true;
            this.comboBoxOzelKod.Location = new System.Drawing.Point(123, 141);
            this.comboBoxOzelKod.Name = "comboBoxOzelKod";
            this.comboBoxOzelKod.Size = new System.Drawing.Size(172, 21);
            this.comboBoxOzelKod.TabIndex = 235;
            // 
            // lblYetkiKodu
            // 
            this.lblYetkiKodu.AutoSize = true;
            this.lblYetkiKodu.BackColor = System.Drawing.Color.Transparent;
            this.lblYetkiKodu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYetkiKodu.Location = new System.Drawing.Point(35, 168);
            this.lblYetkiKodu.Name = "lblYetkiKodu";
            this.lblYetkiKodu.Size = new System.Drawing.Size(65, 15);
            this.lblYetkiKodu.TabIndex = 234;
            this.lblYetkiKodu.Text = "Yetki Kodu";
            // 
            // lblOzelKod
            // 
            this.lblOzelKod.AutoSize = true;
            this.lblOzelKod.BackColor = System.Drawing.Color.Transparent;
            this.lblOzelKod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOzelKod.Location = new System.Drawing.Point(35, 143);
            this.lblOzelKod.Name = "lblOzelKod";
            this.lblOzelKod.Size = new System.Drawing.Size(57, 15);
            this.lblOzelKod.TabIndex = 233;
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
            this.btnTarih.Location = new System.Drawing.Point(330, 67);
            this.btnTarih.Name = "btnTarih";
            this.btnTarih.Normalcolor = System.Drawing.Color.DarkKhaki;
            this.btnTarih.OnHovercolor = System.Drawing.Color.Khaki;
            this.btnTarih.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnTarih.selected = false;
            this.btnTarih.Size = new System.Drawing.Size(23, 20);
            this.btnTarih.TabIndex = 232;
            this.btnTarih.Text = "...";
            this.btnTarih.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnTarih.Textcolor = System.Drawing.Color.Black;
            this.btnTarih.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // txtBelgeNo
            // 
            this.txtBelgeNo.Location = new System.Drawing.Point(123, 116);
            this.txtBelgeNo.Multiline = true;
            this.txtBelgeNo.Name = "txtBelgeNo";
            this.txtBelgeNo.Size = new System.Drawing.Size(230, 21);
            this.txtBelgeNo.TabIndex = 231;
            // 
            // lblBelgeNo
            // 
            this.lblBelgeNo.AutoSize = true;
            this.lblBelgeNo.BackColor = System.Drawing.Color.Transparent;
            this.lblBelgeNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBelgeNo.Location = new System.Drawing.Point(35, 119);
            this.lblBelgeNo.Name = "lblBelgeNo";
            this.lblBelgeNo.Size = new System.Drawing.Size(61, 15);
            this.lblBelgeNo.TabIndex = 230;
            this.lblBelgeNo.Text = "Belge No.";
            // 
            // lblZaman
            // 
            this.lblZaman.AutoSize = true;
            this.lblZaman.BackColor = System.Drawing.Color.Transparent;
            this.lblZaman.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblZaman.Location = new System.Drawing.Point(35, 93);
            this.lblZaman.Name = "lblZaman";
            this.lblZaman.Size = new System.Drawing.Size(46, 15);
            this.lblZaman.TabIndex = 229;
            this.lblZaman.Text = "Zaman";
            // 
            // lblTarih
            // 
            this.lblTarih.AutoSize = true;
            this.lblTarih.BackColor = System.Drawing.Color.Transparent;
            this.lblTarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTarih.Location = new System.Drawing.Point(35, 69);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(35, 15);
            this.lblTarih.TabIndex = 228;
            this.lblTarih.Text = "Tarih";
            // 
            // lblFisNo
            // 
            this.lblFisNo.AutoSize = true;
            this.lblFisNo.BackColor = System.Drawing.Color.Transparent;
            this.lblFisNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFisNo.Location = new System.Drawing.Point(35, 44);
            this.lblFisNo.Name = "lblFisNo";
            this.lblFisNo.Size = new System.Drawing.Size(45, 15);
            this.lblFisNo.TabIndex = 227;
            this.lblFisNo.Text = "Fiş No.";
            // 
            // txtZaman
            // 
            this.txtZaman.Location = new System.Drawing.Point(123, 91);
            this.txtZaman.Multiline = true;
            this.txtZaman.Name = "txtZaman";
            this.txtZaman.Size = new System.Drawing.Size(160, 21);
            this.txtZaman.TabIndex = 226;
            // 
            // txtTarih
            // 
            this.txtTarih.Location = new System.Drawing.Point(123, 66);
            this.txtTarih.Multiline = true;
            this.txtTarih.Name = "txtTarih";
            this.txtTarih.Size = new System.Drawing.Size(230, 21);
            this.txtTarih.TabIndex = 225;
            // 
            // txtFisNo
            // 
            this.txtFisNo.Location = new System.Drawing.Point(123, 42);
            this.txtFisNo.Multiline = true;
            this.txtFisNo.Name = "txtFisNo";
            this.txtFisNo.Size = new System.Drawing.Size(230, 21);
            this.txtFisNo.TabIndex = 224;
            // 
            // cbxSatisElemani
            // 
            this.cbxSatisElemani.FormattingEnabled = true;
            this.cbxSatisElemani.Location = new System.Drawing.Point(642, 117);
            this.cbxSatisElemani.Name = "cbxSatisElemani";
            this.cbxSatisElemani.Size = new System.Drawing.Size(204, 21);
            this.cbxSatisElemani.TabIndex = 223;
            // 
            // lblTicariIslemGrubu
            // 
            this.lblTicariIslemGrubu.AutoSize = true;
            this.lblTicariIslemGrubu.BackColor = System.Drawing.Color.Transparent;
            this.lblTicariIslemGrubu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTicariIslemGrubu.Location = new System.Drawing.Point(524, 93);
            this.lblTicariIslemGrubu.Name = "lblTicariIslemGrubu";
            this.lblTicariIslemGrubu.Size = new System.Drawing.Size(107, 15);
            this.lblTicariIslemGrubu.TabIndex = 222;
            this.lblTicariIslemGrubu.Text = "Ticari İşlem Grubu";
            // 
            // btnUnvan
            // 
            this.btnUnvan.Activecolor = System.Drawing.Color.Khaki;
            this.btnUnvan.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnUnvan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUnvan.BorderRadius = 0;
            this.btnUnvan.ButtonText = "...";
            this.btnUnvan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUnvan.DisabledColor = System.Drawing.Color.Gray;
            this.btnUnvan.Iconcolor = System.Drawing.Color.Transparent;
            this.btnUnvan.Iconimage = null;
            this.btnUnvan.Iconimage_right = null;
            this.btnUnvan.Iconimage_right_Selected = null;
            this.btnUnvan.Iconimage_Selected = null;
            this.btnUnvan.IconMarginLeft = 0;
            this.btnUnvan.IconMarginRight = 0;
            this.btnUnvan.IconRightVisible = true;
            this.btnUnvan.IconRightZoom = 0D;
            this.btnUnvan.IconVisible = true;
            this.btnUnvan.IconZoom = 90D;
            this.btnUnvan.IsTab = false;
            this.btnUnvan.Location = new System.Drawing.Point(823, 68);
            this.btnUnvan.Name = "btnUnvan";
            this.btnUnvan.Normalcolor = System.Drawing.Color.DarkKhaki;
            this.btnUnvan.OnHovercolor = System.Drawing.Color.Khaki;
            this.btnUnvan.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnUnvan.selected = false;
            this.btnUnvan.Size = new System.Drawing.Size(23, 20);
            this.btnUnvan.TabIndex = 220;
            this.btnUnvan.Text = "...";
            this.btnUnvan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnUnvan.Textcolor = System.Drawing.Color.Black;
            this.btnUnvan.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnKod
            // 
            this.btnKod.Activecolor = System.Drawing.Color.Khaki;
            this.btnKod.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnKod.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnKod.BorderRadius = 0;
            this.btnKod.ButtonText = "...";
            this.btnKod.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKod.DisabledColor = System.Drawing.Color.Gray;
            this.btnKod.Iconcolor = System.Drawing.Color.Transparent;
            this.btnKod.Iconimage = null;
            this.btnKod.Iconimage_right = null;
            this.btnKod.Iconimage_right_Selected = null;
            this.btnKod.Iconimage_Selected = null;
            this.btnKod.IconMarginLeft = 0;
            this.btnKod.IconMarginRight = 0;
            this.btnKod.IconRightVisible = true;
            this.btnKod.IconRightZoom = 0D;
            this.btnKod.IconVisible = true;
            this.btnKod.IconZoom = 90D;
            this.btnKod.IsTab = false;
            this.btnKod.Location = new System.Drawing.Point(823, 44);
            this.btnKod.Name = "btnKod";
            this.btnKod.Normalcolor = System.Drawing.Color.DarkKhaki;
            this.btnKod.OnHovercolor = System.Drawing.Color.Khaki;
            this.btnKod.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnKod.selected = false;
            this.btnKod.Size = new System.Drawing.Size(23, 20);
            this.btnKod.TabIndex = 219;
            this.btnKod.Text = "...";
            this.btnKod.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnKod.Textcolor = System.Drawing.Color.Black;
            this.btnKod.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // txtTicIslemGrb
            // 
            this.txtTicIslemGrb.Location = new System.Drawing.Point(642, 92);
            this.txtTicIslemGrb.Multiline = true;
            this.txtTicIslemGrb.Name = "txtTicIslemGrb";
            this.txtTicIslemGrb.Size = new System.Drawing.Size(204, 21);
            this.txtTicIslemGrb.TabIndex = 218;
            // 
            // txtUnvan
            // 
            this.txtUnvan.Location = new System.Drawing.Point(642, 67);
            this.txtUnvan.Multiline = true;
            this.txtUnvan.Name = "txtUnvan";
            this.txtUnvan.Size = new System.Drawing.Size(204, 21);
            this.txtUnvan.TabIndex = 217;
            // 
            // txtKod
            // 
            this.txtKod.Location = new System.Drawing.Point(642, 43);
            this.txtKod.Multiline = true;
            this.txtKod.Name = "txtKod";
            this.txtKod.Size = new System.Drawing.Size(204, 21);
            this.txtKod.TabIndex = 216;
            // 
            // lblUnvanı
            // 
            this.lblUnvanı.AutoSize = true;
            this.lblUnvanı.BackColor = System.Drawing.Color.Transparent;
            this.lblUnvanı.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUnvanı.Location = new System.Drawing.Point(586, 68);
            this.lblUnvanı.Name = "lblUnvanı";
            this.lblUnvanı.Size = new System.Drawing.Size(45, 15);
            this.lblUnvanı.TabIndex = 214;
            this.lblUnvanı.Text = "Unvanı";
            // 
            // lblKodu
            // 
            this.lblKodu.AutoSize = true;
            this.lblKodu.BackColor = System.Drawing.Color.Transparent;
            this.lblKodu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKodu.Location = new System.Drawing.Point(595, 43);
            this.lblKodu.Name = "lblKodu";
            this.lblKodu.Size = new System.Drawing.Size(36, 15);
            this.lblKodu.TabIndex = 213;
            this.lblKodu.Text = "Kodu";
            // 
            // btnEkle
            // 
            this.btnEkle.Activecolor = System.Drawing.Color.Khaki;
            this.btnEkle.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnEkle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEkle.BorderRadius = 0;
            this.btnEkle.ButtonText = "Ekle";
            this.btnEkle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEkle.DisabledColor = System.Drawing.Color.Gray;
            this.btnEkle.Iconcolor = System.Drawing.Color.Transparent;
            this.btnEkle.Iconimage = null;
            this.btnEkle.Iconimage_right = null;
            this.btnEkle.Iconimage_right_Selected = null;
            this.btnEkle.Iconimage_Selected = null;
            this.btnEkle.IconMarginLeft = 0;
            this.btnEkle.IconMarginRight = 0;
            this.btnEkle.IconRightVisible = true;
            this.btnEkle.IconRightZoom = 0D;
            this.btnEkle.IconVisible = true;
            this.btnEkle.IconZoom = 90D;
            this.btnEkle.IsTab = false;
            this.btnEkle.Location = new System.Drawing.Point(1211, 667);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Normalcolor = System.Drawing.Color.DarkKhaki;
            this.btnEkle.OnHovercolor = System.Drawing.Color.Khaki;
            this.btnEkle.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnEkle.selected = false;
            this.btnEkle.Size = new System.Drawing.Size(98, 31);
            this.btnEkle.TabIndex = 273;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEkle.Textcolor = System.Drawing.Color.Black;
            this.btnEkle.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // frmStokIslemleri_SatinAlmaIrsaliye_Irsaliye
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BeeOne.Properties.Resources.background__41_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1350, 726);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.comboBoxIrsaliyeTipi);
            this.Controls.Add(this.lblIrsaliyeTipi);
            this.Controls.Add(this.btnDuzenlemeTarihi);
            this.Controls.Add(this.lblDuzenlemeTarihi);
            this.Controls.Add(this.txtDuzenlemeTarihi);
            this.Controls.Add(this.txtParaBirimiToplamIndirim);
            this.Controls.Add(this.txtIslemDoviziToplam);
            this.Controls.Add(this.txtIslemDoviziToplamIndirim);
            this.Controls.Add(this.txtIslemDoviziNet);
            this.Controls.Add(this.txtIslemDoviziToplamKDV);
            this.Controls.Add(this.txtParaBirimiToplam);
            this.Controls.Add(this.txtParaBirimiNet);
            this.Controls.Add(this.txtParaBirimiToplamKDV);
            this.Controls.Add(this.lblNet);
            this.Controls.Add(this.lblToplamKDV);
            this.Controls.Add(this.lblToplam);
            this.Controls.Add(this.lblToplamIndirim);
            this.Controls.Add(this.lblIslemDovizi);
            this.Controls.Add(this.lblYerelParaBirimi);
            this.Controls.Add(this.dataGridViewFis);
            this.Controls.Add(this.lblCHBilgileri);
            this.Controls.Add(this.comboBoxIsYeri);
            this.Controls.Add(this.lblIsYeri);
            this.Controls.Add(this.comboBoxAmbar);
            this.Controls.Add(this.lblAmbar);
            this.Controls.Add(this.lblSatisElemaniKodu);
            this.Controls.Add(this.comboBoxYetkiKodu);
            this.Controls.Add(this.comboBoxOzelKod);
            this.Controls.Add(this.lblYetkiKodu);
            this.Controls.Add(this.lblOzelKod);
            this.Controls.Add(this.btnTarih);
            this.Controls.Add(this.txtBelgeNo);
            this.Controls.Add(this.lblBelgeNo);
            this.Controls.Add(this.lblZaman);
            this.Controls.Add(this.lblTarih);
            this.Controls.Add(this.lblFisNo);
            this.Controls.Add(this.txtZaman);
            this.Controls.Add(this.txtTarih);
            this.Controls.Add(this.txtFisNo);
            this.Controls.Add(this.cbxSatisElemani);
            this.Controls.Add(this.lblTicariIslemGrubu);
            this.Controls.Add(this.btnUnvan);
            this.Controls.Add(this.btnKod);
            this.Controls.Add(this.txtTicIslemGrb);
            this.Controls.Add(this.txtUnvan);
            this.Controls.Add(this.txtKod);
            this.Controls.Add(this.lblUnvanı);
            this.Controls.Add(this.lblKodu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmStokIslemleri_SatinAlmaIrsaliye_Irsaliye";
            this.Text = "Stok İşlemleri > Satın Alma İrsaliyeleri > İrsaliye";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxIrsaliyeTipi;
        private System.Windows.Forms.Label lblIrsaliyeTipi;
        private Bunifu.Framework.UI.BunifuFlatButton btnDuzenlemeTarihi;
        private System.Windows.Forms.Label lblDuzenlemeTarihi;
        private System.Windows.Forms.TextBox txtDuzenlemeTarihi;
        private System.Windows.Forms.TextBox txtParaBirimiToplamIndirim;
        private System.Windows.Forms.TextBox txtIslemDoviziToplam;
        private System.Windows.Forms.TextBox txtIslemDoviziToplamIndirim;
        private System.Windows.Forms.TextBox txtIslemDoviziNet;
        private System.Windows.Forms.TextBox txtIslemDoviziToplamKDV;
        private System.Windows.Forms.TextBox txtParaBirimiToplam;
        private System.Windows.Forms.TextBox txtParaBirimiNet;
        private System.Windows.Forms.TextBox txtParaBirimiToplamKDV;
        private System.Windows.Forms.Label lblNet;
        private System.Windows.Forms.Label lblToplamKDV;
        private System.Windows.Forms.Label lblToplam;
        private System.Windows.Forms.Label lblToplamIndirim;
        private System.Windows.Forms.Label lblIslemDovizi;
        private System.Windows.Forms.Label lblYerelParaBirimi;
        private System.Windows.Forms.DataGridView dataGridViewFis;
        private System.Windows.Forms.Label lblCHBilgileri;
        private System.Windows.Forms.ComboBox comboBoxIsYeri;
        private System.Windows.Forms.Label lblIsYeri;
        private System.Windows.Forms.ComboBox comboBoxAmbar;
        private System.Windows.Forms.Label lblAmbar;
        private System.Windows.Forms.Label lblSatisElemaniKodu;
        private System.Windows.Forms.ComboBox comboBoxYetkiKodu;
        private System.Windows.Forms.ComboBox comboBoxOzelKod;
        private System.Windows.Forms.Label lblYetkiKodu;
        private System.Windows.Forms.Label lblOzelKod;
        private Bunifu.Framework.UI.BunifuFlatButton btnTarih;
        private System.Windows.Forms.TextBox txtBelgeNo;
        private System.Windows.Forms.Label lblBelgeNo;
        private System.Windows.Forms.Label lblZaman;
        private System.Windows.Forms.Label lblTarih;
        private System.Windows.Forms.Label lblFisNo;
        private System.Windows.Forms.TextBox txtZaman;
        private System.Windows.Forms.TextBox txtTarih;
        private System.Windows.Forms.TextBox txtFisNo;
        private System.Windows.Forms.ComboBox cbxSatisElemani;
        private System.Windows.Forms.Label lblTicariIslemGrubu;
        private Bunifu.Framework.UI.BunifuFlatButton btnUnvan;
        private Bunifu.Framework.UI.BunifuFlatButton btnKod;
        private System.Windows.Forms.TextBox txtTicIslemGrb;
        private System.Windows.Forms.TextBox txtUnvan;
        private System.Windows.Forms.TextBox txtKod;
        private System.Windows.Forms.Label lblUnvanı;
        private System.Windows.Forms.Label lblKodu;
        private Bunifu.Framework.UI.BunifuFlatButton btnEkle;
        private System.Windows.Forms.DataGridViewComboBoxColumn Satir_Turu;
        private System.Windows.Forms.DataGridViewTextBoxColumn MlzKodu;
        private System.Windows.Forms.DataGridViewTextBoxColumn MlzAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Miktar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Birim;
        private System.Windows.Forms.DataGridViewTextBoxColumn Birim_Fiyat;
        private System.Windows.Forms.DataGridViewTextBoxColumn DovBfiyat;
        private System.Windows.Forms.DataGridViewTextBoxColumn KDVOrani;
        private System.Windows.Forms.DataGridViewTextBoxColumn KDVTutari;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tutar;
        private System.Windows.Forms.DataGridViewTextBoxColumn DovTutar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Net_tutar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Aciklama;
    }
}