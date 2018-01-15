using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maze_Game
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to the Maze!");

            //Create an instance of the PlayerScore class:
            PlayerScore result = new PlayerScore();

            //Add scores to the list:
            result.AddScores(8);
            result.AddScores(5);
            result.AddScores(2);

            //Assign calculated results to ScoreBoardStats class:
            ScoreBoardStats playerstats = result.CalculateScoreBoardStats(); 

            //Display results:
            Console.WriteLine("The Highest Score is: {0}", playerstats.HighestScore);
            Console.WriteLine("The Lowest Score is:  {0}", playerstats.LowestScore);
            Console.WriteLine("The Average Score is: {0}", playerstats.AverageScore);

        }
    }
}
