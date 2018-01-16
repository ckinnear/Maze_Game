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
        
        //Scoreboard stats:
        public float HighestScore;
        public float LowestScore;
        public float AverageScore;

    }
}
