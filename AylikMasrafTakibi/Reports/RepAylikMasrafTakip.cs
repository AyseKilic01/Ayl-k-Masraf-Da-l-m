using afbLibrary;
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

namespace AylikMasrafTakibi.Reports
{
    public partial class RepAylikMasrafTakip : Form
    {
        DataTable dtMain = new DataTable();
        SqlDataAdapter daMain = new SqlDataAdapter();
        SqlConnection con = new SqlConnection(cons.getConnectionString());

        public RepAylikMasrafTakip()
        {
            InitializeComponent();
        }

        private void cGridControl1_Load(object sender, EventArgs e)
        {
            List();
            cGridControl1.DataSource = dtMain;
        }
        private void List()
        {
            SqlCommand cmm = new SqlCommand();
            cmm.Parameters.Clear();
            cmm.Connection = con;
            cmm.CommandText = "select a.id, a.code, a.explanation, gidertipkod = b.code, gidertip = b.id, a.vadetarih, a.pasif  from parGider a " +
                " left outer join parGiderTip b on b.id = a.gidertipi ";
            daMain = new SqlDataAdapter(cmm);
            cCommandBuilder cb = new cCommandBuilder();
            cb.AddField("id", SqlDbType.Int, 4, true);
            cb.AddField("code", SqlDbType.VarChar, 50);
            cb.AddField("gidertip", SqlDbType.Int, 4, true);
            cb.AddField("explanation", SqlDbType.VarChar, 130);
            cb.AddField("vadetarih", SqlDbType.DateTime, 4);
            cb.AddField("pasif", SqlDbType.Bit, 0);
            cb.SqlTableName = "parGider";
            cb.Con = con;
            cb.CreateCommands(daMain);
            daMain.Fill(dtMain);

        }
    }
}
