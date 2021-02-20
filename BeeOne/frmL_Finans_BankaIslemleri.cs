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
    public partial class frmL_Finans_BankaIslemleri : Form
    {
        public frmL_Finans_BankaIslemleri()
        {
            InitializeComponent();
            DatagridviewSetting(dataGridViewBanka);
        }

        bool move;
        int mouse_x;
        int mouse_y;

        public void DatagridviewSetting(DataGridView datagridView)
        {
            dataGridViewBanka.RowHeadersVisible = false;
            datagridView.BorderStyle = BorderStyle.None;
            datagridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(50, 50, 50);
            datagridView.DefaultCellStyle.SelectionBackColor = Color.FromArgb(45, 45, 45);
            dataGridViewBanka.DefaultCellStyle.ForeColor = Color.White;
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
            if (Application.OpenForms["frmFinans_BankaIslemleri"] == null)
            {
                frmFinans_BankaIslemleri form = new frmFinans_BankaIslemleri();
                form.Show();
            }
            else
                Application.OpenForms["frmFinans_BankaIslemleri"].Activate();
        }

        private void frmL_Finans_BankaIslemleri_Load(object sender, EventArgs e)
        {
            string yol = Metodlar.GlobalClass.baglanti;
            SqlConnection baglan = new SqlConnection(yol);
            string frmno = Metodlar.GlobalClass.firmano;

            string bn_fis_tablo = "ONE_" + frmno + "_BNFICHE";

            string list_query = "SELECT  CASE WHEN CANCELLED = 1 THEN 'İ' ELSE(CASE WHEN ACCOUNTED = 1 THEN 'M'  ELSE '' END) END[Durumu], " +
" case when TRCODE = 3 then 'Gelen Havale/Eft' WHEN TRCODE = 4 then 'Gönderilen Havale/Eft' end[Fiş Türü]," +
" convert(varchar, DATE_, 104)[Tarihi],FICHENO[Fiş Numarası], bnf.DEBITTOT Borç, CREDITTOT Alacak,bnf.GENEXP[Açıklama] FROM ONE_" +
frmno + "_BNFICHE BNF ";

            SqlDataAdapter da = new SqlDataAdapter(list_query.ToString(), baglan);
            DataSet ds = new DataSet();
            baglan.Open();
            da.Fill(ds, bn_fis_tablo);
            dataGridViewBanka.DataSource = ds.Tables[bn_fis_tablo];
            baglan.Close();
        }
    }
}
