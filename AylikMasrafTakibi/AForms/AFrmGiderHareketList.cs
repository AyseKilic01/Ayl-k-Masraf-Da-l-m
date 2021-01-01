using afbLibrary;
using AylikMasrafTakibi.scrViews;
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

namespace AylikMasrafTakibi.AForms
{
    public partial class AFrmGiderHareketList : Form
    {
        DataTable dt = new DataTable();
        SqlConnection con = new SqlConnection(cons.getConnectionString());
        SqlDataAdapter daMain = null;
        
        public AFrmGiderHareketList()
        {
            InitializeComponent();
        }
        private void scrGiderTanim_FormClosing(object sender, FormClosingEventArgs e)
        {
            scrMain frm = new scrMain();
            frm.Show();
        }
       
        private void LoadData()
        {
            SqlCommand cmm = new SqlCommand();
            cmm.Connection = con;
            cmm.CommandText = "select a.id, a.kod, a.aciklama, a.tarih, a.firmaref, firmakod = b.kod  from giderharmain a " +
                "left outer join parFirma b on b.id = a.firmaref ";

            daMain = new SqlDataAdapter(cmm);
            daMain.Fill(dt);
            cGridControl1.DataSource = dt;
        }
        private void cGridControl1_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            scrGiderHareket frm = new scrGiderHareket();
            frm.Show();
        }

        private void btnYeniKayit_Click(object sender, EventArgs e)
        {
            scrGiderHareket frm = new scrGiderHareket();
            frm.Show();
        }
    }
}
