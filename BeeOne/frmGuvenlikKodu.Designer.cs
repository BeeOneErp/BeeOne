
namespace BeeOne
{
    partial class frmGuvenlikKodu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGuvenlikKodu));
            this.pnlSifreyiSifirla = new System.Windows.Forms.Panel();
            this.btnOnayla = new Bunifu.Framework.UI.BunifuThinButton2();
            this.lblGuvenlikKodu = new System.Windows.Forms.Label();
            this.txtGuvenlikKodu = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.lblAciklama = new System.Windows.Forms.Label();
            this.lblSifreyiSifirlaCizgi = new System.Windows.Forms.Label();
            this.lblSifreyiSifirla = new System.Windows.Forms.Label();
            this.btnCikis = new Bunifu.Framework.UI.BunifuImageButton();
            this.picBeeOne = new System.Windows.Forms.PictureBox();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.pnlSifreyiSifirla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCikis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBeeOne)).BeginInit();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSifreyiSifirla
            // 
            this.pnlSifreyiSifirla.Controls.Add(this.btnOnayla);
            this.pnlSifreyiSifirla.Controls.Add(this.lblGuvenlikKodu);
            this.pnlSifreyiSifirla.Controls.Add(this.txtGuvenlikKodu);
            this.pnlSifreyiSifirla.Controls.Add(this.lblAciklama);
            this.pnlSifreyiSifirla.Controls.Add(this.lblSifreyiSifirlaCizgi);
            this.pnlSifreyiSifirla.Controls.Add(this.lblSifreyiSifirla);
            this.pnlSifreyiSifirla.Location = new System.Drawing.Point(128, 111);
            this.pnlSifreyiSifirla.Name = "pnlSifreyiSifirla";
            this.pnlSifreyiSifirla.Size = new System.Drawing.Size(471, 489);
            this.pnlSifreyiSifirla.TabIndex = 0;
            // 
            // btnOnayla
            // 
            this.btnOnayla.ActiveBorderThickness = 1;
            this.btnOnayla.ActiveCornerRadius = 20;
            this.btnOnayla.ActiveFillColor = System.Drawing.Color.Khaki;
            this.btnOnayla.ActiveForecolor = System.Drawing.Color.Black;
            this.btnOnayla.ActiveLineColor = System.Drawing.Color.Gray;
            this.btnOnayla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnOnayla.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnOnayla.BackgroundImage")));
            this.btnOnayla.ButtonText = "Kodu Onayla";
            this.btnOnayla.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOnayla.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOnayla.ForeColor = System.Drawing.Color.White;
            this.btnOnayla.IdleBorderThickness = 1;
            this.btnOnayla.IdleCornerRadius = 20;
            this.btnOnayla.IdleFillColor = System.Drawing.Color.Gray;
            this.btnOnayla.IdleForecolor = System.Drawing.Color.White;
            this.btnOnayla.IdleLineColor = System.Drawing.Color.Khaki;
            this.btnOnayla.Location = new System.Drawing.Point(154, 314);
            this.btnOnayla.Margin = new System.Windows.Forms.Padding(5);
            this.btnOnayla.Name = "btnOnayla";
            this.btnOnayla.Size = new System.Drawing.Size(181, 41);
            this.btnOnayla.TabIndex = 19;
            this.btnOnayla.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnOnayla.Click += new System.EventHandler(this.btnOnayla_Click);
            // 
            // lblGuvenlikKodu
            // 
            this.lblGuvenlikKodu.AutoSize = true;
            this.lblGuvenlikKodu.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGuvenlikKodu.ForeColor = System.Drawing.Color.DarkKhaki;
            this.lblGuvenlikKodu.Location = new System.Drawing.Point(36, 162);
            this.lblGuvenlikKodu.Name = "lblGuvenlikKodu";
            this.lblGuvenlikKodu.Size = new System.Drawing.Size(110, 19);
            this.lblGuvenlikKodu.TabIndex = 18;
            this.lblGuvenlikKodu.Text = "Güvenlik Kodu";
            // 
            // txtGuvenlikKodu
            // 
            this.txtGuvenlikKodu.BorderColorFocused = System.Drawing.Color.Khaki;
            this.txtGuvenlikKodu.BorderColorIdle = System.Drawing.Color.Gray;
            this.txtGuvenlikKodu.BorderColorMouseHover = System.Drawing.Color.Khaki;
            this.txtGuvenlikKodu.BorderThickness = 3;
            this.txtGuvenlikKodu.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGuvenlikKodu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtGuvenlikKodu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtGuvenlikKodu.isPassword = false;
            this.txtGuvenlikKodu.Location = new System.Drawing.Point(35, 192);
            this.txtGuvenlikKodu.Margin = new System.Windows.Forms.Padding(4);
            this.txtGuvenlikKodu.Name = "txtGuvenlikKodu";
            this.txtGuvenlikKodu.Size = new System.Drawing.Size(394, 44);
            this.txtGuvenlikKodu.TabIndex = 17;
            this.txtGuvenlikKodu.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lblAciklama
            // 
            this.lblAciklama.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAciklama.ForeColor = System.Drawing.Color.DarkKhaki;
            this.lblAciklama.Location = new System.Drawing.Point(36, 83);
            this.lblAciklama.Name = "lblAciklama";
            this.lblAciklama.Size = new System.Drawing.Size(393, 34);
            this.lblAciklama.TabIndex = 16;
            this.lblAciklama.Text = "Güvenlik kodunu içeren bir e-posta gönderilmiştir. \r\nLütfen yeni şifrenizi belirl" +
    "emek için bu kodu giriniz.";
            // 
            // lblSifreyiSifirlaCizgi
            // 
            this.lblSifreyiSifirlaCizgi.BackColor = System.Drawing.Color.Gray;
            this.lblSifreyiSifirlaCizgi.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSifreyiSifirlaCizgi.ForeColor = System.Drawing.Color.White;
            this.lblSifreyiSifirlaCizgi.Location = new System.Drawing.Point(29, 61);
            this.lblSifreyiSifirlaCizgi.Name = "lblSifreyiSifirlaCizgi";
            this.lblSifreyiSifirlaCizgi.Size = new System.Drawing.Size(400, 1);
            this.lblSifreyiSifirlaCizgi.TabIndex = 15;
            // 
            // lblSifreyiSifirla
            // 
            this.lblSifreyiSifirla.AutoSize = true;
            this.lblSifreyiSifirla.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSifreyiSifirla.ForeColor = System.Drawing.Color.White;
            this.lblSifreyiSifirla.Location = new System.Drawing.Point(29, 21);
            this.lblSifreyiSifirla.Name = "lblSifreyiSifirla";
            this.lblSifreyiSifirla.Size = new System.Drawing.Size(170, 25);
            this.lblSifreyiSifirla.TabIndex = 14;
            this.lblSifreyiSifirla.Text = "ŞİFREYİ SIFIRLA";
            // 
            // btnCikis
            // 
            this.btnCikis.BackColor = System.Drawing.Color.Transparent;
            this.btnCikis.Image = ((System.Drawing.Image)(resources.GetObject("btnCikis.Image")));
            this.btnCikis.ImageActive = null;
            this.btnCikis.Location = new System.Drawing.Point(688, 16);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(30, 30);
            this.btnCikis.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCikis.TabIndex = 2;
            this.btnCikis.TabStop = false;
            this.btnCikis.Zoom = 10;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // picBeeOne
            // 
            this.picBeeOne.BackColor = System.Drawing.Color.Transparent;
            this.picBeeOne.Dock = System.Windows.Forms.DockStyle.Left;
            this.picBeeOne.Image = ((System.Drawing.Image)(resources.GetObject("picBeeOne.Image")));
            this.picBeeOne.Location = new System.Drawing.Point(0, 0);
            this.picBeeOne.Name = "picBeeOne";
            this.picBeeOne.Size = new System.Drawing.Size(82, 65);
            this.picBeeOne.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBeeOne.TabIndex = 1;
            this.picBeeOne.TabStop = false;
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.pnlTop.Controls.Add(this.btnCikis);
            this.pnlTop.Controls.Add(this.picBeeOne);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(728, 65);
            this.pnlTop.TabIndex = 1;
            this.pnlTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTop_MouseDown);
            this.pnlTop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlTop_MouseMove);
            this.pnlTop.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlTop_MouseUp);
            // 
            // frmGuvenlikKodu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(728, 694);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.pnlSifreyiSifirla);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmGuvenlikKodu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BeeOne";
            this.pnlSifreyiSifirla.ResumeLayout(false);
            this.pnlSifreyiSifirla.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCikis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBeeOne)).EndInit();
            this.pnlTop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSifreyiSifirla;
        private System.Windows.Forms.Label lblGuvenlikKodu;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtGuvenlikKodu;
        private System.Windows.Forms.Label lblAciklama;
        private System.Windows.Forms.Label lblSifreyiSifirlaCizgi;
        private System.Windows.Forms.Label lblSifreyiSifirla;
        private Bunifu.Framework.UI.BunifuImageButton btnCikis;
        private System.Windows.Forms.PictureBox picBeeOne;
        private System.Windows.Forms.Panel pnlTop;
        private Bunifu.Framework.UI.BunifuThinButton2 btnOnayla;
    }
}