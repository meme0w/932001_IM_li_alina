using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_8_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double p = 0.5;
        Random rnd = new Random();

        private void answBut_Click(object sender, EventArgs e)
        {
            double value = rnd.NextDouble();
            if (value > p)
            {
                answer.Text = "Yes!";
                answer.Visible = true;
            }
            else if(value < p)
            {
                answer.Text = "No!";
                answer.Visible = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            answer.Visible = false;
        }
    }
}
