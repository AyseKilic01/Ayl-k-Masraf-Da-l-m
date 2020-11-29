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
        SqlConnection con = new SqlConnection("server=DEVELOPER\\AYSE; Initial Catalog=afb; User ID = sa; Password = 123321 ; Integrated Security=SSPI");
        SqlCommand cmd, command;
        DataRow dr;
        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt = new DataTable();
        public scrGiderTanim()
        {
            InitializeComponent();
            Load();
           
        }
        public void Load()
        {
            command = new SqlCommand("select a.*, gidertipkod = b.code from parGider a "
            + "left outer join parGiderTip b on b.id = a.gidertipi", con);
            da.SelectCommand = command;
            da.Fill(dt);
            gridControl1.DataSource = dt;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                repositoryItemComboBox1.Items.Add(dt.Rows[i]["gidertipkod"].ToString().Trim());
            }
        }

        public bool Validate()
        {
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
            con.Open();
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
                        cmd = new SqlCommand(sqlstr, con);
                        da.InsertCommand = cmd;
                        da.InsertCommand.ExecuteNonQuery();
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
                        cmd = new SqlCommand(sqlstr, con);
                        da.UpdateCommand = cmd;
                        da.UpdateCommand.ExecuteNonQuery();
                    }
                }
                
            }
            else
            {
                MessageBox.Show("Boş alanlar var. . . ");
            }

            con.Close();
          
        }
    }
}
