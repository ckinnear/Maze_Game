using System;
using System.Collections.Generic; // needed for List
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maze_Game 
{
    // Changing PlayerScore class to public so that the Scores.Test Project can access it: 
 public class PlayerScore : ScoreTracker //Class to store scores & calculate Scoreboard Stats
{
        //Constructor to initilise scores list:
        public PlayerScore()
        {
            _name = "Empty"; // initializing _name for Delegate 
            scores = new List<float>();
        }

        //Method to calculate stats:
        public override ScoreBoardStats CalculateScoreBoardStats()
        //made virtual so that derived class (ThrowAwayPlayerScore) can change method
        {
            ScoreBoardStats stats = new ScoreBoardStats();

            //Calculate the Average, Highest & Lowest stats:
            float sum = 0;
            foreach (float score in scores)
            {
                stats.HighestScore = Math.Max(score, stats.HighestScore); //Highest calculated 
                stats.LowestScore = Math.Min(score, stats.LowestScore); //Lowest calculated
                sum += score;
            }
            stats.AverageScore = sum / scores.Count; // Average calculated 

            return stats;
        }

        public override void WriteGrades(TextWriter destination) 
        // Added using System.IO for TextWritter
        {
            for (int i = scores.Count; i > 0; i --)
            {
                destination.WriteLine($"Player Scores: {scores[i-1]}");

            }
               
        }


        //Method to add Scores to a list:
        public override void AddScores(float score)
        {
            scores.Add(score);
        }

        //List to hold scores:
        // change to protected so that inherited class can access it
        protected List<float> scores;
    }
}
