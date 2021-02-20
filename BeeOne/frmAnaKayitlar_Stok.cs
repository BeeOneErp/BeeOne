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
    public partial class frmAnaKayitlar_Stok : Form
    {
        public String kartturu;
        public frmAnaKayitlar_Stok()
        {
            InitializeComponent();
        }

        bool move;
        int mouse_x;
        int mouse_y;

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

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

        private void frmAnaKayitlar_Stok_Load(object sender, EventArgs e)
        {

            comboBoxKartTuru.SelectedItem = kartturu;
            
            pnlIslem.Visible = false;
        }

        private void btnGenelBilgiler_Click(object sender, EventArgs e)
        {
            pnlIslem.Show();
            pnlIslem.Controls.Clear();
            frmAnaKayitlar_Stok_GenelBilgiler frm = new frmAnaKayitlar_Stok_GenelBilgiler();
            frm.Dock = DockStyle.Fill;
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            pnlIslem.Controls.Add(frm);
            frm.Show();
        }

        private void btnAlternatifMalzemeler_Click(object sender, EventArgs e)
        {
            pnlIslem.Show();
            pnlIslem.Controls.Clear();
            frmAnaKayitlar_Stok_AlternatifMalzemeler frm = new frmAnaKayitlar_Stok_AlternatifMalzemeler();
            frm.Dock = DockStyle.Fill;
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            pnlIslem.Controls.Add(frm);
            frm.Show();
        }

        private void btnMuhasebeHesaplari_Click(object sender, EventArgs e)
        {
            pnlIslem.Show();
            pnlIslem.Controls.Clear();
            frmAnaKayitlar_Stok_MuhasebeHesaplari frm = new frmAnaKayitlar_Stok_MuhasebeHesaplari();
            frm.Dock = DockStyle.Fill;
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            pnlIslem.Controls.Add(frm);
            frm.Show();
        }

        private void btnFiyatBilgisi_Click(object sender, EventArgs e)
        {
            pnlIslem.Show();
            pnlIslem.Controls.Clear();
            frmAnaKayitlar_Stok_FiyatBilgisi frm = new frmAnaKayitlar_Stok_FiyatBilgisi();
            frm.Dock = DockStyle.Fill;
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            pnlIslem.Controls.Add(frm);
            frm.Show();
        }

        private void btnVazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
