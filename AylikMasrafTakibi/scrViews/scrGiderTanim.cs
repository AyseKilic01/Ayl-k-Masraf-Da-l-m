﻿using System;
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
    public partial class scrGiderTanim : Form
    {
        public scrGiderTanim()
        {
            InitializeComponent();
            // This line of code is generated by Data Source Configuration Wizard
            parGiderTableAdapter1.Fill(dsGider.parGider);
        }

        private void scrGiderTanim_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
