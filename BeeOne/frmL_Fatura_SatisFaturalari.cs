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
    public partial class frmL_Fatura_SatisFaturalari : Form
    {
        public frmL_Fatura_SatisFaturalari()
        {
            InitializeComponent();
            DatagridviewSetting(dataGridViewSatisFaturalari);
        }

        bool move;
        int mouse_x;
        int mouse_y;

        public void DatagridviewSetting(DataGridView datagridView)
        {
            dataGridViewSatisFaturalari.RowHeadersVisible = false;
            datagridView.BorderStyle = BorderStyle.None;
            datagridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(50, 50, 50);
            datagridView.DefaultCellStyle.SelectionBackColor = Color.FromArgb(45, 45, 45);
            dataGridViewSatisFaturalari.DefaultCellStyle.ForeColor = Color.White;
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
            if (Application.OpenForms["frmFatura_SatisFaturalari"] == null)
            {
                frmFatura_SatisFaturalari form = new frmFatura_SatisFaturalari();
                form.Show();
            }
            else
                Application.OpenForms["frmFatura_SatisFaturalari"].Activate();
        }

        private void cbxFaturaTuru_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmL_Fatura_SatisFaturalari_Load(object sender, EventArgs e)
        {

            string yol = Metodlar.GlobalClass.baglanti;
            SqlConnection baglan = new SqlConnection(yol);
            string frmno = Metodlar.GlobalClass.firmano;

            string satis_ft_tablo = "ONE_" + frmno + "_KSCARD";

            string list_query = "SELECT  CASE WHEN CANCELLED = 1 THEN 'İ' ELSE(CASE WHEN ACCOUNTED = 0 THEN '' ELSE 'M' END) END Durumu," +
"   case when TRCODE = 1 then 'Satınalma Faturası' WHEN TRCODE = 2 then 'Satış İade Faturası' " +
" WHEN TRCODE = 6 then 'Satınalma İade Faturası' WHEN TRCODE = 7 then 'Satış Faturası' " +
" end[Fiş Türü], convert(varchar, DATE_, 104)[Tarihi],STF.FICHENO[Fiş Numarası], DOCODE[Belge No] ," +
  " ISNULL(cl.DEFINITION_, '')[Cari Hesap], NETTOTAL[Tutar], EXCHNETTOTAL[Dövizli Tutar],ISNULL(SL.CODE, '')[Satış Elemanı] FROM ONE_" + frmno +
  "_INVOICE STF LEFT JOIN ONE_" + frmno + "_CLCARD CL ON STF.CLIENTREF = CL.LOGICALREF left join ONE_" + frmno + "_SALESMAN SL ON STF.SALESMANREF = SL.LOGICALREF WHERE TRCODE IN(1, 2, 6, 7) and GRPCODE = 2";

            SqlDataAdapter da = new SqlDataAdapter(list_query.ToString(), baglan);
            DataSet ds = new DataSet();
            baglan.Open();
            da.Fill(ds, satis_ft_tablo);
            dataGridViewSatisFaturalari.DataSource = ds.Tables[satis_ft_tablo];
            baglan.Close();
        }
    }
}
