
namespace BeeOne
{
    partial class frmL_Muhasebe_MuhasebeFis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmL_Muhasebe_MuhasebeFis));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblMuhasebe = new System.Windows.Forms.Label();
            this.btnClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnMinimize = new Bunifu.Framework.UI.BunifuImageButton();
            this.dataGridViewMuhasebeFis = new System.Windows.Forms.DataGridView();
            this.btnEkle = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnSil = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnDegistir = new Bunifu.Framework.UI.BunifuFlatButton();
            this.dropdownCekSenet = new Bunifu.Framework.UI.BunifuDropdown();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMuhasebeFis)).BeginInit();
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
            this.pnlTop.Size = new System.Drawing.Size(1307, 48);
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
            this.lblMuhasebe.Size = new System.Drawing.Size(261, 21);
            this.lblMuhasebe.TabIndex = 7;
            this.lblMuhasebe.Text = "MUHASEBE > MUHASEBE FİŞLERİ\r\n";
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
            // dataGridViewMuhasebeFis
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewMuhasebeFis.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewMuhasebeFis.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewMuhasebeFis.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewMuhasebeFis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(0, 6, 0, 6);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewMuhasebeFis.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewMuhasebeFis.Location = new System.Drawing.Point(69, 153);
            this.dataGridViewMuhasebeFis.Name = "dataGridViewMuhasebeFis";
            this.dataGridViewMuhasebeFis.ReadOnly = true;
            this.dataGridViewMuhasebeFis.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.dataGridViewMuhasebeFis.RowTemplate.Height = 40;
            this.dataGridViewMuhasebeFis.Size = new System.Drawing.Size(1169, 761);
            this.dataGridViewMuhasebeFis.TabIndex = 18;
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
            this.btnEkle.Location = new System.Drawing.Point(369, 84);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnEkle.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnEkle.OnHoverTextColor = System.Drawing.Color.Khaki;
            this.btnEkle.selected = false;
            this.btnEkle.Size = new System.Drawing.Size(97, 39);
            this.btnEkle.TabIndex = 19;
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
            this.btnSil.Location = new System.Drawing.Point(640, 84);
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
            this.btnDegistir.Location = new System.Drawing.Point(505, 84);
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
            // dropdownCekSenet
            // 
            this.dropdownCekSenet.BackColor = System.Drawing.Color.Transparent;
            this.dropdownCekSenet.BorderRadius = 3;
            this.dropdownCekSenet.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.dropdownCekSenet.ForeColor = System.Drawing.Color.White;
            this.dropdownCekSenet.Items = new string[] {
        "(1) Açılış Fişi",
        "(2) Tahsil Fişi",
        "(3) Tediye Fişi",
        "(4) Mahsup Fişi"};
            this.dropdownCekSenet.Location = new System.Drawing.Point(69, 84);
            this.dropdownCekSenet.Name = "dropdownCekSenet";
            this.dropdownCekSenet.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.dropdownCekSenet.onHoverColor = System.Drawing.Color.Khaki;
            this.dropdownCekSenet.selectedIndex = 3;
            this.dropdownCekSenet.Size = new System.Drawing.Size(260, 39);
            this.dropdownCekSenet.TabIndex = 27;
            // 
            // frmL_Muhasebe_MuhasebeFis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.BackgroundImage = global::BeeOne.Properties.Resources.background__41_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1307, 943);
            this.Controls.Add(this.dropdownCekSenet);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnDegistir);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.dataGridViewMuhasebeFis);
            this.Controls.Add(this.pnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmL_Muhasebe_MuhasebeFis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Muhasebe > Muhasebe Fişleri";
            this.Load += new System.EventHandler(this.frmL_Muhasebe_MuhasebeFis_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMuhasebeFis)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblMuhasebe;
        private Bunifu.Framework.UI.BunifuImageButton btnClose;
        private Bunifu.Framework.UI.BunifuImageButton btnMinimize;
        private System.Windows.Forms.DataGridView dataGridViewMuhasebeFis;
        private Bunifu.Framework.UI.BunifuFlatButton btnEkle;
        private Bunifu.Framework.UI.BunifuFlatButton btnSil;
        private Bunifu.Framework.UI.BunifuFlatButton btnDegistir;
        private Bunifu.Framework.UI.BunifuDropdown dropdownCekSenet;
    }
}