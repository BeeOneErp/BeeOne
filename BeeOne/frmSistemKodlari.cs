using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeeOne
{
    public partial class frmSistemKodlari : Form
    {
        public frmSistemKodlari()
        {
            InitializeComponent();
            DatagridviewSetting(dataGridViewIsyeri);
            DatagridviewSetting(dataGridViewAmbar);
            DatagridviewSetting(dataGridViewOzelKod);
            DatagridviewSetting(dataGridViewYetkiKodu);
            DatagridviewSetting(dataGridViewGrupKodu);
            DatagridviewSetting(dataGridViewProjeKodu);
            DatagridviewSetting(dataGridViewMasrafMerkezi);
            DatagridviewSetting(dataGridViewSatisElemani);
        }

        public void DatagridviewSetting(DataGridView datagridView)
        {
            datagridView.RowHeadersVisible = false;
            datagridView.BorderStyle = BorderStyle.None;
            datagridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(50, 50, 50);
            datagridView.DefaultCellStyle.SelectionBackColor = Color.FromArgb(45, 45, 45);
            datagridView.DefaultCellStyle.ForeColor = Color.White;
            datagridView.DefaultCellStyle.SelectionForeColor = Color.Khaki;
            datagridView.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Times New Roman", 10);
            datagridView.EnableHeadersVisualStyles = false;
            datagridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None; //Başlık çizgilerini kaldırıyor.
            datagridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(40, 40, 40);
            datagridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            datagridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            datagridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        bool move;
        int mouse_x;
        int mouse_y;

        private void pnlTop_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            mouse_x = e.X;
            mouse_y = e.Y;
        }

        private void pnlTop_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }

        private void pnlTop_MouseMove(object sender, MouseEventArgs e)
        {
            if (move == true)
            {
                this.SetDesktopLocation(MousePosition.X - mouse_x, MousePosition.Y - mouse_y);
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmSistemKodlari_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'bEEONE_Sistem_Kodlari.ONE_001_SALESMAN' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.oNE_001_SALESMANTableAdapter.Fill(this.bEEONE_Sistem_Kodlari.ONE_001_SALESMAN);
            // TODO: Bu kod satırı 'bEEONE_Sistem_Kodlari.ONE_001_EMCENTER' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.oNE_001_EMCENTERTableAdapter.Fill(this.bEEONE_Sistem_Kodlari.ONE_001_EMCENTER);
            // TODO: Bu kod satırı 'bEEONE_Sistem_Kodlari.ONE_001_PROJECT' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.oNE_001_PROJECTTableAdapter.Fill(this.bEEONE_Sistem_Kodlari.ONE_001_PROJECT);
            // TODO: Bu kod satırı 'bEEONE_Sistem_Kodlari.ONE_001_GRPCODES' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.oNE_001_GRPCODESTableAdapter.Fill(this.bEEONE_Sistem_Kodlari.ONE_001_GRPCODES);
            // TODO: Bu kod satırı 'bEEONE_Sistem_Kodlari.ONE_001_CYPHCODES' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.oNE_001_CYPHCODESTableAdapter.Fill(this.bEEONE_Sistem_Kodlari.ONE_001_CYPHCODES);
            // TODO: Bu kod satırı 'bEEONE_Sistem_Kodlari.ONE_001_SPECODES' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.oNE_001_SPECODESTableAdapter.Fill(this.bEEONE_Sistem_Kodlari.ONE_001_SPECODES);
            // TODO: Bu kod satırı 'bEEONE_Sistem_Kodlari.ONE_001_CAPIDIV' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.oNE_001_CAPIDIVTableAdapter.Fill(this.bEEONE_Sistem_Kodlari.ONE_001_CAPIDIV);
            // TODO: Bu kod satırı 'bEEONE_Sistem_Kodlari.ONE_001_BRANCH' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.oNE_001_BRANCHTableAdapter.Fill(this.bEEONE_Sistem_Kodlari.ONE_001_BRANCH);

        }

        private void txtProjeKodBilgi_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
