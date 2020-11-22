namespace AylikMasrafTakibi
{
    partial class srcLogin
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnLogin = new DevExpress.XtraEditors.SimpleButton();
            this.vrUsername = new DevExpress.XtraEditors.TextEdit();
            this.vrPassword = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textEdit3 = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vrUsername.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vrPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.textEdit3);
            this.panelControl1.Controls.Add(this.label2);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Controls.Add(this.vrPassword);
            this.panelControl1.Controls.Add(this.vrUsername);
            this.panelControl1.Controls.Add(this.btnLogin);
            this.panelControl1.Location = new System.Drawing.Point(12, 34);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(260, 185);
            this.panelControl1.TabIndex = 0;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(166, 137);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "Giriş";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // vrUsername
            // 
            this.vrUsername.Location = new System.Drawing.Point(109, 70);
            this.vrUsername.Name = "vrUsername";
            this.vrUsername.Size = new System.Drawing.Size(132, 20);
            this.vrUsername.TabIndex = 1;
            // 
            // vrPassword
            // 
            this.vrPassword.Location = new System.Drawing.Point(109, 96);
            this.vrPassword.Name = "vrPassword";
            this.vrPassword.Size = new System.Drawing.Size(132, 20);
            this.vrPassword.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Kullanıcı Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Şifre";
            // 
            // textEdit3
            // 
            this.textEdit3.EditValue = "Aylık Masraf Takibi - AFB";
            this.textEdit3.Enabled = false;
            this.textEdit3.Location = new System.Drawing.Point(29, 24);
            this.textEdit3.Name = "textEdit3";
            this.textEdit3.Properties.Appearance.BackColor = System.Drawing.Color.DodgerBlue;
            this.textEdit3.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.textEdit3.Properties.Appearance.Options.UseBackColor = true;
            this.textEdit3.Properties.Appearance.Options.UseForeColor = true;
            this.textEdit3.Size = new System.Drawing.Size(212, 20);
            this.textEdit3.TabIndex = 5;
            // 
            // srcLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.panelControl1);
            this.Name = "srcLogin";
            this.Text = "Aylık Masraf Takibi - AFB";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vrUsername.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vrPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.TextEdit vrUsername;
        private DevExpress.XtraEditors.SimpleButton btnLogin;
        private DevExpress.XtraEditors.TextEdit textEdit3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit vrPassword;
    }
}

