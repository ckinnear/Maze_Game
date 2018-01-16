using Maze_Game; // needed to add PlayerScore 
//The following is needed for [TestClass]
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
        [TestMethod] // Test to verify highest score code
        public void CalculateHighestScore()
        {
            PlayerScore player = new PlayerScore();
            player.AddScores(8);
            player.AddScores(2);

            ScoreBoardStats result = player.CalculateScoreBoardStats();
            Assert.AreEqual(8, result.HighestScore);
        }

        [TestMethod] // Test to verify lowest score code
        public void CalculateLowestScore()
        {
            PlayerScore player = new PlayerScore();
            player.AddScores(8);
            player.AddScores(5);
            player.AddScores(3);

            ScoreBoardStats stats = player.CalculateScoreBoardStats();
            Assert.AreEqual(3, stats.LowestScore);
        }

        [TestMethod] // Test to verify average score code
        public void CalculateAverageScore()
        {
            PlayerScore player = new PlayerScore();
            player.AddScores(9);
            player.AddScores(5);
            player.AddScores(5);

            ScoreBoardStats stats = player.CalculateScoreBoardStats();
            Assert.AreEqual(6.33, stats.AverageScore, 0.01); //Add the precision 0.01 
        }

























    }
}
