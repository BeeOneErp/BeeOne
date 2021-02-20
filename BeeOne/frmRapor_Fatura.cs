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
    public partial class frmRapor_Fatura : Form
    {
        public frmRapor_Fatura()
        {
            InitializeComponent();
        }

        private void btnGenelDurum_Click(object sender, EventArgs e)
        {
            pnlRapor.Show();
            pnlRapor.Controls.Clear();
            frmRapor_Fatura_GenelDurum frm = new frmRapor_Fatura_GenelDurum();
            frm.Dock = DockStyle.Fill;
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            pnlRapor.Controls.Add(frm);
            frm.Show();
        }

        private void btnSatisElemaniPerformansi_Click(object sender, EventArgs e)
        {
            pnlRapor.Show();
            pnlRapor.Controls.Clear();
            frmRapor_Fatura_SatisElemaniPerformansi frm = new frmRapor_Fatura_SatisElemaniPerformansi();
            frm.Dock = DockStyle.Fill;
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            pnlRapor.Controls.Add(frm);
            frm.Show();
        }

        private void btnSatisKarlilikAnalizi_Click(object sender, EventArgs e)
        {
            pnlRapor.Show();
            pnlRapor.Controls.Clear();
            frmRapor_Fatura_SatisKarlilikAnalizi frm = new frmRapor_Fatura_SatisKarlilikAnalizi();
            frm.Dock = DockStyle.Fill;
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            pnlRapor.Controls.Add(frm);
            frm.Show();
        }

        private void btnMalzemeSatislariEkstresi_Click(object sender, EventArgs e)
        {
            pnlRapor.Show();
            pnlRapor.Controls.Clear();
            frmRapor_Fatura_MalzemeSatislariEkstresi frm = new frmRapor_Fatura_MalzemeSatislariEkstresi();
            frm.Dock = DockStyle.Fill;
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            pnlRapor.Controls.Add(frm);
            frm.Show();
        }

        private void btnSatinAlma_Click(object sender, EventArgs e)
        {
            pnlRapor.Show();
            pnlRapor.Controls.Clear();
            frmRapor_Fatura_SatinAlma frm = new frmRapor_Fatura_SatinAlma();
            frm.Dock = DockStyle.Fill;
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            pnlRapor.Controls.Add(frm);
            frm.Show();
        }

        private void btnSatis_Click(object sender, EventArgs e)
        {
            pnlRapor.Show();
            pnlRapor.Controls.Clear();
            frmRapor_Fatura_Satis frm = new frmRapor_Fatura_Satis();
            frm.Dock = DockStyle.Fill;
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            pnlRapor.Controls.Add(frm);
            frm.Show();
        }

        private void btnSatinAlmaIrsaliyeleri_Click(object sender, EventArgs e)
        {
            pnlRapor.Show();
            pnlRapor.Controls.Clear();
            frmRapor_Fatura_SatinAlmaIrsaliyeleri frm = new frmRapor_Fatura_SatinAlmaIrsaliyeleri();
            frm.Dock = DockStyle.Fill;
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            pnlRapor.Controls.Add(frm);
            frm.Show();
        }

        private void btnSatisIrsaliyeleri_Click(object sender, EventArgs e)
        {
            pnlRapor.Show();
            pnlRapor.Controls.Clear();
            frmRapor_Fatura_SatisIrsaliyeleri frm = new frmRapor_Fatura_SatisIrsaliyeleri();
            frm.Dock = DockStyle.Fill;
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            pnlRapor.Controls.Add(frm);
            frm.Show();
        }

        private void btnKDV_Click(object sender, EventArgs e)
        {
            pnlRapor.Show();
            pnlRapor.Controls.Clear();
            frmRapor_Fatura_KDV frm = new frmRapor_Fatura_KDV();
            frm.Dock = DockStyle.Fill;
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            pnlRapor.Controls.Add(frm);
            frm.Show();
        }
    }
}
