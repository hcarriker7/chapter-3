using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalInteractiveGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            double days;
            double miles;
            double total;

            days = Convert.ToInt32(text1.Text);
            miles = Convert.ToInt32(text2.Text);

            total = days * 20 + miles * .25;
            lblresult.Text = "The total rental fee is " + total;

        }
    }
}
