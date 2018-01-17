﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Speech.Synthesis; //Needed for SpeechSynthesizer
using System.Text;
using System.Threading.Tasks;

namespace Maze_Game
{
    class Program
    {
        static void Main(string[] args)
        {

            //Added System.Speech Assembly reference to use the following:
            SpeechSynthesizer synth = new SpeechSynthesizer();
            synth.Speak("Welcome to the Maze");

            Console.WriteLine("Welcome to the Maze!");

            //Create an instance of the PlayerScore class:
            PlayerScore result = new PlayerScore();

            //Add scores to the list:
            result.AddScores(8);
            result.AddScores(10);
            result.AddScores(1);

            //Assign calculated results to ScoreBoardStats class:
            ScoreBoardStats playerStats = result.CalculateScoreBoardStats();

            //Display results:
            WriteResult("The Highest Score is: ", playerStats.HighestScore);
            WriteResult("The Lowest Score is: ", playerStats.LowestScore);
            WriteResult("The Average Score is: ", playerStats.AverageScore);

        }

        //Method to Display results:
        static void WriteResult(string description, float statsResult) 
        {
            Console.WriteLine($"{description} : {statsResult:F2}"); //F2 rounds to 2 decimal points
        }
    }
}
