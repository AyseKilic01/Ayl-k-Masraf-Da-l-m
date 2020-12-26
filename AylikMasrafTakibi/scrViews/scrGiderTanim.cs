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
using afbLibrary;
using DevExpress.XtraEditors.Controls;

namespace AylikMasrafTakibi.scrViews
{
    public partial class scrGiderTanim : Form
    {
        #region const

        DataTable dtMain = new DataTable();
        DataTable dtTip = new DataTable();
        SqlDataAdapter daMain = new SqlDataAdapter();
        SqlConnection con = new SqlConnection(cons.getConnectionString());



        #endregion

        public scrGiderTanim()
        {
            InitializeComponent();
            

        }
        private void List()
        {

           
            //repositoryItems.DataSource = dt1;
            //repositoryItems.ValueMember = "gidertip";
            //repositoryItems.DisplayMember = "kod";

            //gidertipkod.ColumnEdit = repositoryItems;
            LookUpEdit1.NullText = "";


            SqlCommand cmm = new SqlCommand();
            cmm.Connection = con;
            cmm.CommandText = "select gidertip = id, gidertipkod = code from parGiderTip where pasif = 0";
            SqlDataAdapter da = new SqlDataAdapter(cmm);
            da.Fill(dtTip);
           


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


        public bool Kontrol()
        {
            return true;
        }
        private void scrGiderTanim_FormClosing(object sender, FormClosingEventArgs e)
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
            gridView1.UpdateCurrentRow();
            daMain.Update(dtMain);
        }

        private void cGridControl1_Load(object sender, EventArgs e)
        {
            List();
            cGridControl1.DataSource = dtMain;
            LookUpEdit1.DataSource = dtTip;
            LookUpEdit1.DisplayMember = "gidertipkod";
            LookUpEdit1.ValueMember = "gidertip";
            LookUpEdit1.Columns.Add(new LookUpColumnInfo("gidertipkod", 40, "Gider Tipi"));
        }

        private void LookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {
           
        }

        private void btnKaydet_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Kaydet();
        }
    }
}
