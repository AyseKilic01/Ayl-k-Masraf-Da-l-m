namespace AylikMasrafTakibi.AForms
{
    partial class AFrmGiderHareketList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AFrmGiderHareketList));
            this.cGridControl1 = new afbLibrary.cGridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfirmref = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colkod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colaciklama = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltarih = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnYeniKayit = new DevExpress.XtraEditors.SimpleButton();
            this.btnListele = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.cGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // cGridControl1
            // 
            this.cGridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cGridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cGridControl1.Location = new System.Drawing.Point(186, 71);
            this.cGridControl1.MainView = this.gridView1;
            this.cGridControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cGridControl1.Name = "cGridControl1";
            this.cGridControl1.Size = new System.Drawing.Size(1251, 520);
            this.cGridControl1.TabIndex = 0;
            this.cGridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.cGridControl1.Load += new System.EventHandler(this.cGridControl1_Load);
            // 
            // gridView1
            // 
            this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.Appearance.TopNewRow.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gridView1.Appearance.TopNewRow.Options.UseFont = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.id,
            this.colfirmref,
            this.colkod,
            this.colaciklama,
            this.coltarih});
            this.gridView1.DetailHeight = 431;
            this.gridView1.GridControl = this.cGridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView1_RowClick);
            // 
            // id
            // 
            this.id.Caption = "id";
            this.id.FieldName = "id";
            this.id.MinWidth = 27;
            this.id.Name = "id";
            this.id.Width = 100;
            // 
            // colfirmref
            // 
            this.colfirmref.Caption = "Firma";
            this.colfirmref.FieldName = "firmakod";
            this.colfirmref.MinWidth = 27;
            this.colfirmref.Name = "colfirmref";
            this.colfirmref.Visible = true;
            this.colfirmref.VisibleIndex = 1;
            this.colfirmref.Width = 218;
            // 
            // colkod
            // 
            this.colkod.Caption = "Fiş Kodu";
            this.colkod.FieldName = "kod";
            this.colkod.MinWidth = 27;
            this.colkod.Name = "colkod";
            this.colkod.Visible = true;
            this.colkod.VisibleIndex = 0;
            this.colkod.Width = 135;
            // 
            // colaciklama
            // 
            this.colaciklama.Caption = "Fiş Açıklaması";
            this.colaciklama.FieldName = "aciklama";
            this.colaciklama.MinWidth = 27;
            this.colaciklama.Name = "colaciklama";
            this.colaciklama.Visible = true;
            this.colaciklama.VisibleIndex = 2;
            this.colaciklama.Width = 292;
            // 
            // coltarih
            // 
            this.coltarih.Caption = "Fiş Tarihi";
            this.coltarih.DisplayFormat.FormatString = "d";
            this.coltarih.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.coltarih.FieldName = "tarih";
            this.coltarih.MinWidth = 27;
            this.coltarih.Name = "coltarih";
            this.coltarih.Visible = true;
            this.coltarih.VisibleIndex = 3;
            this.coltarih.Width = 300;
            // 
            // btnYeniKayit
            // 
            this.btnYeniKayit.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYeniKayit.Appearance.Options.UseFont = true;
            this.btnYeniKayit.Location = new System.Drawing.Point(23, 101);
            this.btnYeniKayit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnYeniKayit.Name = "btnYeniKayit";
            this.btnYeniKayit.Size = new System.Drawing.Size(146, 28);
            this.btnYeniKayit.TabIndex = 1;
            this.btnYeniKayit.Text = "Yeni Kayıt";
            this.btnYeniKayit.Click += new System.EventHandler(this.btnYeniKayit_Click);
            // 
            // btnListele
            // 
            this.btnListele.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnListele.Appearance.Options.UseFont = true;
            this.btnListele.Location = new System.Drawing.Point(23, 42);
            this.btnListele.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(146, 28);
            this.btnListele.TabIndex = 0;
            this.btnListele.Text = "Listeyi Güncelle";
            this.btnListele.Click += new System.EventHandler(this.Refresh);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnYeniKayit);
            this.groupBox1.Controls.Add(this.btnListele);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(0, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(186, 520);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // panelControl1
            // 
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1437, 71);
            this.panelControl1.TabIndex = 3;
            // 
            // AFrmGiderHareketList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1437, 591);
            this.Controls.Add(this.cGridControl1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panelControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AFrmGiderHareketList";
            this.Text = "Gider Hareketleri";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.cGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private afbLibrary.cGridControl cGridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn id;
        private DevExpress.XtraGrid.Columns.GridColumn colkod;
        private DevExpress.XtraGrid.Columns.GridColumn colaciklama;
        private DevExpress.XtraGrid.Columns.GridColumn coltarih;
        private DevExpress.XtraGrid.Columns.GridColumn colfirmref;
        private DevExpress.XtraEditors.SimpleButton btnYeniKayit;
        private DevExpress.XtraEditors.SimpleButton btnListele;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
    }
}