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
    public partial class frmStokIslemleri : Form
    {
        public frmStokIslemleri()
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

        private void btnSatinAlmaSiparis_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmL_StokIslemleri_SatinAlmaSiparisleri"] == null)
            {
                frmL_StokIslemleri_SatinAlmaSiparisleri form = new frmL_StokIslemleri_SatinAlmaSiparisleri();
                form.Show();
            }
            else
                Application.OpenForms["frmL_StokIslemleri_SatinAlmaSiparisleri"].Activate();
        }

        private void btnSatisSiparis_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmL_StokIslemleri_SatisSiparisleri"] == null)
            {
                frmL_StokIslemleri_SatisSiparisleri form = new frmL_StokIslemleri_SatisSiparisleri();
                form.Show();
            }
            else
                Application.OpenForms["frmL_StokIslemleri_SatisSiparisleri"].Activate();
        }

        private void btnSatisIrsaliye_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmL_StokIslemleri_SatisIrsaliye"] == null)
            {
                frmL_StokIslemleri_SatisIrsaliye form = new frmL_StokIslemleri_SatisIrsaliye();
                form.Show();
            }
            else
                Application.OpenForms["frmL_StokIslemleri_SatisIrsaliye"].Activate();
        }

        private void btnSatinAlmaIrsaliye_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmL_StokIslemleri_SatinAlmaIrsaliye"] == null)
            {
                frmL_StokIslemleri_SatinAlmaIrsaliye form = new frmL_StokIslemleri_SatinAlmaIrsaliye();
                form.Show();
            }
            else
                Application.OpenForms["frmL_StokIslemleri_SatinAlmaIrsaliye"].Activate();
        }

        private void btnMalzemeFis_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmL_StokIslemleri_MalzemeFis"] == null)
            {
                frmL_StokIslemleri_MalzemeFis form = new frmL_StokIslemleri_MalzemeFis();
                form.Show();
            }
            else
                Application.OpenForms["frmL_StokIslemleri_MalzemeFis"].Activate();
        }

        private void btnMaliyetFis_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmL_StokIslemleri_MaliyetFis"] == null)
            {
                frmL_StokIslemleri_MaliyetFis form = new frmL_StokIslemleri_MaliyetFis();
                form.Show();
            }
            else
                Application.OpenForms["frmL_StokIslemleri_MaliyetFis"].Activate();
        }
    }
}
