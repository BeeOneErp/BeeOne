
namespace BeeOne
{
    partial class frmL_Fatura_SatinAlmaFaturalari
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmL_Fatura_SatinAlmaFaturalari));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblFatura = new System.Windows.Forms.Label();
            this.btnClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnMinimize = new Bunifu.Framework.UI.BunifuImageButton();
            this.dataGridViewSatinAlmaFaturalari = new System.Windows.Forms.DataGridView();
            this.btnEkle = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnSil = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnDegistir = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnMuhasebelestir = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnIptal = new Bunifu.Framework.UI.BunifuFlatButton();
            this.dropdownFTTuru = new Bunifu.Framework.UI.BunifuDropdown();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSatinAlmaFaturalari)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.lblFatura);
            this.pnlTop.Controls.Add(this.btnClose);
            this.pnlTop.Controls.Add(this.btnMinimize);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1307, 48);
            this.pnlTop.TabIndex = 2;
            this.pnlTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTop_MouseDown);
            this.pnlTop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlTop_MouseMove);
            this.pnlTop.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlTop_MouseUp);
            // 
            // lblFatura
            // 
            this.lblFatura.AutoSize = true;
            this.lblFatura.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFatura.ForeColor = System.Drawing.Color.DarkKhaki;
            this.lblFatura.Location = new System.Drawing.Point(12, 13);
            this.lblFatura.Name = "lblFatura";
            this.lblFatura.Size = new System.Drawing.Size(280, 21);
            this.lblFatura.TabIndex = 7;
            this.lblFatura.Text = "FATURA > SATIN ALMA FATURALARI";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageActive = null;
            this.btnClose.Location = new System.Drawing.Point(1277, 10);
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
            this.btnMinimize.Location = new System.Drawing.Point(1251, 10);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(20, 27);
            this.btnMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimize.TabIndex = 5;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.Zoom = 10;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // dataGridViewSatinAlmaFaturalari
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewSatinAlmaFaturalari.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewSatinAlmaFaturalari.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewSatinAlmaFaturalari.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewSatinAlmaFaturalari.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(0, 6, 0, 6);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewSatinAlmaFaturalari.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewSatinAlmaFaturalari.Location = new System.Drawing.Point(69, 153);
            this.dataGridViewSatinAlmaFaturalari.Name = "dataGridViewSatinAlmaFaturalari";
            this.dataGridViewSatinAlmaFaturalari.ReadOnly = true;
            this.dataGridViewSatinAlmaFaturalari.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.dataGridViewSatinAlmaFaturalari.RowTemplate.Height = 40;
            this.dataGridViewSatinAlmaFaturalari.Size = new System.Drawing.Size(1169, 761);
            this.dataGridViewSatinAlmaFaturalari.TabIndex = 16;
            // 
            // btnEkle
            // 
            this.btnEkle.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnEkle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEkle.BorderRadius = 0;
            this.btnEkle.ButtonText = "Ekle";
            this.btnEkle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEkle.DisabledColor = System.Drawing.Color.Gray;
            this.btnEkle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
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
            this.btnEkle.Location = new System.Drawing.Point(331, 83);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnEkle.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnEkle.OnHoverTextColor = System.Drawing.Color.Khaki;
            this.btnEkle.selected = false;
            this.btnEkle.Size = new System.Drawing.Size(97, 39);
            this.btnEkle.TabIndex = 20;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEkle.Textcolor = System.Drawing.Color.White;
            this.btnEkle.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnSil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSil.BorderRadius = 0;
            this.btnSil.ButtonText = "Sil";
            this.btnSil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSil.DisabledColor = System.Drawing.Color.Gray;
            this.btnSil.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnSil.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSil.Iconimage = null;
            this.btnSil.Iconimage_right = null;
            this.btnSil.Iconimage_right_Selected = null;
            this.btnSil.Iconimage_Selected = null;
            this.btnSil.IconMarginLeft = 0;
            this.btnSil.IconMarginRight = 0;
            this.btnSil.IconRightVisible = true;
            this.btnSil.IconRightZoom = 0D;
            this.btnSil.IconVisible = true;
            this.btnSil.IconZoom = 90D;
            this.btnSil.IsTab = false;
            this.btnSil.Location = new System.Drawing.Point(603, 83);
            this.btnSil.Name = "btnSil";
            this.btnSil.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnSil.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnSil.OnHoverTextColor = System.Drawing.Color.Khaki;
            this.btnSil.selected = false;
            this.btnSil.Size = new System.Drawing.Size(97, 39);
            this.btnSil.TabIndex = 26;
            this.btnSil.Text = "Sil";
            this.btnSil.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSil.Textcolor = System.Drawing.Color.White;
            this.btnSil.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnDegistir
            // 
            this.btnDegistir.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnDegistir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnDegistir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDegistir.BorderRadius = 0;
            this.btnDegistir.ButtonText = "Değiştir";
            this.btnDegistir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDegistir.DisabledColor = System.Drawing.Color.Gray;
            this.btnDegistir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnDegistir.Iconcolor = System.Drawing.Color.Transparent;
            this.btnDegistir.Iconimage = null;
            this.btnDegistir.Iconimage_right = null;
            this.btnDegistir.Iconimage_right_Selected = null;
            this.btnDegistir.Iconimage_Selected = null;
            this.btnDegistir.IconMarginLeft = 0;
            this.btnDegistir.IconMarginRight = 0;
            this.btnDegistir.IconRightVisible = true;
            this.btnDegistir.IconRightZoom = 0D;
            this.btnDegistir.IconVisible = true;
            this.btnDegistir.IconZoom = 90D;
            this.btnDegistir.IsTab = false;
            this.btnDegistir.Location = new System.Drawing.Point(468, 83);
            this.btnDegistir.Name = "btnDegistir";
            this.btnDegistir.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnDegistir.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnDegistir.OnHoverTextColor = System.Drawing.Color.Khaki;
            this.btnDegistir.selected = false;
            this.btnDegistir.Size = new System.Drawing.Size(97, 39);
            this.btnDegistir.TabIndex = 25;
            this.btnDegistir.Text = "Değiştir";
            this.btnDegistir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDegistir.Textcolor = System.Drawing.Color.White;
            this.btnDegistir.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnMuhasebelestir
            // 
            this.btnMuhasebelestir.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnMuhasebelestir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnMuhasebelestir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMuhasebelestir.BorderRadius = 0;
            this.btnMuhasebelestir.ButtonText = "Muhasebeleştir";
            this.btnMuhasebelestir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMuhasebelestir.DisabledColor = System.Drawing.Color.Gray;
            this.btnMuhasebelestir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnMuhasebelestir.Iconcolor = System.Drawing.Color.Transparent;
            this.btnMuhasebelestir.Iconimage = null;
            this.btnMuhasebelestir.Iconimage_right = null;
            this.btnMuhasebelestir.Iconimage_right_Selected = null;
            this.btnMuhasebelestir.Iconimage_Selected = null;
            this.btnMuhasebelestir.IconMarginLeft = 0;
            this.btnMuhasebelestir.IconMarginRight = 0;
            this.btnMuhasebelestir.IconRightVisible = true;
            this.btnMuhasebelestir.IconRightZoom = 0D;
            this.btnMuhasebelestir.IconVisible = true;
            this.btnMuhasebelestir.IconZoom = 90D;
            this.btnMuhasebelestir.IsTab = false;
            this.btnMuhasebelestir.Location = new System.Drawing.Point(878, 83);
            this.btnMuhasebelestir.Name = "btnMuhasebelestir";
            this.btnMuhasebelestir.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnMuhasebelestir.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnMuhasebelestir.OnHoverTextColor = System.Drawing.Color.Khaki;
            this.btnMuhasebelestir.selected = false;
            this.btnMuhasebelestir.Size = new System.Drawing.Size(118, 39);
            this.btnMuhasebelestir.TabIndex = 34;
            this.btnMuhasebelestir.Text = "Muhasebeleştir";
            this.btnMuhasebelestir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnMuhasebelestir.Textcolor = System.Drawing.Color.White;
            this.btnMuhasebelestir.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnIptal
            // 
            this.btnIptal.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnIptal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnIptal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnIptal.BorderRadius = 0;
            this.btnIptal.ButtonText = "İptal Et";
            this.btnIptal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIptal.DisabledColor = System.Drawing.Color.Gray;
            this.btnIptal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnIptal.Iconcolor = System.Drawing.Color.Transparent;
            this.btnIptal.Iconimage = null;
            this.btnIptal.Iconimage_right = null;
            this.btnIptal.Iconimage_right_Selected = null;
            this.btnIptal.Iconimage_Selected = null;
            this.btnIptal.IconMarginLeft = 0;
            this.btnIptal.IconMarginRight = 0;
            this.btnIptal.IconRightVisible = true;
            this.btnIptal.IconRightZoom = 0D;
            this.btnIptal.IconVisible = true;
            this.btnIptal.IconZoom = 90D;
            this.btnIptal.IsTab = false;
            this.btnIptal.Location = new System.Drawing.Point(748, 83);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnIptal.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnIptal.OnHoverTextColor = System.Drawing.Color.Khaki;
            this.btnIptal.selected = false;
            this.btnIptal.Size = new System.Drawing.Size(97, 39);
            this.btnIptal.TabIndex = 33;
            this.btnIptal.Text = "İptal Et";
            this.btnIptal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnIptal.Textcolor = System.Drawing.Color.White;
            this.btnIptal.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // dropdownFTTuru
            // 
            this.dropdownFTTuru.BackColor = System.Drawing.Color.Transparent;
            this.dropdownFTTuru.BorderRadius = 3;
            this.dropdownFTTuru.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.dropdownFTTuru.ForeColor = System.Drawing.Color.White;
            this.dropdownFTTuru.Items = new string[] {
        "(1) Satınalma Faturası",
        "(4) Alınan Hizmet Faturası",
        "(6) Satınalma İade Faturası",
        "(13) Alınan Fiyat Farkı Faturası"};
            this.dropdownFTTuru.Location = new System.Drawing.Point(69, 83);
            this.dropdownFTTuru.Name = "dropdownFTTuru";
            this.dropdownFTTuru.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.dropdownFTTuru.onHoverColor = System.Drawing.Color.Khaki;
            this.dropdownFTTuru.selectedIndex = 0;
            this.dropdownFTTuru.Size = new System.Drawing.Size(223, 39);
            this.dropdownFTTuru.TabIndex = 35;
            // 
            // frmL_Fatura_SatinAlmaFaturalari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.BackgroundImage = global::BeeOne.Properties.Resources.background__41_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1307, 943);
            this.Controls.Add(this.dropdownFTTuru);
            this.Controls.Add(this.btnMuhasebelestir);
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnDegistir);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.dataGridViewSatinAlmaFaturalari);
            this.Controls.Add(this.pnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmL_Fatura_SatinAlmaFaturalari";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fatura > Satın Alma Faturaları";
            this.Load += new System.EventHandler(this.frmL_Fatura_SatinAlmaFaturalari_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSatinAlmaFaturalari)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblFatura;
        private Bunifu.Framework.UI.BunifuImageButton btnClose;
        private Bunifu.Framework.UI.BunifuImageButton btnMinimize;
        private System.Windows.Forms.DataGridView dataGridViewSatinAlmaFaturalari;
        private Bunifu.Framework.UI.BunifuFlatButton btnEkle;
        private Bunifu.Framework.UI.BunifuFlatButton btnSil;
        private Bunifu.Framework.UI.BunifuFlatButton btnDegistir;
        private Bunifu.Framework.UI.BunifuFlatButton btnMuhasebelestir;
        private Bunifu.Framework.UI.BunifuFlatButton btnIptal;
        private Bunifu.Framework.UI.BunifuDropdown dropdownFTTuru;
    }
}