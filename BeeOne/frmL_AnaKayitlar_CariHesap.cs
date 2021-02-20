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
    public partial class frmL_AnaKayitlar_CariHesap : Form
    {
        public frmL_AnaKayitlar_CariHesap()
        {
            InitializeComponent();
            DatagridviewSetting(dataGridViewCariHesap);
        }

        bool move;
        int mouse_x;
        int mouse_y;

        public void DatagridviewSetting(DataGridView datagridView)
        {
            dataGridViewCariHesap.RowHeadersVisible = false;
            datagridView.BorderStyle = BorderStyle.None;
            datagridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(50, 50, 50);
            datagridView.DefaultCellStyle.SelectionBackColor = Color.FromArgb(45, 45, 45);
            dataGridViewCariHesap.DefaultCellStyle.ForeColor = Color.White;
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
            if (Application.OpenForms["frmAnaKayitlar_CariHesap"] == null)
            {
                frmAnaKayitlar_CariHesap form = new frmAnaKayitlar_CariHesap();
                form.Show();
            }
            else
                Application.OpenForms["frmAnaKayitlar_CariHesap"].Activate();
        }

        private void frmL_AnaKayitlar_CariHesap_Load(object sender, EventArgs e)
        {
            string yol = Metodlar.GlobalClass.baglanti;
            SqlConnection baglan = new SqlConnection(yol);
            string frmno = Metodlar.GlobalClass.firmano;

            string ch_tablo = "ONE_" + frmno + "_CLCARD";

            string list_query = "SELECT CODE [Cari Hesap Kodu],DEFINITION_ [Cari Hesap Unvanı],DEFINITION2 [Cari Hesap Unvanı 2]," +
                " SPECODE [Özel Kod],CITY [Şehir],(ISNULL(BORC,0)-ISNULL(ALACAK,0)) [Bakiye] FROM ONE_" + frmno + "_CLCARD CL LEFT JOIN" +
" (select CLIENTREF, SUM(AMOUNT)ALACAK from ONE_" + frmno + "_CLFLINE WHERE CANCELLED = 0 AND TRCODE IN(2, 4, 9, 12) GROUP BY CLIENTREF)A" +
" ON CL.LOGICALREF = A.CLIENTREF LEFT JOIN  (select CLIENTREF, SUM(AMOUNT) BORC from ONE_" + frmno + "_CLFLINE WHERE CANCELLED = 0" +
" AND TRCODE IN(1,3,10,11) GROUP BY CLIENTREF)B ON CL.LOGICALREF = B.CLIENTREF order by CL.DEFINITION_ ASC";

            SqlDataAdapter da = new SqlDataAdapter(list_query.ToString(), baglan);
            DataSet ds = new DataSet();
            baglan.Open();
            da.Fill(ds, ch_tablo);
            dataGridViewCariHesap.DataSource = ds.Tables[ch_tablo];
            baglan.Close();

        }
    }
}
