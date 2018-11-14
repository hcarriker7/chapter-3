using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectedRaisesGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRaise_Click(object sender, EventArgs e)
        {
            double salary;
            double raise;

            salary = Convert.ToInt32(text1.Text);

            raise = salary * .04 + salary;
            lblresult.Text = "The total salary is  " + raise;
                
        }
    }
}
