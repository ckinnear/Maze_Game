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
            ScoreBoardStats stats = new ScoreBoardStats();

            //Calculate the Average, Highest & Lowest stats:
            int sum = 0;
            foreach (int score in scores)
            {
                stats.HighestScore = Math.Max(score, stats.HighestScore); //Highest calculated 
                stats.LowestScore = Math.Min(score, stats.LowestScore); //Lowest calculated
                sum += score;
            }
            stats.AverageScore = sum / scores.Count; // Average calculated 

            return stats;
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
