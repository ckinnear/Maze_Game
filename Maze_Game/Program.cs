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
            //Create an instance of the PLayerScore class:
            PlayerScore score = new PlayerScore();

            //Add values (representing scores) to the list:
            score.AddScores(8); 
            score.AddScores(5);
            score.AddScores(2);

        }
    }
}
