using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Q6
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Team> Teams = MethodRead();

            foreach (var team in Teams)
            {

                const string TABLE_FORMAT = "{0,-10}{1,-10}{2,-10}{3,-10}{4,-10}{5,-10}{6,-10:p2}";

                Console.WriteLine(TABLE_FORMAT, "Team", "Played", "Wins", "Losses", "Draws", "Point", "Percentage");
                Console.WriteLine(TABLE_FORMAT, team.Name, team.MatchesPlayed, team.Wins, team.Loss, team.Draws, team.Points, team.Percentage);

                Console.Write("\n");
            }

            Console.ReadKey();
        }

        public static List<Team> MethodRead()
        {
            List<Team> teams = new List<Team>();

            for (int i = 0; i < 3; i++)
            {
                Team team = new Team();

                Console.Write("Insert Team's name : ");
                team.Name = Console.ReadLine();

                try
                {
                    Console.Write("Wins   : ");
                    team.Wins = int.Parse(Console.ReadLine());

                    Console.Write("Losses : ");
                    team.Loss = int.Parse(Console.ReadLine());

                    Console.Write("Draws   : ");
                    team.Draws = int.Parse(Console.ReadLine());

                    teams.Add(Calc(team));
                }
                catch
                {
                    Console.Write("Value not authorized! Try again.");
                    Thread.Sleep(1000);
                    Console.Clear();
                    continue;
                }

                Console.Clear();
                Console.Write("Team add success!");
                Thread.Sleep(2000);
                Console.Clear();
            }

            return teams;
        }

        public static Team Calc(Team team)
        {
            int winPoints = 3, drawPoints = 1, lossPoints = 0;

            team.MatchesPlayed = team.Wins + team.Loss + team.Draws;
            team.Points = (team.Wins * winPoints) + (team.Draws * drawPoints) + (team.Loss * lossPoints);

            team.Percentage = team.MatchesPlayed * 3;

            team.Percentage = team.Points / team.Percentage;

            return team;
        }
    }

    public class Team
    {
        public string Name;
        public int Wins;
        public int Loss;
        public int Draws;
        public int MatchesPlayed;
        public int Points;
        public double Percentage = 0.0;
    }
}
