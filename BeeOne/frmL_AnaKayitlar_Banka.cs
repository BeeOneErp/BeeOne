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
    public partial class frmL_AnaKayitlar_Banka : Form
    {
        public frmL_AnaKayitlar_Banka()
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
            if (Application.OpenForms["frmAnaKayitlar_Banka"] == null)
            {
                frmAnaKayitlar_Banka form = new frmAnaKayitlar_Banka();
                form.Show();
            }
            else
                Application.OpenForms["frmAnaKayitlar_Banka"].Activate();
        }

        private void frmL_AnaKayitlar_Banka_Load(object sender, EventArgs e)
        {
            string yol = Metodlar.GlobalClass.baglanti;
            SqlConnection baglan = new SqlConnection(yol);
            string frmno = Metodlar.GlobalClass.firmano;

            string banka_tablo = "ONE_" + frmno + "_BNCARD";

            string list_query = "SELECT [Banka Kodu],[Banka Adı],[Hesap Kodu],[Hesap Adı],CASE WHEN Bakiye IS NULL THEN 0 ELSE Bakiye "+
                "END [Bakiye] FROM (SELECT BN.BNCODE 'Banka Kodu', BN.BNDEFINITION_ 'Banka Adı', BN.CODE 'Hesap Kodu', BN.DEFINITION_ 'Hesap Adı'," +
"CASE WHEN DEBIT IS NULL THEN ROUND(-1 * CREDIT, 2)" +
" WHEN CREDIT IS NULL THEN ROUND(DEBIT, 2)" +
" ELSE ROUND(DEBIT - CREDIT, 2) END Bakiye" +
" FROM ONE_" + frmno + "_BNCARD BN left JOIN" +
" (SELECT CODE, SUM(DEBIT) DEBIT FROM ONE_" + frmno + "_BNFLINE WHERE TRCODE = 3 AND CANCELLED = 0 GROUP BY CODE)BORC ON BN.CODE = BORC.CODE" +
" LEFT JOIN (SELECT CODE, SUM(CREDIT) CREDIT FROM ONE_" + frmno + "_BNFLINE WHERE TRCODE = 4 AND CANCELLED = 0 GROUP BY CODE)ALACAK" +
" ON BN.CODE = ALACAK.CODE)T";

            SqlDataAdapter da = new SqlDataAdapter(list_query.ToString(), baglan);
            DataSet ds = new DataSet();
            baglan.Open();
            da.Fill(ds, banka_tablo);
            dataGridViewBanka.DataSource = ds.Tables[banka_tablo];
            baglan.Close();

        }
    }
}
