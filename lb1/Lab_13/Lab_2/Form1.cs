using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random random = new Random();

        const double k = 1;
        const double u = -0.1;
        double step = 0.1;
        double w = 0;
        const double sigm = 0.1;
        
        double rateEuro, rateDollar;
        bool begin = true;

        private void activeBut_Click(object sender, EventArgs e)
        {
            if (begin)
            {
                rateEuro = (double)edEuroRate.Value;
                rateDollar = (double)edDollarRate.Value;
                chart1.Series[0].Points.Clear();
                chart1.Series[1].Points.Clear();
                chart1.Series[0].Points.AddXY(0, rateEuro);
                chart1.Series[1].Points.AddXY(0, rateDollar);

            }
           
            begin = false;

            if (activeBut.Text == "Старт")
            {
                activeBut.Text = "Стоп";
                timer1.Start();
            }
            else
            {
                activeBut.Text = "Старт";
                timer1.Stop();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            w = w + Math.Sqrt(step) * random.NextDouble();
            rateEuro = rateEuro * Math.Exp(step * (u - sigm * sigm / 2) + sigm * w);
            Console.WriteLine(rateEuro);
            rateDollar = rateDollar * (1 + k * (random.NextDouble() - 0.5));
            Console.WriteLine(rateDollar);
            chart1.Series[0].Points.AddXY(0, rateEuro);
            chart1.Series[1].Points.AddXY(0, rateDollar);

        }

        private void clearBut_Click(object sender, EventArgs e)
        {
            chart1.Series[0].Points.Clear();
            chart1.Series[1].Points.Clear();
            begin = true;
        }
    }
}
