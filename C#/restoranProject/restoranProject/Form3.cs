﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace restoranProject
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 ac = new Form2();
            ac.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 ac = new Form4();
            ac.ShowDialog();
        }
    }
}
