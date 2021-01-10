namespace AylikMasrafTakibi.scrViews
{
    partial class scrMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(scrMain));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barSubItem2 = new DevExpress.XtraBars.BarSubItem();
            this.btnChangePass = new DevExpress.XtraBars.BarButtonItem();
            this.btnAdminPanel = new DevExpress.XtraBars.BarButtonItem();
            this.barSubItem3 = new DevExpress.XtraBars.BarSubItem();
            this.barSubItem7 = new DevExpress.XtraBars.BarSubItem();
            this.btnGiderTip = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnGiderTanim = new DevExpress.XtraBars.BarButtonItem();
            this.barSubItem8 = new DevExpress.XtraBars.BarSubItem();
            this.btnFirmaTanim = new DevExpress.XtraBars.BarButtonItem();
            this.barSubItem6 = new DevExpress.XtraBars.BarSubItem();
            this.btnGiderHar = new DevExpress.XtraBars.BarButtonItem();
            this.barSubItem4 = new DevExpress.XtraBars.BarSubItem();
            this.barSubItem5 = new DevExpress.XtraBars.BarSubItem();
            this.btnRaporAylik = new DevExpress.XtraBars.BarButtonItem();
            this.btnGiderHareketi = new DevExpress.XtraBars.BarButtonItem();
            this.cBarButtonItem1 = new afbLibrary.cBarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barToolbarsListItem1 = new DevExpress.XtraBars.BarToolbarsListItem();
            this.barSubItem1 = new DevExpress.XtraBars.BarSubItem();
            this.btnGiderTanim = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barToolbarsListItem1,
            this.barSubItem1,
            this.barSubItem2,
            this.barSubItem3,
            this.barSubItem4,
            this.btnChangePass,
            this.btnAdminPanel,
            this.btnGiderTip,
            this.btnGiderTanim,
            this.barButtonItem5,
            this.barSubItem5,
            this.btnRaporAylik,
            this.barSubItem6,
            this.btnGiderHar,
            this.btnGiderHareketi,
            this.barSubItem7,
            this.barBtnGiderTanim,
            this.barSubItem8,
            this.btnFirmaTanim,
            this.cBarButtonItem1});
            this.barManager1.MaxItemId = 21;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem2),
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem3),
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem6),
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem4)});
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barSubItem2
            // 
            this.barSubItem2.Caption = "Kullanıcı İşlemleri";
            this.barSubItem2.Id = 2;
            this.barSubItem2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnChangePass),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnAdminPanel)});
            this.barSubItem2.Name = "barSubItem2";
            // 
            // btnChangePass
            // 
            this.btnChangePass.Caption = "Şifre Değiştir";
            this.btnChangePass.Id = 6;
            this.btnChangePass.Name = "btnChangePass";
            this.btnChangePass.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnChangePass_ItemClick);
            // 
            // btnAdminPanel
            // 
            this.btnAdminPanel.Caption = "Yönetici Paneli";
            this.btnAdminPanel.Id = 7;
            this.btnAdminPanel.Name = "btnAdminPanel";
            this.btnAdminPanel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAdminPanel_ItemClick);
            // 
            // barSubItem3
            // 
            this.barSubItem3.Caption = "Tanımlar";
            this.barSubItem3.Id = 4;
            this.barSubItem3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barSubItem7, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem8)});
            this.barSubItem3.Name = "barSubItem3";
            // 
            // barSubItem7
            // 
            this.barSubItem7.Caption = "Gider Tanımları";
            this.barSubItem7.Id = 16;
            this.barSubItem7.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnGiderTip),
            new DevExpress.XtraBars.LinkPersistInfo(this.barBtnGiderTanim)});
            this.barSubItem7.Name = "barSubItem7";
            // 
            // btnGiderTip
            // 
            this.btnGiderTip.Caption = "Gider Tipleri";
            this.btnGiderTip.Id = 8;
            this.btnGiderTip.Name = "btnGiderTip";
            this.btnGiderTip.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGiderTip_ItemClick);
            // 
            // barBtnGiderTanim
            // 
            this.barBtnGiderTanim.Caption = "Gider Tanımı";
            this.barBtnGiderTanim.Id = 17;
            this.barBtnGiderTanim.Name = "barBtnGiderTanim";
            this.barBtnGiderTanim.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGiderTanim_ItemClick);
            // 
            // barSubItem8
            // 
            this.barSubItem8.Caption = "Firma Tanımları";
            this.barSubItem8.Id = 18;
            this.barSubItem8.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnFirmaTanim)});
            this.barSubItem8.Name = "barSubItem8";
            // 
            // btnFirmaTanim
            // 
            this.btnFirmaTanim.Caption = "Firma Tanımı";
            this.btnFirmaTanim.Id = 19;
            this.btnFirmaTanim.Name = "btnFirmaTanim";
            this.btnFirmaTanim.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnFirmaTanim_ItemClick);
            // 
            // barSubItem6
            // 
            this.barSubItem6.Caption = "Gider Takibi";
            this.barSubItem6.Id = 13;
            this.barSubItem6.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnGiderHar)});
            this.barSubItem6.Name = "barSubItem6";
            // 
            // btnGiderHar
            // 
            this.btnGiderHar.Caption = "Gider Hareketleri";
            this.btnGiderHar.Id = 14;
            this.btnGiderHar.Name = "btnGiderHar";
            this.btnGiderHar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGiderHar_ItemClick);
            // 
            // barSubItem4
            // 
            this.barSubItem4.Caption = "Raporlar";
            this.barSubItem4.Id = 5;
            this.barSubItem4.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem5)});
            this.barSubItem4.Name = "barSubItem4";
            // 
            // barSubItem5
            // 
            this.barSubItem5.Caption = "Muhasebe Takip Raporları";
            this.barSubItem5.Id = 11;
            this.barSubItem5.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnRaporAylik),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnGiderHareketi)});
            this.barSubItem5.Name = "barSubItem5";
            // 
            // btnRaporAylik
            // 
            this.btnRaporAylik.Caption = "Aylık Masraf Takibi";
            this.btnRaporAylik.Id = 12;
            this.btnRaporAylik.Name = "btnRaporAylik";
            this.btnRaporAylik.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRaporAylik_ItemClick);
            // 
            // btnGiderHareketi
            // 
            this.btnGiderHareketi.Caption = "Gider Hareketleri";
            this.btnGiderHareketi.Id = 15;
            this.btnGiderHareketi.Name = "btnGiderHareketi";
            this.btnGiderHareketi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGiderHareketi_ItemClick);
            // 
            // cBarButtonItem1
            // 
            this.cBarButtonItem1.Caption = "TEST";
            this.cBarButtonItem1.Id = 20;
            this.cBarButtonItem1.Name = "cBarButtonItem1";
      
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(825, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 284);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(825, 25);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 284);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(825, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 284);
            // 
            // barToolbarsListItem1
            // 
            this.barToolbarsListItem1.Caption = "barToolbarsListItem1";
            this.barToolbarsListItem1.Id = 0;
            this.barToolbarsListItem1.Name = "barToolbarsListItem1";
            // 
            // barSubItem1
            // 
            this.barSubItem1.Caption = "barSubItem1";
            this.barSubItem1.Id = 1;
            this.barSubItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem2),
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem3),
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem6),
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem4)});
            this.barSubItem1.Name = "barSubItem1";
            // 
            // btnGiderTanim
            // 
            this.btnGiderTanim.Caption = "Gider Tanımları";
            this.btnGiderTanim.Id = 9;
            this.btnGiderTanim.Name = "btnGiderTanim";
            this.btnGiderTanim.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGiderTanim_ItemClick);
            // 
            // barButtonItem5
            // 
            this.barButtonItem5.Id = 10;
            this.barButtonItem5.Name = "barButtonItem5";
            // 
            // scrMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 309);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "scrMain";
            this.Text = "Aylık Masraf Takibi";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.scrMain_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarToolbarsListItem barToolbarsListItem1;
        private DevExpress.XtraBars.BarSubItem barSubItem1;
        private DevExpress.XtraBars.BarSubItem barSubItem2;
        private DevExpress.XtraBars.BarSubItem barSubItem3;
        private DevExpress.XtraBars.BarSubItem barSubItem4;
        private DevExpress.XtraBars.BarButtonItem btnChangePass;
        private DevExpress.XtraBars.BarButtonItem btnAdminPanel;
        private DevExpress.XtraBars.BarButtonItem btnGiderTip;
        private DevExpress.XtraBars.BarButtonItem btnGiderTanim;
        private DevExpress.XtraBars.BarSubItem barSubItem5;
        private DevExpress.XtraBars.BarButtonItem btnRaporAylik;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private DevExpress.XtraBars.BarSubItem barSubItem6;
        private DevExpress.XtraBars.BarButtonItem btnGiderHar;
        private DevExpress.XtraBars.BarButtonItem btnGiderHareketi;
        private DevExpress.XtraBars.BarSubItem barSubItem7;
        private DevExpress.XtraBars.BarButtonItem barBtnGiderTanim;
        private DevExpress.XtraBars.BarSubItem barSubItem8;
        private DevExpress.XtraBars.BarButtonItem btnFirmaTanim;
        private afbLibrary.cBarButtonItem cBarButtonItem1;
    }
}