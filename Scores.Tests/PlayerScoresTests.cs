using Maze_Game; // needed to add PlayerScore 
//The following needed for [Test Class]
using Microsoft.VisualStudio.TestTools.UnitTesting; 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scores.Tests // Testing Project to test calculations
{
    [TestClass]
    public class PlayerScoresTests
    {
        [TestMethod]
        public void CalculateHighestScore()
        {
            PlayerScore player = new PlayerScore();
            player.AddScores(8);
            player.AddScores(2);

            ScoreBoardStats result = player.CalculateScoreBoardStats();
            Assert.AreEqual(8, result.HighestScore);
        }
        
    }
}
