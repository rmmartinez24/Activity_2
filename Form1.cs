using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity_Two
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ConvertWeight_Click(object sender, EventArgs e)
        {
            lblWarning.Text = "";
            const double CONSTANT = 9.8;
            double mass = 0;

            if (double.TryParse(txtMass.Text, out mass))
            {
                double weight = mass * CONSTANT;
                txtWeight.Text = weight.ToString("n2");

                if (mass > 1000)
                {
                    lblWarning.Text = "Weight is to heavy";
                }
                else if (mass < 10)
                {
                    lblWarning.Text = "Weight is to light";
                }
            }
            else
            {
               MessageBox.Show("In Valid");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
