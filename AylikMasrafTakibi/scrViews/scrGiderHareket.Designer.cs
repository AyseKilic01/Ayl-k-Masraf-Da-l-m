namespace AylikMasrafTakibi.scrViews
{
    partial class scrGiderHareket
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(scrGiderHareket));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.lkFirma = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.chKontrol = new DevExpress.XtraEditors.CheckEdit();
            this.txtAciklama = new DevExpress.XtraEditors.TextEdit();
            this.txtKod = new DevExpress.XtraEditors.TextEdit();
            this.dtTime = new DevExpress.XtraEditors.DateEdit();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.separatorControl2 = new DevExpress.XtraEditors.SeparatorControl();
            this.separatorControl1 = new DevExpress.XtraEditors.SeparatorControl();
            this.btnKapat = new DevExpress.XtraEditors.SimpleButton();
            this.btnKaydetKapat = new DevExpress.XtraEditors.SimpleButton();
            this.btnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.cGridControl1 = new afbLibrary.cGridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.mainid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.giderid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GiderLookUpEdit = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.miktar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.fiyat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tutar = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkFirma.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chKontrol.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAciklama.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKod.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtTime.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtTime.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GiderLookUpEdit)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.lkFirma);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.chKontrol);
            this.groupControl1.Controls.Add(this.txtAciklama);
            this.groupControl1.Controls.Add(this.txtKod);
            this.groupControl1.Controls.Add(this.dtTime);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.ShowCaption = false;
            this.groupControl1.Size = new System.Drawing.Size(1267, 117);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "groupControl1";
            // 
            // lkFirma
            // 
            this.lkFirma.EditValue = "";
            this.lkFirma.Location = new System.Drawing.Point(120, 36);
            this.lkFirma.Name = "lkFirma";
            this.lkFirma.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkFirma.Size = new System.Drawing.Size(102, 20);
            this.lkFirma.TabIndex = 9;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(34, 91);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(41, 13);
            this.labelControl4.TabIndex = 8;
            this.labelControl4.Text = "Açıklama";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(34, 65);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(24, 13);
            this.labelControl3.TabIndex = 7;
            this.labelControl3.Text = "Tarih";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(34, 39);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(26, 13);
            this.labelControl2.TabIndex = 6;
            this.labelControl2.Text = "Firma";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(34, 13);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(40, 13);
            this.labelControl1.TabIndex = 5;
            this.labelControl1.Text = "Fiş Kodu";
            // 
            // chKontrol
            // 
            this.chKontrol.Location = new System.Drawing.Point(275, 10);
            this.chKontrol.Name = "chKontrol";
            this.chKontrol.Properties.Caption = "Kontrol";
            this.chKontrol.Size = new System.Drawing.Size(104, 19);
            this.chKontrol.TabIndex = 4;
            // 
            // txtAciklama
            // 
            this.txtAciklama.EditValue = "";
            this.txtAciklama.Location = new System.Drawing.Point(120, 88);
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(259, 20);
            this.txtAciklama.TabIndex = 2;
            // 
            // txtKod
            // 
            this.txtKod.Enabled = false;
            this.txtKod.Location = new System.Drawing.Point(120, 10);
            this.txtKod.Name = "txtKod";
            this.txtKod.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtKod.Properties.Appearance.Options.UseBackColor = true;
            this.txtKod.Size = new System.Drawing.Size(102, 20);
            this.txtKod.TabIndex = 1;
            // 
            // dtTime
            // 
            this.dtTime.EditValue = "";
            this.dtTime.Location = new System.Drawing.Point(120, 62);
            this.dtTime.Name = "dtTime";
            this.dtTime.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtTime.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtTime.Size = new System.Drawing.Size(122, 20);
            this.dtTime.TabIndex = 0;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.separatorControl2);
            this.groupControl2.Controls.Add(this.separatorControl1);
            this.groupControl2.Controls.Add(this.btnKapat);
            this.groupControl2.Controls.Add(this.btnKaydetKapat);
            this.groupControl2.Controls.Add(this.btnKaydet);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupControl2.Location = new System.Drawing.Point(0, 117);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.ShowCaption = false;
            this.groupControl2.Size = new System.Drawing.Size(133, 358);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "groupControl2";
            // 
            // separatorControl2
            // 
            this.separatorControl2.Location = new System.Drawing.Point(0, 149);
            this.separatorControl2.Name = "separatorControl2";
            this.separatorControl2.Size = new System.Drawing.Size(133, 19);
            this.separatorControl2.TabIndex = 4;
            // 
            // separatorControl1
            // 
            this.separatorControl1.Location = new System.Drawing.Point(5, 33);
            this.separatorControl1.Name = "separatorControl1";
            this.separatorControl1.Size = new System.Drawing.Size(128, 19);
            this.separatorControl1.TabIndex = 3;
            // 
            // btnKapat
            // 
            this.btnKapat.Location = new System.Drawing.Point(22, 116);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(84, 23);
            this.btnKapat.TabIndex = 2;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // btnKaydetKapat
            // 
            this.btnKaydetKapat.Location = new System.Drawing.Point(22, 87);
            this.btnKaydetKapat.Name = "btnKaydetKapat";
            this.btnKaydetKapat.Size = new System.Drawing.Size(84, 23);
            this.btnKaydetKapat.TabIndex = 1;
            this.btnKaydetKapat.Text = "Kaydet && Kapat";
            this.btnKaydetKapat.Click += new System.EventHandler(this.btnKaydetKapat_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(22, 58);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(84, 23);
            this.btnKaydet.TabIndex = 0;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // cGridControl1
            // 
            this.cGridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cGridControl1.Location = new System.Drawing.Point(133, 117);
            this.cGridControl1.MainView = this.gridView1;
            this.cGridControl1.Name = "cGridControl1";
            this.cGridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.GiderLookUpEdit});
            this.cGridControl1.Size = new System.Drawing.Size(1134, 358);
            this.cGridControl1.TabIndex = 2;
            this.cGridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.cGridControl1.Load += new System.EventHandler(this.cGridControl1_Load);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.id,
            this.mainid,
            this.giderid,
            this.miktar,
            this.fiyat,
            this.tutar});
            this.gridView1.GridControl = this.cGridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // id
            // 
            this.id.FieldName = "id";
            this.id.Name = "id";
            // 
            // mainid
            // 
            this.mainid.FieldName = "mainid";
            this.mainid.Name = "mainid";
            // 
            // giderid
            // 
            this.giderid.Caption = "Gider";
            this.giderid.ColumnEdit = this.GiderLookUpEdit;
            this.giderid.FieldName = "giderid";
            this.giderid.Name = "giderid";
            this.giderid.Visible = true;
            this.giderid.VisibleIndex = 0;
            // 
            // GiderLookUpEdit
            // 
            this.GiderLookUpEdit.AutoHeight = false;
            this.GiderLookUpEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.GiderLookUpEdit.Name = "GiderLookUpEdit";
            // 
            // miktar
            // 
            this.miktar.Caption = "Miktar";
            this.miktar.FieldName = "miktar";
            this.miktar.Name = "miktar";
            this.miktar.Visible = true;
            this.miktar.VisibleIndex = 1;
            // 
            // fiyat
            // 
            this.fiyat.Caption = "Fiyat";
            this.fiyat.FieldName = "fiyat";
            this.fiyat.Name = "fiyat";
            this.fiyat.Visible = true;
            this.fiyat.VisibleIndex = 2;
            // 
            // tutar
            // 
            this.tutar.Caption = "Tutar";
            this.tutar.FieldName = "tutar";
            this.tutar.Name = "tutar";
            this.tutar.Visible = true;
            this.tutar.VisibleIndex = 3;
            // 
            // scrGiderHareket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1267, 475);
            this.Controls.Add(this.cGridControl1);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "scrGiderHareket";
            this.Text = "Gider Hareketi";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkFirma.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chKontrol.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAciklama.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKod.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtTime.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtTime.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GiderLookUpEdit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private afbLibrary.cGridControl cGridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.TextEdit txtAciklama;
        private DevExpress.XtraEditors.TextEdit txtKod;
        private DevExpress.XtraEditors.DateEdit dtTime;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.CheckEdit chKontrol;
        private DevExpress.XtraEditors.SeparatorControl separatorControl2;
        private DevExpress.XtraEditors.SeparatorControl separatorControl1;
        private DevExpress.XtraEditors.SimpleButton btnKapat;
        private DevExpress.XtraEditors.SimpleButton btnKaydetKapat;
        private DevExpress.XtraEditors.SimpleButton btnKaydet;
        private DevExpress.XtraGrid.Columns.GridColumn id;
        private DevExpress.XtraGrid.Columns.GridColumn mainid;
        private DevExpress.XtraGrid.Columns.GridColumn giderid;
        private DevExpress.XtraGrid.Columns.GridColumn miktar;
        private DevExpress.XtraGrid.Columns.GridColumn fiyat;
        private DevExpress.XtraGrid.Columns.GridColumn tutar;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit GiderLookUpEdit;
        private DevExpress.XtraEditors.LookUpEdit lkFirma;
    }
}