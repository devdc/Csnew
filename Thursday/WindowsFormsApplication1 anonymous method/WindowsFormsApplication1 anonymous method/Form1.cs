﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1_anonymous_method
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button1.Click += delegate(object obj, EventArgs e) { MessageBox.Show("Test"); };
            button1.Click += (s, e) => { MessageBox.Show("Test2"); };
        }
    }
}
