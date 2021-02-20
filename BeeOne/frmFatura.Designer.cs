
namespace BeeOne
{
    partial class frmFatura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFatura));
            this.pnlTop = new System.Windows.Forms.Panel();
            this.btnClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnMinimize = new Bunifu.Framework.UI.BunifuImageButton();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnSatinAlmaFatura = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnSatisFatura = new Bunifu.Framework.UI.BunifuTileButton();
            this.lblFatura = new System.Windows.Forms.Label();
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
            this.btnClose.TabIndex = 10;
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
            this.btnMinimize.TabIndex = 9;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.Zoom = 10;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.Transparent;
            this.pnlMenu.Controls.Add(this.btnSatinAlmaFatura);
            this.pnlMenu.Controls.Add(this.btnSatisFatura);
            this.pnlMenu.Location = new System.Drawing.Point(109, 160);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(418, 224);
            this.pnlMenu.TabIndex = 1;
            // 
            // btnSatinAlmaFatura
            // 
            this.btnSatinAlmaFatura.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSatinAlmaFatura.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnSatinAlmaFatura.color = System.Drawing.Color.DarkKhaki;
            this.btnSatinAlmaFatura.colorActive = System.Drawing.Color.Khaki;
            this.btnSatinAlmaFatura.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSatinAlmaFatura.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSatinAlmaFatura.ForeColor = System.Drawing.Color.Black;
            this.btnSatinAlmaFatura.Image = ((System.Drawing.Image)(resources.GetObject("btnSatinAlmaFatura.Image")));
            this.btnSatinAlmaFatura.ImagePosition = 14;
            this.btnSatinAlmaFatura.ImageZoom = 50;
            this.btnSatinAlmaFatura.LabelPosition = 29;
            this.btnSatinAlmaFatura.LabelText = "Satın Alma Faturaları";
            this.btnSatinAlmaFatura.Location = new System.Drawing.Point(222, 51);
            this.btnSatinAlmaFatura.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSatinAlmaFatura.Name = "btnSatinAlmaFatura";
            this.btnSatinAlmaFatura.Size = new System.Drawing.Size(152, 119);
            this.btnSatinAlmaFatura.TabIndex = 5;
            this.btnSatinAlmaFatura.Click += new System.EventHandler(this.btnSatinAlmaFatura_Click);
            // 
            // btnSatisFatura
            // 
            this.btnSatisFatura.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSatisFatura.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnSatisFatura.color = System.Drawing.Color.DarkKhaki;
            this.btnSatisFatura.colorActive = System.Drawing.Color.Khaki;
            this.btnSatisFatura.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSatisFatura.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSatisFatura.ForeColor = System.Drawing.Color.Black;
            this.btnSatisFatura.Image = ((System.Drawing.Image)(resources.GetObject("btnSatisFatura.Image")));
            this.btnSatisFatura.ImagePosition = 14;
            this.btnSatisFatura.ImageZoom = 50;
            this.btnSatisFatura.LabelPosition = 29;
            this.btnSatisFatura.LabelText = "Satış Faturaları";
            this.btnSatisFatura.Location = new System.Drawing.Point(41, 51);
            this.btnSatisFatura.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSatisFatura.Name = "btnSatisFatura";
            this.btnSatisFatura.Size = new System.Drawing.Size(152, 119);
            this.btnSatisFatura.TabIndex = 4;
            this.btnSatisFatura.Click += new System.EventHandler(this.btnSatisFatura_Click);
            // 
            // lblFatura
            // 
            this.lblFatura.AutoSize = true;
            this.lblFatura.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFatura.ForeColor = System.Drawing.Color.DarkKhaki;
            this.lblFatura.Location = new System.Drawing.Point(12, 17);
            this.lblFatura.Name = "lblFatura";
            this.lblFatura.Size = new System.Drawing.Size(83, 25);
            this.lblFatura.TabIndex = 8;
            this.lblFatura.Text = "FATURA";
            // 
            // frmFatura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(656, 510);
            this.Controls.Add(this.lblFatura);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.pnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmFatura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fatura";
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
        private System.Windows.Forms.Panel pnlMenu;
        private Bunifu.Framework.UI.BunifuTileButton btnSatinAlmaFatura;
        private Bunifu.Framework.UI.BunifuTileButton btnSatisFatura;
        private System.Windows.Forms.Label lblFatura;
    }
}