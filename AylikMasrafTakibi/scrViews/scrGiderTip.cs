using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using AylikMasrafTakibi.Entities;

namespace AylikMasrafTakibi.scrViews
{
    public partial class scrGiderTip : Form
    {
        #region constructor
        SqlConnection con = new SqlConnection("server=DEVELOPER\\AYSE; Initial Catalog=afb; User ID = sa; Password = 123321 ; Integrated Security=SSPI");
        SqlCommand cmd, command;
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds;
        DataTable dt = new DataTable();
        cSqlCommandInsert csi = new cSqlCommandInsert();
        cSqlCommandUpdate csu = new cSqlCommandUpdate();
        #endregion
        public scrGiderTip()
        {
            InitializeComponent();
            Load();

        }
        public void Load()
        {
            command = new SqlCommand("Select * from parGiderTip", con);
            da.SelectCommand = command;
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }

       
        //private void scrGiderTip_Load(object sender, EventArgs e)
        //{
        //    // TODO: This line of code loads data into the 'afbDataSet.parGiderTip' table. You can move, or remove it, as needed.

        //    grdGiderTip.OptionsView.ShowAutoFilterRow = true;
        //    con = new SqlConnection("server=DEVELOPER\\AYSE; Initial Catalog=afb; User ID = sa; Password = 123321 ; Integrated Security=SSPI");
        //    da = new SqlDataAdapter("Select * from parGiderTip", con);
        //    ds = new DataSet();
        //    ds.Clear();
        //    da.Fill(ds);
        //    gridControl1.DataSource = ds.Tables[0];
        //    da.Dispose();
        //    con.Dispose();

        //}
        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Hide();
            scrMain frm = new scrMain();
            frm.Show();

        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Kaydet();
        }
        private void Kaydet()
        {
            if (csi.CheckInsert(da, dt))
            {
                csi.SqlCommandInsert("parGiderTip", dt, da);

            }

            else
            {
                csu.SqlCommandUpdate("parGiderTip", dt, da);
            }
        }

    }
}
