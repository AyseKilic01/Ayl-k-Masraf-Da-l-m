namespace AylikMasrafTakibi.scrViews
{
    partial class scrGiderTanim
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(scrGiderTanim));
            this.vScrollBar1 = new DevExpress.XtraEditors.VScrollBar();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.cGridControl1 = new afbLibrary.cGridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colexplanation = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colgidertipi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gidertipkod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colvadetarih = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpasif = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colgidertip = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Dock = System.Windows.Forms.DockStyle.Right;
            this.vScrollBar1.Location = new System.Drawing.Point(868, 60);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(17, 422);
            this.vScrollBar1.TabIndex = 1;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnKaydet);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(885, 60);
            this.groupControl1.TabIndex = 3;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(31, 24);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(75, 23);
            this.btnKaydet.TabIndex = 0;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // cGridControl1
            // 
            this.cGridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cGridControl1.Location = new System.Drawing.Point(0, 60);
            this.cGridControl1.MainView = this.gridView1;
            this.cGridControl1.Name = "cGridControl1";
            this.cGridControl1.Size = new System.Drawing.Size(868, 422);
            this.cGridControl1.TabIndex = 4;
            this.cGridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colcode,
            this.colexplanation,
            this.colgidertipi,
            this.gidertipkod,
            this.colvadetarih,
            this.colpasif,
            this.colgidertip});
            this.gridView1.GridControl = this.cGridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.NewItemRowText = "Yeni Kayıt Satırı";
            this.gridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditForm;
            this.gridView1.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click;
            this.gridView1.OptionsClipboard.AllowCopy = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsSelection.MultiSelect = true;
            this.gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.Tag = -1;
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            this.colid.OptionsColumn.ShowCaption = false;
            this.colid.OptionsColumn.ShowInCustomizationForm = false;
            this.colid.OptionsColumn.ShowInExpressionEditor = false;
            this.colid.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            // 
            // colcode
            // 
            this.colcode.Caption = "Kod";
            this.colcode.FieldName = "code";
            this.colcode.Name = "colcode";
            this.colcode.Visible = true;
            this.colcode.VisibleIndex = 0;
            // 
            // colexplanation
            // 
            this.colexplanation.Caption = "Açıklama";
            this.colexplanation.FieldName = "explanation";
            this.colexplanation.Name = "colexplanation";
            this.colexplanation.Visible = true;
            this.colexplanation.VisibleIndex = 1;
            // 
            // colgidertipi
            // 
            this.colgidertipi.Caption = "colgidertip";
            this.colgidertipi.FieldName = "gidertip";
            this.colgidertipi.Name = "colgidertipi";
            // 
            // gidertipkod
            // 
            this.gidertipkod.Caption = "Gider Tipi";
            this.gidertipkod.FieldName = "gidertipkod";
            this.gidertipkod.Name = "gidertipkod";
            this.gidertipkod.Visible = true;
            this.gidertipkod.VisibleIndex = 2;
            // 
            // colvadetarih
            // 
            this.colvadetarih.Caption = "Vade Tarihi";
            this.colvadetarih.DisplayFormat.FormatString = "d";
            this.colvadetarih.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colvadetarih.FieldName = "vadetarih";
            this.colvadetarih.Name = "colvadetarih";
            this.colvadetarih.Visible = true;
            this.colvadetarih.VisibleIndex = 3;
            // 
            // colpasif
            // 
            this.colpasif.Caption = "Pasif";
            this.colpasif.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colpasif.FieldName = "pasif";
            this.colpasif.Name = "colpasif";
            this.colpasif.Visible = true;
            this.colpasif.VisibleIndex = 4;
            // 
            // colgidertip
            // 
            this.colgidertip.Caption = "colgidertip";
            this.colgidertip.Name = "colgidertip";
            // 
            // scrGiderTanim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 482);
            this.Controls.Add(this.cGridControl1);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.groupControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "scrGiderTanim";
            this.Text = "Gider Tanımları";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.scrGiderTanim_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.VScrollBar vScrollBar1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnKaydet;
        private afbLibrary.cGridControl cGridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colcode;
        private DevExpress.XtraGrid.Columns.GridColumn colexplanation;
        private DevExpress.XtraGrid.Columns.GridColumn colgidertipi;
        private DevExpress.XtraGrid.Columns.GridColumn gidertipkod;
        private DevExpress.XtraGrid.Columns.GridColumn colvadetarih;
        private DevExpress.XtraGrid.Columns.GridColumn colpasif;
        private DevExpress.XtraGrid.Columns.GridColumn colgidertip;
    }
}