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
    public partial class frmAnaKayitlar_Stok_FiyatBilgisi : Form
    {
        public frmAnaKayitlar_Stok_FiyatBilgisi()
        {
            InitializeComponent();
            DatagridviewSetting(dataGridViewFiyatBilgisi);
        }

        public void DatagridviewSetting(DataGridView datagridView)
        {
            dataGridViewFiyatBilgisi.RowHeadersVisible = false;
            datagridView.BorderStyle = BorderStyle.None;
            datagridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(50, 50, 50);
            datagridView.DefaultCellStyle.SelectionBackColor = Color.FromArgb(45, 45, 45);
            dataGridViewFiyatBilgisi.DefaultCellStyle.ForeColor = Color.White;
            datagridView.DefaultCellStyle.SelectionForeColor = Color.Khaki;
            datagridView.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Times New Roman", 10);
            datagridView.EnableHeadersVisualStyles = false;
            datagridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None; //Başlık çizgilerini kaldırıyor.
            datagridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(40, 40, 40);
            datagridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            datagridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            datagridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void frmAnaKayitlar_Stok_FiyatBilgisi_Load(object sender, EventArgs e)
        {
            string yol = Metodlar.GlobalClass.baglanti;
            string mlz_kodu = Metodlar.Stok.stok_kodu;
            if (mlz_kodu == "")
            {
            }
            else
            {
                SqlConnection baglan = new SqlConnection(yol);
            string frmno = Metodlar.GlobalClass.firmano;

            string fiyat_tablo = "ONE_" + frmno + "_PRCLIST";

            
            string list_query = "select CASE WHEN PTYPE=0 THEN 'Alış' WHEN PTYPE=1 THEN 'Satış' END [Fiyat Kartı Türü], "+
" CLIENTCODE[Cari Hesap Kodu],BEGDATE[Başlangıç Tarihi],ENDDATE[Bitiş Tarihi] from ONE_"+frmno+"_ITEMS IT INNER JOIN "+
"ONE_"+frmno+"_PRCLIST PRC ON PRC.CARDREF = IT.LOGICALREF WHERE IT.CODE = "+mlz_kodu;

            SqlDataAdapter da = new SqlDataAdapter(list_query.ToString(), baglan);
            DataSet ds = new DataSet();
            baglan.Open();
            da.Fill(ds, fiyat_tablo);
            dataGridViewFiyatBilgisi.DataSource = ds.Tables[fiyat_tablo];
            baglan.Close();

        }
    }
    }
}
