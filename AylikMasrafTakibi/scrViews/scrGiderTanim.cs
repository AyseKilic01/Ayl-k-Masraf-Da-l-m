using DevExpress.XtraEditors;
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
using AylikMasrafTakibi.Entities;

namespace AylikMasrafTakibi.scrViews
{
    public partial class scrGiderTanim : Form
    {
        SqlConnection con = new SqlConnection("server=DEVELOPER\\AYSE; Initial Catalog=afb; User ID = sa; Password = 123321 ; Integrated Security=SSPI");
        SqlCommand cmd, command;
        SqlDataAdapter da = new SqlDataAdapter();
        SqlDataAdapter da1 = new SqlDataAdapter();
        DataTable dt = new DataTable();
        DataTable dt1 = new DataTable();
        public scrGiderTanim()
        {
            InitializeComponent();
            Load();
         
        }
        public void Load()
        {
            command = new SqlCommand("select a.id, a.code, a.explanation, a.vadetarih, a.pasif, gidertipkod = b.code from parGider a " +
                " left outer join parGiderTip b on b.id = a.gidertipi " 
            , con);
            da.SelectCommand = command;
            da.Fill(dt);
            gridControl1.DataSource = dt;

            da1.SelectCommand = new SqlCommand("select gidertipi = id, code from parGiderTip where pasif = 0", con);
            da1.Fill(dt1);
            for (int i = 0; i < dt1.Rows.Count; i++)
            {
                repositoryItemComboBox1.Items.Add(dt1.Rows[i]["code"].ToString().Trim());
            }
       
            
            
        }

        public bool Validate()
        {
            return true;
        }
  
            void ritem_SelectedIndexChanged(object sender, EventArgs e)
        {
             
        }
        private void scrGiderTanim_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            scrMain frm = new scrMain();
            frm.Show();
        }
        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Hide();
            scrMain frm = new scrMain();
            frm.Show();
        }
        private void btnKaydKapat_Click(object sender, EventArgs e)
        {
            if (true)
            {
                this.Hide();
                scrMain frm = new scrMain();
                frm.Show();
            }
            else
            {

            }
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Kaydet();

        }

        

        private void Kaydet()
        {

            cSqlCommandInsert cs = new cSqlCommandInsert();
            //  string str = "insert into parGider VALUES('Elektrik', 'Elektrik Faturas', 1031, '2020-12-05', 0)";
            string str = "";
            string[] arr = new string[dt.Rows.Count];
            for(int i = 0; i<dt.Rows.Count; i++)
            {for(int j = 0; j<dt.Columns.Count; j++)
                {
                    arr[i] += dt.Rows[i][j].ToString().Trim() + "";
                }
                
            }
            cs.SqlCommandInsert("parGider", arr);
            
        

        }
    }
}
