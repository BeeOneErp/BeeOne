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
    public partial class frmSifreSifirla : Form
    {
        public frmSifreSifirla()
        {
            InitializeComponent();
        }

        //**Formu fareyle tutarak hareket ettirmek için..
        bool move;
        int mouse_x;
        int mouse_y;

        private void btnDevam_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmGuvenlikKodu frm = new frmGuvenlikKodu();
            frm.Show();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
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
    }
}
