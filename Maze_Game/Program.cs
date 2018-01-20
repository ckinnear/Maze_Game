using System;
using System.Collections.Generic;
using System.IO;
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
            //Output text Greeting:
            Console.WriteLine("Welcome to the Maze!");

            ScoreTracker result = CreatePlayerScore();

            //Using the event delegte:
            result.NameChanged += OnNameChanged;

            GetPlayerName(result);
            AddPlayerScores(result);
            SaveScores(result);
            WriteResults(result);

        }

        private static ScoreTracker CreatePlayerScore()
        {
            //changed to instantiate the derived class, ThrowAwayPLayerScore()
            //which throws away the lowest score before calculating the Score Board Stats
            return new ThrowAwayPlayerScore();
        }

        private static void WriteResults(ScoreTracker result)
        {
            //Assign calculated results to ScoreBoardStats class:
            ScoreBoardStats playerStats = result.CalculateScoreBoardStats();
            //Display results:
            WriteResult("The Highest Score is: ", playerStats.HighestScore);
            WriteResult("The Lowest Score is: ", playerStats.LowestScore);
            WriteResult("The Average Score is: ", playerStats.AverageScore);
            //Display the players Skill level:
            WriteResult("Your Skill Level is: ", playerStats.PlayerSkill);
        }

        private static void SaveScores(ScoreTracker result)
        {
        //File returns object StreamWriter which is compatible with TextWriter that WriteGrades expects.
        //Wrap in using {} so that the complier sets up a try, finally to make sure all resources are closed
        //for example outputFile.Close();
            using (StreamWriter outputFile = File.CreateText("scores.txt")) // Added using System.IO
            {
                result.WriteGrades(outputFile);
            }

        }

        private static void AddPlayerScores(ScoreTracker result)
        {
            //Add scores to the list:
            result.AddScores(8);
            result.AddScores(10);
            result.AddScores(1);
        }

        private static void GetPlayerName(ScoreTracker result)
        {
            //Handling the exception if the user leaves the Name empty
            bool correctNameInput = false;
            while (correctNameInput == false)
            {
                try
                {
                    Console.WriteLine("Please Enter Your Name: ");
                    result.Name = Console.ReadLine();
                    correctNameInput = true;
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                    //Console.WriteLine(ex.StackTrace); //shows the stack trace as well
                }
            }
        }

        //Change the Method arguments to use NameChangedEventArgs: 
        static void OnNameChanged(object sender, NameChangedEventArgs args) 
        {
            Console.WriteLine($"Player Score changing name from {args.ExistingName} to {args.NewName}");
        }


        //Method to Display results:
        static void WriteResult(string description, float statsResult) 
        {
            Console.WriteLine($"{description} : {statsResult:F2}"); //F2 rounds to 2 decimal points
        }

        //Method to Display the user skill rating:
        static void WriteResult(string description, string statsResult)
        {
            Console.WriteLine($"{description} : {statsResult}"); 
        }
    }
}
