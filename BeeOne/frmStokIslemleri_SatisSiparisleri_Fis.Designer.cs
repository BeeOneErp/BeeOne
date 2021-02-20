
namespace BeeOne
{
    partial class frmStokIslemleri_SatisSiparisleri_Fis
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
            this.txtUnvan = new System.Windows.Forms.TextBox();
            this.txtKod = new System.Windows.Forms.TextBox();
            this.lblUnvanı = new System.Windows.Forms.Label();
            this.lblKodu = new System.Windows.Forms.Label();
            this.btnUnvan = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnKod = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lblTicariIslemGrubu = new System.Windows.Forms.Label();
            this.txtBelgeNo = new System.Windows.Forms.TextBox();
            this.lblBelgeNo = new System.Windows.Forms.Label();
            this.lblZaman = new System.Windows.Forms.Label();
            this.lblTarih = new System.Windows.Forms.Label();
            this.lblFisNo = new System.Windows.Forms.Label();
            this.txtZaman = new System.Windows.Forms.TextBox();
            this.txtFisNo = new System.Windows.Forms.TextBox();
            this.btnTarih = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtTarih = new System.Windows.Forms.TextBox();
            this.comboBoxYetkiKodu = new System.Windows.Forms.ComboBox();
            this.comboBoxOzelKod = new System.Windows.Forms.ComboBox();
            this.lblYetkiKodu = new System.Windows.Forms.Label();
            this.lblOzelKod = new System.Windows.Forms.Label();
            this.lblSatisElemaniKodu = new System.Windows.Forms.Label();
            this.comboBoxAmbar = new System.Windows.Forms.ComboBox();
            this.lblAmbar = new System.Windows.Forms.Label();
            this.comboBoxIsYeri = new System.Windows.Forms.ComboBox();
            this.lblIsYeri = new System.Windows.Forms.Label();
            this.lblCHBilgileri = new System.Windows.Forms.Label();
            this.dataGridViewFis = new System.Windows.Forms.DataGridView();
            this.lblYerelParaBirimi = new System.Windows.Forms.Label();
            this.lblIslemDovizi = new System.Windows.Forms.Label();
            this.lblToplamIndirim = new System.Windows.Forms.Label();
            this.lblToplam = new System.Windows.Forms.Label();
            this.lblToplamKDV = new System.Windows.Forms.Label();
            this.lblNet = new System.Windows.Forms.Label();
            this.txtParaBirimiToplam = new System.Windows.Forms.TextBox();
            this.txtParaBirimiNet = new System.Windows.Forms.TextBox();
            this.txtParaBirimiToplamKDV = new System.Windows.Forms.TextBox();
            this.txtIslemDoviziToplam = new System.Windows.Forms.TextBox();
            this.txtIslemDoviziToplamIndirim = new System.Windows.Forms.TextBox();
            this.txtIslemDoviziNet = new System.Windows.Forms.TextBox();
            this.txtIslemDoviziToplamKDV = new System.Windows.Forms.TextBox();
            this.checkBoxOdemeli = new System.Windows.Forms.CheckBox();
            this.txtParaBirimiToplamIndirim = new System.Windows.Forms.TextBox();
            this.btnEkle = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtTicIslemGrubu = new System.Windows.Forms.TextBox();
            this.SatisElemani = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFis)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUnvan
            // 
            this.txtUnvan.Location = new System.Drawing.Point(653, 61);
            this.txtUnvan.Multiline = true;
            this.txtUnvan.Name = "txtUnvan";
            this.txtUnvan.Size = new System.Drawing.Size(204, 21);
            this.txtUnvan.TabIndex = 98;
            // 
            // txtKod
            // 
            this.txtKod.Location = new System.Drawing.Point(653, 37);
            this.txtKod.Multiline = true;
            this.txtKod.Name = "txtKod";
            this.txtKod.Size = new System.Drawing.Size(204, 21);
            this.txtKod.TabIndex = 97;
            // 
            // lblUnvanı
            // 
            this.lblUnvanı.AutoSize = true;
            this.lblUnvanı.BackColor = System.Drawing.Color.Transparent;
            this.lblUnvanı.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUnvanı.Location = new System.Drawing.Point(597, 62);
            this.lblUnvanı.Name = "lblUnvanı";
            this.lblUnvanı.Size = new System.Drawing.Size(45, 15);
            this.lblUnvanı.TabIndex = 95;
            this.lblUnvanı.Text = "Unvanı";
            // 
            // lblKodu
            // 
            this.lblKodu.AutoSize = true;
            this.lblKodu.BackColor = System.Drawing.Color.Transparent;
            this.lblKodu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKodu.Location = new System.Drawing.Point(606, 37);
            this.lblKodu.Name = "lblKodu";
            this.lblKodu.Size = new System.Drawing.Size(36, 15);
            this.lblKodu.TabIndex = 94;
            this.lblKodu.Text = "Kodu";
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
            this.btnUnvan.Location = new System.Drawing.Point(834, 62);
            this.btnUnvan.Name = "btnUnvan";
            this.btnUnvan.Normalcolor = System.Drawing.Color.DarkKhaki;
            this.btnUnvan.OnHovercolor = System.Drawing.Color.Khaki;
            this.btnUnvan.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnUnvan.selected = false;
            this.btnUnvan.Size = new System.Drawing.Size(23, 20);
            this.btnUnvan.TabIndex = 101;
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
            this.btnKod.Location = new System.Drawing.Point(834, 38);
            this.btnKod.Name = "btnKod";
            this.btnKod.Normalcolor = System.Drawing.Color.DarkKhaki;
            this.btnKod.OnHovercolor = System.Drawing.Color.Khaki;
            this.btnKod.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnKod.selected = false;
            this.btnKod.Size = new System.Drawing.Size(23, 20);
            this.btnKod.TabIndex = 100;
            this.btnKod.Text = "...";
            this.btnKod.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnKod.Textcolor = System.Drawing.Color.Black;
            this.btnKod.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // lblTicariIslemGrubu
            // 
            this.lblTicariIslemGrubu.AutoSize = true;
            this.lblTicariIslemGrubu.BackColor = System.Drawing.Color.Transparent;
            this.lblTicariIslemGrubu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTicariIslemGrubu.Location = new System.Drawing.Point(535, 90);
            this.lblTicariIslemGrubu.Name = "lblTicariIslemGrubu";
            this.lblTicariIslemGrubu.Size = new System.Drawing.Size(107, 15);
            this.lblTicariIslemGrubu.TabIndex = 103;
            this.lblTicariIslemGrubu.Text = "Ticari İşlem Grubu";
            // 
            // txtBelgeNo
            // 
            this.txtBelgeNo.Location = new System.Drawing.Point(121, 112);
            this.txtBelgeNo.Multiline = true;
            this.txtBelgeNo.Name = "txtBelgeNo";
            this.txtBelgeNo.Size = new System.Drawing.Size(230, 21);
            this.txtBelgeNo.TabIndex = 112;
            // 
            // lblBelgeNo
            // 
            this.lblBelgeNo.AutoSize = true;
            this.lblBelgeNo.BackColor = System.Drawing.Color.Transparent;
            this.lblBelgeNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBelgeNo.Location = new System.Drawing.Point(33, 115);
            this.lblBelgeNo.Name = "lblBelgeNo";
            this.lblBelgeNo.Size = new System.Drawing.Size(61, 15);
            this.lblBelgeNo.TabIndex = 111;
            this.lblBelgeNo.Text = "Belge No.";
            // 
            // lblZaman
            // 
            this.lblZaman.AutoSize = true;
            this.lblZaman.BackColor = System.Drawing.Color.Transparent;
            this.lblZaman.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblZaman.Location = new System.Drawing.Point(33, 89);
            this.lblZaman.Name = "lblZaman";
            this.lblZaman.Size = new System.Drawing.Size(46, 15);
            this.lblZaman.TabIndex = 110;
            this.lblZaman.Text = "Zaman";
            // 
            // lblTarih
            // 
            this.lblTarih.AutoSize = true;
            this.lblTarih.BackColor = System.Drawing.Color.Transparent;
            this.lblTarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTarih.Location = new System.Drawing.Point(33, 65);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(35, 15);
            this.lblTarih.TabIndex = 109;
            this.lblTarih.Text = "Tarih";
            // 
            // lblFisNo
            // 
            this.lblFisNo.AutoSize = true;
            this.lblFisNo.BackColor = System.Drawing.Color.Transparent;
            this.lblFisNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFisNo.Location = new System.Drawing.Point(33, 40);
            this.lblFisNo.Name = "lblFisNo";
            this.lblFisNo.Size = new System.Drawing.Size(45, 15);
            this.lblFisNo.TabIndex = 108;
            this.lblFisNo.Text = "Fiş No.";
            // 
            // txtZaman
            // 
            this.txtZaman.Location = new System.Drawing.Point(121, 87);
            this.txtZaman.Multiline = true;
            this.txtZaman.Name = "txtZaman";
            this.txtZaman.Size = new System.Drawing.Size(160, 21);
            this.txtZaman.TabIndex = 107;
            // 
            // txtFisNo
            // 
            this.txtFisNo.Location = new System.Drawing.Point(121, 38);
            this.txtFisNo.Multiline = true;
            this.txtFisNo.Name = "txtFisNo";
            this.txtFisNo.Size = new System.Drawing.Size(230, 21);
            this.txtFisNo.TabIndex = 105;
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
            this.btnTarih.Location = new System.Drawing.Point(328, 63);
            this.btnTarih.Name = "btnTarih";
            this.btnTarih.Normalcolor = System.Drawing.Color.DarkKhaki;
            this.btnTarih.OnHovercolor = System.Drawing.Color.Khaki;
            this.btnTarih.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnTarih.selected = false;
            this.btnTarih.Size = new System.Drawing.Size(23, 20);
            this.btnTarih.TabIndex = 113;
            this.btnTarih.Text = "...";
            this.btnTarih.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnTarih.Textcolor = System.Drawing.Color.Black;
            this.btnTarih.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // txtTarih
            // 
            this.txtTarih.Location = new System.Drawing.Point(121, 62);
            this.txtTarih.Multiline = true;
            this.txtTarih.Name = "txtTarih";
            this.txtTarih.Size = new System.Drawing.Size(230, 21);
            this.txtTarih.TabIndex = 106;
            // 
            // comboBoxYetkiKodu
            // 
            this.comboBoxYetkiKodu.FormattingEnabled = true;
            this.comboBoxYetkiKodu.Location = new System.Drawing.Point(121, 162);
            this.comboBoxYetkiKodu.Name = "comboBoxYetkiKodu";
            this.comboBoxYetkiKodu.Size = new System.Drawing.Size(172, 21);
            this.comboBoxYetkiKodu.TabIndex = 117;
            // 
            // comboBoxOzelKod
            // 
            this.comboBoxOzelKod.FormattingEnabled = true;
            this.comboBoxOzelKod.Location = new System.Drawing.Point(121, 137);
            this.comboBoxOzelKod.Name = "comboBoxOzelKod";
            this.comboBoxOzelKod.Size = new System.Drawing.Size(172, 21);
            this.comboBoxOzelKod.TabIndex = 116;
            // 
            // lblYetkiKodu
            // 
            this.lblYetkiKodu.AutoSize = true;
            this.lblYetkiKodu.BackColor = System.Drawing.Color.Transparent;
            this.lblYetkiKodu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYetkiKodu.Location = new System.Drawing.Point(33, 164);
            this.lblYetkiKodu.Name = "lblYetkiKodu";
            this.lblYetkiKodu.Size = new System.Drawing.Size(65, 15);
            this.lblYetkiKodu.TabIndex = 115;
            this.lblYetkiKodu.Text = "Yetki Kodu";
            // 
            // lblOzelKod
            // 
            this.lblOzelKod.AutoSize = true;
            this.lblOzelKod.BackColor = System.Drawing.Color.Transparent;
            this.lblOzelKod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOzelKod.Location = new System.Drawing.Point(33, 139);
            this.lblOzelKod.Name = "lblOzelKod";
            this.lblOzelKod.Size = new System.Drawing.Size(57, 15);
            this.lblOzelKod.TabIndex = 114;
            this.lblOzelKod.Text = "Özel Kod";
            // 
            // lblSatisElemaniKodu
            // 
            this.lblSatisElemaniKodu.AutoSize = true;
            this.lblSatisElemaniKodu.BackColor = System.Drawing.Color.Transparent;
            this.lblSatisElemaniKodu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSatisElemaniKodu.Location = new System.Drawing.Point(527, 118);
            this.lblSatisElemaniKodu.Name = "lblSatisElemaniKodu";
            this.lblSatisElemaniKodu.Size = new System.Drawing.Size(115, 15);
            this.lblSatisElemaniKodu.TabIndex = 118;
            this.lblSatisElemaniKodu.Text = "Satış Elemanı Kodu";
            // 
            // comboBoxAmbar
            // 
            this.comboBoxAmbar.FormattingEnabled = true;
            this.comboBoxAmbar.Location = new System.Drawing.Point(1105, 110);
            this.comboBoxAmbar.Name = "comboBoxAmbar";
            this.comboBoxAmbar.Size = new System.Drawing.Size(204, 21);
            this.comboBoxAmbar.TabIndex = 122;
            // 
            // lblAmbar
            // 
            this.lblAmbar.AutoSize = true;
            this.lblAmbar.BackColor = System.Drawing.Color.Transparent;
            this.lblAmbar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAmbar.Location = new System.Drawing.Point(1031, 112);
            this.lblAmbar.Name = "lblAmbar";
            this.lblAmbar.Size = new System.Drawing.Size(43, 15);
            this.lblAmbar.TabIndex = 121;
            this.lblAmbar.Text = "Ambar";
            // 
            // comboBoxIsYeri
            // 
            this.comboBoxIsYeri.FormattingEnabled = true;
            this.comboBoxIsYeri.Location = new System.Drawing.Point(1105, 37);
            this.comboBoxIsYeri.Name = "comboBoxIsYeri";
            this.comboBoxIsYeri.Size = new System.Drawing.Size(204, 21);
            this.comboBoxIsYeri.TabIndex = 124;
            // 
            // lblIsYeri
            // 
            this.lblIsYeri.AutoSize = true;
            this.lblIsYeri.BackColor = System.Drawing.Color.Transparent;
            this.lblIsYeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblIsYeri.Location = new System.Drawing.Point(1031, 39);
            this.lblIsYeri.Name = "lblIsYeri";
            this.lblIsYeri.Size = new System.Drawing.Size(40, 15);
            this.lblIsYeri.TabIndex = 123;
            this.lblIsYeri.Text = "İş Yeri";
            // 
            // lblCHBilgileri
            // 
            this.lblCHBilgileri.AutoSize = true;
            this.lblCHBilgileri.BackColor = System.Drawing.Color.Transparent;
            this.lblCHBilgileri.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCHBilgileri.Location = new System.Drawing.Point(594, 9);
            this.lblCHBilgileri.Name = "lblCHBilgileri";
            this.lblCHBilgileri.Size = new System.Drawing.Size(143, 16);
            this.lblCHBilgileri.TabIndex = 127;
            this.lblCHBilgileri.Text = "Cari Hesap Bilgileri";
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(0, 6, 0, 6);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewFis.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewFis.Location = new System.Drawing.Point(36, 210);
            this.dataGridViewFis.Name = "dataGridViewFis";
            this.dataGridViewFis.ReadOnly = true;
            this.dataGridViewFis.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.dataGridViewFis.RowTemplate.Height = 40;
            this.dataGridViewFis.Size = new System.Drawing.Size(1273, 297);
            this.dataGridViewFis.TabIndex = 128;
            // 
            // lblYerelParaBirimi
            // 
            this.lblYerelParaBirimi.AutoSize = true;
            this.lblYerelParaBirimi.BackColor = System.Drawing.Color.Transparent;
            this.lblYerelParaBirimi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYerelParaBirimi.Location = new System.Drawing.Point(189, 539);
            this.lblYerelParaBirimi.Name = "lblYerelParaBirimi";
            this.lblYerelParaBirimi.Size = new System.Drawing.Size(100, 13);
            this.lblYerelParaBirimi.TabIndex = 129;
            this.lblYerelParaBirimi.Text = "Yerel Para Birimi";
            // 
            // lblIslemDovizi
            // 
            this.lblIslemDovizi.AutoSize = true;
            this.lblIslemDovizi.BackColor = System.Drawing.Color.Transparent;
            this.lblIslemDovizi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblIslemDovizi.Location = new System.Drawing.Point(437, 539);
            this.lblIslemDovizi.Name = "lblIslemDovizi";
            this.lblIslemDovizi.Size = new System.Drawing.Size(75, 13);
            this.lblIslemDovizi.TabIndex = 130;
            this.lblIslemDovizi.Text = "İşlem Dövizi";
            // 
            // lblToplamIndirim
            // 
            this.lblToplamIndirim.AutoSize = true;
            this.lblToplamIndirim.BackColor = System.Drawing.Color.Transparent;
            this.lblToplamIndirim.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplamIndirim.Location = new System.Drawing.Point(33, 578);
            this.lblToplamIndirim.Name = "lblToplamIndirim";
            this.lblToplamIndirim.Size = new System.Drawing.Size(89, 13);
            this.lblToplamIndirim.TabIndex = 133;
            this.lblToplamIndirim.Text = "Toplam İndirim";
            // 
            // lblToplam
            // 
            this.lblToplam.AutoSize = true;
            this.lblToplam.BackColor = System.Drawing.Color.Transparent;
            this.lblToplam.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplam.Location = new System.Drawing.Point(33, 602);
            this.lblToplam.Name = "lblToplam";
            this.lblToplam.Size = new System.Drawing.Size(48, 13);
            this.lblToplam.TabIndex = 134;
            this.lblToplam.Text = "Toplam";
            // 
            // lblToplamKDV
            // 
            this.lblToplamKDV.AutoSize = true;
            this.lblToplamKDV.BackColor = System.Drawing.Color.Transparent;
            this.lblToplamKDV.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplamKDV.Location = new System.Drawing.Point(33, 626);
            this.lblToplamKDV.Name = "lblToplamKDV";
            this.lblToplamKDV.Size = new System.Drawing.Size(77, 13);
            this.lblToplamKDV.TabIndex = 136;
            this.lblToplamKDV.Text = "Toplam KDV";
            // 
            // lblNet
            // 
            this.lblNet.AutoSize = true;
            this.lblNet.BackColor = System.Drawing.Color.Transparent;
            this.lblNet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblNet.Location = new System.Drawing.Point(33, 650);
            this.lblNet.Name = "lblNet";
            this.lblNet.Size = new System.Drawing.Size(27, 13);
            this.lblNet.TabIndex = 137;
            this.lblNet.Text = "Net";
            // 
            // txtParaBirimiToplam
            // 
            this.txtParaBirimiToplam.Location = new System.Drawing.Point(140, 600);
            this.txtParaBirimiToplam.Multiline = true;
            this.txtParaBirimiToplam.Name = "txtParaBirimiToplam";
            this.txtParaBirimiToplam.Size = new System.Drawing.Size(207, 21);
            this.txtParaBirimiToplam.TabIndex = 142;
            // 
            // txtParaBirimiNet
            // 
            this.txtParaBirimiNet.Location = new System.Drawing.Point(140, 648);
            this.txtParaBirimiNet.Multiline = true;
            this.txtParaBirimiNet.Name = "txtParaBirimiNet";
            this.txtParaBirimiNet.Size = new System.Drawing.Size(207, 21);
            this.txtParaBirimiNet.TabIndex = 139;
            // 
            // txtParaBirimiToplamKDV
            // 
            this.txtParaBirimiToplamKDV.Location = new System.Drawing.Point(140, 624);
            this.txtParaBirimiToplamKDV.Multiline = true;
            this.txtParaBirimiToplamKDV.Name = "txtParaBirimiToplamKDV";
            this.txtParaBirimiToplamKDV.Size = new System.Drawing.Size(207, 21);
            this.txtParaBirimiToplamKDV.TabIndex = 138;
            // 
            // txtIslemDoviziToplam
            // 
            this.txtIslemDoviziToplam.Location = new System.Drawing.Point(368, 600);
            this.txtIslemDoviziToplam.Multiline = true;
            this.txtIslemDoviziToplam.Name = "txtIslemDoviziToplam";
            this.txtIslemDoviziToplam.Size = new System.Drawing.Size(207, 21);
            this.txtIslemDoviziToplam.TabIndex = 148;
            // 
            // txtIslemDoviziToplamIndirim
            // 
            this.txtIslemDoviziToplamIndirim.Location = new System.Drawing.Point(368, 576);
            this.txtIslemDoviziToplamIndirim.Multiline = true;
            this.txtIslemDoviziToplamIndirim.Name = "txtIslemDoviziToplamIndirim";
            this.txtIslemDoviziToplamIndirim.Size = new System.Drawing.Size(207, 21);
            this.txtIslemDoviziToplamIndirim.TabIndex = 147;
            // 
            // txtIslemDoviziNet
            // 
            this.txtIslemDoviziNet.Location = new System.Drawing.Point(368, 648);
            this.txtIslemDoviziNet.Multiline = true;
            this.txtIslemDoviziNet.Name = "txtIslemDoviziNet";
            this.txtIslemDoviziNet.Size = new System.Drawing.Size(207, 21);
            this.txtIslemDoviziNet.TabIndex = 145;
            // 
            // txtIslemDoviziToplamKDV
            // 
            this.txtIslemDoviziToplamKDV.Location = new System.Drawing.Point(368, 624);
            this.txtIslemDoviziToplamKDV.Multiline = true;
            this.txtIslemDoviziToplamKDV.Name = "txtIslemDoviziToplamKDV";
            this.txtIslemDoviziToplamKDV.Size = new System.Drawing.Size(207, 21);
            this.txtIslemDoviziToplamKDV.TabIndex = 144;
            // 
            // checkBoxOdemeli
            // 
            this.checkBoxOdemeli.AutoSize = true;
            this.checkBoxOdemeli.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxOdemeli.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBoxOdemeli.Location = new System.Drawing.Point(1034, 159);
            this.checkBoxOdemeli.Name = "checkBoxOdemeli";
            this.checkBoxOdemeli.Size = new System.Drawing.Size(73, 19);
            this.checkBoxOdemeli.TabIndex = 150;
            this.checkBoxOdemeli.Text = "Ödemeli";
            this.checkBoxOdemeli.UseVisualStyleBackColor = false;
            // 
            // txtParaBirimiToplamIndirim
            // 
            this.txtParaBirimiToplamIndirim.Location = new System.Drawing.Point(140, 576);
            this.txtParaBirimiToplamIndirim.Multiline = true;
            this.txtParaBirimiToplamIndirim.Name = "txtParaBirimiToplamIndirim";
            this.txtParaBirimiToplamIndirim.Size = new System.Drawing.Size(207, 21);
            this.txtParaBirimiToplamIndirim.TabIndex = 151;
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
            this.btnEkle.TabIndex = 173;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEkle.Textcolor = System.Drawing.Color.Black;
            this.btnEkle.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // txtTicIslemGrubu
            // 
            this.txtTicIslemGrubu.Location = new System.Drawing.Point(653, 89);
            this.txtTicIslemGrubu.Name = "txtTicIslemGrubu";
            this.txtTicIslemGrubu.Size = new System.Drawing.Size(204, 20);
            this.txtTicIslemGrubu.TabIndex = 174;
            // 
            // SatisElemani
            // 
            this.SatisElemani.FormattingEnabled = true;
            this.SatisElemani.Location = new System.Drawing.Point(653, 117);
            this.SatisElemani.Name = "SatisElemani";
            this.SatisElemani.Size = new System.Drawing.Size(204, 21);
            this.SatisElemani.TabIndex = 175;
            // 
            // frmStokIslemleri_SatisSiparisleri_Fis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.BackgroundImage = global::BeeOne.Properties.Resources.background__41_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1350, 726);
            this.Controls.Add(this.SatisElemani);
            this.Controls.Add(this.txtTicIslemGrubu);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.txtParaBirimiToplamIndirim);
            this.Controls.Add(this.checkBoxOdemeli);
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
            this.Controls.Add(this.lblTicariIslemGrubu);
            this.Controls.Add(this.btnUnvan);
            this.Controls.Add(this.btnKod);
            this.Controls.Add(this.txtUnvan);
            this.Controls.Add(this.txtKod);
            this.Controls.Add(this.lblUnvanı);
            this.Controls.Add(this.lblKodu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmStokIslemleri_SatisSiparisleri_Fis";
            this.Text = "Stok İşlemleri > Satış Siparişleri > Fiş";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtUnvan;
        private System.Windows.Forms.TextBox txtKod;
        private System.Windows.Forms.Label lblUnvanı;
        private System.Windows.Forms.Label lblKodu;
        private Bunifu.Framework.UI.BunifuFlatButton btnUnvan;
        private Bunifu.Framework.UI.BunifuFlatButton btnKod;
        private System.Windows.Forms.Label lblTicariIslemGrubu;
        private System.Windows.Forms.TextBox txtBelgeNo;
        private System.Windows.Forms.Label lblBelgeNo;
        private System.Windows.Forms.Label lblZaman;
        private System.Windows.Forms.Label lblTarih;
        private System.Windows.Forms.Label lblFisNo;
        private System.Windows.Forms.TextBox txtZaman;
        private System.Windows.Forms.TextBox txtFisNo;
        private Bunifu.Framework.UI.BunifuFlatButton btnTarih;
        private System.Windows.Forms.TextBox txtTarih;
        private System.Windows.Forms.ComboBox comboBoxYetkiKodu;
        private System.Windows.Forms.ComboBox comboBoxOzelKod;
        private System.Windows.Forms.Label lblYetkiKodu;
        private System.Windows.Forms.Label lblOzelKod;
        private System.Windows.Forms.Label lblSatisElemaniKodu;
        private System.Windows.Forms.ComboBox comboBoxAmbar;
        private System.Windows.Forms.Label lblAmbar;
        private System.Windows.Forms.ComboBox comboBoxIsYeri;
        private System.Windows.Forms.Label lblIsYeri;
        private System.Windows.Forms.Label lblCHBilgileri;
        private System.Windows.Forms.DataGridView dataGridViewFis;
        private System.Windows.Forms.Label lblYerelParaBirimi;
        private System.Windows.Forms.Label lblIslemDovizi;
        private System.Windows.Forms.Label lblToplamIndirim;
        private System.Windows.Forms.Label lblToplam;
        private System.Windows.Forms.Label lblToplamKDV;
        private System.Windows.Forms.Label lblNet;
        private System.Windows.Forms.TextBox txtParaBirimiToplam;
        private System.Windows.Forms.TextBox txtParaBirimiNet;
        private System.Windows.Forms.TextBox txtParaBirimiToplamKDV;
        private System.Windows.Forms.TextBox txtIslemDoviziToplam;
        private System.Windows.Forms.TextBox txtIslemDoviziToplamIndirim;
        private System.Windows.Forms.TextBox txtIslemDoviziNet;
        private System.Windows.Forms.TextBox txtIslemDoviziToplamKDV;
        private System.Windows.Forms.CheckBox checkBoxOdemeli;
        private System.Windows.Forms.TextBox txtParaBirimiToplamIndirim;
        private Bunifu.Framework.UI.BunifuFlatButton btnEkle;
        private System.Windows.Forms.TextBox txtTicIslemGrubu;
        private System.Windows.Forms.ComboBox SatisElemani;
    }
}