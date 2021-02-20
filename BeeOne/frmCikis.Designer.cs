
namespace BeeOne
{
    partial class frmCikis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCikis));
            this.lblSorgu = new System.Windows.Forms.Label();
            this.btnClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnCik = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnOturumuKapat = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSorgu
            // 
            this.lblSorgu.AutoSize = true;
            this.lblSorgu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSorgu.ForeColor = System.Drawing.Color.DarkKhaki;
            this.lblSorgu.Location = new System.Drawing.Point(32, 42);
            this.lblSorgu.Name = "lblSorgu";
            this.lblSorgu.Size = new System.Drawing.Size(353, 15);
            this.lblSorgu.TabIndex = 0;
            this.lblSorgu.Text = "BeeOne\'dan çıkmak mı yoksa oturumu kapatmak mı istiyorsun?";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageActive = null;
            this.btnClose.Location = new System.Drawing.Point(404, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(21, 18);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 5;
            this.btnClose.TabStop = false;
            this.btnClose.Zoom = 10;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnCik
            // 
            this.btnCik.ActiveBorderThickness = 1;
            this.btnCik.ActiveCornerRadius = 20;
            this.btnCik.ActiveFillColor = System.Drawing.Color.Silver;
            this.btnCik.ActiveForecolor = System.Drawing.Color.Transparent;
            this.btnCik.ActiveLineColor = System.Drawing.Color.Gray;
            this.btnCik.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnCik.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCik.BackgroundImage")));
            this.btnCik.ButtonText = "Çık";
            this.btnCik.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCik.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCik.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCik.IdleBorderThickness = 1;
            this.btnCik.IdleCornerRadius = 20;
            this.btnCik.IdleFillColor = System.Drawing.Color.Gray;
            this.btnCik.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnCik.IdleLineColor = System.Drawing.Color.Gray;
            this.btnCik.Location = new System.Drawing.Point(48, 84);
            this.btnCik.Margin = new System.Windows.Forms.Padding(5);
            this.btnCik.Name = "btnCik";
            this.btnCik.Size = new System.Drawing.Size(105, 41);
            this.btnCik.TabIndex = 20;
            this.btnCik.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCik.Click += new System.EventHandler(this.btnCik_Click);
            // 
            // btnOturumuKapat
            // 
            this.btnOturumuKapat.ActiveBorderThickness = 1;
            this.btnOturumuKapat.ActiveCornerRadius = 20;
            this.btnOturumuKapat.ActiveFillColor = System.Drawing.Color.Silver;
            this.btnOturumuKapat.ActiveForecolor = System.Drawing.Color.Transparent;
            this.btnOturumuKapat.ActiveLineColor = System.Drawing.Color.Gray;
            this.btnOturumuKapat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnOturumuKapat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnOturumuKapat.BackgroundImage")));
            this.btnOturumuKapat.ButtonText = "Oturumu Kapat";
            this.btnOturumuKapat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOturumuKapat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOturumuKapat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnOturumuKapat.IdleBorderThickness = 1;
            this.btnOturumuKapat.IdleCornerRadius = 20;
            this.btnOturumuKapat.IdleFillColor = System.Drawing.Color.Gray;
            this.btnOturumuKapat.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnOturumuKapat.IdleLineColor = System.Drawing.Color.Gray;
            this.btnOturumuKapat.Location = new System.Drawing.Point(175, 84);
            this.btnOturumuKapat.Margin = new System.Windows.Forms.Padding(5);
            this.btnOturumuKapat.Name = "btnOturumuKapat";
            this.btnOturumuKapat.Size = new System.Drawing.Size(210, 41);
            this.btnOturumuKapat.TabIndex = 21;
            this.btnOturumuKapat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnOturumuKapat.Click += new System.EventHandler(this.btnOturumuKapat_Click);
            // 
            // frmCikis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(427, 152);
            this.Controls.Add(this.btnOturumuKapat);
            this.Controls.Add(this.btnCik);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblSorgu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCikis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCikis";
            this.Load += new System.EventHandler(this.frmCikis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSorgu;
        private Bunifu.Framework.UI.BunifuImageButton btnClose;
        private Bunifu.Framework.UI.BunifuThinButton2 btnCik;
        private Bunifu.Framework.UI.BunifuThinButton2 btnOturumuKapat;
    }
}