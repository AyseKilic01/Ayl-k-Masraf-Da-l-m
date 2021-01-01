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
using afbLibrary.FormClass;

namespace AylikMasrafTakibi.scrViews
{
    public partial class scrGiderTip : Form
    {
        #region const
        SqlConnection con = new SqlConnection(cons.getConnectionString());
        cGiderTip cgidertip = null;
        #endregion

        public scrGiderTip()
        {
            InitializeComponent();
            cgidertip = new cGiderTip();
        }

        private void SaveData()
        {
            gridView2.UpdateCurrentRow();
            cgidertip.SaveData();
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
       
        private void cGridControl1_Load(object sender, EventArgs e)
        {
            cgidertip.LoadData();
            cGridControl1.DataSource = cgidertip.cDsGiderTip.GiderTip;
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
