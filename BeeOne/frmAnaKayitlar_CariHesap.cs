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
    public partial class frmAnaKayitlar_CariHesap : Form
    {
        public frmAnaKayitlar_CariHesap()
        {
            InitializeComponent();
        }

        bool move;
        int mouse_x;
        int mouse_y;

        private void frmAnaKayitlar_CariHesap_Load(object sender, EventArgs e)
        {
            pnlIslem.Visible = false;
        }

        private void btnIletisim_Click(object sender, EventArgs e)
        {
            pnlIslem.Show();
            pnlIslem.Controls.Clear();
            frmAnaKayitlar_CariHesap_Iletisim frm = new frmAnaKayitlar_CariHesap_Iletisim();
            frm.Dock = DockStyle.Fill;
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            pnlIslem.Controls.Add(frm);
            frm.Show();
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

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTicariBilgiler_Click(object sender, EventArgs e)
        {
            pnlIslem.Show();
            pnlIslem.Controls.Clear();
            frmAnaKayitlar_CariHesap_TicariBilgiler frm = new frmAnaKayitlar_CariHesap_TicariBilgiler();
            frm.Dock = DockStyle.Fill;
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            pnlIslem.Controls.Add(frm);
            frm.Show();
        }

        private void btnDiger_Click(object sender, EventArgs e)
        {
            pnlIslem.Show();
            pnlIslem.Controls.Clear();
            frmAnaKayitlar_CariHesap_Diger frm = new frmAnaKayitlar_CariHesap_Diger();
            frm.Dock = DockStyle.Fill;
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            pnlIslem.Controls.Add(frm);
            frm.Show();
        }

        private void btnVazgec_Click(object sender, EventArgs e)
        {
            
        }
    }
}
