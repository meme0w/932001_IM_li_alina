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
        double f = 0.9;
        int k;
        Random rnd = new Random();

        private void answBut_Click(object sender, EventArgs e)
        {
            double value = rnd.NextDouble();
            if (value < p)
            {
                k = 0;
                answer.Text = "Стоит сто раз подумать!";
                answer.Visible = true;
                
            }
            else if (value > p && value < f)
            {
                k = 1;
                answer.Text = "Обязательно!";
                answer.Visible = true;
            }
            else if(value > f)
            {
                k = 2;
                answer.Text = "Точно нет!";
                answer.Visible = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            answer.Visible = false;
        }
    }
}
