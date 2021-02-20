
namespace BeeOne
{
    partial class frmAnaKayitlar_Stok_AlternatifMalzemeler
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewAlternatifMalzemeler = new System.Windows.Forms.DataGridView();
            this.oNE001ITEMSUBSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bEEONEDataSet1 = new BeeOne.BEEONEDataSet1();
            this.fillByToolStrip = new System.Windows.Forms.ToolStrip();
            this.sTOCKREFToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.sTOCKREFToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillByToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.oNE_001_ITEMSUBSTableAdapter = new BeeOne.BEEONEDataSet1TableAdapters.ONE_001_ITEMSUBSTableAdapter();
            this.mAINITEMREFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sUBITEMREFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRIORITYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mAXQUANTITYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mINQUANTITYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bEGDATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eNDDATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAlternatifMalzemeler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oNE001ITEMSUBSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bEEONEDataSet1)).BeginInit();
            this.fillByToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewAlternatifMalzemeler
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewAlternatifMalzemeler.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewAlternatifMalzemeler.AutoGenerateColumns = false;
            this.dataGridViewAlternatifMalzemeler.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAlternatifMalzemeler.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewAlternatifMalzemeler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAlternatifMalzemeler.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mAINITEMREFDataGridViewTextBoxColumn,
            this.sUBITEMREFDataGridViewTextBoxColumn,
            this.pRIORITYDataGridViewTextBoxColumn,
            this.mAXQUANTITYDataGridViewTextBoxColumn,
            this.mINQUANTITYDataGridViewTextBoxColumn,
            this.bEGDATEDataGridViewTextBoxColumn,
            this.eNDDATEDataGridViewTextBoxColumn});
            this.dataGridViewAlternatifMalzemeler.DataSource = this.oNE001ITEMSUBSBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(0, 6, 0, 6);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewAlternatifMalzemeler.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewAlternatifMalzemeler.Location = new System.Drawing.Point(12, 10);
            this.dataGridViewAlternatifMalzemeler.Name = "dataGridViewAlternatifMalzemeler";
            this.dataGridViewAlternatifMalzemeler.ReadOnly = true;
            this.dataGridViewAlternatifMalzemeler.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.dataGridViewAlternatifMalzemeler.RowTemplate.Height = 40;
            this.dataGridViewAlternatifMalzemeler.Size = new System.Drawing.Size(920, 274);
            this.dataGridViewAlternatifMalzemeler.TabIndex = 19;
            // 
            // oNE001ITEMSUBSBindingSource
            // 
            this.oNE001ITEMSUBSBindingSource.DataMember = "ONE_001_ITEMSUBS";
            this.oNE001ITEMSUBSBindingSource.DataSource = this.bEEONEDataSet1;
            // 
            // bEEONEDataSet1
            // 
            this.bEEONEDataSet1.DataSetName = "BEEONEDataSet1";
            this.bEEONEDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fillByToolStrip
            // 
            this.fillByToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sTOCKREFToolStripLabel,
            this.sTOCKREFToolStripTextBox,
            this.fillByToolStripButton});
            this.fillByToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillByToolStrip.Name = "fillByToolStrip";
            this.fillByToolStrip.Size = new System.Drawing.Size(952, 25);
            this.fillByToolStrip.TabIndex = 20;
            this.fillByToolStrip.Text = "fillByToolStrip";
            // 
            // sTOCKREFToolStripLabel
            // 
            this.sTOCKREFToolStripLabel.Name = "sTOCKREFToolStripLabel";
            this.sTOCKREFToolStripLabel.Size = new System.Drawing.Size(64, 22);
            this.sTOCKREFToolStripLabel.Text = "STOCKREF:";
            // 
            // sTOCKREFToolStripTextBox
            // 
            this.sTOCKREFToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.sTOCKREFToolStripTextBox.Name = "sTOCKREFToolStripTextBox";
            this.sTOCKREFToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // fillByToolStripButton
            // 
            this.fillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByToolStripButton.Name = "fillByToolStripButton";
            this.fillByToolStripButton.Size = new System.Drawing.Size(39, 22);
            this.fillByToolStripButton.Text = "FillBy";
            // 
            // oNE_001_ITEMSUBSTableAdapter
            // 
            this.oNE_001_ITEMSUBSTableAdapter.ClearBeforeFill = true;
            // 
            // mAINITEMREFDataGridViewTextBoxColumn
            // 
            this.mAINITEMREFDataGridViewTextBoxColumn.DataPropertyName = "MAINITEMREF";
            this.mAINITEMREFDataGridViewTextBoxColumn.HeaderText = "Ana Malzeme Kodu";
            this.mAINITEMREFDataGridViewTextBoxColumn.Name = "mAINITEMREFDataGridViewTextBoxColumn";
            this.mAINITEMREFDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sUBITEMREFDataGridViewTextBoxColumn
            // 
            this.sUBITEMREFDataGridViewTextBoxColumn.DataPropertyName = "SUBITEMREF";
            this.sUBITEMREFDataGridViewTextBoxColumn.HeaderText = "Alternatif Malzeme Kodu";
            this.sUBITEMREFDataGridViewTextBoxColumn.Name = "sUBITEMREFDataGridViewTextBoxColumn";
            this.sUBITEMREFDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pRIORITYDataGridViewTextBoxColumn
            // 
            this.pRIORITYDataGridViewTextBoxColumn.DataPropertyName = "PRIORITY_";
            this.pRIORITYDataGridViewTextBoxColumn.HeaderText = "Öncelik";
            this.pRIORITYDataGridViewTextBoxColumn.Name = "pRIORITYDataGridViewTextBoxColumn";
            this.pRIORITYDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mAXQUANTITYDataGridViewTextBoxColumn
            // 
            this.mAXQUANTITYDataGridViewTextBoxColumn.DataPropertyName = "MAXQUANTITY";
            this.mAXQUANTITYDataGridViewTextBoxColumn.HeaderText = "Max Miktar";
            this.mAXQUANTITYDataGridViewTextBoxColumn.Name = "mAXQUANTITYDataGridViewTextBoxColumn";
            this.mAXQUANTITYDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mINQUANTITYDataGridViewTextBoxColumn
            // 
            this.mINQUANTITYDataGridViewTextBoxColumn.DataPropertyName = "MINQUANTITY";
            this.mINQUANTITYDataGridViewTextBoxColumn.HeaderText = "Min Miktar";
            this.mINQUANTITYDataGridViewTextBoxColumn.Name = "mINQUANTITYDataGridViewTextBoxColumn";
            this.mINQUANTITYDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bEGDATEDataGridViewTextBoxColumn
            // 
            this.bEGDATEDataGridViewTextBoxColumn.DataPropertyName = "BEGDATE";
            this.bEGDATEDataGridViewTextBoxColumn.HeaderText = "Başlangıç Tarihi";
            this.bEGDATEDataGridViewTextBoxColumn.Name = "bEGDATEDataGridViewTextBoxColumn";
            this.bEGDATEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // eNDDATEDataGridViewTextBoxColumn
            // 
            this.eNDDATEDataGridViewTextBoxColumn.DataPropertyName = "ENDDATE";
            this.eNDDATEDataGridViewTextBoxColumn.HeaderText = "Bitiş Tarihi";
            this.eNDDATEDataGridViewTextBoxColumn.Name = "eNDDATEDataGridViewTextBoxColumn";
            this.eNDDATEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // frmAnaKayitlar_Stok_AlternatifMalzemeler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BeeOne.Properties.Resources.background__41_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(952, 304);
            this.Controls.Add(this.fillByToolStrip);
            this.Controls.Add(this.dataGridViewAlternatifMalzemeler);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAnaKayitlar_Stok_AlternatifMalzemeler";
            this.Text = "Ana Kayıtlar > Stok > Alternatif Malzemeler";
            this.Load += new System.EventHandler(this.frmAnaKayitlar_Stok_AlternatifMalzemeler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAlternatifMalzemeler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oNE001ITEMSUBSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bEEONEDataSet1)).EndInit();
            this.fillByToolStrip.ResumeLayout(false);
            this.fillByToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewAlternatifMalzemeler;
        private BEEONEDataSet1 bEEONEDataSet1;
        private System.Windows.Forms.BindingSource oNE001ITEMSUBSBindingSource;
        private BEEONEDataSet1TableAdapters.ONE_001_ITEMSUBSTableAdapter oNE_001_ITEMSUBSTableAdapter;
        private System.Windows.Forms.ToolStrip fillByToolStrip;
        private System.Windows.Forms.ToolStripLabel sTOCKREFToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox sTOCKREFToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillByToolStripButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn mAINITEMREFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sUBITEMREFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRIORITYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mAXQUANTITYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mINQUANTITYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bEGDATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eNDDATEDataGridViewTextBoxColumn;
    }
}