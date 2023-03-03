using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace li_lb2_IM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double rateEuro, rateDollar; //курсы валют
        const double k = 0.1; //коэффициент для формулы
        Random random = new Random();
        bool help = true; //для распознавания начала построения нового моделирования

        private void timer1_Tick(object sender, EventArgs e)
        {
                rateEuro = rateEuro * (1 + k * (random.NextDouble() - 0.5)); //формула из презентации
                rateDollar = rateDollar * (1 + k * (random.NextDouble() - 0.5)); //NextDouble() возврщает от 0 до 1
                chart1.Series[0].Points.AddXY(0, rateEuro);
                chart1.Series[1].Points.AddXY(0, rateDollar);
        }

        private void clearBut_Click(object sender, EventArgs e)
        {
            chart1.Series[0].Points.Clear(); //очистка
            chart1.Series[1].Points.Clear(); //очистка
            help = true; //можно начать построение нового моделирования
        }

        private void activeBut_Click(object sender, EventArgs e)
        {
            if (help)//если новое моделирование
            { 
                rateEuro = (double)edEuro.Value; //берем текущее значение Евро
                rateDollar = (double)edDollar.Value; //берем текущее значение Доллара

                chart1.Series[0].Points.Clear(); //очистка
                chart1.Series[1].Points.Clear(); //очистка
                chart1.Series[0].Points.AddXY(0, rateEuro); //ставим первую точку
                chart1.Series[1].Points.AddXY(0, rateDollar); //ставим первую точку
            }
            help = false;
            if (activeBut.Text == "Старт")
            {
                activeBut.Text = "Стоп";//меняем название кнопки
                timer1.Start(); //начинаем моделирование
            }
            else
            {
                activeBut.Text = "Старт";//меняем название кнопки
                timer1.Stop();//останавливаем моделирование
            }
        }
    }
}
