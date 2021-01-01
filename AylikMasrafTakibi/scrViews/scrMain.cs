using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using AylikMasrafTakibi.Reports;
using AylikMasrafTakibi.AForms;

namespace AylikMasrafTakibi.scrViews
{
    public partial class scrMain : DevExpress.XtraEditors.XtraForm
    {
        public scrMain()
        {
            InitializeComponent();
        }

        #region administration
        private void btnChangePass_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnAdminPanel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
        private void scrMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        #endregion

        #region definitions
        private void btnGiderTip_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            scrGiderTip frm = new scrGiderTip();
     
            frm.Show();
        }

        private void btnGiderTanim_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            scrGiderTanim frm = new scrGiderTanim();
            frm.Show();
        }
        private void btnFirmaTanim_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            scrFirma frm = new scrFirma();
            frm.Show();
            this.Hide();

        }
        #endregion

        #region actions
        private void btnGiderHar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AFrmGiderHareketList frm = new AFrmGiderHareketList();
            frm.Show();
        }
        #endregion

        #region reports
        private void btnRaporAylik_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            RepAylikMasrafTakip aylk = new RepAylikMasrafTakip();
            aylk.Show();
        }

        private void btnGiderHareketi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            RepGiderHareketleri gdr = new RepGiderHareketleri();
            gdr.Show();
        }



        #endregion

        private void cBarButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           
        }
    }
}