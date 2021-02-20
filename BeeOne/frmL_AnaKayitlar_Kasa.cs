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
    public partial class frmL_AnaKayitlar_Kasa : Form
    {
        public frmL_AnaKayitlar_Kasa()
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
            datagridView.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Times New Roman", 12);
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
            if (Application.OpenForms["frmAnaKayitlar_Kasa"] == null)
            {
                frmAnaKayitlar_Kasa form = new frmAnaKayitlar_Kasa();
                form.Show();
            }
            else
                Application.OpenForms["frmAnaKayitlar_Kasa"].Activate();
        }

        private void frmL_AnaKayitlar_Kasa_Load(object sender, EventArgs e)
        {
          //  Metodlar.GlobalClass glb = new Metodlar.GlobalClass();

            string yol = Metodlar.GlobalClass.baglanti;
            SqlConnection baglan = new SqlConnection(yol);
            string frmno = Metodlar.GlobalClass.firmano;

            string kasa_tablo = "ONE_" + frmno + "_KSCARD";

            string kasa_list_query = "SELECT CODE [Kasa Kodu],NAME [Kasa Adı]," +
"CASE WHEN TAHSILAT IS NULL THEN ROUND(-1 * ODEME, 2)" +
"WHEN ODEME IS NULL THEN ROUND(TAHSILAT,2)" +
"ELSE ROUND(TAHSILAT-ODEME,2) END Bakiye FROM ONE_" + frmno + "_KSCARD K LEFT JOIN (select CARDREF, SUM(AMOUNT) TAHSILAT from ONE_" +
frmno + "_KSLINES WHERE CANCELLED = 0 AND TRCODE = 11 GROUP BY CARDREF)KTH ON K.LOGICALREF = KTH.CARDREF LEFT JOIN" +
"(select CARDREF, SUM(AMOUNT) ODEME from ONE_" + frmno + "_KSLINES WHERE CANCELLED = 0 AND TRCODE = 12 GROUP BY CARDREF)KOH ON K.LOGICALREF = KOH.CARDREF";


            SqlDataAdapter da = new SqlDataAdapter(kasa_list_query.ToString(), baglan);
            DataSet ds = new DataSet();
            baglan.Open();
            da.Fill(ds, kasa_tablo);
            dataGridViewKasa.DataSource = ds.Tables[kasa_tablo];
            baglan.Close();

        }
    }
}
