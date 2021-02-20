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
    public partial class frmL_AnaKayitlar_Muhasebe : Form
    {
        public frmL_AnaKayitlar_Muhasebe()
        {
            InitializeComponent();
            DatagridviewSetting(dataGridViewMuhasebe);
        }

        bool move;
        int mouse_x;
        int mouse_y;

        public void DatagridviewSetting(DataGridView datagridView)
        {
            dataGridViewMuhasebe.RowHeadersVisible = false;
            datagridView.BorderStyle = BorderStyle.None;
            datagridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(50, 50, 50);
            datagridView.DefaultCellStyle.SelectionBackColor = Color.FromArgb(45, 45, 45);
            dataGridViewMuhasebe.DefaultCellStyle.ForeColor = Color.White;
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

        private void pnlTop_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }

        private void pnlTop_MouseMove(object sender, MouseEventArgs e)
        {
            if (move == true)
            {
                this.SetDesktopLocation(MousePosition.X - mouse_x, MousePosition.Y - mouse_y);
            }
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
            if (Application.OpenForms["frmAnaKayitlar_Muhasebe"] == null)
            {
                frmAnaKayitlar_Muhasebe form = new frmAnaKayitlar_Muhasebe();
                form.Show();
            }
            else
                Application.OpenForms["frmAnaKayitlar_Muhasebe"].Activate();
        }

        private void frmL_AnaKayitlar_Muhasebe_Load(object sender, EventArgs e)
        {

            string yol = Metodlar.GlobalClass.baglanti;
            SqlConnection baglan = new SqlConnection(yol);
            string frmno = Metodlar.GlobalClass.firmano;

            string muh_tablo = "ONE_" + frmno + "_EMUHACC";

            string list_query = "select M.CODE [Muhasebe Hesap Kodu],M.DEFINITION_ [Muhasebe Hesap Adı],EXTNAME [Açıklama],SPECODE [Özel Kod]," +
" case WHEN BORC IS NULL THEN (CASE WHEN ALACAK IS NULL THEN (CASE WHEN(SELECT ROUND(SUM(DEBIT - CREDIT), 2) FROM " +
"ONE_" + frmno + "_EMFLINE WHERE CANCELLED = 0 AND KEBIRCODE = M.CODE) IS NULL" +
          "  THEN 0 ELSE(SELECT ROUND(SUM(DEBIT - CREDIT), 2) FROM ONE_" + frmno + "_EMFLINE WHERE KEBIRCODE = M.CODE) END)" +
" ELSE ROUND(((ISNULL(BORC, 0)) - ALACAK), 2) END)  ELSE ROUND(BORC-ISNULL(ALACAK, 0),2) END Bakiye from one_" + frmno + "_EMUHACC M LEFT JOIN" +
" (SELECT ACCOUNTREF, SUM(DEBIT)BORC FROM ONE_" + frmno + "_EMFLINE WHERE CANCELLED = 0 AND SIGN = 0 GROUP BY ACCOUNTREF)B " +
" ON M.LOGICALREF = B.ACCOUNTREF LEFT JOIN (SELECT ACCOUNTREF, SUM(CREDIT) ALACAK FROM ONE_" + frmno + "_EMFLINE WHERE CANCELLED = 0 " +
"AND SIGN = 1 GROUP BY ACCOUNTREF)A ON M.LOGICALREF = A.ACCOUNTREF ORDER BY CODE ASC";

            SqlDataAdapter da = new SqlDataAdapter(list_query.ToString(), baglan);
            DataSet ds = new DataSet();
            baglan.Open();
            da.Fill(ds, muh_tablo);
            dataGridViewMuhasebe.DataSource = ds.Tables[muh_tablo];
            baglan.Close();
        }
    }
}
