using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_11
{
    public partial class Form1 : Form
    {
        double sampleSize = 0;
        double average = 0;
        double variance = 0;

        List<double> values = new List<double>();
        


      

        public Form1()
        {
            InitializeComponent();
        }

        private void startBut_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            double x = 0;
            values = new List<double>();
            sampleSize = (double)SizeNmd.Value;
            average = (double)MeanNmd.Value;
            variance = (double)VarNmd.Value;
            for(int i = 0; i < sampleSize; i++)
            {
                double x1 = rand.NextDouble();
                double x2 = rand.NextDouble();
                x = (Math.Sqrt(-2 * Math.Log(x1))) * (Math.Cos(2 * Math.PI * x2)) * (Math.Sqrt(variance)) + average;
                
                values.Add(x);
            }

            var intervalAmmount = (int)Math.Ceiling(Math.Sqrt(values.Count));
            var interval = (values.Max() - values.Min()) / intervalAmmount;
            double[] points = new double[intervalAmmount + 1];
            points[0] = values.Min();
            for(int i = 1; i < intervalAmmount+1; i++)
            {
                points[i] = points[i - 1] + interval;
            }
            Console.WriteLine("Минимальное число - " + values.Min());
            Console.WriteLine(interval);
            Console.WriteLine(points.Length);
         

            double[] freq = new double[intervalAmmount];
            for (int i = 0; i < intervalAmmount; i++)
            {
                for(int j = 0; j < values.Count; j++)
                {
                    if((values[j] > points[i]) && (values[j] <= points[i + 1]))
                    {
                        freq[i] += 1;
                    }
                }
            }
            freq[0] += 2;


            chart1.Series[0].Points.Clear();
            chart1.ChartAreas[0].AxisX.Minimum = values.Min();
            chart1.ChartAreas[0].AxisX.Maximum = points[intervalAmmount];
            chart1.ChartAreas[0].AxisX.Interval = interval;
            for (int i = 0; i < freq.Length; i++)
            {
                chart1.Series[0].Points.AddXY((points[i + 1] + points[i]) / 2, freq[i]/sampleSize);
            }
            for (int i = 0; i < freq.Length; i++)
            {
                Console.WriteLine(freq[i]);
            }
            Console.WriteLine("//////////////////////");
            for(int i = 0; i < points.Length; i++)
            {
                Console.WriteLine(points[i]);
            }


            var empAverage = 0.0;
            for(int i = 0; i < freq.Length; i++)
            {
                empAverage += (freq[i] / sampleSize) * (points[i + 1] + points[i]) / 2;
            }
            double empVariance = 0.0;
            for(int i = 0; i < freq.Length; i++)
            {
                empVariance += (freq[i] / sampleSize) * Math.Pow((points[i + 1] + points[i]) / 2 - empAverage, 2);
            }
          


            double averageError = Math.Abs((empAverage - average) /average) * 100;
            double varianceError = Math.Abs((empVariance - variance) / variance) * 100;



            /*    for (int i = 0; i < 5; i++)
                {
                    if (statProbs[i] == 0)
                        continue;
                    chiSquared += results[i] * results[i] / (n * statProbs[i]);       
                    Console.WriteLine(chiSquared);
                }

                chiSquared -= n;
    */

           

            double chi = 0;
            if (sampleSize == 10000)
                chi = 180.342;
            if (sampleSize == 1000)
                chi = 55.758;
            if (sampleSize == 100)
                chi = 18.307;
            if (sampleSize == 10)
                chi = 9.488;

            Console.WriteLine("//////////////////////////////");
            double[] probs = new double[intervalAmmount];
            for (int i = 0; i < probs.Length; i++)
            {
                double probsC = 0;
                probsC = (Math.Exp((-Math.Pow(((points[i+1]+points[i])/2 - average), 2)) / (2 * variance))) / (Math.Sqrt(2 * Math.PI * variance));
                Console.WriteLine((points[i + 1] + points[i]) / 2);
                probs[i] = (points[i + 1] - points[i]) * probsC;
            }
            Console.WriteLine("//////////////////////////////");
           /* for (int i = 0; i < probs.Length; i++)
            {
                Console.WriteLine(probs[i]);
            }
*/
            double chiSquare = 0.0;
            for(int i = 0; i < freq.Length; i++)
            {
                if (probs[i] > 0)
                {
                    chiSquare += ((freq[i] * freq[i]) / (sampleSize * probs[i]));
                   
                }
            }
            chiSquare -= sampleSize;
;






            if(sampleSize != 10 && sampleSize!=100 && sampleSize!=1000 && sampleSize != 10000)
            {
                ChiLabel.Text = "Невозможно посчитать, выберите размер выборки равный 10/100/1000/10000";
            }
            else
            {
                AverLabel.Text = Math.Round(empAverage, 3).ToString() + " (error = " + Math.Round(averageError, 3).ToString() + "% )";
                if (averageError > 100)
                {
                    AverLabel.Text = Math.Round(empAverage, 3).ToString() + " (error = big )";
                }
                VarLabel.Text = Math.Round(empVariance, 3).ToString() + " (error = " + Math.Round(varianceError, 3).ToString() + "% )";
                ChiLabel.Text = Math.Round(chiSquare, 3).ToString() + " > " + chi.ToString() + " is " + (chiSquare > chi).ToString();
            }
           



        }

        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
