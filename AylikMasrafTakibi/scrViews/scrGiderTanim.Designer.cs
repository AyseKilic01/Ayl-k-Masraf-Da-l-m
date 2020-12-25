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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(scrGiderTanim));
            this.vScrollBar1 = new DevExpress.XtraEditors.VScrollBar();
            this.cGridControl1 = new afbLibrary.cGridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colexplanation = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colgidertipi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gidertipkod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colvadetarih = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpasif = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colgidertip = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cBarManager1 = new afbLibrary.cBarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            ((System.ComponentModel.ISupportInitialize)(this.cGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cBarManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Dock = System.Windows.Forms.DockStyle.Right;
            this.vScrollBar1.Location = new System.Drawing.Point(868, 22);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(17, 437);
            this.vScrollBar1.TabIndex = 1;
            // 
            // cGridControl1
            // 
            this.cGridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cGridControl1.Location = new System.Drawing.Point(0, 22);
            this.cGridControl1.MainView = this.gridView1;
            this.cGridControl1.Name = "cGridControl1";
            this.cGridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.LookUpEdit1});
            this.cGridControl1.Size = new System.Drawing.Size(868, 437);
            this.cGridControl1.TabIndex = 4;
            this.cGridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.cGridControl1.Load += new System.EventHandler(this.cGridControl1_Load);
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
            this.gidertipkod.ColumnEdit = this.LookUpEdit1;
            this.gidertipkod.FieldName = "gidertipkod";
            this.gidertipkod.Name = "gidertipkod";
            this.gidertipkod.Visible = true;
            this.gidertipkod.VisibleIndex = 2;
            // 
            // LookUpEdit1
            // 
            this.LookUpEdit1.AutoHeight = false;
            this.LookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LookUpEdit1.Name = "LookUpEdit1";
            this.LookUpEdit1.EditValueChanged += new System.EventHandler(this.LookUpEdit1_EditValueChanged);
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
            // cBarManager1
            // 
            this.cBarManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2,
            this.bar3});
            this.cBarManager1.DockControls.Add(this.barDockControlTop);
            this.cBarManager1.DockControls.Add(this.barDockControlBottom);
            this.cBarManager1.DockControls.Add(this.barDockControlLeft);
            this.cBarManager1.DockControls.Add(this.barDockControlRight);
            this.cBarManager1.Form = this;
            this.cBarManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItem1,
            this.barButtonItem2,
            this.barButtonItem3});
            this.cBarManager1.MainMenu = this.bar2;
            this.cBarManager1.MaxItemId = 3;
            this.cBarManager1.StatusBar = this.bar3;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem2),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem3)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Kaydet";
            this.barButtonItem1.Id = 0;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Kaydet&&Kapat";
            this.barButtonItem2.Id = 1;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Kapat";
            this.barButtonItem3.Id = 2;
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.cBarManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(885, 22);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 459);
            this.barDockControlBottom.Manager = this.cBarManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(885, 23);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 22);
            this.barDockControlLeft.Manager = this.cBarManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 437);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(885, 22);
            this.barDockControlRight.Manager = this.cBarManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 437);
            // 
            // scrGiderTanim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 482);
            this.Controls.Add(this.cGridControl1);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "scrGiderTanim";
            this.Text = "Gider Tanımları";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.scrGiderTanim_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.cGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cBarManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.VScrollBar vScrollBar1;
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
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit LookUpEdit1;
        private afbLibrary.cBarManager cBarManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
    }
}