using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloVisualWorld
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnhere_Click(object sender, EventArgs e)
        {
            lblhello.Visible = true;
            lblhello.Text = "Hello, Visual World";
        }

        private void btnGoodbye_Click(object sender, EventArgs e)
        {
            lblhello.Text = "Goodbye";
        }

        private void btnReallyLast_Click(object sender, EventArgs e)
        {
            lblhello.Visible = false;
        }
    }
}
