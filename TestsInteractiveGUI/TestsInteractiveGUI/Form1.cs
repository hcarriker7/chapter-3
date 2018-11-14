using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestsInteractiveGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            double test1;
            double test2;
            double test3;
            double test4;
            double test5;
            double average;

            test1 = Convert.ToInt32(txt1.Text);
            test2 = Convert.ToInt32(txt2.Text);
            test3 = Convert.ToInt32(txt3.Text);
            test4 = Convert.ToInt32(txt4.Text);
            test5 = Convert.ToInt32(txt5.Text);

            average = test1 + test2 + test3 + test4 + test5 / 5;

            lblResult.Text = "The average is " + average;
        }
    }
}
