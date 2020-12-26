namespace AylikMasrafTakibi.AForms
{
    partial class AFrmFirmaList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AFrmFirmaList));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.cGridControl1 = new afbLibrary.cGridControl();
            this.btnList = new DevExpress.XtraEditors.SimpleButton();
            this.btnKayit = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cGridControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnKayit);
            this.groupControl1.Controls.Add(this.btnList);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.ShowCaption = false;
            this.groupControl1.Size = new System.Drawing.Size(144, 261);
            this.groupControl1.TabIndex = 3;
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.cGridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            // 
            // cGridControl1
            // 
            this.cGridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cGridControl1.Location = new System.Drawing.Point(144, 0);
            this.cGridControl1.MainView = this.gridView1;
            this.cGridControl1.Name = "cGridControl1";
            this.cGridControl1.Size = new System.Drawing.Size(571, 261);
            this.cGridControl1.TabIndex = 2;
            this.cGridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // btnList
            // 
            this.btnList.Location = new System.Drawing.Point(12, 23);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(126, 23);
            this.btnList.TabIndex = 0;
            this.btnList.Text = "Listeyi Güncelle";
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // btnKayit
            // 
            this.btnKayit.Location = new System.Drawing.Point(12, 61);
            this.btnKayit.Name = "btnKayit";
            this.btnKayit.Size = new System.Drawing.Size(126, 23);
            this.btnKayit.TabIndex = 1;
            this.btnKayit.Text = "Yeni Kayıt";
            this.btnKayit.Click += new System.EventHandler(this.btnKayit_Click);
            // 
            // AFrmFirmaList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 261);
            this.Controls.Add(this.cGridControl1);
            this.Controls.Add(this.groupControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AFrmFirmaList";
            this.Text = "Firma Tanımları";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cGridControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private afbLibrary.cGridControl cGridControl1;
        private DevExpress.XtraEditors.SimpleButton btnKayit;
        private DevExpress.XtraEditors.SimpleButton btnList;
    }
}