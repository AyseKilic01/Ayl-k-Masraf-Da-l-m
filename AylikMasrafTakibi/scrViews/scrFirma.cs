using afbLibrary;
using afbLibrary.FormClass;
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
    public partial class scrFirma : Form
    {
        #region const
        SqlConnection con = new SqlConnection(cons.getConnectionString());

        cFirm cfirma = null;
        #endregion

        public scrFirma()
        {
            InitializeComponent();
            cfirma = new cFirm();
        }

        private void SaveData()
        {
            gridView2.UpdateCurrentRow();
            cfirma.SaveData();
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
            cfirma.LoadData();
            cGridControl1.DataSource = cfirma.cDsFirm.Firma;
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

