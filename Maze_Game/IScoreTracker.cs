using System;
using System.IO;

namespace Maze_Game
{
    internal interface IScoreTracker
    {
        void AddScores(float score);
        ScoreBoardStats CalculateScoreBoardStats();
        void WriteScores(TextWriter destination);
        string PlayerName { get; set;}
        string MenuChoice { get; set; }
        event NameChangedDelgate NameChanged;

    }
}