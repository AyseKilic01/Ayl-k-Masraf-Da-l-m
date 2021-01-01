using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using afbLibrary;
using afbLibrary.FormClass;

namespace AylikMasrafTakibi.scrViews
{
    public partial class scrGiderTanim : Form
    {
        #region const
        SqlConnection con = new SqlConnection(cons.getConnectionString());
        cGiderTanim cgidertanim = null;
        #endregion

        public scrGiderTanim()
        {
            InitializeComponent();            
            cgidertanim = new cGiderTanim();
        }
     
        private void SaveData()
        {
            gridView1.UpdateCurrentRow();
            cgidertanim.SaveData();
        }


        public bool ValidateForm()
        {
            return true;
        }
        private void scrGiderTanim_FormClosing(object sender, FormClosingEventArgs e)
        {
            scrMain frm = new scrMain();
            frm.Show();
        }
        private void ConfigureCombos()
        {
            DataTable dtGiderTip = new DataTable();
            SqlCommand cmm = new SqlCommand();
            cmm.Connection = con;
            cmm.CommandText = "select gidertipref = id, gidertipkod = cast(code as varchar) from parGiderTip";
            SqlDataAdapter da = new SqlDataAdapter(cmm);
            da.Fill(dtGiderTip);
            repositoryItemLookUpEdit1.DataSource = dtGiderTip;
        }
        private void cGridControl1_Load(object sender, EventArgs e)
        {
            ConfigureCombos();
            cgidertanim.LoadData();
            cGridControl1.DataSource = cgidertanim.cDsGider.gider;
        }

        private void btnKaydet_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveData();
        }
        private void btnKaydetKapat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveData();
            Close();
        }
        private void btnKapat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }
    }
}
