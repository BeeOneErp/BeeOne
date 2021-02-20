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
    public partial class frmRapor_Kasa : Form
    {
        public frmRapor_Kasa()
        {
            InitializeComponent();
        }

        private void btnKasaHesapOzeti_Click(object sender, EventArgs e)
        {
            pnlRapor.Show();
            pnlRapor.Controls.Clear();
            frmRapor_Kasa_KasaHesapOzeti frm = new frmRapor_Kasa_KasaHesapOzeti();
            frm.Dock = DockStyle.Fill;
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            pnlRapor.Controls.Add(frm);
            frm.Show();
        }

        private void btnKasaEkstresi_Click(object sender, EventArgs e)
        {
            pnlRapor.Show();
            pnlRapor.Controls.Clear();
            frmRapor_Kasa_KasaEkstresi frm = new frmRapor_Kasa_KasaEkstresi();
            frm.Dock = DockStyle.Fill;
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            pnlRapor.Controls.Add(frm);
            frm.Show();
        }
    }
}
