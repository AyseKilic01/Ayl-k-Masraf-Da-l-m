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
            this.vScrollBar1 = new DevExpress.XtraEditors.VScrollBar();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.dsGider = new AylikMasrafTakibi.afbDataSet1();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colexplanation = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colgidertipi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colvadetarih = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpasif = new DevExpress.XtraGrid.Columns.GridColumn();
            this.parGiderTableAdapter1 = new AylikMasrafTakibi.afbDataSet1TableAdapters.parGiderTableAdapter();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsGider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Dock = System.Windows.Forms.DockStyle.Right;
            this.vScrollBar1.Location = new System.Drawing.Point(580, 60);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(17, 201);
            this.vScrollBar1.TabIndex = 1;
            // 
            // gridControl1
            // 
            this.gridControl1.DataMember = "parGider";
            this.gridControl1.DataSource = this.dsGider;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 60);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(580, 201);
            this.gridControl1.TabIndex = 2;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // dsGider
            // 
            this.dsGider.DataSetName = "dsGider";
            this.dsGider.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colcode,
            this.colexplanation,
            this.colgidertipi,
            this.colvadetarih,
            this.colpasif});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            this.colid.OptionsColumn.ShowCaption = false;
            this.colid.OptionsColumn.ShowInCustomizationForm = false;
            this.colid.OptionsColumn.ShowInExpressionEditor = false;
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
            this.colgidertipi.Caption = "Gider Tipi";
            this.colgidertipi.FieldName = "gidertipi";
            this.colgidertipi.Name = "colgidertipi";
            this.colgidertipi.Visible = true;
            this.colgidertipi.VisibleIndex = 2;
            // 
            // colvadetarih
            // 
            this.colvadetarih.Caption = "Vade Tarihi";
            this.colvadetarih.FieldName = "vadetarih";
            this.colvadetarih.Name = "colvadetarih";
            this.colvadetarih.Visible = true;
            this.colvadetarih.VisibleIndex = 3;
            // 
            // colpasif
            // 
            this.colpasif.Caption = "Pasif";
            this.colpasif.FieldName = "pasif";
            this.colpasif.Name = "colpasif";
            this.colpasif.Visible = true;
            this.colpasif.VisibleIndex = 4;
            // 
            // parGiderTableAdapter1
            // 
            this.parGiderTableAdapter1.ClearBeforeFill = true;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.simpleButton3);
            this.groupControl1.Controls.Add(this.simpleButton2);
            this.groupControl1.Controls.Add(this.simpleButton1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(597, 60);
            this.groupControl1.TabIndex = 3;
            // 
            // simpleButton3
            // 
            this.simpleButton3.Location = new System.Drawing.Point(223, 24);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(75, 23);
            this.simpleButton3.TabIndex = 2;
            this.simpleButton3.Text = "Kapat";
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(112, 24);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(105, 23);
            this.simpleButton2.TabIndex = 1;
            this.simpleButton2.Text = "Kaydet && Kapat";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(31, 24);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 0;
            this.simpleButton1.Text = "Kaydet";
            // 
            // scrGiderTanim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 261);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.groupControl1);
            this.Name = "scrGiderTanim";
            this.Text = "Gider Tanımları";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.scrGiderTanim_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsGider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.VScrollBar vScrollBar1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private afbDataSet1 dsGider;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colcode;
        private DevExpress.XtraGrid.Columns.GridColumn colexplanation;
        private DevExpress.XtraGrid.Columns.GridColumn colgidertipi;
        private DevExpress.XtraGrid.Columns.GridColumn colvadetarih;
        private DevExpress.XtraGrid.Columns.GridColumn colpasif;
        private afbDataSet1TableAdapters.parGiderTableAdapter parGiderTableAdapter1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}