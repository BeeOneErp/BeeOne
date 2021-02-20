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
    public partial class frmL_AnaKayitlar_Stok : Form
    {
        public frmL_AnaKayitlar_Stok()
        {
            InitializeComponent();
            DatagridviewSetting(dataGridViewStok);
        }

        bool move;
        int mouse_x;
        int mouse_y;

        public void DatagridviewSetting(DataGridView datagridView)
        {
            dataGridViewStok.RowHeadersVisible = false;
            datagridView.BorderStyle = BorderStyle.None;
            datagridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(50, 50, 50);
            datagridView.DefaultCellStyle.SelectionBackColor = Color.FromArgb(45, 45, 45);
            dataGridViewStok.DefaultCellStyle.ForeColor = Color.White;
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

        private void frmL_AnaKayitlar_Stok_Load(object sender, EventArgs e)
        {
            string yol = Metodlar.GlobalClass.baglanti;
            SqlConnection baglan = new SqlConnection(yol);
            string frmno = Metodlar.GlobalClass.firmano;

            string stok_tablo = "ONE_" + frmno + "_ITEMS";

            string list_query = "SELECT CASE WHEN CARDTYPE = 1 THEN 'TM' WHEN CARDTYPE = 2 THEN 'HM' WHEN CARDTYPE = 3 THEN 'YM' " +
                " WHEN CARDTYPE = 4 THEN 'SK' ELSE 'MM' END[Kart Türü] ,CODE[Malzeme Kodu],ITEM_NAME[Açıklaması], " +
                "ITEM_NAME2[Açıklaması 2],SPECODE[Özel Kodu],STGRPCODE[Grup Kodu], ISNULL(ARTI_STOK, 0) - ISNULL(EKSI_STOK, 0)[Stok Miktarı]" +
" FROM ONE_" + frmno + "_ITEMS IT left JOIN (SELECT STOCKREF, SUM(AMOUNT)ARTI_STOK FROM ONE_" + frmno + "_STLINE WHERE CANCELLED = 0 " +
" AND TRCODE IN(1, 2, 13, 50) GROUP BY STOCKREF) ARTI ON IT.LOGICALREF = ARTI.STOCKREF LEFT JOIN" +
"   (SELECT STOCKREF, SUM(AMOUNT) EKSI_STOK FROM ONE_" + frmno + "_STLINE WHERE CANCELLED = 0 AND TRCODE IN(6,7,11,12,51) GROUP BY STOCKREF) EKSI" +
" ON IT.LOGICALREF = EKSI.STOCKREF";

            SqlDataAdapter da = new SqlDataAdapter(list_query.ToString(), baglan);
            DataSet ds = new DataSet();
            baglan.Open();
            da.Fill(ds, stok_tablo);
            dataGridViewStok.DataSource = ds.Tables[stok_tablo];
            baglan.Close();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmAnaKayitlar_Stok"] == null)
            {
                frmAnaKayitlar_Stok form = new frmAnaKayitlar_Stok();
                form.kartturu = "(1) Ticari mal";
                form.Show();
            }
            else
                Application.OpenForms["frmAnaKayitlar_Stok"].Activate();
        }
    }
}
