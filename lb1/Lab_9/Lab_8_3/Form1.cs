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
        double p1, p2, p3, p4;

        double chi = 9.488;
        double chiSquared;
        double[] statProbs;
        double[] empProbs;
        double statAverage;
        double empAverage;
        double statVariance;
        double empVariance;
        double averageError;
        double varianceError;
       

        private void startBut_Click(object sender, EventArgs e)
        {
            /////////////////////////////////////////////////
           
            chiSquared = 0;
            statAverage = 0;
            empAverage = 0;
            statVariance = 0;
            empVariance = 0;
            averageError = 0;
            varianceError = 0;
            statProbs = new double[5];
            empProbs = new double[5];

            double[] results = new double[5];
            pb1 = (Double)prob1.Value;
            pb2 = (Double)prob2.Value;
            pb3 = (Double)prob3.Value;
            pb4 = (Double)prob4.Value;
            pb5 = (Double)prob5.Value;

            /////////////////////////////////////////////////
            statProbs[0] = pb1;
            statProbs[1] = pb2;
            statProbs[2] = pb3;
            statProbs[3] = pb4;
            statProbs[4] = pb5;

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

        
            chart1.Series[0].Points.Clear();
            chart1.Series[0].Points.AddXY(1, results[0] / n);
            chart1.Series[0].Points.AddXY(2, results[1] / n);
            chart1.Series[0].Points.AddXY(3, results[2] / n);
            chart1.Series[0].Points.AddXY(4, results[3] / n);
            chart1.Series[0].Points.AddXY(5, results[4] / n);

            //////////////////////////////////////////////////
            for (int i = 0; i < 5; i++)
            {
                empProbs[i] = (double)results[i] / n;
            }

            for(int i = 0; i < 5; i++)
            {
                if (statProbs[i] == 0)
                    continue;
                chiSquared += results[i] * results[i] / (n * statProbs[i]);
                Console.WriteLine(chiSquared);
            }

            chiSquared -= n;

            for(int i = 0; i< 5; i++)
            {
                statAverage += statProbs[i] * (i + 1);
                empAverage += empProbs[i] * (i + 1);
            }

            for (int i = 0; i < 5; i++)
            {
                statVariance += statProbs[i] * (i + 1) * (i + 1);
                empVariance += empProbs[i] * (i + 1) * (i + 1);
            }

            statVariance -= statAverage * statAverage;
            empVariance -= empAverage * empAverage;

            averageError = Math.Abs((empAverage - statAverage) / statAverage) * 100;
            varianceError = Math.Abs((empVariance - statVariance) / statVariance) * 100;

            averLabel.Text = Math.Round(empAverage, 3).ToString() + " (error = " + Math.Round(averageError, 3).ToString() + "% )";
            variaLabel.Text = Math.Round(empVariance, 3).ToString() + " (error = " + Math.Round(varianceError, 3).ToString() + "% )";
            chiLabel.Text = Math.Round(chiSquared, 3).ToString() + " > " + chi.ToString() + " is " + (chiSquared>chi).ToString();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            prob5.Value = 1 - prob1.Value - prob2.Value - prob3.Value - prob4.Value;
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }
 
}
