using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace li_lb4_IM
{

    public partial class Form1 : Form
    {
        bool[,] map; //поле для генерации
        Graphics graph;
        int rows; //количество строк
        int cols; //количество столбцов
        int res;
        int currentGeneration = 0;//счетчик поколений

        public Form1()
        {
            InitializeComponent();
        }

        private void butStart_Click_1(object sender, EventArgs e)
        {

            if (timer1.Enabled) //если таймер включен, ничего не делаем
                    return; //во время того, как игра началась, мы не должны иметь возможности что-то менять 

            currentGeneration = 0;
            Text = $"Generation #{currentGeneration}";
            Resolution.Enabled = false; //блокируем эти поля 
            Density.Enabled = false;

            res = (int)Resolution.Value; //считываем разрешение
            rows = pictureBox1.Height / res; // высота pictureBox1/ на разрешение
            cols = pictureBox1.Width / res; // ширина pictureBox1/ на разрешение

            map = new bool[cols, rows]; //создаем поле - массив информации о клетках

            Random rand = new Random();
            for(int x = 0; x < cols; x++) //рандомно создаем первое поколение клеток
            {
                for(int y = 0; y < rows; y++)
                {
                    map[x, y] = rand.Next((int)Density.Value) == 0; //если 0, то в соотвутсвующая ячейка = true
                } //(int)Density.Value максимальное значение при генерации случайного числа
            }

            pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height); //создаем картинку размера pictureBox1
            graph = Graphics.FromImage(pictureBox1.Image); //чтобы рисовать на нашем поле 
            //graph.FillRectangle(Brushes.Green, 0, 0, res, res);
            timer1.Start();
        }

        private void butStop_Click_1(object sender, EventArgs e)
        {
            if (!timer1.Enabled) //если таймер не включен
                return;
            timer1.Stop(); //если таймер включен, то стоп
            Resolution.Enabled = true;
            Density.Enabled = true;
        }

        private int Neighbours(int x, int y) //считаем соседей
        {
            int count = 0; 

            for (int i = -1; i < 2; i++) //х-1 дает информацию о соседе слева, х+1 о соседе справа
            {
                for (int j = -1; j < 2; j++)
                {
                    var col = (x + i + cols) % cols; //для того чтобы не вылезти за границы карты, если считаем для крайних клеток
                    var row = (y + j + rows) % rows;
                    var isSelfChecking = col == x && row == y; //проверяем самого себя, чтобы не записать себя в подсчет соседей
                    var life = map[col, row]; //для подсчета живых соседей
                    if (life && !isSelfChecking) //если есть жизнь и это не сама клетка
                    {
                        count++;
                    }
                }
            }
            return count;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            graph.Clear(Color.Black); //каждый раз при генерации нового поколения очищаем
            var newMap = new bool[cols, rows]; //для генерации следующего поколения

            for (int x = 0; x < cols; x++)
            {
                for (int y = 0; y < rows; y++)
                {
                    var neighbours = Neighbours(x, y); //подсчитываем соседей
                    var life = map[x, y]; //помечаем, есть ли живая клетка в текущих координатах

                    if (!life && neighbours == 3) //если клетка свободна и количство соседей == 3
                        newMap[x, y] = true; //то зарождается жизнь
                    
                    else if (life && (neighbours < 2 || neighbours > 3)) //если в клетке есть жизнь и количство соседей<2 или >3
                        newMap[x, y] = false; //то клетка погибает
                    
                    else //если правила не действуют, то клетка остается 
                        newMap[x, y] = map[x, y];
                    
                    if (life)
                        graph.FillRectangle(Brushes.Green, x * res, y * res, res, res);//в качестве отступа - индекс*разрешение
                }
            }
            map = newMap; //новое поколение станет текущим
            pictureBox1.Refresh(); //перерисовка игрового поля
            Text = $"Generation #{++currentGeneration}";
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Text = $"Generation #{currentGeneration}";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (!timer1.Enabled) //если игра не идет
                return;

            if (e.Button == MouseButtons.Left) //если держим левую кноаку мышки
            {
                var x = e.Location.X / res;
                var y = e.Location.Y / res;
                var validationPassed = ValidateMousePosition(x, y);
                if (validationPassed)
                    map[x, y] = true;
            }
            if (e.Button == MouseButtons.Right) //если держим правую кноаку мышки
            {
                var x = e.Location.X / res;
                var y = e.Location.Y / res;
                var validationPassed = ValidateMousePosition(x, y);
                if (validationPassed)
                    map[x, y] = false;
            }
        }

        private bool ValidateMousePosition(int x, int y) //чтобы проверить не вышла ли мышька за границу
        {
            return x >= 0 && y >= 0 && x < cols && y < rows;
        }
    }
}
