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
    public partial class frmRapor : Form
    {
        public frmRapor()
        {
            InitializeComponent();
        }

        //**Formu fareyle tutarak hareket ettirmek için..
        bool move;
        int mouse_x;
        int mouse_y;

        private void frmRapor_Load(object sender, EventArgs e)
        {
            pnlAltMenu.Hide();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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

        private void btnStok_Click(object sender, EventArgs e)
        {
            pnlAltMenu.Show();
            pnlAltMenu.Controls.Clear();
            frmRapor_Stok frm = new frmRapor_Stok();
            frm.Dock = DockStyle.Fill;
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            pnlAltMenu.Controls.Add(frm);
            frm.Show();
        }

        private void btnFatura_Click(object sender, EventArgs e)
        {
            pnlAltMenu.Show();
            pnlAltMenu.Controls.Clear();
            frmRapor_Fatura frm = new frmRapor_Fatura();
            frm.Dock = DockStyle.Fill;
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            pnlAltMenu.Controls.Add(frm);
            frm.Show();
        }

        private void btnCariHesap_Click(object sender, EventArgs e)
        {
            pnlAltMenu.Show();
            pnlAltMenu.Controls.Clear();
            frmRapor_CariHesap frm = new frmRapor_CariHesap();
            frm.Dock = DockStyle.Fill;
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            pnlAltMenu.Controls.Add(frm);
            frm.Show();
        }

        private void btnKasa_Click(object sender, EventArgs e)
        {
            pnlAltMenu.Show();
            pnlAltMenu.Controls.Clear();
            frmRapor_Kasa frm = new frmRapor_Kasa();
            frm.Dock = DockStyle.Fill;
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            pnlAltMenu.Controls.Add(frm);
            frm.Show();
        }

        private void btnBanka_Click(object sender, EventArgs e)
        {
            pnlAltMenu.Show();
            pnlAltMenu.Controls.Clear();
            frmRapor_Banka frm = new frmRapor_Banka();
            frm.Dock = DockStyle.Fill;
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            pnlAltMenu.Controls.Add(frm);
            frm.Show();
        }

        private void btnCekSenet_Click(object sender, EventArgs e)
        {
            pnlAltMenu.Show();
            pnlAltMenu.Controls.Clear();
            frmRapor_CekSenet frm = new frmRapor_CekSenet();
            frm.Dock = DockStyle.Fill;
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            pnlAltMenu.Controls.Add(frm);
            frm.Show();
        }

        private void btnMuhasebe_Click(object sender, EventArgs e)
        {
            pnlAltMenu.Show();
            pnlAltMenu.Controls.Clear();
            frmRapor_Muhasebe frm = new frmRapor_Muhasebe();
            frm.Dock = DockStyle.Fill;
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            pnlAltMenu.Controls.Add(frm);
            frm.Show();
        }

        private void btnSabitKiymet_Click(object sender, EventArgs e)
        {
            pnlAltMenu.Show();
            pnlAltMenu.Controls.Clear();
            frmRapor_SabitKiymet frm = new frmRapor_SabitKiymet();
            frm.Dock = DockStyle.Fill;
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            pnlAltMenu.Controls.Add(frm);
            frm.Show();
        }
    }
}
