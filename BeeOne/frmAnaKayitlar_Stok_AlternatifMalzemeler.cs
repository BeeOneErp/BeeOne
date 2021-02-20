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
    public partial class frmAnaKayitlar_Stok_AlternatifMalzemeler : Form
    {
        public frmAnaKayitlar_Stok_AlternatifMalzemeler()
        {
            InitializeComponent();
            DatagridviewSetting(dataGridViewAlternatifMalzemeler);
        }

        public void DatagridviewSetting(DataGridView datagridView)
        {
            dataGridViewAlternatifMalzemeler.RowHeadersVisible = false;
            datagridView.BorderStyle = BorderStyle.None;
            datagridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(50, 50, 50);
            datagridView.DefaultCellStyle.SelectionBackColor = Color.FromArgb(45, 45, 45);
            dataGridViewAlternatifMalzemeler.DefaultCellStyle.ForeColor = Color.White;
            datagridView.DefaultCellStyle.SelectionForeColor = Color.Khaki;
            datagridView.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Times New Roman", 10);
            datagridView.EnableHeadersVisualStyles = false;
            datagridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None; //Başlık çizgilerini kaldırıyor.
            datagridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(40, 40, 40);
            datagridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            datagridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            datagridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void frmAnaKayitlar_Stok_AlternatifMalzemeler_Load(object sender, EventArgs e)
        {
            fillByToolStrip.Visible = false;

            // TODO: Bu kod satırı 'bEEONEDataSet1.ONE_001_ITEMSUBS' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.oNE_001_ITEMSUBSTableAdapter.Fill(this.bEEONEDataSet1.ONE_001_ITEMSUBS);

            //string yol = Metodlar.GlobalClass.baglanti;
            //string mlz_kodu = Metodlar.Stok.stok_kodu;
            //if (mlz_kodu == "")
            //{
            //}
            //else
            //{
            //    SqlConnection baglan = new SqlConnection(yol);
            //    string frmno = Metodlar.GlobalClass.firmano;
            //    baglan.Open();

            //    SqlCommand cmd2 = new SqlCommand("select LOGICALREF from [ONE_"+frmno+"_ITEMS] where [CODE]=@veri2", baglan);
            //    cmd2.Parameters.AddWithValue("@veri2", Metodlar.Stok.stok_kodu);
            //    SqlDataReader dr = cmd2.ExecuteReader();
            //    if (dr.Read())
            //    {
            //        sTOCKREFToolStripTextBox.Text = dr["LOGICALREF"].ToString();
            //    }

            //    baglan.Close();


    //            string muadil_tablo = "ONE_" + frmno + "_ITEMSUBS";


    //            string list_query = "select CASE WHEN PTYPE=0 THEN 'Alış' WHEN PTYPE=1 THEN 'Satış' END [Fiyat Kartı Türü], " +
    //" CLIENTCODE[Cari Hesap Kodu],BEGDATE[Başlangıç Tarihi],ENDDATE[Bitiş Tarihi] from ONE_" + frmno + "_ITEMS IT INNER JOIN " +
    //"ONE_" + frmno + "_PRCLIST PRC ON PRC.CARDREF = IT.LOGICALREF WHERE IT.CODE = " + mlz_kodu;



                //SqlDataAdapter da = new SqlDataAdapter(list_query.ToString(), baglan);
                //DataSet ds = new DataSet();
                //baglan.Open();
                //da.Fill(ds, muadil_tablo);
                //dataGridViewAlternatifMalzemeler.DataSource = ds.Tables[muadil_tablo];
                //baglan.Close();





            

        }

       
    }


}
 

