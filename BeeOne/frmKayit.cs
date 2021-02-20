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
    public partial class frmKayit : Form
    {
        public frmKayit()
        {
            InitializeComponent();
        }

        //**Formu fareyle tutarak hareket ettirmek için..
        bool move;
        int mouse_x;
        int mouse_y;

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
        //...**

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linklblfrmGiris_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmGiris frmGiris = new frmGiris();
            frmGiris.Show();
            this.Hide();
        }

        private void txtMailAdresi_Enter(object sender, EventArgs e)
        {
            if (txtMailAdresi.Text == "E-Posta")
            {
                txtMailAdresi.Text = "";
            }
        }

        private void txtMailAdresi_Leave(object sender, EventArgs e)
        {
            if (txtMailAdresi.Text == "")
            {
                txtMailAdresi.Text = "E-Posta";
            }
        }

        private void txtKullaniciAdi_Enter(object sender, EventArgs e)
        {
            if (txtKullaniciAdi.Text == "Kullanıcı adı")
            {
                txtKullaniciAdi.Text = "";
            }
        }

        private void txtKullaniciAdi_Leave(object sender, EventArgs e)
        {
            if (txtKullaniciAdi.Text == "")
            {
                txtKullaniciAdi.Text = "Kullanıcı adı";
            }
        }

        private void txtSifre_Enter(object sender, EventArgs e)
        {
            if (txtSifre.Text == "Şifre")
            {
                txtSifre.Text = "";
            }
        }

        private void txtSifre_Leave(object sender, EventArgs e)
        {
            if (txtSifre.Text == "")
            {
                txtSifre.Text = "Şifre";
            }
        }
    }
}
