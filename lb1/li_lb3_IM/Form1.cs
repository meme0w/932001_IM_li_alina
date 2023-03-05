using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace li_lb3_IM
{
    public partial class Form1 : Form
    {

        bool help = true;
        List<Control> labels = new List<Control>(); //создаем список элементов управления - лэйблов, для нумерации строк
        string biNumber; //переменная для ддвоичного представления
        List<int> FirstLine; //первая линия, которая должна быть заполнена по шаблону
        Color[,] Colors; //массив цветов для сохранения цвета для каждой ячейки в таблице
        List<int> line = new List<int>(new int[15]);
        List<int> otherLine = new List<int>(new int[15]);

        public Form1()
        {
            InitializeComponent();

            Colors = new Color[15, 14];
            for (int i = 0; i < 15; i++)
            {
                for (int j = 0; j < 14; j++)
                {
                    Colors[i, j] = SystemColors.Control;
                }
            }
        }

        private void edRule_ValueChanged(object sender, EventArgs e)
        {

        }

        private void acriveBut_Click(object sender, EventArgs e)
        {
            if (help)
            {
                labels.Add(label0);
                labels.Add(label1);
                labels.Add(label2);
                labels.Add(label3);
                labels.Add(label4);
                labels.Add(label5);
                labels.Add(label6);
                labels.Add(label7);
                labels.Add(label8);
                labels.Add(label9);
                labels.Add(label10);
                labels.Add(label11);
                labels.Add(label12);

                table.Refresh(); //таблица и её дочерние элементы управления становятся недействительными и перерисовываются
                biNumber = Convert.ToString((int)edRule.Value, 2); //перевод числа в двоичное представление

                if (biNumber.Length != 8)//если длина двоичного числа не достигает 8, то
                {
                    int n = 8 - biNumber.Length; //смотрим, сколько цифр не хватает
                    for (int i = 0; i < n; i++)
                    {
                        biNumber = biNumber.Insert(0, "0"); //вставляем спереди нули
                    }
                }

                //далее заполняем первую линию
                FirstLine = new List<int>(new int[15]); //в первой линии 15 квадратиков
                for (int i = 0; i < FirstLine.Count; i++)
                {
                    if (i == 7 || i == 8 || i == 12)
                    {
                        FirstLine[i] = 1; //квадратик заполняется цветом
                        Colors[i, 0] = Color.Green; //красим ячейку в зеленый
                    }
                    else
                    {
                        FirstLine[i] = 0; //пустой квадратик
                    }
                }

                for (int i = 0; i < otherLine.Count; i++)
                {
                    otherLine[i] = 0;
                }

                table.Refresh();
                line = FirstLine;
            }
            help = false;
            
            if (acriveBut.Text == "Старт")
            {
                acriveBut.Text = "Стоп";
                timer1.Start();
            }
            else
            {
                acriveBut.Text = "Старт";
                timer1.Stop();
            }
            table.Refresh();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void label0_Click(object sender, EventArgs e)
        {

        }

        private void table_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {   //рисуем фон ячеек
            if (Colors != null)
            {
                using (var b = new SolidBrush(Colors[e.Column, e.Row]))
                {
                    e.Graphics.FillRectangle(b, e.CellBounds);
                }
            }
        }

        public int check(string help)
        {
            switch (help)
            {
                case "110":
                    return (int)biNumber[1] - 48;
                case "101":
                    return (int)biNumber[2] - 48;
                case "011":
                    return (int)biNumber[4] - 48;
                case "010":
                    return (int)biNumber[5] - 48;
                case "100":
                    return (int)biNumber[3] - 48;
                case "000":
                    return (int)biNumber[7] - 48;
                case "111":
                    return (int)biNumber[0] - 48;
                case "001":
                    return (int)biNumber[6] - 48;
                default:
                    return (int)biNumber[0] - 48;
            }
        }

        int Count = 1;
        bool First = true;
        private void timer1_Tick(object sender, EventArgs e)
        {
            labels[Count].Text = Count.ToString(); //записываем номер текущей строки в ячейку

            if (First == true) //если это первая строка простодолжаем дальше
            {
                First = false;
            }
            else //если это не первая строка
            {
                for (int i = 0; i < otherLine.Count; i++)
                {
                    line[i] = otherLine[i];
                }
            }

            for (int i = 0; i < line.Count; i++)
            {
                if (i != 0 && i != line.Count - 1)
                {
                    string Result = ""; //вспомогательная строка для считывания 3х символов
                    Result = line[i - 1].ToString() + line[i].ToString() + line[i + 1].ToString();
                    int result = check(Result); //провряем под какое правило подходят три считанных символа
                    otherLine[i] = result; //записываем результат действия правила
                    if (otherLine[i] == 1) //если 1, закрашиваем
                    {
                        Colors[i, Count] = Color.Green;
                    }
                }
            }

            table.Refresh();
            Count++;

            if (Count == 13)
            {
                timer1.Stop();
            }
        }
    }
}
