﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Area_Of_Circle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int radius;
            float area,circ;
            radius = Convert.ToInt32(textBox1.Text);
            area = 3.14f * radius * radius;
            circ = 2 * 3.14f * radius;
            label2.Text = "Area of Circumference: " + area;
            label3.Text = "Circumference of Circle: " + circ;
        }
    }
}
