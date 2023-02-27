using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace li_lb1_IM
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        const int col = 6;
        const int row = 4;
        private void Form1_Load(object sender, EventArgs e)
        {
            //добавляем столбцы
            for(int j = 0; j < col; j++)
            {
                dataGridView1.Columns.Add(j.ToString(), j.ToString());
            }
            // убираем заголовок таблицы
            dataGridView1.ColumnHeadersVisible = false;
            //добавляем строки
            for (int j = 0; j < row; j++)
            {
                dataGridView1.Rows.Add();
            }
            //подписываем строки
            dataGridView1.Rows[0].HeaderCell.Value = "dt";
            dataGridView1.Rows[1].HeaderCell.Value = "Distance";
            dataGridView1.Rows[2].HeaderCell.Value = "maxHeight";
            dataGridView1.Rows[3].HeaderCell.Value = "Speed_end";
        }

        double x, y, y0, v0, a, t, sina, cosa, m, S, k, vx, vy, maxH=-1;
        double dt;
        const double g = 9.81, C = 0.15, rho = 1.29;
        int i = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            double v = Math.Sqrt(vx * vx + vy * vy);
            t += dt;

            vx = vx - k * vx * v * dt; // скорость по х
            vy = vy - (g + k * vy * v) * dt; // скорость по y
            x = x + vx * dt; // перемещение по х
            y = y + vy * dt; // перемещение по у
            if (maxH < y) maxH = y; // чтобы найти макс H

            chart1.Series[i].Points.AddXY(x, y);
            if (y <= 0) { 
                timer1.Stop(); 
                dataGridView1.Rows[1].Cells[i].Value = x.ToString(); //заполняем ячейку с дистанцией
                                  
                dataGridView1.Rows[2].Cells[i].Value = maxH.ToString();//заполняем ячейку maxH

                double endV = Math.Sqrt(vx * vx + vy * vy); // находим по формуле из корня суммы квадратов проекций скоростей
                dataGridView1.Rows[3].Cells[i].Value = endV.ToString();//заполняем ячейку Vend
                i += 1; }
            }
        
        private void buttonLaunch_Click(object sender, EventArgs e)
        {
            y0 = (double)editH.Value; //начальная высота
            v0 = (double)editS.Value; //начальная скорость
            a = (double)editA.Value; //угол
            S = (double)editSize.Value; //размер тела
            m = (double)editM.Value; //масса тела
            dt = (double)editDt.Value; //шаг по времени

            a = a * Math.PI / 180; //переводим в радианы
            cosa = (double)Math.Cos(a);
            sina = (double)Math.Sin(a);

            //заполняем ячейку dt
            dataGridView1.Rows[0].Cells[i].Value = dt.ToString();

            t = 0;
            x = 0;
            y = y0;
           
            k = 0.5 * C * rho * S / m; //коэффициент, расчитываем по данной формуле

            vx = v0 * cosa; //проекция скорости на ось ОХ
            vy = v0 * sina; //проекция скорости на ось ОY

            chart1.Series[i].Points.AddXY(x, y);

            timer1.Start();
        }
    }
}
