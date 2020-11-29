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
        SqlConnection con = new SqlConnection("server=DEVELOPER\\AYSE; Initial Catalog=afb; User ID = sa; Password = 123321 ; Integrated Security=SSPI");
        SqlCommand cmd, command;
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds;
        DataTable dt = new DataTable();
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

        private void scrGiderTip_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Close();
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
            this.Close();
            
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Kaydet();
        }
        private void Kaydet()
        {
           con.Open();
            string sqlstr = "";
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (dt.Rows[i]["id"] == DBNull.Value)
                {

                    sqlstr = sqlstr + " insert into parGiderTip VALUES('"
                        + dt.Rows[i]["code"].ToString().Trim() +
                        "', '"
                        + dt.Rows[i]["explanation"].ToString().Trim() +
                        "' , "
                        + Convert.ToByte(dt.Rows[i]["pasif"]) +
                        ") ";
                    cmd = new SqlCommand(sqlstr, con);
                    da.InsertCommand = cmd;
                    da.InsertCommand.ExecuteNonQuery();
                }
                else
                {
                    sqlstr = sqlstr + "update parGiderTip set code = '"
                        + dt.Rows[i]["code"].ToString().Trim() + "' , explanation = '"
                        + dt.Rows[i]["explanation"].ToString().Trim() + "' , pasif = "
                        + Convert.ToByte(dt.Rows[i]["pasif"])
                        + "  where id = "
                        + dt.Rows[i]["id"].ToString().Trim() +
                        " ";
                    cmd = new SqlCommand(sqlstr, con);
                    da.UpdateCommand = cmd;
                    da.UpdateCommand.ExecuteNonQuery();
                }
            }
            con.Close();
        }

    }
}
