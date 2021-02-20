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
    public partial class frmAnaKayitlar_Stok_MuhasebeHesaplari : Form
    {
        public frmAnaKayitlar_Stok_MuhasebeHesaplari()
        {
            InitializeComponent();
            DatagridviewSetting(dataGridViewMuhasebeHesaplari);
        }

        public void DatagridviewSetting(DataGridView datagridView)
        {
            dataGridViewMuhasebeHesaplari.RowHeadersVisible = false;
            datagridView.BorderStyle = BorderStyle.None;
            datagridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(50, 50, 50);
            datagridView.DefaultCellStyle.SelectionBackColor = Color.FromArgb(45, 45, 45);
            dataGridViewMuhasebeHesaplari.DefaultCellStyle.ForeColor = Color.White;
            datagridView.DefaultCellStyle.SelectionForeColor = Color.Khaki;
            datagridView.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Times New Roman", 10);
            datagridView.EnableHeadersVisualStyles = false;
            datagridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None; //Başlık çizgilerini kaldırıyor.
            datagridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(40, 40, 40);
            datagridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            datagridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            datagridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void frmAnaKayitlar_Stok_MuhasebeHesaplari_Load(object sender, EventArgs e)
        {
            //string yol = Metodlar.GlobalClass.baglanti;
            //string mlz_kodu = Metodlar.Stok.stok_kodu;
            //if (mlz_kodu == "")
            //{
            //}
            //else
            //{
            //    SqlConnection baglan = new SqlConnection(yol);
            //    string frmno = Metodlar.GlobalClass.firmano;

            //    string muhbag_tablo = "ONE_" + frmno + "_PRCLIST";


            //    string list_query = "select CR.TYP,M.CODE,PR.CODE FROM ONE_" + frmno + "_CRDACREF CR INNER JOIN ONE_" + frmno + "_ITEMS IT " +
            //        " ON IT.LOGICALREF = CR.CARDREF INNER JOIN ONE_" + frmno + "_EMUHACC M ON CR.ACCOUNTREF = M.LOGICALREF " +
            //        "LEFT JOIN ONE_" + frmno + "_PROJECT PR ON CR.PROJECTREF = PR.LOGICALREF WHERE CR.TRCODE = 1 AND IT.CODE = " + mlz_kodu + " order by TYP ASC";

            //    SqlDataAdapter da = new SqlDataAdapter(list_query.ToString(), baglan);
            //    DataSet ds = new DataSet();
            //    baglan.Open();
            //    da.Fill(ds, muhbag_tablo);
            //    dataGridViewMuhasebeHesaplari.DataSource = ds.Tables[muhbag_tablo];
            //    baglan.Close();

            //}
        }

        private void btnMuhHes_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmL_AnaKayitlar_Muhasebe"] == null)
            {
                frmL_AnaKayitlar_Muhasebe form = new frmL_AnaKayitlar_Muhasebe();
                form.Show();
            }
            else
                Application.OpenForms["frmL_AnaKayitlar_Muhasebe"].Activate();
        }
    }
}