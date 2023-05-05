using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_10
{
    public partial class Form1 : Form
    {

        public List<Team> teams;
        public List<GameObject> games = new List<GameObject>();
        public List<Game> resultStrings = new List<Game>();
        Random rand = new Random();
        public int ammount = 8;
        public List<DataGridViewRow> rows = new List<DataGridViewRow>();

        public Form1()
        {   
            InitializeComponent();

            teams = new List<Team>
            {
                new Team(1,"Chelsea", 0 , 2),
                new Team(2,"Arsenal", 0 , 1),
                new Team(3,"Liverpool", 0 , 1),
                new Team(4,"Man City", 0 , 0.75),
                new Team(5,"Man Utd", 0 , 0.75),
                new Team(6,"Everton", 0 , 0.6),
                new Team(7,"Stoke", 0 , 0.6),
                new Team(8,"Hull", 0 , 0.5)
            };
            table.DataSource = teams;
        }



        public class Team
        {
            public int Place { get; set; }
            public string Name { get; set; }
            public int Points { get; set; }
            private double lambd { get; set; }

            public double getLambd()
            {
                return this.lambd;
            }
            public Team(int Place, string Name, int Points, double lambd)
            {
                this.Place = Place;
                this.Name = Name;
                this.Points = Points;
                this.lambd = lambd;
            }
        }

        public class Game
        {
            
            public string tour { get; set; }

            public string name { get; set; }

            public string result { get; set; }

        }

        public class GameObject
        {
            public Team team1 { get; set; }
            public Team team2 { get; set; }
            public int team1Score { get; set; }
            public int team2Score { get; set; }
            private int tour { get; set; }
           
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < teams.Count; i++)
            {
                for(int j = i + 1; j < teams.Count; j++)
                {
                    games.Add(new GameObject
                    {
                        team1 = teams[i],
                        team2 = teams[j]
                    });
                }
            }

            for(int i = 0; i< 28; i++)
            {
                double a = rand.NextDouble();
                double lambda1 = games[i].team1.getLambd();
                double sum = 0;
                int x = 0;
                while(sum > lambda1*(-1))
                {
                    sum += Math.Log(a);
                    x++;
                    Console.WriteLine(x);
                }
                games[i].team1Score = x;
                sum = 0;
                x = 0;
                a = rand.NextDouble();
                double lambda2 = games[i].team2.getLambd();
                while (sum > lambda2 * (-1))
                {
                    sum += Math.Log(a);
                    x++;
                }
                games[i].team2Score = x;
                if(games[i].team1Score > games[i].team2Score)
                {
                    games[i].team1.Points += 3;
                }
                else if(games[i].team1Score < games[i].team2Score)
                {
                    games[i].team2.Points += 3;
                }
                else
                {
                    games[i].team1.Points += 1;
                    games[i].team2.Points += 1;
                }
              
            }

            table.Refresh();
            
            List<Team> SortedList = teams.OrderByDescending(o => o.Points).ToList();

            table.DataSource = SortedList;
            for(int i = 0; i < 8; i++)
            {
                table.Rows[i].Cells[0].Value = i+1;
            }
            
            
            for(int i = 0; i < games.Count; i++)
            {
                results.Rows.Add("1",games[i].team1.Name + " vs " + games[i].team2.Name, games[i].team1Score + " - " + games[i].team2Score);
            }

            int count = 0;
            for(int i = 0; i< 7; i++)
            {
                for(int j = i; j < 7; j++)
                {
                    results.Rows[count].Cells[0].Value = j+1;
                    count++;
                }
                
            }
            
            /*for(int i = 1; i < 8; i++)
            {
                for(int j = 0; j < 28; j++)
                {
                    if (results.Rows[j].Cells[0].Value.ToString() == i.ToString())
                    {
                        resultStrings.Add(new Game
                        {
                            tour = i.ToString(),
                            name = results.Rows[j].Cells[1].Value.ToString(),
                            result = results.Rows[j].Cells[2].Value.ToString()
                        });
                    }
                }
            }

            Console.WriteLine(resultStrings);
            results.DataSource = resultStrings;
            results.Refresh();*/

        }
        
    }
}
