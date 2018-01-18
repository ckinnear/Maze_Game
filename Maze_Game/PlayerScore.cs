using System;
using System.Collections.Generic; // needed for List
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maze_Game
{
    // Changing PlayerScore class to public so that the Scores.Test Project can access it: 
    public class PlayerScore //Class to store scores & calculate Scoreboard Stats
    {
        //Constructor to initilise scores list:
        public PlayerScore()
        {
            _name = "Empty"; // initializing _name for Delegate 
            scores = new List<float>();
        }

        //Method to calculate stats:
        public ScoreBoardStats CalculateScoreBoardStats()
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


        //Method to add Scores to a list:
        public void AddScores(float score)
        {
            scores.Add(score);
        }


        public string Name
        {
            get { return _name; }

            set
            {
                if (!String.IsNullOrEmpty(value))
                {
                    if (_name != value)// if the name changed invoke the delegate:
                    {
                        //Create a NameChangedEventArgs instance:
                        NameChangedEventArgs args = new NameChangedEventArgs();
                        args.ExistingName = _name;
                        args.NewName = value; 
                        NameChanged(this, args);
                        //"this" will pass in the current PlayerScore object that we are in
                    }

                    _name = value;

                }
            }

        }

        //Made this delegate an event so that the user cannot wipe out subscribers with "null"
        public event NameChangedDelgate NameChanged; //field of type NameChangedDelegate

        private string _name;
        //List to hold scores:
        private List<float> scores;

    }
}
