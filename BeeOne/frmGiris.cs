using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeeOne
{
    public partial class frmGiris : Form
    {
       
        public frmGiris()
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

        private void linklblfrmKayit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmKayit frmKayit = new frmKayit();
            frmKayit.Show();
            this.Hide();
        }

        private void txtKullaniciAdi_Enter(object sender, EventArgs e)
        {
            if(txtKullaniciAdi.Text == "Kullanıcı adı")
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
                txtSifre.isPassword = true;
            }
        }

        private void txtSifre_Leave(object sender, EventArgs e)
        {
            if (txtSifre.Text == "")
            {
                txtSifre.Text = "Şifre";
                txtSifre.isPassword = false;
            }
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
           
            frmArayuz frmArayuz = new frmArayuz();
            frmArayuz.kullaniciadi = txtKullaniciAdi.Text;
            Metodlar.GlobalClass.firmano = cbxfirma.ValueMember.ToString();
            frmArayuz.Show();
            this.Hide();
        }

        private void linklblSifremiUnuttum_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmSifreSifirla frm = new frmSifreSifirla();
            frm.Show();
        }

        private void frmGiris_Load(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection();
            baglanti.ConnectionString = Metodlar.GlobalClass.baglanti;
            SqlCommand komut = new SqlCommand();
            komut.CommandText = "SELECT NR, '('+NR+') '+FRMNAME AS FRMAD FROM ONE_FIRMS";
            komut.Connection = baglanti;
            komut.CommandType = CommandType.Text;

            SqlDataReader dr;
            baglanti.Open();
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
               cbxfirma.Items.Add(dr["FRMAD"]);
                cbxfirma.ValueMember = dr["NR"].ToString();
            }
            baglanti.Close();
        }
    }
}
