
namespace BeeOne
{
    partial class frmMuhasebe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMuhasebe));
            this.pnlTop = new System.Windows.Forms.Panel();
            this.btnClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnMinimize = new Bunifu.Framework.UI.BunifuImageButton();
            this.lblMuhasebe = new System.Windows.Forms.Label();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnYevmiyeNo = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnMuhasebeFis = new Bunifu.Framework.UI.BunifuTileButton();
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
            // lblMuhasebe
            // 
            this.lblMuhasebe.AutoSize = true;
            this.lblMuhasebe.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMuhasebe.ForeColor = System.Drawing.Color.DarkKhaki;
            this.lblMuhasebe.Location = new System.Drawing.Point(12, 17);
            this.lblMuhasebe.Name = "lblMuhasebe";
            this.lblMuhasebe.Size = new System.Drawing.Size(213, 25);
            this.lblMuhasebe.TabIndex = 8;
            this.lblMuhasebe.Text = "MUHASEBE İŞLEMLERİ";
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.Transparent;
            this.pnlMenu.Controls.Add(this.btnYevmiyeNo);
            this.pnlMenu.Controls.Add(this.btnMuhasebeFis);
            this.pnlMenu.Location = new System.Drawing.Point(151, 158);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(354, 194);
            this.pnlMenu.TabIndex = 9;
            // 
            // btnYevmiyeNo
            // 
            this.btnYevmiyeNo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnYevmiyeNo.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnYevmiyeNo.color = System.Drawing.Color.DarkKhaki;
            this.btnYevmiyeNo.colorActive = System.Drawing.Color.Khaki;
            this.btnYevmiyeNo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnYevmiyeNo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYevmiyeNo.ForeColor = System.Drawing.Color.Black;
            this.btnYevmiyeNo.Image = ((System.Drawing.Image)(resources.GetObject("btnYevmiyeNo.Image")));
            this.btnYevmiyeNo.ImagePosition = 5;
            this.btnYevmiyeNo.ImageZoom = 50;
            this.btnYevmiyeNo.LabelPosition = 40;
            this.btnYevmiyeNo.LabelText = "Yevmiye Madde Numarası Verme";
            this.btnYevmiyeNo.Location = new System.Drawing.Point(199, 38);
            this.btnYevmiyeNo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnYevmiyeNo.Name = "btnYevmiyeNo";
            this.btnYevmiyeNo.Size = new System.Drawing.Size(134, 119);
            this.btnYevmiyeNo.TabIndex = 9;
            this.btnYevmiyeNo.Click += new System.EventHandler(this.btnYevmiyeNo_Click);
            // 
            // btnMuhasebeFis
            // 
            this.btnMuhasebeFis.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnMuhasebeFis.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnMuhasebeFis.color = System.Drawing.Color.DarkKhaki;
            this.btnMuhasebeFis.colorActive = System.Drawing.Color.Khaki;
            this.btnMuhasebeFis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMuhasebeFis.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMuhasebeFis.ForeColor = System.Drawing.Color.Black;
            this.btnMuhasebeFis.Image = ((System.Drawing.Image)(resources.GetObject("btnMuhasebeFis.Image")));
            this.btnMuhasebeFis.ImagePosition = 14;
            this.btnMuhasebeFis.ImageZoom = 50;
            this.btnMuhasebeFis.LabelPosition = 29;
            this.btnMuhasebeFis.LabelText = "Muhasebe Fişleri";
            this.btnMuhasebeFis.Location = new System.Drawing.Point(21, 38);
            this.btnMuhasebeFis.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMuhasebeFis.Name = "btnMuhasebeFis";
            this.btnMuhasebeFis.Size = new System.Drawing.Size(134, 119);
            this.btnMuhasebeFis.TabIndex = 8;
            this.btnMuhasebeFis.Click += new System.EventHandler(this.btnMuhasebeFis_Click);
            // 
            // frmMuhasebe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(656, 510);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.lblMuhasebe);
            this.Controls.Add(this.pnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMuhasebe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Muhasebe İşlemleri";
            this.pnlTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).EndInit();
            this.pnlMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private Bunifu.Framework.UI.BunifuImageButton btnClose;
        private Bunifu.Framework.UI.BunifuImageButton btnMinimize;
        private System.Windows.Forms.Label lblMuhasebe;
        private System.Windows.Forms.Panel pnlMenu;
        private Bunifu.Framework.UI.BunifuTileButton btnYevmiyeNo;
        private Bunifu.Framework.UI.BunifuTileButton btnMuhasebeFis;
    }
}