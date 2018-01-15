using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maze_Game
{
    class ScoreBoardStats // Class to hold calculated scoreboard stats
    {

        //Initialise scoreboard stats values:
        public ScoreBoardStats()
        {
            HighestScore = 0;
            LowestScore = int.MaxValue;
        }
        
        //Scoreboard stats:
        public int HighestScore;
        public int LowestScore;
        public int AverageScore;

    }
}
