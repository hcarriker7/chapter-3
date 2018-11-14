using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUIcalculator1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            int num1;
            int num2;
            int sum;
           
            num1 = Convert.ToInt32(text1.Text);
            num2 = Convert.ToInt32(text2.Text);

            sum = num1 + num2;
            lblresult.Text = "The sum is " + sum;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1;
            int num2;
            int difference;

            num1 = Convert.ToInt32(text1.Text);
            num2 = Convert.ToInt32(text2.Text);

            difference = num1 - num2;
            lblresult.Text = "The difference is " + difference;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int num1;
            int num2;
            int product;

            num1 = Convert.ToInt32(text1.Text);
            num2 = Convert.ToInt32(text2.Text);

            product = num1 * num2;
            lblresult.Text = "The product is " + product;
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            int num1;
            int num2;
            int quotient;

            num1 = Convert.ToInt32(text1.Text);
            num2 = Convert.ToInt32(text2.Text);

            quotient = num1 / num2;
            lblresult.Text = "The quotient is " + quotient;


        }

        private void btnMod_Click(object sender, EventArgs e)
        {
            int num1;
            int num2;
            int mod;

            num1 = Convert.ToInt32(text1.Text);
            num2 = Convert.ToInt32(text2.Text);

            mod = num1 % num2;
            lblresult.Text = "The mod is " + mod;


        }
    }
}
