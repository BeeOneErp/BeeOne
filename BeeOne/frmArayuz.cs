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
    public partial class frmArayuz : Form
    {
        public String kullaniciadi;
        public frmArayuz()
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

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnRestoreDown_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmCikis"] == null)
            {
                frmCikis form1 = new frmCikis();
                form1.Show();
            }
            else
                Application.OpenForms["frmCikis"].Activate();
        }

        private void frmArayuz_Load(object sender, EventArgs e)
        {
            
            lblKullaniciAdi.Text = kullaniciadi;


            timer1.Start();
            pnlKullanici.Visible = false;
        }

        private void btnKullanici_Click(object sender, EventArgs e)
        {
            pnlKullanici.Visible = true;
        }

        private void frmArayuz_MouseMove(object sender, MouseEventArgs e)
        {
            pnlKullanici.Visible = false;
        }

        private void btnKullanici_MouseMove(object sender, MouseEventArgs e)
        {
            pnlKullanici.Visible = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTarih.Text = DateTime.Now.ToLongDateString();
            lblSaat.Text = DateTime.Now.ToLongTimeString();
        }

        private void btnSifreDegistir_Click(object sender, EventArgs e)
        {
            frmSifreSifirla frm = new frmSifreSifirla();
            frm.Show();
        }

        private void btnOturumKapat_Click(object sender, EventArgs e)
        {

        }

        private void pnlRenk_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAnaKayit_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmAnaKayitlar"] == null)
            {
                frmAnaKayitlar frmAnaKayit = new frmAnaKayitlar();
                frmAnaKayit.Show();
            }
            else
                Application.OpenForms["frmAnaKayitlar"].Activate();            
        }

        private void btnStokIslemi_Click(object sender, EventArgs e)
        {

            if (Application.OpenForms["frmStokIslemleri"] == null)
            {
                frmStokIslemleri frmStok = new frmStokIslemleri();
                frmStok.Show();
            }
            else
                Application.OpenForms["frmStokIslemleri"].Activate();           
        }

        private void btnCariHesap_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmL_CariHesap"] == null)
            {
                frmL_CariHesap frm = new frmL_CariHesap();
                frm.Show();
            }
            else
                Application.OpenForms["frmL_CariHesap"].Activate();
        }

        private void btnFatura_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmFatura"] == null)
            {
                frmFatura frmFatura = new frmFatura();
                frmFatura.Show();
            }
            else
                Application.OpenForms["frmFatura"].Activate();           
        }

        private void btnFinans_Click(object sender, EventArgs e)
        {

            if (Application.OpenForms["frmFinans"] == null)
            {
                frmFinans frmFinans = new frmFinans();
                frmFinans.Show();
            }
            else
                Application.OpenForms["frmFinans"].Activate();
        }

        private void btnMuhasebe_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmMuhasebe"] == null)
            {
                frmMuhasebe frmMuhasebe = new frmMuhasebe();
                frmMuhasebe.Show();
            }
            else
                Application.OpenForms["frmMuhasebe"].Activate();           
        }

        private void btnSabitKiymet_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmL_SabitKiymet"] == null)
            {
                frmL_SabitKiymet frm = new frmL_SabitKiymet();
                frm.Show();
            }
            else
                Application.OpenForms["frmL_SabitKiymet"].Activate();
        }

        private void btnRapor_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmRapor"] == null)
            {
                frmRapor frmRapor = new frmRapor();
                frmRapor.Show();
            }
            else
                Application.OpenForms["frmRapor"].Activate();            
        }

        private void btnSistemKodlari_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmSistemKodlari"] == null)
            {
                frmSistemKodlari frm = new frmSistemKodlari();
                frm.Show();
            }
            else
                Application.OpenForms["frmSistemKodlari"].Activate();
        }

        private void btnYardim_Click(object sender, EventArgs e)
        {

        }
    }
}
