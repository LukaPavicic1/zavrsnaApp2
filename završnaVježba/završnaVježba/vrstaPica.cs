﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace završnaVježba
{
    public partial class vrstaPica : Form
    {
        public vrstaPica()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            odabir odabir = new odabir();
            odabir.Show();
        }
    }
}
