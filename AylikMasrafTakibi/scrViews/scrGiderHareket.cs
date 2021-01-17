using afbLibrary;
using afbLibrary.Base;
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
using AylikMasrafTakibi.AForms;

namespace AylikMasrafTakibi.scrViews
{
    public partial class scrGiderHareket : Form
    {
        int mainid1;
        SqlConnection con = new SqlConnection(cons.getConnectionString());
        afbLibrary.FormClass.cGiderHar cFrm = new afbLibrary.FormClass.cGiderHar();
        SqlDataAdapter da = null;
        public scrGiderHareket()
        {
            InitializeComponent();

        }
        public scrGiderHareket(int mainref)
        {
            mainid1 = mainref;
            InitializeComponent();

        }

        private void ConfigureCombos()
        {
            SqlCommand cmm = new SqlCommand();
            cmm.Connection = con;
            cmm.CommandText = "SELECT giderid = a.id, giderkod = a.code, a.explanation FROM parGider a where coalesce(a.pasif, 0) = 0";
            SqlDataAdapter da = new SqlDataAdapter(cmm);
            DataTable dtkitap = new DataTable();
            da.Fill(dtkitap);
            GiderLookUpEdit.NullText = " ";
            GiderLookUpEdit.DataSource = dtkitap;
            GiderLookUpEdit.DisplayMember = "giderkod";
            GiderLookUpEdit.ValueMember = "giderid";
            GiderLookUpEdit.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("giderkod", 40, "Gider Kodu"));
            cmm.CommandText = "SELECT id, kod, aciklama from parFirma where coalesce(pasif, 0) = 0";
            da = new SqlDataAdapter(cmm);
            DataTable dtFirma = new DataTable();
            da.Fill(dtFirma);
            lkFirma.Properties.NullText = " ";
            lkFirma.Properties.DataSource = dtFirma;
            lkFirma.Properties.DisplayMember = "kod";
            lkFirma.Properties.ValueMember = "id";
            lkFirma.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("kod", 40, "Firma Kodu"));
            lkFirma.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("aciklama", 40, "Firma Açıklama"));

        }

        private void LoadData()
        {
            cSqlCommand cmm = new cSqlCommand();
            cmm.CommandText = "SELECT a.id, a.mainid, a.giderid, giderkod = c.code, a.miktar, a.fiyat, a.tutar, b.aciklama, b.tarih, b.firmaref " +
                "FROM giderhardetail a " +
                "INNER JOIN giderharmain b on b.id = a.mainid " +
                "INNER JOIN parGider c on c.id = a.giderid " +
                "where a.mainid = @mainid ";
            DataTable dt = new DataTable();
            cmm.Parameters.AddWithValue("@mainid", mainid1);
            da = new SqlDataAdapter(cmm.CommandObject);
            da.Fill(dt);
            da.Fill(cFrm.cDsGiderHar.giderhardetail);

            cGridControl1.DataSource = cFrm.cDsGiderHar.giderhardetail;

        }
        //private void AddGiderHar()
        //{
        //    SqlCommand cmm = new SqlCommand();
        //    cmm.Connection = con;
        //    cmm.CommandText = "INSERT INTO giderharmain (kod, aciklama, tarih, firmaref) VALUES(@kod, @aciklama, @tarih, @firmaref)";
        //    cmm.Parameters.AddWithValue("@kod", Convert.ToInt32(txtKod.Text));
        //    cmm.Parameters.AddWithValue("@aciklama", txtAciklama.Text);
        //    cmm.Parameters.AddWithValue("@tarih", dtTime.Text);
        //    cmm.Parameters.AddWithValue("@firmaref", lkFirma.EditValue);
        //    cmm.Connection.Open();
        //    cmm.ExecuteNonQuery();
        //    cmm.CommandText = "INSERT INTO giderhardetail (mainid, giderid, miktar, fiyat, tutar) VALUES(@mainid, @giderid, @miktar, @fiyat, @tutar)";
        //    cmm.ExecuteNonQuery();
        //    cmm.Connection.Close();
        //}


        private void cGridControl1_Load(object sender, EventArgs e)
        {
            ConfigureCombos();
            LoadData();
            txtKod.Text = cFrm.Kod;
            txtAciklama.Text = cFrm.Aciklama;
            lkFirma.EditValue = cFrm.FirmaKod;
            dtTime.Text = Convert.ToString(cFrm.Tarih);
            //cGridControl1.DataSource = cFrm.cDsGiderHar.giderharmain;
        }

        private void SaveData()
        {
            da.Update(cFrm.cDsGiderHar.giderhardetail);
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            SaveData();
        }

        private void btnKaydetKapat_Click(object sender, EventArgs e)
        {

        }

        private void btnKapat_Click(object sender, EventArgs e)
        {

            this.Close();

        }
    }
}
