using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maze_Game
{
    class PlayerScore
    {
        //Create a Method to add Scores to a list:
        public void AddScores(int result)
        {
            scores.Add(result);
        }

        //Create a List to hold scores:
        public List<int> scores = new List<int>();

    }
}
