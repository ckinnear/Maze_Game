using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maze_Game
{
    public class ScoreBoardStats // Class to hold calculated scoreboard stats
    {

        //Initialise scoreboard stats values:
        public ScoreBoardStats()
        {
            HighestScore = 0;
            LowestScore = float.MaxValue;
        }

        //Rate players calculated Skill
        public string PlayerSkill
        {
            get
            {
                string result;

                if (HighestScore <= 3)
                {
                    result = "Beginner";
                }
                else if (HighestScore <= 6)
                {
                    result = "Intermediate";
                }
                else if (HighestScore <= 9)
                {
                    result = "Expert";
                }
                else
                {
                    result = "Master";
                }
                return result;
            }

        }
        
        //Scoreboard stats:
        public float HighestScore;
        public float LowestScore;
        public float AverageScore;

    }
}
