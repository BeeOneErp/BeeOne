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
    public partial class frmRapor_CekSenet : Form
    {
        public frmRapor_CekSenet()
        {
            InitializeComponent();
        }

        private void btnMusteriReeskont_Click(object sender, EventArgs e)
        {
            pnlRapor.Show();
            pnlRapor.Controls.Clear();
            frmRapor_CekSenet_MusteriReeskont frm = new frmRapor_CekSenet_MusteriReeskont();
            frm.Dock = DockStyle.Fill;
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            pnlRapor.Controls.Add(frm);
            frm.Show();
        }

        private void btnFirmaReeskont_Click(object sender, EventArgs e)
        {
            pnlRapor.Show();
            pnlRapor.Controls.Clear();
            frmRapor_CekSenet_FirmaReeskont frm = new frmRapor_CekSenet_FirmaReeskont();
            frm.Dock = DockStyle.Fill;
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            pnlRapor.Controls.Add(frm);
            frm.Show();
        }

        private void btnBorcYaslandirma_Click(object sender, EventArgs e)
        {
            pnlRapor.Show();
            pnlRapor.Controls.Clear();
            frmRapor_CekSenet_BorcYaslandirma frm = new frmRapor_CekSenet_BorcYaslandirma();
            frm.Dock = DockStyle.Fill;
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            pnlRapor.Controls.Add(frm);
            frm.Show();
        }

        private void btnMusteriCekSenet_Click(object sender, EventArgs e)
        {
            pnlRapor.Show();
            pnlRapor.Controls.Clear();
            frmRapor_CekSenet_MusteriCekSenet frm = new frmRapor_CekSenet_MusteriCekSenet();
            frm.Dock = DockStyle.Fill;
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            pnlRapor.Controls.Add(frm);
            frm.Show();
        }

        private void btnFirmaCekSenet_Click(object sender, EventArgs e)
        {
            pnlRapor.Show();
            pnlRapor.Controls.Clear();
            frmRapor_CekSenet_FirmaCekSenet frm = new frmRapor_CekSenet_FirmaCekSenet();
            frm.Dock = DockStyle.Fill;
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            pnlRapor.Controls.Add(frm);
            frm.Show();
        }

        private void btnOzetBordro_Click(object sender, EventArgs e)
        {
            pnlRapor.Show();
            pnlRapor.Controls.Clear();
            frmRapor_CekSenet_OzetBordro frm = new frmRapor_CekSenet_OzetBordro();
            frm.Dock = DockStyle.Fill;
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            pnlRapor.Controls.Add(frm);
            frm.Show();
        }

        private void btnAyrintiliBordro_Click(object sender, EventArgs e)
        {
            pnlRapor.Show();
            pnlRapor.Controls.Clear();
            frmRapor_CekSenet_AyrintiliBordro frm = new frmRapor_CekSenet_AyrintiliBordro();
            frm.Dock = DockStyle.Fill;
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            pnlRapor.Controls.Add(frm);
            frm.Show();
        }
    }
}
