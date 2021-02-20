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
    public partial class frmL_StokIslemleri_MaliyetFis : Form
    {
        public frmL_StokIslemleri_MaliyetFis()
        {
            InitializeComponent();
            DatagridviewSetting(dataGridViewMaliyetFis);
        }

        bool move;
        int mouse_x;
        int mouse_y;

        public void DatagridviewSetting(DataGridView datagridView)
        {
            dataGridViewMaliyetFis.RowHeadersVisible = false;
            datagridView.BorderStyle = BorderStyle.None;
            datagridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(50, 50, 50);
            datagridView.DefaultCellStyle.SelectionBackColor = Color.FromArgb(45, 45, 45);
            dataGridViewMaliyetFis.DefaultCellStyle.ForeColor = Color.White;
            datagridView.DefaultCellStyle.SelectionForeColor = Color.Khaki;
            datagridView.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Times New Roman", 10);
            datagridView.EnableHeadersVisualStyles = false;
            datagridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None; //Başlık çizgilerini kaldırıyor.
            datagridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(40, 40, 40);
            datagridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            datagridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            datagridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
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

        private void pnlTop_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            mouse_x = e.X;
            mouse_y = e.Y;
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
            if (Application.OpenForms["frmStokIslemleri_MaliyetFisleri"] == null)
            {
                frmStokIslemleri_MaliyetFisleri form = new frmStokIslemleri_MaliyetFisleri();
                form.Show();
            }
            else
                Application.OpenForms["frmStokIslemleri_MaliyetFisleri"].Activate();
        }

        private void frmL_StokIslemleri_MaliyetFis_Load(object sender, EventArgs e)
        {
            string yol = Metodlar.GlobalClass.baglanti;
            SqlConnection baglan = new SqlConnection(yol);
            string frmno = Metodlar.GlobalClass.firmano;

            string maliyet_tablo = "ONE_" + frmno + "_COST";

            string maliyet_list_query = "SELECT DATE_ Tarih, FICHENO[Fiş No], cl.CODE[Cari Hesap Kodu],CL.DEFINITION_[Unvanı]," +
                " INVNO[Fatura No],IT.CODE[Stok Kodu],IT.ITEM_NAME[Adı],AMOUNT Tutar FROM ONE_" + frmno + "_COST CS LEFT JOIN ONE_" + frmno + "_CLCARD CL " +
                " ON CS.CLIENTREF = CL.LOGICALREF LEFT JOIN ONE_" + frmno + "_ITEMS IT ON CS.STOCKREF = IT.LOGICALREF";


            SqlDataAdapter da = new SqlDataAdapter(maliyet_list_query.ToString(), baglan);
            DataSet ds = new DataSet();
            baglan.Open();
            da.Fill(ds, maliyet_tablo);
            dataGridViewMaliyetFis.DataSource = ds.Tables[maliyet_tablo];
            baglan.Close();

        }
    }
}
