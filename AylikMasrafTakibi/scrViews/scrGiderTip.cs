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
using afbLibrary;

namespace AylikMasrafTakibi.scrViews
{
    public partial class scrGiderTip : Form
    {
        #region constructor
        DataTable dtMain = new DataTable();
        SqlDataAdapter daMain = new SqlDataAdapter();
        SqlConnection con = new SqlConnection(cons.getConnectionString());
        #endregion
        public scrGiderTip()
        {
            InitializeComponent();
        }
        private void List()
        {
            SqlCommand cmm = new SqlCommand();
            cmm.Connection = con;
            cmm.CommandText = "Select a.id, a.code, a.explanation, a.pasif from parGiderTip a ";
            daMain = new SqlDataAdapter(cmm);
            cCommandBuilder cb = new cCommandBuilder();
            cb.AddField("id", SqlDbType.Int, 4, true);
            cb.AddField("code", SqlDbType.VarChar, 50);
            cb.AddField("explanation", SqlDbType.VarChar, 130);
            cb.AddField("pasif", SqlDbType.Bit, 0);
            cb.SqlTableName = "parGiderTip";
            cb.Con = con;
            cb.CreateCommands(daMain);

            daMain.Fill(dtMain);

        }

     
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
            gridView2.UpdateCurrentRow();
            daMain.Update(dtMain);
        }

        private void gridControl1_Load(object sender, EventArgs e)
        {
            List();
            cGridControl1.DataSource = dtMain;
        }
    }
}
