using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EggsInteractiveGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            int chicken1;
            int chicken2;
            int chicken3;
            int chicken4;
            int chicken5;
            int dozen;
            int remainingEggs;
            int total;

            chicken1 = Convert.ToInt32(txt1.Text);
            chicken2 = Convert.ToInt32(txt2.Text);
            chicken3 = Convert.ToInt32(txt3.Text);
            chicken4 = Convert.ToInt32(txt4.Text);
            chicken5 = Convert.ToInt32(txt5.Text);

            total = chicken1 + chicken2 + chicken3 + chicken4 + chicken5;
            dozen = total / 12;
            remainingEggs = total % 12;

            lblResult.Text = dozen + " dozens and" + remainingEggs + " eggs";


        }
    }
}
