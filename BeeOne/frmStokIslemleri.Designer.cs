
namespace BeeOne
{
    partial class frmStokIslemleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStokIslemleri));
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblStokIslemleri = new System.Windows.Forms.Label();
            this.btnClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnMinimize = new Bunifu.Framework.UI.BunifuImageButton();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnMalzemeFis = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnSatinAlmaIrsaliye = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnSatisIrsaliye = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnSatinAlmaSiparis = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnSatisSiparis = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnMaliyetFis = new Bunifu.Framework.UI.BunifuTileButton();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).BeginInit();
            this.pnlMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.lblStokIslemleri);
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
            // lblStokIslemleri
            // 
            this.lblStokIslemleri.AutoSize = true;
            this.lblStokIslemleri.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblStokIslemleri.ForeColor = System.Drawing.Color.DarkKhaki;
            this.lblStokIslemleri.Location = new System.Drawing.Point(12, 17);
            this.lblStokIslemleri.Name = "lblStokIslemleri";
            this.lblStokIslemleri.Size = new System.Drawing.Size(157, 25);
            this.lblStokIslemleri.TabIndex = 9;
            this.lblStokIslemleri.Text = "STOK İŞLEMLERİ";
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
            this.btnClose.TabIndex = 8;
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
            this.btnMinimize.TabIndex = 7;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.Zoom = 10;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.Transparent;
            this.pnlMenu.Controls.Add(this.btnMaliyetFis);
            this.pnlMenu.Controls.Add(this.btnMalzemeFis);
            this.pnlMenu.Controls.Add(this.btnSatinAlmaIrsaliye);
            this.pnlMenu.Controls.Add(this.btnSatisIrsaliye);
            this.pnlMenu.Controls.Add(this.btnSatinAlmaSiparis);
            this.pnlMenu.Controls.Add(this.btnSatisSiparis);
            this.pnlMenu.Location = new System.Drawing.Point(71, 119);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(498, 310);
            this.pnlMenu.TabIndex = 1;
            // 
            // btnMalzemeFis
            // 
            this.btnMalzemeFis.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnMalzemeFis.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnMalzemeFis.color = System.Drawing.Color.DarkKhaki;
            this.btnMalzemeFis.colorActive = System.Drawing.Color.Khaki;
            this.btnMalzemeFis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMalzemeFis.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMalzemeFis.ForeColor = System.Drawing.Color.Black;
            this.btnMalzemeFis.Image = ((System.Drawing.Image)(resources.GetObject("btnMalzemeFis.Image")));
            this.btnMalzemeFis.ImagePosition = 14;
            this.btnMalzemeFis.ImageZoom = 50;
            this.btnMalzemeFis.LabelPosition = 29;
            this.btnMalzemeFis.LabelText = "Malzeme Fişleri";
            this.btnMalzemeFis.Location = new System.Drawing.Point(177, 171);
            this.btnMalzemeFis.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMalzemeFis.Name = "btnMalzemeFis";
            this.btnMalzemeFis.Size = new System.Drawing.Size(145, 119);
            this.btnMalzemeFis.TabIndex = 6;
            this.btnMalzemeFis.Click += new System.EventHandler(this.btnMalzemeFis_Click);
            // 
            // btnSatinAlmaIrsaliye
            // 
            this.btnSatinAlmaIrsaliye.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSatinAlmaIrsaliye.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnSatinAlmaIrsaliye.color = System.Drawing.Color.DarkKhaki;
            this.btnSatinAlmaIrsaliye.colorActive = System.Drawing.Color.Khaki;
            this.btnSatinAlmaIrsaliye.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSatinAlmaIrsaliye.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSatinAlmaIrsaliye.ForeColor = System.Drawing.Color.Black;
            this.btnSatinAlmaIrsaliye.Image = ((System.Drawing.Image)(resources.GetObject("btnSatinAlmaIrsaliye.Image")));
            this.btnSatinAlmaIrsaliye.ImagePosition = 14;
            this.btnSatinAlmaIrsaliye.ImageZoom = 50;
            this.btnSatinAlmaIrsaliye.LabelPosition = 29;
            this.btnSatinAlmaIrsaliye.LabelText = "Satın Alma İrsaliyeleri";
            this.btnSatinAlmaIrsaliye.Location = new System.Drawing.Point(22, 171);
            this.btnSatinAlmaIrsaliye.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSatinAlmaIrsaliye.Name = "btnSatinAlmaIrsaliye";
            this.btnSatinAlmaIrsaliye.Size = new System.Drawing.Size(145, 119);
            this.btnSatinAlmaIrsaliye.TabIndex = 5;
            this.btnSatinAlmaIrsaliye.Click += new System.EventHandler(this.btnSatinAlmaIrsaliye_Click);
            // 
            // btnSatisIrsaliye
            // 
            this.btnSatisIrsaliye.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSatisIrsaliye.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnSatisIrsaliye.color = System.Drawing.Color.DarkKhaki;
            this.btnSatisIrsaliye.colorActive = System.Drawing.Color.Khaki;
            this.btnSatisIrsaliye.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSatisIrsaliye.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSatisIrsaliye.ForeColor = System.Drawing.Color.Black;
            this.btnSatisIrsaliye.Image = ((System.Drawing.Image)(resources.GetObject("btnSatisIrsaliye.Image")));
            this.btnSatisIrsaliye.ImagePosition = 14;
            this.btnSatisIrsaliye.ImageZoom = 50;
            this.btnSatisIrsaliye.LabelPosition = 29;
            this.btnSatisIrsaliye.LabelText = "Satış İrsaliyeleri";
            this.btnSatisIrsaliye.Location = new System.Drawing.Point(330, 25);
            this.btnSatisIrsaliye.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSatisIrsaliye.Name = "btnSatisIrsaliye";
            this.btnSatisIrsaliye.Size = new System.Drawing.Size(145, 119);
            this.btnSatisIrsaliye.TabIndex = 4;
            this.btnSatisIrsaliye.Click += new System.EventHandler(this.btnSatisIrsaliye_Click);
            // 
            // btnSatinAlmaSiparis
            // 
            this.btnSatinAlmaSiparis.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSatinAlmaSiparis.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnSatinAlmaSiparis.color = System.Drawing.Color.DarkKhaki;
            this.btnSatinAlmaSiparis.colorActive = System.Drawing.Color.Khaki;
            this.btnSatinAlmaSiparis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSatinAlmaSiparis.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSatinAlmaSiparis.ForeColor = System.Drawing.Color.Black;
            this.btnSatinAlmaSiparis.Image = ((System.Drawing.Image)(resources.GetObject("btnSatinAlmaSiparis.Image")));
            this.btnSatinAlmaSiparis.ImagePosition = 14;
            this.btnSatinAlmaSiparis.ImageZoom = 50;
            this.btnSatinAlmaSiparis.LabelPosition = 29;
            this.btnSatinAlmaSiparis.LabelText = "Satın Alma Siparişleri";
            this.btnSatinAlmaSiparis.Location = new System.Drawing.Point(177, 25);
            this.btnSatinAlmaSiparis.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSatinAlmaSiparis.Name = "btnSatinAlmaSiparis";
            this.btnSatinAlmaSiparis.Size = new System.Drawing.Size(145, 119);
            this.btnSatinAlmaSiparis.TabIndex = 3;
            this.btnSatinAlmaSiparis.Click += new System.EventHandler(this.btnSatinAlmaSiparis_Click);
            // 
            // btnSatisSiparis
            // 
            this.btnSatisSiparis.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSatisSiparis.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnSatisSiparis.color = System.Drawing.Color.DarkKhaki;
            this.btnSatisSiparis.colorActive = System.Drawing.Color.Khaki;
            this.btnSatisSiparis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSatisSiparis.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSatisSiparis.ForeColor = System.Drawing.Color.Black;
            this.btnSatisSiparis.Image = ((System.Drawing.Image)(resources.GetObject("btnSatisSiparis.Image")));
            this.btnSatisSiparis.ImagePosition = 14;
            this.btnSatisSiparis.ImageZoom = 50;
            this.btnSatisSiparis.LabelPosition = 29;
            this.btnSatisSiparis.LabelText = "Satış Siparişleri";
            this.btnSatisSiparis.Location = new System.Drawing.Point(22, 25);
            this.btnSatisSiparis.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSatisSiparis.Name = "btnSatisSiparis";
            this.btnSatisSiparis.Size = new System.Drawing.Size(145, 119);
            this.btnSatisSiparis.TabIndex = 2;
            this.btnSatisSiparis.Click += new System.EventHandler(this.btnSatisSiparis_Click);
            // 
            // btnMaliyetFis
            // 
            this.btnMaliyetFis.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnMaliyetFis.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnMaliyetFis.color = System.Drawing.Color.DarkKhaki;
            this.btnMaliyetFis.colorActive = System.Drawing.Color.Khaki;
            this.btnMaliyetFis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaliyetFis.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMaliyetFis.ForeColor = System.Drawing.Color.Black;
            this.btnMaliyetFis.Image = ((System.Drawing.Image)(resources.GetObject("btnMaliyetFis.Image")));
            this.btnMaliyetFis.ImagePosition = 14;
            this.btnMaliyetFis.ImageZoom = 50;
            this.btnMaliyetFis.LabelPosition = 29;
            this.btnMaliyetFis.LabelText = "Maliyet Fişleri";
            this.btnMaliyetFis.Location = new System.Drawing.Point(330, 171);
            this.btnMaliyetFis.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMaliyetFis.Name = "btnMaliyetFis";
            this.btnMaliyetFis.Size = new System.Drawing.Size(145, 119);
            this.btnMaliyetFis.TabIndex = 7;
            this.btnMaliyetFis.Click += new System.EventHandler(this.btnMaliyetFis_Click);
            // 
            // frmStokIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(656, 510);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.pnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmStokIslemleri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stok İşlemleri";
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).EndInit();
            this.pnlMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private Bunifu.Framework.UI.BunifuImageButton btnClose;
        private Bunifu.Framework.UI.BunifuImageButton btnMinimize;
        private System.Windows.Forms.Panel pnlMenu;
        private Bunifu.Framework.UI.BunifuTileButton btnSatisSiparis;
        private Bunifu.Framework.UI.BunifuTileButton btnMalzemeFis;
        private Bunifu.Framework.UI.BunifuTileButton btnSatinAlmaIrsaliye;
        private Bunifu.Framework.UI.BunifuTileButton btnSatisIrsaliye;
        private Bunifu.Framework.UI.BunifuTileButton btnSatinAlmaSiparis;
        private System.Windows.Forms.Label lblStokIslemleri;
        private Bunifu.Framework.UI.BunifuTileButton btnMaliyetFis;
    }
}