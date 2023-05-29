using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_12
{
    public partial class Form1 : Form
    {
        int[] res = new int[3];
        Random rand = new Random();
        string state = "sun";
        double sunToCloud, sunToRain, cloudToSun, cloudToRain, rainToSun, rainToCloud, sunPosition, cloudPosition, rainPosition;
        double[,] mat = new double[,]
        {
            { -0.4, 0.3, 0.1 },   // солнечно
            { 0.4, -0.8, 0.4 },   // облачно
            { 0.1, 0.4, -0.5 }    // дождливо
        };

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void stopBut_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            sunPosition = res[0] / k;
            cloudPosition = res[1] / k;
            rainPosition = res[2] / k;
            Console.WriteLine();
            Console.WriteLine(res[1]);
            Console.WriteLine(res[2]);
            Console.WriteLine(k);
            nmdSun.Value = (decimal)sunPosition;
            nmdCloud.Value = (decimal)cloudPosition;
            nmdRain.Value = (decimal)rainPosition;
        }

        double k = 0;
        int N = 50;


        public Form1()
        {
          
            InitializeComponent();
        }

        private void startBut_Click(object sender, EventArgs e)
        {
            k = 0;
            res[0] = 0;res[1] = 0;res[2] = 0;
            nmdSun.Value = 0;
            nmdCloud.Value = 0;
            nmdRain.Value = 0;
            sunPosition = (double)nmdSun.Value;
            cloudPosition = (double)nmdCloud.Value;
            rainPosition = (double)nmdRain.Value;
            sunToCloud = -mat[0, 1] / mat[0, 0];
            sunToRain = -mat[0, 2] / mat[0, 0];
            cloudToSun = -mat[1, 0] / mat[1, 1];
            cloudToRain = -mat[1, 2] / mat[1, 1];
            rainToSun = -mat[2, 0] / mat[2, 2];
            rainToCloud = -mat[2, 1] / mat[2, 2];
            weatherLabel.Text = "Солнечно";
            timer1.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            k++;
            timer1.Interval = 400;
            double a = rand.NextDouble();
            Console.WriteLine(a);
            switch (state)
            {
                case "sun":
                    timer1.Interval *= 1 + (int)(Math.Log(a) / mat[0, 0]);
                    break;
                case "cloud":
                    timer1.Interval *= 1 + (int)(Math.Log(a) / mat[1, 1]);
                    break;
                case "rain":
                    timer1.Interval *= 1 + (int)(Math.Log(a) / mat[2, 2]);
                    break;
            }

            switch (state)
            {
                case "sun":
                    if (a >= 0 && a < sunToCloud)
                    {
                        state = "cloud";
                        weatherLabel.Text = "Облачно";
                        res[1]++;
                    }
                    else if (a >= sunToCloud && a < 1)
                    {
                        state = "rain";
                        weatherLabel.Text = "Дождливо";
                        res[2]++;
                    }
                    break;
                case "cloud":
                    if (a >= 0 && a < cloudToSun)
                    {
                        state = "sun";
                        weatherLabel.Text = "Солнечно";
                        res[0]++;
                    }
                    else if (a >= cloudToSun && a < 1)
                    {
                        state = "rain";
                        weatherLabel.Text = "Дождливо";
                        res[2]++;
                    }
                    break;
                case "rain":
                    if (a >= 0 && a < rainToSun)
                    {
                        state = "sun";
                        weatherLabel.Text = "Солнечно";
                        res[0]++;
                    }
                    else if (a >= rainToSun && a < 1)
                    {
                        state = "cloud";
                        weatherLabel.Text = "Облачно";
                        res[1]++;
                    }
                    break;
            }


        }
    }
}
