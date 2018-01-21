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

                if (HighestScore <= 2)
                {
                    result = "Beginner";
                }
                else if (HighestScore <= 4)
                {
                    result = "Intermediate";
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
