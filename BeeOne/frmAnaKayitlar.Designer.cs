
namespace BeeOne
{
    partial class frmAnaKayitlar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAnaKayitlar));
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblAnaKayitlar = new System.Windows.Forms.Label();
            this.btnClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnMinimize = new Bunifu.Framework.UI.BunifuImageButton();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnBanka = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnKasa = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnCariHesap = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnSabitKiymet = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnMuhasebe = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnStok = new Bunifu.Framework.UI.BunifuTileButton();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).BeginInit();
            this.pnlMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.lblAnaKayitlar);
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
            // lblAnaKayitlar
            // 
            this.lblAnaKayitlar.AutoSize = true;
            this.lblAnaKayitlar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAnaKayitlar.ForeColor = System.Drawing.Color.DarkKhaki;
            this.lblAnaKayitlar.Location = new System.Drawing.Point(12, 17);
            this.lblAnaKayitlar.Name = "lblAnaKayitlar";
            this.lblAnaKayitlar.Size = new System.Drawing.Size(146, 25);
            this.lblAnaKayitlar.TabIndex = 7;
            this.lblAnaKayitlar.Text = "ANA KAYITLAR";
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
            this.btnMinimize.Location = new System.Drawing.Point(577, 17);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(30, 30);
            this.btnMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimize.TabIndex = 5;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.Zoom = 10;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.Transparent;
            this.pnlMenu.Controls.Add(this.btnBanka);
            this.pnlMenu.Controls.Add(this.btnKasa);
            this.pnlMenu.Controls.Add(this.btnCariHesap);
            this.pnlMenu.Controls.Add(this.btnSabitKiymet);
            this.pnlMenu.Controls.Add(this.btnMuhasebe);
            this.pnlMenu.Controls.Add(this.btnStok);
            this.pnlMenu.Location = new System.Drawing.Point(71, 119);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(498, 310);
            this.pnlMenu.TabIndex = 1;
            // 
            // btnBanka
            // 
            this.btnBanka.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBanka.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnBanka.color = System.Drawing.Color.DarkKhaki;
            this.btnBanka.colorActive = System.Drawing.Color.Khaki;
            this.btnBanka.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBanka.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBanka.ForeColor = System.Drawing.Color.Black;
            this.btnBanka.Image = ((System.Drawing.Image)(resources.GetObject("btnBanka.Image")));
            this.btnBanka.ImagePosition = 14;
            this.btnBanka.ImageZoom = 50;
            this.btnBanka.LabelPosition = 29;
            this.btnBanka.LabelText = "Banka";
            this.btnBanka.Location = new System.Drawing.Point(341, 168);
            this.btnBanka.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBanka.Name = "btnBanka";
            this.btnBanka.Size = new System.Drawing.Size(134, 119);
            this.btnBanka.TabIndex = 6;
            this.btnBanka.Click += new System.EventHandler(this.btnBanka_Click);
            // 
            // btnKasa
            // 
            this.btnKasa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnKasa.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnKasa.color = System.Drawing.Color.DarkKhaki;
            this.btnKasa.colorActive = System.Drawing.Color.Khaki;
            this.btnKasa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKasa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKasa.ForeColor = System.Drawing.Color.Black;
            this.btnKasa.Image = ((System.Drawing.Image)(resources.GetObject("btnKasa.Image")));
            this.btnKasa.ImagePosition = 14;
            this.btnKasa.ImageZoom = 50;
            this.btnKasa.LabelPosition = 29;
            this.btnKasa.LabelText = "Kasa";
            this.btnKasa.Location = new System.Drawing.Point(184, 168);
            this.btnKasa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnKasa.Name = "btnKasa";
            this.btnKasa.Size = new System.Drawing.Size(134, 119);
            this.btnKasa.TabIndex = 5;
            this.btnKasa.Click += new System.EventHandler(this.btnKasa_Click);
            // 
            // btnCariHesap
            // 
            this.btnCariHesap.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCariHesap.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnCariHesap.color = System.Drawing.Color.DarkKhaki;
            this.btnCariHesap.colorActive = System.Drawing.Color.Khaki;
            this.btnCariHesap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCariHesap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCariHesap.ForeColor = System.Drawing.Color.Black;
            this.btnCariHesap.Image = ((System.Drawing.Image)(resources.GetObject("btnCariHesap.Image")));
            this.btnCariHesap.ImagePosition = 14;
            this.btnCariHesap.ImageZoom = 50;
            this.btnCariHesap.LabelPosition = 29;
            this.btnCariHesap.LabelText = "Cari Hesap";
            this.btnCariHesap.Location = new System.Drawing.Point(28, 168);
            this.btnCariHesap.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCariHesap.Name = "btnCariHesap";
            this.btnCariHesap.Size = new System.Drawing.Size(134, 119);
            this.btnCariHesap.TabIndex = 4;
            this.btnCariHesap.Click += new System.EventHandler(this.btnCariHesap_Click);
            // 
            // btnSabitKiymet
            // 
            this.btnSabitKiymet.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSabitKiymet.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnSabitKiymet.color = System.Drawing.Color.DarkKhaki;
            this.btnSabitKiymet.colorActive = System.Drawing.Color.Khaki;
            this.btnSabitKiymet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSabitKiymet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSabitKiymet.ForeColor = System.Drawing.Color.Black;
            this.btnSabitKiymet.Image = ((System.Drawing.Image)(resources.GetObject("btnSabitKiymet.Image")));
            this.btnSabitKiymet.ImagePosition = 14;
            this.btnSabitKiymet.ImageZoom = 50;
            this.btnSabitKiymet.LabelPosition = 29;
            this.btnSabitKiymet.LabelText = "Sabit Kıymet";
            this.btnSabitKiymet.Location = new System.Drawing.Point(341, 20);
            this.btnSabitKiymet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSabitKiymet.Name = "btnSabitKiymet";
            this.btnSabitKiymet.Size = new System.Drawing.Size(134, 119);
            this.btnSabitKiymet.TabIndex = 3;
            this.btnSabitKiymet.Click += new System.EventHandler(this.btnSabitKiymet_Click);
            // 
            // btnMuhasebe
            // 
            this.btnMuhasebe.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnMuhasebe.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnMuhasebe.color = System.Drawing.Color.DarkKhaki;
            this.btnMuhasebe.colorActive = System.Drawing.Color.Khaki;
            this.btnMuhasebe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMuhasebe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMuhasebe.ForeColor = System.Drawing.Color.Black;
            this.btnMuhasebe.Image = ((System.Drawing.Image)(resources.GetObject("btnMuhasebe.Image")));
            this.btnMuhasebe.ImagePosition = 14;
            this.btnMuhasebe.ImageZoom = 50;
            this.btnMuhasebe.LabelPosition = 29;
            this.btnMuhasebe.LabelText = "Muhasebe ";
            this.btnMuhasebe.Location = new System.Drawing.Point(184, 20);
            this.btnMuhasebe.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMuhasebe.Name = "btnMuhasebe";
            this.btnMuhasebe.Size = new System.Drawing.Size(134, 119);
            this.btnMuhasebe.TabIndex = 2;
            this.btnMuhasebe.Click += new System.EventHandler(this.btnMuhasebe_Click);
            // 
            // btnStok
            // 
            this.btnStok.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnStok.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnStok.color = System.Drawing.Color.DarkKhaki;
            this.btnStok.colorActive = System.Drawing.Color.Khaki;
            this.btnStok.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStok.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnStok.ForeColor = System.Drawing.Color.Black;
            this.btnStok.Image = ((System.Drawing.Image)(resources.GetObject("btnStok.Image")));
            this.btnStok.ImagePosition = 14;
            this.btnStok.ImageZoom = 50;
            this.btnStok.LabelPosition = 29;
            this.btnStok.LabelText = "Stok";
            this.btnStok.Location = new System.Drawing.Point(28, 20);
            this.btnStok.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnStok.Name = "btnStok";
            this.btnStok.Size = new System.Drawing.Size(134, 119);
            this.btnStok.TabIndex = 1;
            this.btnStok.Click += new System.EventHandler(this.btnStok_Click);
            // 
            // frmAnaKayitlar
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
            this.Name = "frmAnaKayitlar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ana Kayıtlar";
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).EndInit();
            this.pnlMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Panel pnlMenu;
        private Bunifu.Framework.UI.BunifuTileButton btnBanka;
        private Bunifu.Framework.UI.BunifuTileButton btnKasa;
        private Bunifu.Framework.UI.BunifuTileButton btnCariHesap;
        private Bunifu.Framework.UI.BunifuTileButton btnSabitKiymet;
        private Bunifu.Framework.UI.BunifuTileButton btnMuhasebe;
        private Bunifu.Framework.UI.BunifuTileButton btnStok;
        private Bunifu.Framework.UI.BunifuImageButton btnClose;
        private Bunifu.Framework.UI.BunifuImageButton btnMinimize;
        private System.Windows.Forms.Label lblAnaKayitlar;
    }
}