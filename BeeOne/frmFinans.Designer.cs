
namespace BeeOne
{
    partial class frmFinans
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFinans));
            this.pnlTop = new System.Windows.Forms.Panel();
            this.btnClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnMinimize = new Bunifu.Framework.UI.BunifuImageButton();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnCekSenet = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnBankaIslem = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnKasaIslem = new Bunifu.Framework.UI.BunifuTileButton();
            this.lblFinans = new System.Windows.Forms.Label();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).BeginInit();
            this.pnlMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.btnClose);
            this.pnlTop.Controls.Add(this.btnMinimize);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(656, 65);
            this.pnlTop.TabIndex = 0;
            this.pnlTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTop_MouseDown);
            this.pnlTop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlTop_MouseMove);
            this.pnlTop.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlTop_MouseUp);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageActive = null;
            this.btnClose.Location = new System.Drawing.Point(614, 17);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 30);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 12;
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
            this.btnMinimize.Location = new System.Drawing.Point(577, 17);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(30, 30);
            this.btnMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimize.TabIndex = 11;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.Zoom = 10;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.Transparent;
            this.pnlMenu.Controls.Add(this.btnCekSenet);
            this.pnlMenu.Controls.Add(this.btnBankaIslem);
            this.pnlMenu.Controls.Add(this.btnKasaIslem);
            this.pnlMenu.Location = new System.Drawing.Point(66, 175);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(512, 171);
            this.pnlMenu.TabIndex = 1;
            // 
            // btnCekSenet
            // 
            this.btnCekSenet.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCekSenet.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnCekSenet.color = System.Drawing.Color.DarkKhaki;
            this.btnCekSenet.colorActive = System.Drawing.Color.Khaki;
            this.btnCekSenet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCekSenet.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCekSenet.ForeColor = System.Drawing.Color.Black;
            this.btnCekSenet.Image = ((System.Drawing.Image)(resources.GetObject("btnCekSenet.Image")));
            this.btnCekSenet.ImagePosition = 14;
            this.btnCekSenet.ImageZoom = 50;
            this.btnCekSenet.LabelPosition = 29;
            this.btnCekSenet.LabelText = "Çek Senet Bordroları";
            this.btnCekSenet.Location = new System.Drawing.Point(346, 27);
            this.btnCekSenet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCekSenet.Name = "btnCekSenet";
            this.btnCekSenet.Size = new System.Drawing.Size(144, 119);
            this.btnCekSenet.TabIndex = 7;
            this.btnCekSenet.Click += new System.EventHandler(this.btnCekSenet_Click);
            // 
            // btnBankaIslem
            // 
            this.btnBankaIslem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBankaIslem.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnBankaIslem.color = System.Drawing.Color.DarkKhaki;
            this.btnBankaIslem.colorActive = System.Drawing.Color.Khaki;
            this.btnBankaIslem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBankaIslem.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBankaIslem.ForeColor = System.Drawing.Color.Black;
            this.btnBankaIslem.Image = ((System.Drawing.Image)(resources.GetObject("btnBankaIslem.Image")));
            this.btnBankaIslem.ImagePosition = 14;
            this.btnBankaIslem.ImageZoom = 50;
            this.btnBankaIslem.LabelPosition = 29;
            this.btnBankaIslem.LabelText = "Banka İşlemleri";
            this.btnBankaIslem.Location = new System.Drawing.Point(185, 27);
            this.btnBankaIslem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBankaIslem.Name = "btnBankaIslem";
            this.btnBankaIslem.Size = new System.Drawing.Size(144, 119);
            this.btnBankaIslem.TabIndex = 6;
            this.btnBankaIslem.Click += new System.EventHandler(this.btnBankaIslem_Click);
            // 
            // btnKasaIslem
            // 
            this.btnKasaIslem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnKasaIslem.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnKasaIslem.color = System.Drawing.Color.DarkKhaki;
            this.btnKasaIslem.colorActive = System.Drawing.Color.Khaki;
            this.btnKasaIslem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKasaIslem.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKasaIslem.ForeColor = System.Drawing.Color.Black;
            this.btnKasaIslem.Image = ((System.Drawing.Image)(resources.GetObject("btnKasaIslem.Image")));
            this.btnKasaIslem.ImagePosition = 14;
            this.btnKasaIslem.ImageZoom = 50;
            this.btnKasaIslem.LabelPosition = 29;
            this.btnKasaIslem.LabelText = "Kasa İşlemleri";
            this.btnKasaIslem.Location = new System.Drawing.Point(18, 27);
            this.btnKasaIslem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnKasaIslem.Name = "btnKasaIslem";
            this.btnKasaIslem.Size = new System.Drawing.Size(144, 119);
            this.btnKasaIslem.TabIndex = 5;
            this.btnKasaIslem.Click += new System.EventHandler(this.btnKasaIslem_Click);
            // 
            // lblFinans
            // 
            this.lblFinans.AutoSize = true;
            this.lblFinans.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFinans.ForeColor = System.Drawing.Color.DarkKhaki;
            this.lblFinans.Location = new System.Drawing.Point(12, 17);
            this.lblFinans.Name = "lblFinans";
            this.lblFinans.Size = new System.Drawing.Size(82, 25);
            this.lblFinans.TabIndex = 8;
            this.lblFinans.Text = "FİNANS";
            // 
            // frmFinans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(656, 510);
            this.Controls.Add(this.lblFinans);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.pnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmFinans";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Finans";
            this.pnlTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).EndInit();
            this.pnlMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Panel pnlMenu;
        private Bunifu.Framework.UI.BunifuImageButton btnClose;
        private Bunifu.Framework.UI.BunifuImageButton btnMinimize;
        private Bunifu.Framework.UI.BunifuTileButton btnCekSenet;
        private Bunifu.Framework.UI.BunifuTileButton btnBankaIslem;
        private Bunifu.Framework.UI.BunifuTileButton btnKasaIslem;
        private System.Windows.Forms.Label lblFinans;
    }
}