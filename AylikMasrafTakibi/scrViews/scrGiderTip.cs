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

namespace AylikMasrafTakibi.scrViews
{
    public partial class scrGiderTip : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        SqlDataAdapter da;
        DataSet ds;

        public scrGiderTip()
        {
            InitializeComponent();
        }

        private void scrGiderTip_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
        }

        private void scrGiderTip_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'afbDataSet.parGiderTip' table. You can move, or remove it, as needed.
            this.parGiderTipTableAdapter.Fill(this.dsGiderTip.parGiderTip);
            grdGiderTip.OptionsView.ShowAutoFilterRow = true;
            con = new SqlConnection("server=DEVELOPER\\AYSE; Initial Catalog=afb; User ID = sa; Password = 123321 ; Integrated Security=SSPI");
            da = new SqlDataAdapter("Select * from parGiderTip", con);
            ds = new DataSet();
            ds.Clear();
            da.Fill(ds);
            gridControl1.DataSource = ds.Tables[0];
            da.Dispose();
            con.Dispose();

        }
    }
}
