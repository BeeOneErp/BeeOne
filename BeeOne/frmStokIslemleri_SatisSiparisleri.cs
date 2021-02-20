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
    public partial class frmStokIslemleri_SatisSiparisleri : Form
    {
        public frmStokIslemleri_SatisSiparisleri()
        {
            InitializeComponent();
        }

        bool move;
        int mouse_x;
        int mouse_y;

        private void btnFis_Click(object sender, EventArgs e)
        {
            pnlIslem.Show();
            pnlIslem.Controls.Clear();
            frmStokIslemleri_SatisSiparisleri_Fis frm = new frmStokIslemleri_SatisSiparisleri_Fis();
            frm.Dock = DockStyle.Fill;
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            pnlIslem.Controls.Add(frm);
            frm.Show();
        }

        private void btnDetaylar_Click(object sender, EventArgs e)
        {
            pnlIslem.Show();
            pnlIslem.Controls.Clear();
            frmStokIslemleri_SatisSiparisleri_Detay frm = new frmStokIslemleri_SatisSiparisleri_Detay();
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

        private void frmStokIslemleri_SatisSiparisleri_Load(object sender, EventArgs e)
        {
            pnlIslem.Visible = false;
        }

        private void btnVazgec_Click(object sender, EventArgs e)
        {
            
        }
    }
}
