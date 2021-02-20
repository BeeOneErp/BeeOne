
namespace BeeOne
{
    partial class frmStokIslemleri_MalzemeFisleri_Fis
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewFis = new System.Windows.Forms.DataGridView();
            this.comboBoxYetkiKodu = new System.Windows.Forms.ComboBox();
            this.comboBoxOzelKod = new System.Windows.Forms.ComboBox();
            this.lblYetkiKodu = new System.Windows.Forms.Label();
            this.lblOzelKod = new System.Windows.Forms.Label();
            this.btnFisTarihi = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtBelgeNo = new System.Windows.Forms.TextBox();
            this.lblBelgeNo = new System.Windows.Forms.Label();
            this.lblSaat = new System.Windows.Forms.Label();
            this.lblFisTarihi = new System.Windows.Forms.Label();
            this.lblFisNo = new System.Windows.Forms.Label();
            this.txtZaman = new System.Windows.Forms.TextBox();
            this.txtFisTarihi = new System.Windows.Forms.TextBox();
            this.txtFisNo = new System.Windows.Forms.TextBox();
            this.txtEUROToplamEkVergi = new System.Windows.Forms.TextBox();
            this.txtEUROToplam = new System.Windows.Forms.TextBox();
            this.txtParaBirimiToplamEkVergi = new System.Windows.Forms.TextBox();
            this.txtParaBirimiToplam = new System.Windows.Forms.TextBox();
            this.lblToplamEkVergi = new System.Windows.Forms.Label();
            this.lblToplam = new System.Windows.Forms.Label();
            this.lblEURO = new System.Windows.Forms.Label();
            this.lblYerelParaBirimi = new System.Windows.Forms.Label();
            this.comboBoxIsYeri = new System.Windows.Forms.ComboBox();
            this.lblIsYeri = new System.Windows.Forms.Label();
            this.comboBoxAmbar = new System.Windows.Forms.ComboBox();
            this.lblAmbar = new System.Windows.Forms.Label();
            this.btnEkle = new Bunifu.Framework.UI.BunifuFlatButton();
            this.MlzKodu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MlzAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Miktar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Birim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BirimFiyat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DovBirimFiyat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tutar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DovTutar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Aciklama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KaynakAmbar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HedefAmbar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFis)).BeginInit();
            this.SuspendLayout();
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
            this.MlzKodu,
            this.MlzAdi,
            this.Miktar,
            this.Birim,
            this.BirimFiyat,
            this.DovBirimFiyat,
            this.Tutar,
            this.DovTutar,
            this.Aciklama,
            this.KaynakAmbar,
            this.HedefAmbar});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(0, 6, 0, 6);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewFis.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewFis.Location = new System.Drawing.Point(13, 169);
            this.dataGridViewFis.Name = "dataGridViewFis";
            this.dataGridViewFis.ReadOnly = true;
            this.dataGridViewFis.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.dataGridViewFis.RowTemplate.Height = 40;
            this.dataGridViewFis.Size = new System.Drawing.Size(660, 169);
            this.dataGridViewFis.TabIndex = 143;
            // 
            // comboBoxYetkiKodu
            // 
            this.comboBoxYetkiKodu.FormattingEnabled = true;
            this.comboBoxYetkiKodu.Location = new System.Drawing.Point(469, 39);
            this.comboBoxYetkiKodu.Name = "comboBoxYetkiKodu";
            this.comboBoxYetkiKodu.Size = new System.Drawing.Size(172, 21);
            this.comboBoxYetkiKodu.TabIndex = 141;
            // 
            // comboBoxOzelKod
            // 
            this.comboBoxOzelKod.FormattingEnabled = true;
            this.comboBoxOzelKod.Location = new System.Drawing.Point(469, 12);
            this.comboBoxOzelKod.Name = "comboBoxOzelKod";
            this.comboBoxOzelKod.Size = new System.Drawing.Size(172, 21);
            this.comboBoxOzelKod.TabIndex = 140;
            // 
            // lblYetkiKodu
            // 
            this.lblYetkiKodu.AutoSize = true;
            this.lblYetkiKodu.BackColor = System.Drawing.Color.Transparent;
            this.lblYetkiKodu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYetkiKodu.Location = new System.Drawing.Point(387, 41);
            this.lblYetkiKodu.Name = "lblYetkiKodu";
            this.lblYetkiKodu.Size = new System.Drawing.Size(65, 15);
            this.lblYetkiKodu.TabIndex = 139;
            this.lblYetkiKodu.Text = "Yetki Kodu";
            // 
            // lblOzelKod
            // 
            this.lblOzelKod.AutoSize = true;
            this.lblOzelKod.BackColor = System.Drawing.Color.Transparent;
            this.lblOzelKod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOzelKod.Location = new System.Drawing.Point(395, 13);
            this.lblOzelKod.Name = "lblOzelKod";
            this.lblOzelKod.Size = new System.Drawing.Size(57, 15);
            this.lblOzelKod.TabIndex = 138;
            this.lblOzelKod.Text = "Özel Kod";
            // 
            // btnFisTarihi
            // 
            this.btnFisTarihi.Activecolor = System.Drawing.Color.Khaki;
            this.btnFisTarihi.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnFisTarihi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFisTarihi.BorderRadius = 0;
            this.btnFisTarihi.ButtonText = "...";
            this.btnFisTarihi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFisTarihi.DisabledColor = System.Drawing.Color.Gray;
            this.btnFisTarihi.Iconcolor = System.Drawing.Color.Transparent;
            this.btnFisTarihi.Iconimage = null;
            this.btnFisTarihi.Iconimage_right = null;
            this.btnFisTarihi.Iconimage_right_Selected = null;
            this.btnFisTarihi.Iconimage_Selected = null;
            this.btnFisTarihi.IconMarginLeft = 0;
            this.btnFisTarihi.IconMarginRight = 0;
            this.btnFisTarihi.IconRightVisible = true;
            this.btnFisTarihi.IconRightZoom = 0D;
            this.btnFisTarihi.IconVisible = true;
            this.btnFisTarihi.IconZoom = 90D;
            this.btnFisTarihi.IsTab = false;
            this.btnFisTarihi.Location = new System.Drawing.Point(307, 41);
            this.btnFisTarihi.Name = "btnFisTarihi";
            this.btnFisTarihi.Normalcolor = System.Drawing.Color.DarkKhaki;
            this.btnFisTarihi.OnHovercolor = System.Drawing.Color.Khaki;
            this.btnFisTarihi.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnFisTarihi.selected = false;
            this.btnFisTarihi.Size = new System.Drawing.Size(23, 20);
            this.btnFisTarihi.TabIndex = 137;
            this.btnFisTarihi.Text = "...";
            this.btnFisTarihi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnFisTarihi.Textcolor = System.Drawing.Color.Black;
            this.btnFisTarihi.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // txtBelgeNo
            // 
            this.txtBelgeNo.Location = new System.Drawing.Point(100, 90);
            this.txtBelgeNo.Multiline = true;
            this.txtBelgeNo.Name = "txtBelgeNo";
            this.txtBelgeNo.Size = new System.Drawing.Size(230, 21);
            this.txtBelgeNo.TabIndex = 136;
            // 
            // lblBelgeNo
            // 
            this.lblBelgeNo.AutoSize = true;
            this.lblBelgeNo.BackColor = System.Drawing.Color.Transparent;
            this.lblBelgeNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBelgeNo.Location = new System.Drawing.Point(12, 93);
            this.lblBelgeNo.Name = "lblBelgeNo";
            this.lblBelgeNo.Size = new System.Drawing.Size(61, 15);
            this.lblBelgeNo.TabIndex = 135;
            this.lblBelgeNo.Text = "Belge No.";
            // 
            // lblSaat
            // 
            this.lblSaat.AutoSize = true;
            this.lblSaat.BackColor = System.Drawing.Color.Transparent;
            this.lblSaat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSaat.Location = new System.Drawing.Point(12, 67);
            this.lblSaat.Name = "lblSaat";
            this.lblSaat.Size = new System.Drawing.Size(32, 15);
            this.lblSaat.TabIndex = 134;
            this.lblSaat.Text = "Saat";
            // 
            // lblFisTarihi
            // 
            this.lblFisTarihi.AutoSize = true;
            this.lblFisTarihi.BackColor = System.Drawing.Color.Transparent;
            this.lblFisTarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFisTarihi.Location = new System.Drawing.Point(12, 43);
            this.lblFisTarihi.Name = "lblFisTarihi";
            this.lblFisTarihi.Size = new System.Drawing.Size(57, 15);
            this.lblFisTarihi.TabIndex = 133;
            this.lblFisTarihi.Text = "Fiş Tarihi";
            // 
            // lblFisNo
            // 
            this.lblFisNo.AutoSize = true;
            this.lblFisNo.BackColor = System.Drawing.Color.Transparent;
            this.lblFisNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFisNo.Location = new System.Drawing.Point(12, 18);
            this.lblFisNo.Name = "lblFisNo";
            this.lblFisNo.Size = new System.Drawing.Size(45, 15);
            this.lblFisNo.TabIndex = 132;
            this.lblFisNo.Text = "Fiş No.";
            // 
            // txtZaman
            // 
            this.txtZaman.Location = new System.Drawing.Point(100, 65);
            this.txtZaman.Multiline = true;
            this.txtZaman.Name = "txtZaman";
            this.txtZaman.Size = new System.Drawing.Size(160, 21);
            this.txtZaman.TabIndex = 131;
            // 
            // txtFisTarihi
            // 
            this.txtFisTarihi.Location = new System.Drawing.Point(100, 40);
            this.txtFisTarihi.Multiline = true;
            this.txtFisTarihi.Name = "txtFisTarihi";
            this.txtFisTarihi.Size = new System.Drawing.Size(230, 21);
            this.txtFisTarihi.TabIndex = 130;
            // 
            // txtFisNo
            // 
            this.txtFisNo.Location = new System.Drawing.Point(100, 16);
            this.txtFisNo.Multiline = true;
            this.txtFisNo.Name = "txtFisNo";
            this.txtFisNo.Size = new System.Drawing.Size(230, 21);
            this.txtFisNo.TabIndex = 129;
            // 
            // txtEUROToplamEkVergi
            // 
            this.txtEUROToplamEkVergi.Location = new System.Drawing.Point(345, 373);
            this.txtEUROToplamEkVergi.Multiline = true;
            this.txtEUROToplamEkVergi.Name = "txtEUROToplamEkVergi";
            this.txtEUROToplamEkVergi.Size = new System.Drawing.Size(207, 21);
            this.txtEUROToplamEkVergi.TabIndex = 157;
            // 
            // txtEUROToplam
            // 
            this.txtEUROToplam.Location = new System.Drawing.Point(345, 400);
            this.txtEUROToplam.Multiline = true;
            this.txtEUROToplam.Name = "txtEUROToplam";
            this.txtEUROToplam.Size = new System.Drawing.Size(207, 21);
            this.txtEUROToplam.TabIndex = 156;
            // 
            // txtParaBirimiToplamEkVergi
            // 
            this.txtParaBirimiToplamEkVergi.Location = new System.Drawing.Point(117, 373);
            this.txtParaBirimiToplamEkVergi.Multiline = true;
            this.txtParaBirimiToplamEkVergi.Name = "txtParaBirimiToplamEkVergi";
            this.txtParaBirimiToplamEkVergi.Size = new System.Drawing.Size(207, 21);
            this.txtParaBirimiToplamEkVergi.TabIndex = 155;
            // 
            // txtParaBirimiToplam
            // 
            this.txtParaBirimiToplam.Location = new System.Drawing.Point(117, 400);
            this.txtParaBirimiToplam.Multiline = true;
            this.txtParaBirimiToplam.Name = "txtParaBirimiToplam";
            this.txtParaBirimiToplam.Size = new System.Drawing.Size(207, 21);
            this.txtParaBirimiToplam.TabIndex = 154;
            // 
            // lblToplamEkVergi
            // 
            this.lblToplamEkVergi.AutoSize = true;
            this.lblToplamEkVergi.BackColor = System.Drawing.Color.Transparent;
            this.lblToplamEkVergi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplamEkVergi.Location = new System.Drawing.Point(10, 375);
            this.lblToplamEkVergi.Name = "lblToplamEkVergi";
            this.lblToplamEkVergi.Size = new System.Drawing.Size(100, 13);
            this.lblToplamEkVergi.TabIndex = 153;
            this.lblToplamEkVergi.Text = "Toplam Ek Vergi";
            // 
            // lblToplam
            // 
            this.lblToplam.AutoSize = true;
            this.lblToplam.BackColor = System.Drawing.Color.Transparent;
            this.lblToplam.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplam.Location = new System.Drawing.Point(10, 402);
            this.lblToplam.Name = "lblToplam";
            this.lblToplam.Size = new System.Drawing.Size(48, 13);
            this.lblToplam.TabIndex = 152;
            this.lblToplam.Text = "Toplam";
            // 
            // lblEURO
            // 
            this.lblEURO.AutoSize = true;
            this.lblEURO.BackColor = System.Drawing.Color.Transparent;
            this.lblEURO.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEURO.Location = new System.Drawing.Point(409, 349);
            this.lblEURO.Name = "lblEURO";
            this.lblEURO.Size = new System.Drawing.Size(75, 13);
            this.lblEURO.TabIndex = 151;
            this.lblEURO.Text = "İşlem Dövizi";
            // 
            // lblYerelParaBirimi
            // 
            this.lblYerelParaBirimi.AutoSize = true;
            this.lblYerelParaBirimi.BackColor = System.Drawing.Color.Transparent;
            this.lblYerelParaBirimi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYerelParaBirimi.Location = new System.Drawing.Point(171, 349);
            this.lblYerelParaBirimi.Name = "lblYerelParaBirimi";
            this.lblYerelParaBirimi.Size = new System.Drawing.Size(100, 13);
            this.lblYerelParaBirimi.TabIndex = 150;
            this.lblYerelParaBirimi.Text = "Yerel Para Birimi";
            // 
            // comboBoxIsYeri
            // 
            this.comboBoxIsYeri.FormattingEnabled = true;
            this.comboBoxIsYeri.Location = new System.Drawing.Point(469, 66);
            this.comboBoxIsYeri.Name = "comboBoxIsYeri";
            this.comboBoxIsYeri.Size = new System.Drawing.Size(172, 21);
            this.comboBoxIsYeri.TabIndex = 163;
            // 
            // lblIsYeri
            // 
            this.lblIsYeri.AutoSize = true;
            this.lblIsYeri.BackColor = System.Drawing.Color.Transparent;
            this.lblIsYeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblIsYeri.Location = new System.Drawing.Point(412, 67);
            this.lblIsYeri.Name = "lblIsYeri";
            this.lblIsYeri.Size = new System.Drawing.Size(40, 15);
            this.lblIsYeri.TabIndex = 162;
            this.lblIsYeri.Text = "İş Yeri";
            // 
            // comboBoxAmbar
            // 
            this.comboBoxAmbar.FormattingEnabled = true;
            this.comboBoxAmbar.Location = new System.Drawing.Point(469, 93);
            this.comboBoxAmbar.Name = "comboBoxAmbar";
            this.comboBoxAmbar.Size = new System.Drawing.Size(172, 21);
            this.comboBoxAmbar.TabIndex = 161;
            // 
            // lblAmbar
            // 
            this.lblAmbar.AutoSize = true;
            this.lblAmbar.BackColor = System.Drawing.Color.Transparent;
            this.lblAmbar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAmbar.Location = new System.Drawing.Point(409, 94);
            this.lblAmbar.Name = "lblAmbar";
            this.lblAmbar.Size = new System.Drawing.Size(43, 15);
            this.lblAmbar.TabIndex = 160;
            this.lblAmbar.Text = "Ambar";
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
            this.btnEkle.Location = new System.Drawing.Point(575, 449);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Normalcolor = System.Drawing.Color.DarkKhaki;
            this.btnEkle.OnHovercolor = System.Drawing.Color.Khaki;
            this.btnEkle.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnEkle.selected = false;
            this.btnEkle.Size = new System.Drawing.Size(98, 31);
            this.btnEkle.TabIndex = 173;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEkle.Textcolor = System.Drawing.Color.Black;
            this.btnEkle.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // MlzKodu
            // 
            this.MlzKodu.HeaderText = "Malzeme Kodu";
            this.MlzKodu.Name = "MlzKodu";
            this.MlzKodu.ReadOnly = true;
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
            this.Birim.ToolTipText = "ADET";
            // 
            // BirimFiyat
            // 
            this.BirimFiyat.HeaderText = "Birim Fiyat";
            this.BirimFiyat.Name = "BirimFiyat";
            this.BirimFiyat.ReadOnly = true;
            // 
            // DovBirimFiyat
            // 
            this.DovBirimFiyat.HeaderText = "Dövizli Birim Fiyat";
            this.DovBirimFiyat.Name = "DovBirimFiyat";
            this.DovBirimFiyat.ReadOnly = true;
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
            // Aciklama
            // 
            this.Aciklama.HeaderText = "Açıklama";
            this.Aciklama.Name = "Aciklama";
            this.Aciklama.ReadOnly = true;
            // 
            // KaynakAmbar
            // 
            this.KaynakAmbar.HeaderText = "Kaynak Ambar Kodu";
            this.KaynakAmbar.Name = "KaynakAmbar";
            this.KaynakAmbar.ReadOnly = true;
            this.KaynakAmbar.ToolTipText = "0";
            // 
            // HedefAmbar
            // 
            this.HedefAmbar.HeaderText = "Hedef Ambar Kodu";
            this.HedefAmbar.Name = "HedefAmbar";
            this.HedefAmbar.ReadOnly = true;
            this.HedefAmbar.ToolTipText = "0";
            // 
            // frmStokIslemleri_MalzemeFisleri_Fis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.BackgroundImage = global::BeeOne.Properties.Resources.background__41_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(688, 492);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.comboBoxIsYeri);
            this.Controls.Add(this.lblIsYeri);
            this.Controls.Add(this.comboBoxAmbar);
            this.Controls.Add(this.lblAmbar);
            this.Controls.Add(this.txtEUROToplamEkVergi);
            this.Controls.Add(this.txtEUROToplam);
            this.Controls.Add(this.txtParaBirimiToplamEkVergi);
            this.Controls.Add(this.txtParaBirimiToplam);
            this.Controls.Add(this.lblToplamEkVergi);
            this.Controls.Add(this.lblToplam);
            this.Controls.Add(this.lblEURO);
            this.Controls.Add(this.lblYerelParaBirimi);
            this.Controls.Add(this.dataGridViewFis);
            this.Controls.Add(this.comboBoxYetkiKodu);
            this.Controls.Add(this.comboBoxOzelKod);
            this.Controls.Add(this.lblYetkiKodu);
            this.Controls.Add(this.lblOzelKod);
            this.Controls.Add(this.btnFisTarihi);
            this.Controls.Add(this.txtBelgeNo);
            this.Controls.Add(this.lblBelgeNo);
            this.Controls.Add(this.lblSaat);
            this.Controls.Add(this.lblFisTarihi);
            this.Controls.Add(this.lblFisNo);
            this.Controls.Add(this.txtZaman);
            this.Controls.Add(this.txtFisTarihi);
            this.Controls.Add(this.txtFisNo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmStokIslemleri_MalzemeFisleri_Fis";
            this.Text = "Stok İşlemleri > Malzeme Fişleri > Fiş";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewFis;
        private System.Windows.Forms.ComboBox comboBoxYetkiKodu;
        private System.Windows.Forms.ComboBox comboBoxOzelKod;
        private System.Windows.Forms.Label lblYetkiKodu;
        private System.Windows.Forms.Label lblOzelKod;
        private Bunifu.Framework.UI.BunifuFlatButton btnFisTarihi;
        private System.Windows.Forms.TextBox txtBelgeNo;
        private System.Windows.Forms.Label lblBelgeNo;
        private System.Windows.Forms.Label lblSaat;
        private System.Windows.Forms.Label lblFisTarihi;
        private System.Windows.Forms.Label lblFisNo;
        private System.Windows.Forms.TextBox txtZaman;
        private System.Windows.Forms.TextBox txtFisTarihi;
        private System.Windows.Forms.TextBox txtFisNo;
        private System.Windows.Forms.TextBox txtEUROToplamEkVergi;
        private System.Windows.Forms.TextBox txtEUROToplam;
        private System.Windows.Forms.TextBox txtParaBirimiToplamEkVergi;
        private System.Windows.Forms.TextBox txtParaBirimiToplam;
        private System.Windows.Forms.Label lblToplamEkVergi;
        private System.Windows.Forms.Label lblToplam;
        private System.Windows.Forms.Label lblEURO;
        private System.Windows.Forms.Label lblYerelParaBirimi;
        private System.Windows.Forms.ComboBox comboBoxIsYeri;
        private System.Windows.Forms.Label lblIsYeri;
        private System.Windows.Forms.ComboBox comboBoxAmbar;
        private System.Windows.Forms.Label lblAmbar;
        private Bunifu.Framework.UI.BunifuFlatButton btnEkle;
        private System.Windows.Forms.DataGridViewTextBoxColumn MlzKodu;
        private System.Windows.Forms.DataGridViewTextBoxColumn MlzAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Miktar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Birim;
        private System.Windows.Forms.DataGridViewTextBoxColumn BirimFiyat;
        private System.Windows.Forms.DataGridViewTextBoxColumn DovBirimFiyat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tutar;
        private System.Windows.Forms.DataGridViewTextBoxColumn DovTutar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Aciklama;
        private System.Windows.Forms.DataGridViewTextBoxColumn KaynakAmbar;
        private System.Windows.Forms.DataGridViewTextBoxColumn HedefAmbar;
    }
}