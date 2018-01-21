using System;
using System.IO;

namespace Maze_Game
{
    internal interface IScoreTracker
    {
        void AddScores(float score);
        ScoreBoardStats CalculateScoreBoardStats();
        void WriteGrades(TextWriter destination);
        string Name { get; set;}
        event NameChangedDelgate NameChanged; //field of type NameChangedDelegate

    }
}