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
    public partial class frmRapor_SabitKiymet : Form
    {
        public frmRapor_SabitKiymet()
        {
            InitializeComponent();
        }

        private void btnSKListesi_Click(object sender, EventArgs e)
        {
            pnlRapor.Show();
            pnlRapor.Controls.Clear();
            frmRapor_SabitKiymet_SKListesi frm = new frmRapor_SabitKiymet_SKListesi();
            frm.Dock = DockStyle.Fill;
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            pnlRapor.Controls.Add(frm);
            frm.Show();
        }

        private void btnSKDurumu_Click(object sender, EventArgs e)
        {
            pnlRapor.Show();
            pnlRapor.Controls.Clear();
            frmRapor_SabitKiymet_SKDurumu frm = new frmRapor_SabitKiymet_SKDurumu();
            frm.Dock = DockStyle.Fill;
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            pnlRapor.Controls.Add(frm);
            frm.Show();
        }

        private void btnSKMizani_Click(object sender, EventArgs e)
        {
            pnlRapor.Show();
            pnlRapor.Controls.Clear();
            frmRapor_SabitKiymet_SKMizani frm = new frmRapor_SabitKiymet_SKMizani();
            frm.Dock = DockStyle.Fill;
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            pnlRapor.Controls.Add(frm);
            frm.Show();
        }

        private void btnAmortismanTablolari_Click(object sender, EventArgs e)
        {
            pnlRapor.Show();
            pnlRapor.Controls.Clear();
            frmRapor_SabitKiymet_AmortismanTablolari frm = new frmRapor_SabitKiymet_AmortismanTablolari();
            frm.Dock = DockStyle.Fill;
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            pnlRapor.Controls.Add(frm);
            frm.Show();
        }

        private void btnSKEnflasyonFarklari_Click(object sender, EventArgs e)
        {
            pnlRapor.Show();
            pnlRapor.Controls.Clear();
            frmRapor_SabitKiymet_SKEnflasyonFarklari frm = new frmRapor_SabitKiymet_SKEnflasyonFarklari();
            frm.Dock = DockStyle.Fill;
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            pnlRapor.Controls.Add(frm);
            frm.Show();
        }

        private void btnAmortismanOzeti_Click(object sender, EventArgs e)
        {
            pnlRapor.Show();
            pnlRapor.Controls.Clear();
            frmRapor_SabitKiymet_AmortismanOzeti frm = new frmRapor_SabitKiymet_AmortismanOzeti();
            frm.Dock = DockStyle.Fill;
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            pnlRapor.Controls.Add(frm);
            frm.Show();
        }
    }
}
