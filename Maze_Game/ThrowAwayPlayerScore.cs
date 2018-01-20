using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maze_Game
{
    //inherit from PlayerScore base class,
    //Class to get rid of the lowest Player score:
    public class ThrowAwayPlayerScore : PlayerScore 
    {
        public override ScoreBoardStats CalculateScoreBoardStats()
        {
            //Overrides the base Method CalculateScoreBoardStats(), causing Polymorphic behaviour
            float lowest = float.MaxValue;

            foreach (float score in scores)
            {
                lowest = Math.Min(score, lowest);
            }
            scores.Remove(lowest);
            return base.CalculateScoreBoardStats();
        }
    }
}
