﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MilesToKilometersGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCon_Click(object sender, EventArgs e)
        {
            double miles;
            double kilometers;
            

            miles = Convert.ToInt32(text1.Text);

            kilometers = miles / 1.6;
            lblResult.Text = "The amount of kilometers is " + kilometers;

        }
    }
}
