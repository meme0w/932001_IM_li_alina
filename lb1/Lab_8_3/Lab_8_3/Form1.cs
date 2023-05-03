using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_8_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double pb1, pb2, pb3, pb4, pb5;
        double p1, p2, p3, p4, p5;
       

        private void startBut_Click(object sender, EventArgs e)
        {
            double[] results = new double[5];
            pb1 = (Double)prob1.Value;
            pb2 = (Double)prob2.Value;
            pb3 = (Double)prob3.Value;
            pb4 = (Double)prob4.Value;
            pb5 = (Double)prob5.Value;
            p1 = pb1;
            p2 = pb1 + pb2;
            p3 = pb1 + pb2 + pb3;
            p4 = pb1 + pb2 + pb3 + pb4;
            Random rnd = new Random();
            int n = (int)trials.Value;
            for(int i = 0; i < n; i++)
            {
               double f = rnd.NextDouble();
               if (f < p1)
                {
                    results[0]++;
                }
               else if (f > p1 && f < p2)
                {
                    results[1]++;
                }
               else if (f > p2 && f < p3)
                {
                    results[2]++;
                }
               else if (f > p3 && f < p4)
                {
                    results[3]++;
                }
               else if (f > p4)
                {
                    results[4]++;
                }

            }
            Console.WriteLine((Double)(results[0] / n));
            Console.WriteLine((Double)(results[1] / n));
            Console.WriteLine((Double)(results[2] / n));
            Console.WriteLine((Double)(results[3] / n));
            Console.WriteLine((Double)(results[4] / n));

            chart1.Series[0].Points.Clear();
            chart1.Series[0].Points.AddXY(1, results[0] / n);
            chart1.Series[0].Points.AddXY(2, results[1] / n);
            chart1.Series[0].Points.AddXY(3, results[2] / n);
            chart1.Series[0].Points.AddXY(4, results[3] / n);
            chart1.Series[0].Points.AddXY(5, results[4] / n);


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            prob5.Value = 1 - prob1.Value - prob2.Value - prob3.Value - prob4.Value;
           
        }
    }
}
