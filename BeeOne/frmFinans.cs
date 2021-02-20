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
    public partial class frmFinans : Form
    {
        public frmFinans()
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

        private void btnKasaIslem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmL_Finans_KasaIslemleri"] == null)
            {
                frmL_Finans_KasaIslemleri form = new frmL_Finans_KasaIslemleri();
                form.Show();
            }
            else
                Application.OpenForms["frmL_Finans_KasaIslemleri"].Activate();
        }

        private void btnBankaIslem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmL_Finans_BankaIslemleri"] == null)
            {
                frmL_Finans_BankaIslemleri form = new frmL_Finans_BankaIslemleri();
                form.Show();
            }
            else
                Application.OpenForms["frmL_Finans_BankaIslemleri"].Activate();
        }

        private void btnCekSenet_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmL_Finans_CekSenet"] == null)
            {
                frmL_Finans_CekSenet form = new frmL_Finans_CekSenet();
                form.Show();
            }
            else
                Application.OpenForms["frmL_Finans_CekSenet"].Activate();
        }
    }
}
