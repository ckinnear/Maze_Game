using System;
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

            //Make a new instance of the NameChangedDelegate and reference the OnNameChanged method
            result.NameChanged = new NameChangedDelgate(OnNameChanged);
            //you can call multiple methods, using += doesnt remove the first call it just adds to it instead
            result.NameChanged += new NameChangedDelgate(OnNameChanged2);

            result.Name = "Player 1";
            result.Name = "Player 2";


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

        //this method has the same signature as the Delegate so it can be referenced by the delegate
        static void OnNameChanged(string existingName, string newName) 
        {
            Console.WriteLine($"Player Score changing name from {existingName} to {newName}");

        }

        //Second Method to show that delegates can call multiple methods
        static void OnNameChanged2(string existingName, string newName)
        {
            Console.WriteLine("***");

        }
        //Method to Display results:
        static void WriteResult(string description, float statsResult) 
        {
            Console.WriteLine($"{description} : {statsResult:F2}"); //F2 rounds to 2 decimal points
        }
    }
}
