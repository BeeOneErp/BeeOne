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
    public partial class frmL_StokIslemleri_MalzemeFis : Form
    {
        public frmL_StokIslemleri_MalzemeFis()
        {
            InitializeComponent();
            DatagridviewSetting(dataGridViewMalzemeFis);
        }

        bool move;
        int mouse_x;
        int mouse_y;

        public void DatagridviewSetting(DataGridView datagridView)
        {
            dataGridViewMalzemeFis.RowHeadersVisible = false;
            datagridView.BorderStyle = BorderStyle.None;
            datagridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(50, 50, 50);
            datagridView.DefaultCellStyle.SelectionBackColor = Color.FromArgb(45, 45, 45);
            dataGridViewMalzemeFis.DefaultCellStyle.ForeColor = Color.White;
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
            if (Application.OpenForms["frmStokIslemleri_MalzemeFisleri"] == null)
            {
                frmStokIslemleri_MalzemeFisleri form = new frmStokIslemleri_MalzemeFisleri();
                form.Show();
            }
            else
                Application.OpenForms["frmStokIslemleri_MalzemeFisleri"].Activate();
        }

        private void frmL_StokIslemleri_MalzemeFis_Load(object sender, EventArgs e)
        {
            string yol = Metodlar.GlobalClass.baglanti;
            SqlConnection baglan = new SqlConnection(yol);
            string frmno = Metodlar.GlobalClass.firmano;

            string stok_fis_tablo = "ONE_" + frmno + "_MLZFICHE";

            string list_query = "SELECT CASE WHEN CANCELLED = 1 THEN 'İ' ELSE(CASE WHEN INVOICEREF = 0 THEN '' ELSE 'F' END) END Durumu," +
   " case when TRCODE = 1 then 'Satınalma İrsaliyesi' WHEN TRCODE = 2 then 'Satış İade İrsaliyesi' " +
" WHEN TRCODE = 6 then 'Satınalma İade İrsaliyesi'  WHEN TRCODE = 7 then 'Satış İrsaliyesi' " +
" WHEN TRCODE = 11 then 'Fire Fişi' WHEN TRCODE = 12 then 'Sarf Fişi' WHEN TRCODE = 13 then 'Üretimden Giriş Fişi' " +
" WHEN TRCODE = 25 then 'Ambar Fişi' WHEN TRCODE = 50 then 'Sayım Fazlası Fişi' WHEN TRCODE = 51 then 'Sayım Eksiği Fişi' " +
" ELSE 'Devir Fişi' end[Fiş Türü], convert(varchar, DATE_, 104)[Tarihi],STF.FICHENO[Fiş Numarası], DOCODE[Belge No] ," +
" ISNULL(cl.DEFINITION_, '')[Cari Hesap], NETTOTAL[Tutar], EXCHNETTOTAL[Dövizli Tutar],ISNULL(SL.CODE, '')[Satış Elemanı] " +
"FROM ONE_" + frmno + "_STFICHE STF LEFT JOIN ONE_" + frmno + "_CLCARD CL ON STF.CLIENTREF = CL.LOGICALREF left join ONE_" + frmno + "_SALESMAN SL " +
" ON STF.SALESMANREF = SL.LOGICALREF where TRCODE IN(11, 12, 13, 25, 50, 51)";

            SqlDataAdapter da = new SqlDataAdapter(list_query.ToString(), baglan);
            DataSet ds = new DataSet();
            baglan.Open();
            da.Fill(ds, stok_fis_tablo);
            dataGridViewMalzemeFis.DataSource = ds.Tables[stok_fis_tablo];
            baglan.Close();
        }
    }
}
