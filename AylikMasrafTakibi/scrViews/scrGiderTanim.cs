﻿using DevExpress.XtraEditors;
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
using AylikMasrafTakibi.Entities.Dto;
using DevExpress.XtraEditors.Repository;

namespace AylikMasrafTakibi.scrViews
{
    public partial class scrGiderTanim : Form
    {
        #region const
        SqlConnection con = new SqlConnection("server=DEVELOPER\\AYSE; Initial Catalog=afb; User ID = sa; Password = 123321 ; Integrated Security=SSPI");
        SqlCommand command;
        SqlDataAdapter da = new SqlDataAdapter();
        SqlDataAdapter da1 = new SqlDataAdapter();
        DataTable dt = new DataTable();
        DataTable dt1 = new DataTable();
        cSqlDataAdapter ddd = new cSqlDataAdapter();

        cSqlCommandInsert csi = new cSqlCommandInsert();
        cSqlCommandUpdate csu = new cSqlCommandUpdate();
        #endregion
   
        public scrGiderTanim()
        {
            InitializeComponent();
            List();
         
        }
        public void List()
        {
            command = new SqlCommand("select a.id, a.code, a.explanation, a.vadetarih, a.pasif, gidertipkod = b.code, gidertip = b.id from parGider a " +
                " left outer join parGiderTip b on b.id = a.gidertipi " 
            , con);
          
            da.SelectCommand = command;
            da.Fill(dt);
            gridControl1.DataSource = dt;

            da1.SelectCommand = new SqlCommand("select gidertip = id, kod = code from parGiderTip where pasif = 0", con);

            da1.Fill(dt1);
            repositoryItems.DataSource = dt1;
            repositoryItems.ValueMember = "gidertip";
            repositoryItems.DisplayMember = "kod";

            gidertipkod.ColumnEdit = repositoryItems;
    
        }

        public bool Validate()
        {
            return true;
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
        

        private void gridView1_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
           
        }

        //private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        //{
        //    var kod = gridView1.GetFocusedRowCellValue("code").ToString();
        //    var aciklama = gridView1.GetFocusedRowCellValue("explanation").ToString();
        //    var gidertipkod = gridView1.GetFocusedRowCellValue("gidertipkod").ToString();
            
        //    var a = gridView1.GetFocusedRowCellValue("gidertip").ToString();
        //}

        private void btnSil_Click(object sender, EventArgs e)
        {
            var i = gridView1.GetFocusedRowCellValue("id").ToString();
            var deger = dt.Rows.Find(i);
            dt.Rows.Remove(deger);
            gridControl1.DataSource = dt;
            XtraMessageBox.Show("Silindi");
        }

        private void gridView1_RowDeleting(object sender, DevExpress.Data.RowDeletingEventArgs e)
        {

        }

        private void repositoryItemComboBox1_EditValueChanged(object sender, EventArgs e)
        {       
          
            var ge = gridView1.EditingValue.ToString();
            //      gridView1.SetFocusedRowCellValue("gidertipkod",ge);
            

            XtraMessageBox.Show(ge);
        }

        private void gridView1_RowDeleted(object sender, DevExpress.Data.RowDeletedEventArgs e)
        {

        }

        private void Kaydet()
        {
            if (csi.CheckInsert(da, dt))
            {
                csi.SqlCommandInsert("parGider", dt, da);
                
            }
            else
            {
                csu.SqlCommandUpdate("parGider", dt, da);
            }

        }
    }
}
