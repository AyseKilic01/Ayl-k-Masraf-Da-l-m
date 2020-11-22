using DevExpress.XtraEditors.Controls;
using System.Drawing;

namespace AylikMasrafTakibi.scrViews
{
    partial class winformmain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(winformmain));
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.tanımlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.giderTipleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.giderTanımlarıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tanımlarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmGiderTip = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmGiderTanimi = new System.Windows.Forms.ToolStripMenuItem();
            this.raporTakibiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.muhasebeTakipRaporlarıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aylıkMasrafDağılımıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ımageSlider1 = new DevExpress.XtraEditors.Controls.ImageSlider();
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ımageSlider1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tanımlarToolStripMenuItem,
            this.tanımlarToolStripMenuItem1,
            this.raporTakibiToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(811, 24);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // tanımlarToolStripMenuItem
            // 
            this.tanımlarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.giderTipleriToolStripMenuItem,
            this.giderTanımlarıToolStripMenuItem});
            this.tanımlarToolStripMenuItem.Name = "tanımlarToolStripMenuItem";
            this.tanımlarToolStripMenuItem.Size = new System.Drawing.Size(111, 20);
            this.tanımlarToolStripMenuItem.Text = "Kullanıcı İşlemleri";
            // 
            // giderTipleriToolStripMenuItem
            // 
            this.giderTipleriToolStripMenuItem.Name = "giderTipleriToolStripMenuItem";
            this.giderTipleriToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.giderTipleriToolStripMenuItem.Text = "Şifre Değiştir";
            // 
            // giderTanımlarıToolStripMenuItem
            // 
            this.giderTanımlarıToolStripMenuItem.Name = "giderTanımlarıToolStripMenuItem";
            this.giderTanımlarıToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.giderTanımlarıToolStripMenuItem.Text = "Yönetici Paneli";
            // 
            // tanımlarToolStripMenuItem1
            // 
            this.tanımlarToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmGiderTip,
            this.tsmGiderTanimi});
            this.tanımlarToolStripMenuItem1.Name = "tanımlarToolStripMenuItem1";
            this.tanımlarToolStripMenuItem1.Size = new System.Drawing.Size(64, 20);
            this.tanımlarToolStripMenuItem1.Text = "Tanımlar";
            // 
            // tsmGiderTip
            // 
            this.tsmGiderTip.Name = "tsmGiderTip";
            this.tsmGiderTip.Size = new System.Drawing.Size(153, 22);
            this.tsmGiderTip.Text = "Gider Tipleri";
            this.tsmGiderTip.Click += new System.EventHandler(this.tsmGiderTip_Click);
            // 
            // tsmGiderTanimi
            // 
            this.tsmGiderTanimi.Name = "tsmGiderTanimi";
            this.tsmGiderTanimi.Size = new System.Drawing.Size(153, 22);
            this.tsmGiderTanimi.Text = "Gider Tanımları";
            this.tsmGiderTanimi.Click += new System.EventHandler(this.tsmGiderTanimi_Click);
            // 
            // raporTakibiToolStripMenuItem
            // 
            this.raporTakibiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.muhasebeTakipRaporlarıToolStripMenuItem});
            this.raporTakibiToolStripMenuItem.Name = "raporTakibiToolStripMenuItem";
            this.raporTakibiToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.raporTakibiToolStripMenuItem.Text = "Rapor Takibi";
            // 
            // muhasebeTakipRaporlarıToolStripMenuItem
            // 
            this.muhasebeTakipRaporlarıToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aylıkMasrafDağılımıToolStripMenuItem});
            this.muhasebeTakipRaporlarıToolStripMenuItem.Name = "muhasebeTakipRaporlarıToolStripMenuItem";
            this.muhasebeTakipRaporlarıToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.muhasebeTakipRaporlarıToolStripMenuItem.Text = "Muhasebe Takip  Raporları";
            // 
            // aylıkMasrafDağılımıToolStripMenuItem
            // 
            this.aylıkMasrafDağılımıToolStripMenuItem.Name = "aylıkMasrafDağılımıToolStripMenuItem";
            this.aylıkMasrafDağılımıToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.aylıkMasrafDağılımıToolStripMenuItem.Text = "Aylık Masraf Dağılımı";
            // 
            // ımageSlider1
            // 
            this.ımageSlider1.AnimationTime = 1200;
            this.ımageSlider1.CurrentImageIndex = 0;
            this.ımageSlider1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ımageSlider1.Images.Add(((System.Drawing.Image)(resources.GetObject("ımageSlider1.Images"))));
            this.ımageSlider1.Images.Add(((System.Drawing.Image)(resources.GetObject("ımageSlider1.Images1"))));
            this.ımageSlider1.Images.Add(((System.Drawing.Image)(resources.GetObject("ımageSlider1.Images2"))));
            this.ımageSlider1.LayoutMode = DevExpress.Utils.Drawing.ImageLayoutMode.MiddleCenter;
            this.ımageSlider1.Location = new System.Drawing.Point(0, 24);
            this.ımageSlider1.Name = "ımageSlider1";
            this.ımageSlider1.Size = new System.Drawing.Size(811, 237);
            this.ımageSlider1.TabIndex = 2;
            this.ımageSlider1.Text = "ımageSlider1";
            // 
            // scrMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 261);
            this.Controls.Add(this.ımageSlider1);
            this.Controls.Add(this.menuStrip2);
            this.Name = "scrMain";
            this.Text = "Aylık Masraf Takibi";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.scrMain_FormClosing);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ımageSlider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem tanımlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem giderTipleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem giderTanımlarıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tanımlarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tsmGiderTip;
        private System.Windows.Forms.ToolStripMenuItem tsmGiderTanimi;
        private System.Windows.Forms.ToolStripMenuItem raporTakibiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem muhasebeTakipRaporlarıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aylıkMasrafDağılımıToolStripMenuItem;
        private DevExpress.XtraEditors.Controls.ImageSlider ımageSlider1;
    }
}