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
    public partial class frmL_Finans_KasaIslemleri : Form
    {
        public frmL_Finans_KasaIslemleri()
        {
            InitializeComponent();
            DatagridviewSetting(dataGridViewKasa);
        }

        bool move;
        int mouse_x;
        int mouse_y;

        public void DatagridviewSetting(DataGridView datagridView)
        {
            dataGridViewKasa.RowHeadersVisible = false;
            datagridView.BorderStyle = BorderStyle.None;
            datagridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(50, 50, 50);
            datagridView.DefaultCellStyle.SelectionBackColor = Color.FromArgb(45, 45, 45);
            dataGridViewKasa.DefaultCellStyle.ForeColor = Color.White;
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
            if (Application.OpenForms["frmFinans_KasaIslemleri"] == null)
            {
                frmFinans_KasaIslemleri form = new frmFinans_KasaIslemleri();
                form.Show();
            }
            else
                Application.OpenForms["frmFinans_KasaIslemleri"].Activate();
        }

        private void frmL_Finans_KasaIslemleri_Load(object sender, EventArgs e)
        {

            string yol = Metodlar.GlobalClass.baglanti;
            SqlConnection baglan = new SqlConnection(yol);
            string frmno = Metodlar.GlobalClass.firmano;

            string ksf_tablo = "ONE_" + frmno + "_KSFICHE";

            string list_query = "SELECT CASE WHEN CANCELLED = 1 THEN 'İ' ELSE(CASE WHEN ACCOUNTED = 1 THEN 'M'  ELSE '' END) END[Durumu], " +
" case when TRCODE = 11 then 'Cari Hesap Tahsilat' WHEN TRCODE = 12 then 'Cari Hesap Ödeme' end[Fiş Türü],convert(varchar, DATE_, 104)[Tarihi]," +
" FICHENO[Fiş Numarası],KSL.DOCODE[Belge No],KS.CODE[Kasa No], KSL.GENEXP[Açıklama],AMOUNT Tutar, KS.NAME[Kasa Adı] FROM ONE_" +
frmno + "_KSLINES KSL LEFT JOIN ONE_001_KSCARD KS ON KSL.CARDREF = KS.LOGICALREF";

            SqlDataAdapter da = new SqlDataAdapter(list_query.ToString(), baglan);
            DataSet ds = new DataSet();
            baglan.Open();
            da.Fill(ds, ksf_tablo);
            dataGridViewKasa.DataSource = ds.Tables[ksf_tablo];
            baglan.Close();
        }
    }
}
