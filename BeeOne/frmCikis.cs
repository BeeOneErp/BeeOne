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
    public partial class frmCikis : Form
    {
        public frmCikis()
        {
            InitializeComponent();
        }

       
        private void frmCikis_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void frmCikis_Load(object sender, EventArgs e)
        {

        }


        private void btnCik_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOturumuKapat_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
