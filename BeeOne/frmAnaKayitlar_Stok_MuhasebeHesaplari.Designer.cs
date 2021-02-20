
namespace BeeOne
{
    partial class frmAnaKayitlar_Stok_MuhasebeHesaplari
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewMuhasebeHesaplari = new System.Windows.Forms.DataGridView();
            this.Baglantı_turu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Muh_Kodu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Proje_kodu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblProje = new System.Windows.Forms.Label();
            this.btnMuhHes = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnKaydet = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMuhasebeHesaplari)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewMuhasebeHesaplari
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewMuhasebeHesaplari.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewMuhasebeHesaplari.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewMuhasebeHesaplari.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewMuhasebeHesaplari.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMuhasebeHesaplari.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Baglantı_turu,
            this.Muh_Kodu,
            this.Proje_kodu});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.Padding = new System.Windows.Forms.Padding(0, 6, 0, 6);
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewMuhasebeHesaplari.DefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridViewMuhasebeHesaplari.Location = new System.Drawing.Point(12, 9);
            this.dataGridViewMuhasebeHesaplari.Name = "dataGridViewMuhasebeHesaplari";
            this.dataGridViewMuhasebeHesaplari.ReadOnly = true;
            this.dataGridViewMuhasebeHesaplari.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.dataGridViewMuhasebeHesaplari.RowTemplate.Height = 40;
            this.dataGridViewMuhasebeHesaplari.Size = new System.Drawing.Size(762, 275);
            this.dataGridViewMuhasebeHesaplari.TabIndex = 90;
            // 
            // Baglantı_turu
            // 
            this.Baglantı_turu.HeaderText = "Bağlantı Türü";
            this.Baglantı_turu.Name = "Baglantı_turu";
            this.Baglantı_turu.ReadOnly = true;
            // 
            // Muh_Kodu
            // 
            this.Muh_Kodu.HeaderText = "Muhasebe Hesap Kodu";
            this.Muh_Kodu.Name = "Muh_Kodu";
            this.Muh_Kodu.ReadOnly = true;
            // 
            // Proje_kodu
            // 
            this.Proje_kodu.HeaderText = "Proje Kodu";
            this.Proje_kodu.Name = "Proje_kodu";
            this.Proje_kodu.ReadOnly = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(789, 58);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(143, 21);
            this.comboBox1.TabIndex = 91;
            // 
            // lblProje
            // 
            this.lblProje.AutoSize = true;
            this.lblProje.BackColor = System.Drawing.Color.Transparent;
            this.lblProje.Location = new System.Drawing.Point(789, 39);
            this.lblProje.Name = "lblProje";
            this.lblProje.Size = new System.Drawing.Size(59, 13);
            this.lblProje.TabIndex = 92;
            this.lblProje.Text = "Proje Kodu";
            // 
            // btnMuhHes
            // 
            this.btnMuhHes.Activecolor = System.Drawing.Color.Khaki;
            this.btnMuhHes.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnMuhHes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMuhHes.BorderRadius = 0;
            this.btnMuhHes.ButtonText = "Muhasebe Hesaplarını Görüntüle";
            this.btnMuhHes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMuhHes.DisabledColor = System.Drawing.Color.Gray;
            this.btnMuhHes.Iconcolor = System.Drawing.Color.Transparent;
            this.btnMuhHes.Iconimage = null;
            this.btnMuhHes.Iconimage_right = null;
            this.btnMuhHes.Iconimage_right_Selected = null;
            this.btnMuhHes.Iconimage_Selected = null;
            this.btnMuhHes.IconMarginLeft = 0;
            this.btnMuhHes.IconMarginRight = 0;
            this.btnMuhHes.IconRightVisible = true;
            this.btnMuhHes.IconRightZoom = 0D;
            this.btnMuhHes.IconVisible = true;
            this.btnMuhHes.IconZoom = 90D;
            this.btnMuhHes.IsTab = false;
            this.btnMuhHes.Location = new System.Drawing.Point(789, 125);
            this.btnMuhHes.Name = "btnMuhHes";
            this.btnMuhHes.Normalcolor = System.Drawing.Color.DarkKhaki;
            this.btnMuhHes.OnHovercolor = System.Drawing.Color.Khaki;
            this.btnMuhHes.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnMuhHes.selected = false;
            this.btnMuhHes.Size = new System.Drawing.Size(143, 79);
            this.btnMuhHes.TabIndex = 93;
            this.btnMuhHes.Text = "Muhasebe Hesaplarını Görüntüle";
            this.btnMuhHes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnMuhHes.Textcolor = System.Drawing.Color.Black;
            this.btnMuhHes.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMuhHes.Click += new System.EventHandler(this.btnMuhHes_Click);
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
            this.btnKaydet.Location = new System.Drawing.Point(813, 253);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Normalcolor = System.Drawing.Color.DarkKhaki;
            this.btnKaydet.OnHovercolor = System.Drawing.Color.Khaki;
            this.btnKaydet.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnKaydet.selected = false;
            this.btnKaydet.Size = new System.Drawing.Size(98, 31);
            this.btnKaydet.TabIndex = 94;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnKaydet.Textcolor = System.Drawing.Color.Black;
            this.btnKaydet.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // frmAnaKayitlar_Stok_MuhasebeHesaplari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BeeOne.Properties.Resources.background__41_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(944, 296);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.btnMuhHes);
            this.Controls.Add(this.lblProje);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGridViewMuhasebeHesaplari);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAnaKayitlar_Stok_MuhasebeHesaplari";
            this.Text = "Ana Kayıtlar > Stok > Muhasebe Hesapları";
            this.Load += new System.EventHandler(this.frmAnaKayitlar_Stok_MuhasebeHesaplari_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMuhasebeHesaplari)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewMuhasebeHesaplari;
        private System.Windows.Forms.DataGridViewTextBoxColumn Baglantı_turu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Muh_Kodu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Proje_kodu;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblProje;
        private Bunifu.Framework.UI.BunifuFlatButton btnMuhHes;
        private Bunifu.Framework.UI.BunifuFlatButton btnKaydet;
    }
}