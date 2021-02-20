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
    public partial class frmL_StokIslemleri_SatisSiparisleri : Form
    {
        public frmL_StokIslemleri_SatisSiparisleri()
        {
            InitializeComponent();
            DatagridviewSetting(dataGridViewSatisSiparisleri);
        }

        bool move;
        int mouse_x;
        int mouse_y;

        public void DatagridviewSetting(DataGridView datagridView)
        {
            dataGridViewSatisSiparisleri.RowHeadersVisible = false;
            datagridView.BorderStyle = BorderStyle.None;
            datagridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(50, 50, 50);
            datagridView.DefaultCellStyle.SelectionBackColor = Color.FromArgb(45, 45, 45);
            dataGridViewSatisSiparisleri.DefaultCellStyle.ForeColor = Color.White;
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
            if (Application.OpenForms["frmStokIslemleri_SatisSiparisleri"] == null)
            {
                frmStokIslemleri_SatisSiparisleri form = new frmStokIslemleri_SatisSiparisleri();
                form.Show();
            }
            else
                Application.OpenForms["frmStokIslemleri_SatisSiparisleri"].Activate();
        }

        private void btnStatu_Click(object sender, EventArgs e)
        {
            DurumPaneli.Visible = true;
        }

        private void frmL_StokIslemleri_SatisSiparisleri_Load(object sender, EventArgs e)
        {
            string yol = Metodlar.GlobalClass.baglanti;
            SqlConnection baglan = new SqlConnection(yol);
            string frmno = Metodlar.GlobalClass.firmano;

            string satis_sip_tablo = "ONE_" + frmno + "_ORFICHE2";

            string list_query = "SELECT CASE WHEN CANCELLED = 1 THEN 'İ' ELSE(CASE WHEN[STATUS] = 0 THEN 'Ö' "+
" WHEN[STATUS] = 1 THEN 'S' WHEN[STATUS] = 2 THEN 'SZ' ELSE '' END) END[Durumu],"+
" convert(varchar, DATE_, 104)[Tarihi],ORF.FICHENO[Sipariş Numarası], DOCODE[Belge No] ,cl.DEFINITION_[Cari Hesap], " +
"ROUND(ORF.NETTOTAL, 2)[Tutar], EXCHNETTOTAL[Dövizli Tutar],ISNULL(SL.CODE, '')[Satış Elemanı] FROM ONE_"+frmno+"_ORFICHE ORF LEFT JOIN " +
"ONE_"+frmno+"_CLCARD CL ON ORF.CLIENTREF = CL.LOGICALREF left join ONE_"+frmno+"_SALESMAN SL ON ORF.SALESMANREF = SL.LOGICALREF where ORF.TRCODE = 1";

            SqlDataAdapter da = new SqlDataAdapter(list_query.ToString(), baglan);
            DataSet ds = new DataSet();
            baglan.Open();
            da.Fill(ds, satis_sip_tablo);
            dataGridViewSatisSiparisleri.DataSource = ds.Tables[satis_sip_tablo];
            baglan.Close();
        }
    }
}
