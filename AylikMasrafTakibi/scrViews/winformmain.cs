using DevExpress.XtraEditors.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AylikMasrafTakibi.scrViews
{
    public partial class winformmain : Form
    {
        public winformmain()
        {
            InitializeComponent();
        }

        private void scrMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void tsmGiderTip_Click(object sender, EventArgs e)
        {
            scrGiderTip frm = new scrGiderTip();
            frm.Show();
            this.Hide();
        }

        private void tsmGiderTanimi_Click(object sender, EventArgs e)
        {
            scrGiderTanim frm = new scrGiderTanim();
            frm.Show();
            this.Hide();
        }

    }
}
