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
    public partial class frmFatura : Form
    {
        public frmFatura()
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

        private void btnSatisFatura_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmL_Fatura_SatisFaturalari"] == null)
            {
                frmL_Fatura_SatisFaturalari form = new frmL_Fatura_SatisFaturalari();
                form.Show();
            }
            else
                Application.OpenForms["frmL_Fatura_SatisFaturalari"].Activate();
        }

        private void btnSatinAlmaFatura_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmL_Fatura_SatinAlmaFaturalari"] == null)
            {
                frmL_Fatura_SatinAlmaFaturalari form = new frmL_Fatura_SatinAlmaFaturalari();
                form.Show();
            }
            else
                Application.OpenForms["frmL_Fatura_SatinAlmaFaturalari"].Activate();
        }
    }
}
