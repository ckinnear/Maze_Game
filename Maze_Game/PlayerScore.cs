using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maze_Game
{
    class PlayerScore //Class to store scores & calculate Scoreboard Stats
    {
        //Constructor to initilise scores list:
        public PlayerScore()
        {
            scores = new List<int>();
        }

        //Method to calculate stats:
        public ScoreBoardStats CalculateScoreBoardStats()
        {
            return new ScoreBoardStats();
        }


        //Method to add Scores to a list:
        public void AddScores(int score)
        {
            scores.Add(score);
        }

        //List to hold scores:
        public List<int> scores;

    }
}
