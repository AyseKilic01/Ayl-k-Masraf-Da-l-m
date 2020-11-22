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
using AylikMasrafTakibi.scrViews;

namespace AylikMasrafTakibi
{
    public partial class srcLogin : Form
    {
        public srcLogin()
        {
            InitializeComponent();
        }
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string user = vrUsername.Text;
            string pass = vrPassword.Text;
            con = new SqlConnection("server=DEVELOPER\\AYSE; Initial Catalog=afb; User ID = sa; Password = 123321 ; Integrated Security=SSPI");
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM parLogin where username='" + vrUsername.Text + "' AND password='" + vrPassword.Text + "'";
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                scrMain frm = new scrMain();//açılacak form
                frm.Show(); //form 2 açılıyor.
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı adını ve şifrenizi kontrol ediniz.");
            }
            con.Close();
        }
    }
}
