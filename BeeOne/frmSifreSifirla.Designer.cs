
namespace BeeOne
{
    partial class frmSifreSifirla
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSifreSifirla));
            this.pnlTop = new System.Windows.Forms.Panel();
            this.btnCikis = new Bunifu.Framework.UI.BunifuImageButton();
            this.picBeeOne = new System.Windows.Forms.PictureBox();
            this.pnlSifreSifirla = new System.Windows.Forms.Panel();
            this.lblMail = new System.Windows.Forms.Label();
            this.txtMailAdresi = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.lblAciklama = new System.Windows.Forms.Label();
            this.btnDevam = new Bunifu.Framework.UI.BunifuThinButton2();
            this.lblSifreyiSifirlaCizgi = new System.Windows.Forms.Label();
            this.lblSifreyiSifirla = new System.Windows.Forms.Label();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCikis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBeeOne)).BeginInit();
            this.pnlSifreSifirla.SuspendLayout();
            this.SuspendLayout();
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
            this.pnlTop.TabIndex = 0;
            this.pnlTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTop_MouseDown);
            this.pnlTop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlTop_MouseMove);
            this.pnlTop.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlTop_MouseUp);
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
            // pnlSifreSifirla
            // 
            this.pnlSifreSifirla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.pnlSifreSifirla.Controls.Add(this.lblMail);
            this.pnlSifreSifirla.Controls.Add(this.txtMailAdresi);
            this.pnlSifreSifirla.Controls.Add(this.lblAciklama);
            this.pnlSifreSifirla.Controls.Add(this.btnDevam);
            this.pnlSifreSifirla.Controls.Add(this.lblSifreyiSifirlaCizgi);
            this.pnlSifreSifirla.Controls.Add(this.lblSifreyiSifirla);
            this.pnlSifreSifirla.Location = new System.Drawing.Point(128, 111);
            this.pnlSifreSifirla.Name = "pnlSifreSifirla";
            this.pnlSifreSifirla.Size = new System.Drawing.Size(471, 489);
            this.pnlSifreSifirla.TabIndex = 2;
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMail.ForeColor = System.Drawing.Color.DarkKhaki;
            this.lblMail.Location = new System.Drawing.Point(36, 162);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(61, 19);
            this.lblMail.TabIndex = 13;
            this.lblMail.Text = "E-posta";
            // 
            // txtMailAdresi
            // 
            this.txtMailAdresi.BorderColorFocused = System.Drawing.Color.Khaki;
            this.txtMailAdresi.BorderColorIdle = System.Drawing.Color.Gray;
            this.txtMailAdresi.BorderColorMouseHover = System.Drawing.Color.Khaki;
            this.txtMailAdresi.BorderThickness = 3;
            this.txtMailAdresi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMailAdresi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtMailAdresi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtMailAdresi.isPassword = false;
            this.txtMailAdresi.Location = new System.Drawing.Point(35, 192);
            this.txtMailAdresi.Margin = new System.Windows.Forms.Padding(4);
            this.txtMailAdresi.Name = "txtMailAdresi";
            this.txtMailAdresi.Size = new System.Drawing.Size(370, 44);
            this.txtMailAdresi.TabIndex = 12;
            this.txtMailAdresi.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lblAciklama
            // 
            this.lblAciklama.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAciklama.ForeColor = System.Drawing.Color.DarkKhaki;
            this.lblAciklama.Location = new System.Drawing.Point(37, 87);
            this.lblAciklama.Name = "lblAciklama";
            this.lblAciklama.Size = new System.Drawing.Size(392, 34);
            this.lblAciklama.TabIndex = 16;
            this.lblAciklama.Text = "Şifre sıfırlama bağlantısının gönderilmesi için lütfen e-posta adresinizi giriniz" +
    ".";
            // 
            // btnDevam
            // 
            this.btnDevam.ActiveBorderThickness = 1;
            this.btnDevam.ActiveCornerRadius = 20;
            this.btnDevam.ActiveFillColor = System.Drawing.Color.Khaki;
            this.btnDevam.ActiveForecolor = System.Drawing.Color.Black;
            this.btnDevam.ActiveLineColor = System.Drawing.Color.Gray;
            this.btnDevam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnDevam.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDevam.BackgroundImage")));
            this.btnDevam.ButtonText = "Devam";
            this.btnDevam.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDevam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDevam.ForeColor = System.Drawing.Color.White;
            this.btnDevam.IdleBorderThickness = 1;
            this.btnDevam.IdleCornerRadius = 20;
            this.btnDevam.IdleFillColor = System.Drawing.Color.Gray;
            this.btnDevam.IdleForecolor = System.Drawing.Color.White;
            this.btnDevam.IdleLineColor = System.Drawing.Color.Khaki;
            this.btnDevam.Location = new System.Drawing.Point(133, 317);
            this.btnDevam.Margin = new System.Windows.Forms.Padding(5);
            this.btnDevam.Name = "btnDevam";
            this.btnDevam.Size = new System.Drawing.Size(181, 41);
            this.btnDevam.TabIndex = 5;
            this.btnDevam.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDevam.Click += new System.EventHandler(this.btnDevam_Click);
            // 
            // lblSifreyiSifirlaCizgi
            // 
            this.lblSifreyiSifirlaCizgi.BackColor = System.Drawing.Color.Gray;
            this.lblSifreyiSifirlaCizgi.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSifreyiSifirlaCizgi.ForeColor = System.Drawing.Color.White;
            this.lblSifreyiSifirlaCizgi.Location = new System.Drawing.Point(29, 61);
            this.lblSifreyiSifirlaCizgi.Name = "lblSifreyiSifirlaCizgi";
            this.lblSifreyiSifirlaCizgi.Size = new System.Drawing.Size(400, 1);
            this.lblSifreyiSifirlaCizgi.TabIndex = 1;
            // 
            // lblSifreyiSifirla
            // 
            this.lblSifreyiSifirla.AutoSize = true;
            this.lblSifreyiSifirla.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSifreyiSifirla.ForeColor = System.Drawing.Color.White;
            this.lblSifreyiSifirla.Location = new System.Drawing.Point(29, 21);
            this.lblSifreyiSifirla.Name = "lblSifreyiSifirla";
            this.lblSifreyiSifirla.Size = new System.Drawing.Size(170, 25);
            this.lblSifreyiSifirla.TabIndex = 0;
            this.lblSifreyiSifirla.Text = "ŞİFREYİ SIFIRLA";
            // 
            // frmSifreSifirla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(728, 694);
            this.Controls.Add(this.pnlSifreSifirla);
            this.Controls.Add(this.pnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSifreSifirla";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BeeOne";
            this.pnlTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnCikis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBeeOne)).EndInit();
            this.pnlSifreSifirla.ResumeLayout(false);
            this.pnlSifreSifirla.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.PictureBox picBeeOne;
        private Bunifu.Framework.UI.BunifuImageButton btnCikis;
        private System.Windows.Forms.Panel pnlSifreSifirla;
        private Bunifu.Framework.UI.BunifuThinButton2 btnDevam;
        private System.Windows.Forms.Label lblSifreyiSifirlaCizgi;
        private System.Windows.Forms.Label lblSifreyiSifirla;
        private System.Windows.Forms.Label lblAciklama;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtMailAdresi;
        private System.Windows.Forms.Label lblMail;
    }
}