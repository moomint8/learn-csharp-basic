﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace _01_template
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Hello World!";
        }
    }
}
