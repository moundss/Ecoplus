﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ecoplustest.Feuilles.Distribution
{
    public partial class Distribution : Form
    {
        public Distribution()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var details=new DetailsDistr();
            details.ShowDialog();
        }
    }
}
