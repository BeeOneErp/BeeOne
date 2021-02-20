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
    public partial class frmRapor_Stok : Form
    {
        public frmRapor_Stok()
        {
            InitializeComponent();
        }

        private void frmRapor_Stok_Load(object sender, EventArgs e)
        {

        }

        private void btnOzetMaliyet_Click(object sender, EventArgs e)
        {
            pnlRapor.Show();
            pnlRapor.Controls.Clear();
            frmRapor_Stok_OzetMaliyet frm = new frmRapor_Stok_OzetMaliyet();
            frm.Dock = DockStyle.Fill;
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            pnlRapor.Controls.Add(frm);
            frm.Show();
        }

        private void btnAyrintiliMaliyet_Click(object sender, EventArgs e)
        {
            pnlRapor.Show();
            pnlRapor.Controls.Clear();
            frmRapor_Stok_AyrintiliMaliyet frm = new frmRapor_Stok_AyrintiliMaliyet();
            frm.Dock = DockStyle.Fill;
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            pnlRapor.Controls.Add(frm);
            frm.Show();
        }

        private void btnMalzemeAmbar_Click(object sender, EventArgs e)
        {
            pnlRapor.Show();
            pnlRapor.Controls.Clear();
            frmRapor_Stok_MalzemeAmbar frm = new frmRapor_Stok_MalzemeAmbar();
            frm.Dock = DockStyle.Fill;
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            pnlRapor.Controls.Add(frm);
            frm.Show();
        }

        private void btnToplamSatinAlmaRakamlari_Click(object sender, EventArgs e)
        {
            pnlRapor.Show();
            pnlRapor.Controls.Clear();
            frmRapor_Stok_ToplamSatinAlmaRakamlari frm = new frmRapor_Stok_ToplamSatinAlmaRakamlari();
            frm.Dock = DockStyle.Fill;
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            pnlRapor.Controls.Add(frm);
            frm.Show();
        }

        private void btnToplamSatisRakamlari_Click(object sender, EventArgs e)
        {
            pnlRapor.Show();
            pnlRapor.Controls.Clear();
            frmRapor_Stok_ToplamSatisRakamlari frm = new frmRapor_Stok_ToplamSatisRakamlari();
            frm.Dock = DockStyle.Fill;
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            pnlRapor.Controls.Add(frm);
            frm.Show();
        }

        private void btnAyrintiliSatis_Click(object sender, EventArgs e)
        {
            pnlRapor.Show();
            pnlRapor.Controls.Clear();
            frmRapor_Stok_AyrintiliSatis frm = new frmRapor_Stok_AyrintiliSatis();
            frm.Dock = DockStyle.Fill;
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            pnlRapor.Controls.Add(frm);
            frm.Show();
        }

        private void btnAyrintiliSatinAlma_Click(object sender, EventArgs e)
        {
            pnlRapor.Show();
            pnlRapor.Controls.Clear();
            frmRapor_Stok_AyrintiliSatinAlma frm = new frmRapor_Stok_AyrintiliSatinAlma();
            frm.Dock = DockStyle.Fill;
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            pnlRapor.Controls.Add(frm);
            frm.Show();
        }

        private void btnEnvanter_Click(object sender, EventArgs e)
        {
            pnlRapor.Show();
            pnlRapor.Controls.Clear();
            frmRapor_Stok_Envanter frm = new frmRapor_Stok_Envanter();
            frm.Dock = DockStyle.Fill;
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            pnlRapor.Controls.Add(frm);
            frm.Show();
        }

        private void btnMalzemeListesi_Click(object sender, EventArgs e)
        {
            pnlRapor.Show();
            pnlRapor.Controls.Clear();
            frmRapor_Stok_MalzemeListesi frm = new frmRapor_Stok_MalzemeListesi();
            frm.Dock = DockStyle.Fill;
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            pnlRapor.Controls.Add(frm);
            frm.Show();
        }

        private void btnSatinAlmaSiparisleri_Click(object sender, EventArgs e)
        {
            pnlRapor.Show();
            pnlRapor.Controls.Clear();
            frmRapor_Stok_SatinAlmaSiparisleri frm = new frmRapor_Stok_SatinAlmaSiparisleri();
            frm.Dock = DockStyle.Fill;
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            pnlRapor.Controls.Add(frm);
            frm.Show();
        }

        private void btnSatisSiparisleri_Click(object sender, EventArgs e)
        {
            pnlRapor.Show();
            pnlRapor.Controls.Clear();
            frmRapor_Stok_SatisSiparisleri frm = new frmRapor_Stok_SatisSiparisleri();
            frm.Dock = DockStyle.Fill;
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            pnlRapor.Controls.Add(frm);
            frm.Show();
        }

        private void btnMalzemeFisleri_Click(object sender, EventArgs e)
        {
            pnlRapor.Show();
            pnlRapor.Controls.Clear();
            frmRapor_Stok_MalzemeFisleri frm = new frmRapor_Stok_MalzemeFisleri();
            frm.Dock = DockStyle.Fill;
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            pnlRapor.Controls.Add(frm);
            frm.Show();
        }

        private void btnMalzemeHareketleri_Click(object sender, EventArgs e)
        {
            pnlRapor.Show();
            pnlRapor.Controls.Clear();
            frmRapor_Stok_MalzemeHareketleri frm = new frmRapor_Stok_MalzemeHareketleri();
            frm.Dock = DockStyle.Fill;
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            pnlRapor.Controls.Add(frm);
            frm.Show();
        }

        private void btnMalzemeEkstresi_Click(object sender, EventArgs e)
        {
            pnlRapor.Show();
            pnlRapor.Controls.Clear();
            frmRapor_Stok_MalzemeEkstresi frm = new frmRapor_Stok_MalzemeEkstresi();
            frm.Dock = DockStyle.Fill;
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            pnlRapor.Controls.Add(frm);
            frm.Show();
        }
    }
}
