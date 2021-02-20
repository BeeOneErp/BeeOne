
namespace BeeOne
{
    partial class frmL_Muhasebe_YevmiyeNo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmL_Muhasebe_YevmiyeNo));
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblMuhasebe = new System.Windows.Forms.Label();
            this.btnClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnMinimize = new Bunifu.Framework.UI.BunifuImageButton();
            this.dateTimePickerSonYevmiye = new System.Windows.Forms.DateTimePicker();
            this.lblSonYevmiyeTarihi = new System.Windows.Forms.Label();
            this.txtSonYevmiyeNo = new System.Windows.Forms.TextBox();
            this.lblSonYevmiyeNo = new System.Windows.Forms.Label();
            this.lblTarihAraligi = new System.Windows.Forms.Label();
            this.dateTimePickerTarihAraligiBasi = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerTarihAraligiSonu = new System.Windows.Forms.DateTimePicker();
            this.txtIlkYevmiyeNo = new System.Windows.Forms.TextBox();
            this.lblIlkYevmiyeMaddeNo = new System.Windows.Forms.Label();
            this.btnVazgec = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnTamam = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.lblMuhasebe);
            this.pnlTop.Controls.Add(this.btnClose);
            this.pnlTop.Controls.Add(this.btnMinimize);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(664, 48);
            this.pnlTop.TabIndex = 4;
            this.pnlTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTop_MouseDown);
            this.pnlTop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlTop_MouseMove);
            this.pnlTop.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlTop_MouseUp);
            // 
            // lblMuhasebe
            // 
            this.lblMuhasebe.AutoSize = true;
            this.lblMuhasebe.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMuhasebe.ForeColor = System.Drawing.Color.DarkKhaki;
            this.lblMuhasebe.Location = new System.Drawing.Point(12, 13);
            this.lblMuhasebe.Name = "lblMuhasebe";
            this.lblMuhasebe.Size = new System.Drawing.Size(396, 21);
            this.lblMuhasebe.TabIndex = 7;
            this.lblMuhasebe.Text = "MUHASEBE > YEVMİYE MADDE NUMARASI VERME\r\n";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageActive = null;
            this.btnClose.Location = new System.Drawing.Point(634, 10);
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
            this.btnMinimize.Location = new System.Drawing.Point(608, 10);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(20, 27);
            this.btnMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimize.TabIndex = 5;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.Zoom = 10;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // dateTimePickerSonYevmiye
            // 
            this.dateTimePickerSonYevmiye.Location = new System.Drawing.Point(171, 73);
            this.dateTimePickerSonYevmiye.Name = "dateTimePickerSonYevmiye";
            this.dateTimePickerSonYevmiye.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerSonYevmiye.TabIndex = 5;
            // 
            // lblSonYevmiyeTarihi
            // 
            this.lblSonYevmiyeTarihi.AutoSize = true;
            this.lblSonYevmiyeTarihi.BackColor = System.Drawing.Color.Transparent;
            this.lblSonYevmiyeTarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSonYevmiyeTarihi.Location = new System.Drawing.Point(33, 77);
            this.lblSonYevmiyeTarihi.Name = "lblSonYevmiyeTarihi";
            this.lblSonYevmiyeTarihi.Size = new System.Drawing.Size(111, 15);
            this.lblSonYevmiyeTarihi.TabIndex = 67;
            this.lblSonYevmiyeTarihi.Text = "Son Yevmiye Tarihi";
            // 
            // txtSonYevmiyeNo
            // 
            this.txtSonYevmiyeNo.Location = new System.Drawing.Point(171, 115);
            this.txtSonYevmiyeNo.Multiline = true;
            this.txtSonYevmiyeNo.Name = "txtSonYevmiyeNo";
            this.txtSonYevmiyeNo.Size = new System.Drawing.Size(200, 21);
            this.txtSonYevmiyeNo.TabIndex = 105;
            // 
            // lblSonYevmiyeNo
            // 
            this.lblSonYevmiyeNo.AutoSize = true;
            this.lblSonYevmiyeNo.BackColor = System.Drawing.Color.Transparent;
            this.lblSonYevmiyeNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSonYevmiyeNo.Location = new System.Drawing.Point(33, 118);
            this.lblSonYevmiyeNo.Name = "lblSonYevmiyeNo";
            this.lblSonYevmiyeNo.Size = new System.Drawing.Size(96, 15);
            this.lblSonYevmiyeNo.TabIndex = 104;
            this.lblSonYevmiyeNo.Text = "Son Yevmiye No";
            // 
            // lblTarihAraligi
            // 
            this.lblTarihAraligi.AutoSize = true;
            this.lblTarihAraligi.BackColor = System.Drawing.Color.Transparent;
            this.lblTarihAraligi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTarihAraligi.Location = new System.Drawing.Point(33, 164);
            this.lblTarihAraligi.Name = "lblTarihAraligi";
            this.lblTarihAraligi.Size = new System.Drawing.Size(72, 15);
            this.lblTarihAraligi.TabIndex = 107;
            this.lblTarihAraligi.Text = "Tarih Aralığı";
            // 
            // dateTimePickerTarihAraligiBasi
            // 
            this.dateTimePickerTarihAraligiBasi.Location = new System.Drawing.Point(171, 160);
            this.dateTimePickerTarihAraligiBasi.Name = "dateTimePickerTarihAraligiBasi";
            this.dateTimePickerTarihAraligiBasi.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerTarihAraligiBasi.TabIndex = 106;
            // 
            // dateTimePickerTarihAraligiSonu
            // 
            this.dateTimePickerTarihAraligiSonu.Location = new System.Drawing.Point(405, 159);
            this.dateTimePickerTarihAraligiSonu.Name = "dateTimePickerTarihAraligiSonu";
            this.dateTimePickerTarihAraligiSonu.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerTarihAraligiSonu.TabIndex = 108;
            // 
            // txtIlkYevmiyeNo
            // 
            this.txtIlkYevmiyeNo.Location = new System.Drawing.Point(171, 206);
            this.txtIlkYevmiyeNo.Multiline = true;
            this.txtIlkYevmiyeNo.Name = "txtIlkYevmiyeNo";
            this.txtIlkYevmiyeNo.Size = new System.Drawing.Size(200, 21);
            this.txtIlkYevmiyeNo.TabIndex = 110;
            // 
            // lblIlkYevmiyeMaddeNo
            // 
            this.lblIlkYevmiyeMaddeNo.AutoSize = true;
            this.lblIlkYevmiyeMaddeNo.BackColor = System.Drawing.Color.Transparent;
            this.lblIlkYevmiyeMaddeNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblIlkYevmiyeMaddeNo.Location = new System.Drawing.Point(33, 209);
            this.lblIlkYevmiyeMaddeNo.Name = "lblIlkYevmiyeMaddeNo";
            this.lblIlkYevmiyeMaddeNo.Size = new System.Drawing.Size(128, 15);
            this.lblIlkYevmiyeMaddeNo.TabIndex = 109;
            this.lblIlkYevmiyeMaddeNo.Text = "İlk Yevmiye Madde No";
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
            this.btnVazgec.Location = new System.Drawing.Point(507, 334);
            this.btnVazgec.Name = "btnVazgec";
            this.btnVazgec.Normalcolor = System.Drawing.Color.DarkKhaki;
            this.btnVazgec.OnHovercolor = System.Drawing.Color.Khaki;
            this.btnVazgec.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnVazgec.selected = false;
            this.btnVazgec.Size = new System.Drawing.Size(98, 31);
            this.btnVazgec.TabIndex = 112;
            this.btnVazgec.Text = "Vazgeç";
            this.btnVazgec.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnVazgec.Textcolor = System.Drawing.Color.Black;
            this.btnVazgec.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnTamam
            // 
            this.btnTamam.Activecolor = System.Drawing.Color.Khaki;
            this.btnTamam.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnTamam.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTamam.BorderRadius = 0;
            this.btnTamam.ButtonText = "Tamam";
            this.btnTamam.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTamam.DisabledColor = System.Drawing.Color.Gray;
            this.btnTamam.Iconcolor = System.Drawing.Color.Transparent;
            this.btnTamam.Iconimage = null;
            this.btnTamam.Iconimage_right = null;
            this.btnTamam.Iconimage_right_Selected = null;
            this.btnTamam.Iconimage_Selected = null;
            this.btnTamam.IconMarginLeft = 0;
            this.btnTamam.IconMarginRight = 0;
            this.btnTamam.IconRightVisible = true;
            this.btnTamam.IconRightZoom = 0D;
            this.btnTamam.IconVisible = true;
            this.btnTamam.IconZoom = 90D;
            this.btnTamam.IsTab = false;
            this.btnTamam.Location = new System.Drawing.Point(401, 334);
            this.btnTamam.Name = "btnTamam";
            this.btnTamam.Normalcolor = System.Drawing.Color.DarkKhaki;
            this.btnTamam.OnHovercolor = System.Drawing.Color.Khaki;
            this.btnTamam.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnTamam.selected = false;
            this.btnTamam.Size = new System.Drawing.Size(98, 31);
            this.btnTamam.TabIndex = 111;
            this.btnTamam.Text = "Tamam";
            this.btnTamam.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnTamam.Textcolor = System.Drawing.Color.Black;
            this.btnTamam.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // frmL_Muhasebe_YevmiyeNo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.BackgroundImage = global::BeeOne.Properties.Resources.background__41_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(664, 408);
            this.Controls.Add(this.btnVazgec);
            this.Controls.Add(this.btnTamam);
            this.Controls.Add(this.txtIlkYevmiyeNo);
            this.Controls.Add(this.lblIlkYevmiyeMaddeNo);
            this.Controls.Add(this.dateTimePickerTarihAraligiSonu);
            this.Controls.Add(this.lblTarihAraligi);
            this.Controls.Add(this.dateTimePickerTarihAraligiBasi);
            this.Controls.Add(this.txtSonYevmiyeNo);
            this.Controls.Add(this.lblSonYevmiyeNo);
            this.Controls.Add(this.lblSonYevmiyeTarihi);
            this.Controls.Add(this.dateTimePickerSonYevmiye);
            this.Controls.Add(this.pnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmL_Muhasebe_YevmiyeNo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Muhasebe > Yevmiye Madde Numarası Verme";
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblMuhasebe;
        private Bunifu.Framework.UI.BunifuImageButton btnClose;
        private Bunifu.Framework.UI.BunifuImageButton btnMinimize;
        private System.Windows.Forms.DateTimePicker dateTimePickerSonYevmiye;
        private System.Windows.Forms.Label lblSonYevmiyeTarihi;
        private System.Windows.Forms.TextBox txtSonYevmiyeNo;
        private System.Windows.Forms.Label lblSonYevmiyeNo;
        private System.Windows.Forms.Label lblTarihAraligi;
        private System.Windows.Forms.DateTimePicker dateTimePickerTarihAraligiBasi;
        private System.Windows.Forms.DateTimePicker dateTimePickerTarihAraligiSonu;
        private System.Windows.Forms.TextBox txtIlkYevmiyeNo;
        private System.Windows.Forms.Label lblIlkYevmiyeMaddeNo;
        private Bunifu.Framework.UI.BunifuFlatButton btnVazgec;
        private Bunifu.Framework.UI.BunifuFlatButton btnTamam;
    }
}