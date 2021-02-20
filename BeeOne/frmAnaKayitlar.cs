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
    public partial class frmAnaKayitlar : Form
    {
        public frmAnaKayitlar()
        {
            InitializeComponent();
        }

        bool move;
        int mouse_x;
        int mouse_y;

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pnlTop_MouseMove(object sender, MouseEventArgs e)
        {
            if (move == true)
            {
                this.SetDesktopLocation(MousePosition.X - mouse_x, MousePosition.Y - mouse_y);
            }
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

        private void btnSabitKiymet_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmL_AnaKayitlar_SabitKiymet"] == null)
            {
                frmL_AnaKayitlar_SabitKiymet form = new frmL_AnaKayitlar_SabitKiymet();
                form.Show();
            }
            else
                Application.OpenForms["frmL_AnaKayitlar_SabitKiymet"].Activate();
        }

        private void btnBanka_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmL_AnaKayitlar_Banka"] == null)
            {
                frmL_AnaKayitlar_Banka form = new frmL_AnaKayitlar_Banka();
                form.Show();
            }
            else
                Application.OpenForms["frmL_AnaKayitlar_Banka"].Activate();
        }

        private void btnKasa_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmL_AnaKayitlar_Kasa"] == null)
            {
                frmL_AnaKayitlar_Kasa form = new frmL_AnaKayitlar_Kasa();
                form.Show();
            }
            else
                Application.OpenForms["frmL_AnaKayitlar_Kasa"].Activate();
        }

        private void btnCariHesap_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmL_AnaKayitlar_CariHesap"] == null)
            {
                frmL_AnaKayitlar_CariHesap form = new frmL_AnaKayitlar_CariHesap();
                form.Show();
            }
            else
                Application.OpenForms["frmL_AnaKayitlar_CariHesap"].Activate();
        }

        private void btnMuhasebe_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmL_AnaKayitlar_Muhasebe"] == null)
            {
                frmL_AnaKayitlar_Muhasebe form = new frmL_AnaKayitlar_Muhasebe();
                form.Show();
            }
            else
                Application.OpenForms["frmL_AnaKayitlar_Muhasebe"].Activate();
        }

        private void btnStok_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmL_AnaKayitlar_Stok"] == null)
            {
                frmL_AnaKayitlar_Stok form = new frmL_AnaKayitlar_Stok();
                form.Show();
            }
            else
                Application.OpenForms["frmL_AnaKayitlar_Stok"].Activate();
        }
    }
}
