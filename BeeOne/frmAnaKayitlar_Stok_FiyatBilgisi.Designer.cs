
namespace BeeOne
{
    partial class frmAnaKayitlar_Stok_FiyatBilgisi
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
            this.dataGridViewFiyatBilgisi = new System.Windows.Forms.DataGridView();
            this.btnEkle = new Bunifu.Framework.UI.BunifuFlatButton();
            this.comboBoxTuru = new System.Windows.Forms.ComboBox();
            this.lblTuru = new System.Windows.Forms.Label();
            this.txtBirimFiyat = new System.Windows.Forms.TextBox();
            this.lblBirimFiyat = new System.Windows.Forms.Label();
            this.txtCariKodu = new System.Windows.Forms.TextBox();
            this.lblCariKodu = new System.Windows.Forms.Label();
            this.txtBitisTarihi = new System.Windows.Forms.TextBox();
            this.lblBitisTarihi = new System.Windows.Forms.Label();
            this.txtBaslangicTarihi = new System.Windows.Forms.TextBox();
            this.lblBaslangicTarihi = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFiyatBilgisi)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewFiyatBilgisi
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewFiyatBilgisi.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewFiyatBilgisi.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewFiyatBilgisi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewFiyatBilgisi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(0, 6, 0, 6);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewFiyatBilgisi.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewFiyatBilgisi.Location = new System.Drawing.Point(12, 94);
            this.dataGridViewFiyatBilgisi.Name = "dataGridViewFiyatBilgisi";
            this.dataGridViewFiyatBilgisi.ReadOnly = true;
            this.dataGridViewFiyatBilgisi.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.dataGridViewFiyatBilgisi.RowTemplate.Height = 40;
            this.dataGridViewFiyatBilgisi.Size = new System.Drawing.Size(920, 187);
            this.dataGridViewFiyatBilgisi.TabIndex = 91;
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
            this.btnEkle.Location = new System.Drawing.Point(47, 46);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Normalcolor = System.Drawing.Color.DarkKhaki;
            this.btnEkle.OnHovercolor = System.Drawing.Color.Khaki;
            this.btnEkle.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnEkle.selected = false;
            this.btnEkle.Size = new System.Drawing.Size(98, 31);
            this.btnEkle.TabIndex = 93;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEkle.Textcolor = System.Drawing.Color.Black;
            this.btnEkle.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // comboBoxTuru
            // 
            this.comboBoxTuru.FormattingEnabled = true;
            this.comboBoxTuru.Items.AddRange(new object[] {
            "Satış",
            "Satın alma"});
            this.comboBoxTuru.Location = new System.Drawing.Point(47, 8);
            this.comboBoxTuru.Name = "comboBoxTuru";
            this.comboBoxTuru.Size = new System.Drawing.Size(172, 21);
            this.comboBoxTuru.TabIndex = 96;
            // 
            // lblTuru
            // 
            this.lblTuru.AutoSize = true;
            this.lblTuru.BackColor = System.Drawing.Color.Transparent;
            this.lblTuru.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTuru.Location = new System.Drawing.Point(9, 9);
            this.lblTuru.Name = "lblTuru";
            this.lblTuru.Size = new System.Drawing.Size(32, 15);
            this.lblTuru.TabIndex = 95;
            this.lblTuru.Text = "Türü";
            // 
            // txtBirimFiyat
            // 
            this.txtBirimFiyat.Location = new System.Drawing.Point(392, 8);
            this.txtBirimFiyat.Multiline = true;
            this.txtBirimFiyat.Name = "txtBirimFiyat";
            this.txtBirimFiyat.Size = new System.Drawing.Size(172, 21);
            this.txtBirimFiyat.TabIndex = 105;
            // 
            // lblBirimFiyat
            // 
            this.lblBirimFiyat.AutoSize = true;
            this.lblBirimFiyat.BackColor = System.Drawing.Color.Transparent;
            this.lblBirimFiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBirimFiyat.Location = new System.Drawing.Point(322, 9);
            this.lblBirimFiyat.Name = "lblBirimFiyat";
            this.lblBirimFiyat.Size = new System.Drawing.Size(64, 15);
            this.lblBirimFiyat.TabIndex = 104;
            this.lblBirimFiyat.Text = "Birim Fiyat";
            // 
            // txtCariKodu
            // 
            this.txtCariKodu.Location = new System.Drawing.Point(392, 32);
            this.txtCariKodu.Multiline = true;
            this.txtCariKodu.Name = "txtCariKodu";
            this.txtCariKodu.Size = new System.Drawing.Size(172, 21);
            this.txtCariKodu.TabIndex = 107;
            // 
            // lblCariKodu
            // 
            this.lblCariKodu.AutoSize = true;
            this.lblCariKodu.BackColor = System.Drawing.Color.Transparent;
            this.lblCariKodu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCariKodu.Location = new System.Drawing.Point(322, 33);
            this.lblCariKodu.Name = "lblCariKodu";
            this.lblCariKodu.Size = new System.Drawing.Size(61, 15);
            this.lblCariKodu.TabIndex = 106;
            this.lblCariKodu.Text = "Cari Kodu";
            // 
            // txtBitisTarihi
            // 
            this.txtBitisTarihi.Location = new System.Drawing.Point(760, 32);
            this.txtBitisTarihi.Multiline = true;
            this.txtBitisTarihi.Name = "txtBitisTarihi";
            this.txtBitisTarihi.Size = new System.Drawing.Size(172, 21);
            this.txtBitisTarihi.TabIndex = 111;
            // 
            // lblBitisTarihi
            // 
            this.lblBitisTarihi.AutoSize = true;
            this.lblBitisTarihi.BackColor = System.Drawing.Color.Transparent;
            this.lblBitisTarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBitisTarihi.Location = new System.Drawing.Point(659, 33);
            this.lblBitisTarihi.Name = "lblBitisTarihi";
            this.lblBitisTarihi.Size = new System.Drawing.Size(64, 15);
            this.lblBitisTarihi.TabIndex = 110;
            this.lblBitisTarihi.Text = "Bitiş Tarihi";
            // 
            // txtBaslangicTarihi
            // 
            this.txtBaslangicTarihi.Location = new System.Drawing.Point(760, 8);
            this.txtBaslangicTarihi.Multiline = true;
            this.txtBaslangicTarihi.Name = "txtBaslangicTarihi";
            this.txtBaslangicTarihi.Size = new System.Drawing.Size(172, 21);
            this.txtBaslangicTarihi.TabIndex = 109;
            // 
            // lblBaslangicTarihi
            // 
            this.lblBaslangicTarihi.AutoSize = true;
            this.lblBaslangicTarihi.BackColor = System.Drawing.Color.Transparent;
            this.lblBaslangicTarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBaslangicTarihi.Location = new System.Drawing.Point(659, 9);
            this.lblBaslangicTarihi.Name = "lblBaslangicTarihi";
            this.lblBaslangicTarihi.Size = new System.Drawing.Size(95, 15);
            this.lblBaslangicTarihi.TabIndex = 108;
            this.lblBaslangicTarihi.Text = "Başlangıç Tarihi";
            // 
            // frmAnaKayitlar_Stok_FiyatBilgisi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BeeOne.Properties.Resources.background__41_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(944, 296);
            this.Controls.Add(this.txtBitisTarihi);
            this.Controls.Add(this.lblBitisTarihi);
            this.Controls.Add(this.txtBaslangicTarihi);
            this.Controls.Add(this.lblBaslangicTarihi);
            this.Controls.Add(this.txtCariKodu);
            this.Controls.Add(this.lblCariKodu);
            this.Controls.Add(this.txtBirimFiyat);
            this.Controls.Add(this.lblBirimFiyat);
            this.Controls.Add(this.comboBoxTuru);
            this.Controls.Add(this.lblTuru);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.dataGridViewFiyatBilgisi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAnaKayitlar_Stok_FiyatBilgisi";
            this.Text = "Ana Kayıtlar > Stok > Fiyat Bilgisi";
            this.Load += new System.EventHandler(this.frmAnaKayitlar_Stok_FiyatBilgisi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFiyatBilgisi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewFiyatBilgisi;
        private Bunifu.Framework.UI.BunifuFlatButton btnEkle;
        private System.Windows.Forms.ComboBox comboBoxTuru;
        private System.Windows.Forms.Label lblTuru;
        private System.Windows.Forms.TextBox txtBirimFiyat;
        private System.Windows.Forms.Label lblBirimFiyat;
        private System.Windows.Forms.TextBox txtCariKodu;
        private System.Windows.Forms.Label lblCariKodu;
        private System.Windows.Forms.TextBox txtBitisTarihi;
        private System.Windows.Forms.Label lblBitisTarihi;
        private System.Windows.Forms.TextBox txtBaslangicTarihi;
        private System.Windows.Forms.Label lblBaslangicTarihi;
    }
}