using DevExpress.XtraGrid.Views.Grid;
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

namespace AylikMasrafTakibi.scrViews
{
    public partial class scrGiderTanim : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        DataRow dr;
        public scrGiderTanim()
        {
            InitializeComponent();
            Refresh();
        } 
        public void Refresh()
        {
            parGiderTableAdapter1.Fill(dsGider.parGider);
        }

        public bool Validate()
        {
            con = new SqlConnection("server=DEVELOPER\\AYSE; Initial Catalog=afb; User ID = sa; Password = 123321 ; Integrated Security=SSPI");
            con.Open();

            DataTable dt = dsGider.Tables[0];
            for(int i = 0; i<dt.Rows.Count; i++)
            {
                if(dt.Rows[i]["code"].ToString().Trim() == "" 
                    || dt.Rows[i]["explanation"].ToString().Trim() == ""
                   // || dt.Rows[i]["gidertipi"].ToString().Trim() == "" 
                   )
                {
                    return false;
                }
            }
            con.Close();

            return true;

        }

        private void scrGiderTanim_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Hide();
            scrMain frm = new scrMain();
            frm.Show();
        }

        private void btnKaydKapat_Click(object sender, EventArgs e)
        {

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Kaydet();

        }
        private void Kaydet()
        {
            con = new SqlConnection("server=DEVELOPER\\AYSE; Initial Catalog=afb; User ID = sa; Password = 123321 ; Integrated Security=SSPI");
            con.Open();

            DataTable dt = dsGider.Tables[0];
            DataTable dt2 = dsGider.parGiderTip;
            string sqlstr = "";
            if (Validate())
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (Convert.ToInt32(dt.Rows[i]["id"]) <= -1)
                    {
                        sqlstr = sqlstr + " insert into parGider VALUES('"
                            + dt.Rows[i]["code"].ToString().Trim() + "', "
                            + dt.Rows[i]["explanation"].ToString().Trim() + "', "
                            + dt.Rows[i]["gidertipi"].ToString().Trim() + " , '"
                            + Convert.ToDateTime(dt.Rows[i]["vadetarih"].ToString().Trim()).ToString("yyyyMMdd")
                            + "', "
                            + Convert.ToByte(dt.Rows[i]["pasif"]) +
                            ") ";

                    }
                    else
                    {
                        sqlstr = sqlstr + "update parGider set code = '"
                        + dt.Rows[i]["code"].ToString().Trim() + "' , explanation = '"
                        + dt.Rows[i]["explanation"].ToString().Trim() + "' , gidertipi = "
                        + dt.Rows[i]["gidertipi"].ToString().Trim() + " , vadetarih =  '"
                        + Convert.ToDateTime(dt.Rows[i]["vadetarih"].ToString().Trim()).ToString("yyyyMMdd") + "' , pasif = "
                        + Convert.ToByte(dt.Rows[i]["pasif"])
                        + "  where id = "
                        + dt.Rows[i]["id"].ToString().Trim() +
                        " ";
                    }
                }
                
            }
            else
            {
                MessageBox.Show("Boş alanlar var. . . ");
            }
            if (sqlstr != "")
            {
                cmd = new SqlCommand(sqlstr, con);
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
            }
            con.Close();
            Refresh();
        }
    }
}
