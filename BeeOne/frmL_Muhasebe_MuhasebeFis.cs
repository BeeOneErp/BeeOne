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
    public partial class frmL_Muhasebe_MuhasebeFis : Form
    {
        public frmL_Muhasebe_MuhasebeFis()
        {
            InitializeComponent();
            DatagridviewSetting(dataGridViewMuhasebeFis);
        }

        bool move;
        int mouse_x;
        int mouse_y;

        public void DatagridviewSetting(DataGridView datagridView)
        {
            dataGridViewMuhasebeFis.RowHeadersVisible = false;
            datagridView.BorderStyle = BorderStyle.None;
            datagridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(50, 50, 50);
            datagridView.DefaultCellStyle.SelectionBackColor = Color.FromArgb(45, 45, 45);
            dataGridViewMuhasebeFis.DefaultCellStyle.ForeColor = Color.White;
            datagridView.DefaultCellStyle.SelectionForeColor = Color.Khaki;
            datagridView.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Times New Roman", 10);
            datagridView.EnableHeadersVisualStyles = false;
            datagridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None; //Başlık çizgilerini kaldırıyor.
            datagridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(40, 40, 40);
            datagridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            datagridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            datagridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void pnlTop_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            mouse_x = e.X;
            mouse_y = e.Y;
        }

        private void pnlTop_MouseMove(object sender, MouseEventArgs e)
        {
            if (move == true)
            {
                this.SetDesktopLocation(MousePosition.X - mouse_x, MousePosition.Y - mouse_y);
            }
        }

        private void pnlTop_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmMuhasebe_MuhasebeFisleri"] == null)
            {
                frmMuhasebe_MuhasebeFisleri form = new frmMuhasebe_MuhasebeFisleri();
                form.Show();
            }
            else
                Application.OpenForms["frmMuhasebe_MuhasebeFisleri"].Activate();
        }

        private void frmL_Muhasebe_MuhasebeFis_Load(object sender, EventArgs e)
        {

            string yol = Metodlar.GlobalClass.baglanti;
            SqlConnection baglan = new SqlConnection(yol);
            string frmno = Metodlar.GlobalClass.firmano;

            string muh_fis_tablo = "ONE_" + frmno + "_EMFICHE";

            string list_query = "SELECT  convert(varchar, DATE_, 104)[Tarihi],FICHENO[Fiş Numarası],"+
"case when TRCODE = 1 then 'Açılış Fişi' WHEN TRCODE = 2 then 'Tahsil Fişi' when TRCODE = 3 then 'Tediye Fişi' WHEN TRCODE = 4 then 'Mahsup Fişi'"+
" end[Fiş Türü], DOCODE[Belge No],DEBIT Borç, CREDIT Alacak,GENEXP1[Açıklama],SPECODE[Özel Kod],JOURNALNO[Yevmiye Madde No] FROM ONE_" + frmno + "_EMFICHE";


            SqlDataAdapter da = new SqlDataAdapter(list_query.ToString(), baglan);
            DataSet ds = new DataSet();
            baglan.Open();
            da.Fill(ds, muh_fis_tablo);
            dataGridViewMuhasebeFis.DataSource = ds.Tables[muh_fis_tablo];
            baglan.Close();


        }
    }
}
