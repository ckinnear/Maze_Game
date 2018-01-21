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
            Console.WriteLine("Welcome to the Maze!\n");
            
            //IScoreTracker is a n interface to keep track of users scores
            IScoreTracker result = CreatePlayerScore();

            //Using the event delegte to listen to name change and print message when it does
            result.NameChanged += OnNameChanged;
            
            //Ask for the Players Name:
            GetPlayerName(result);
            //Display the Game Menu:
            DisplayMenu();
            //Handle Players Menu choice
            HandlePlayerChoice(result);
            //

        }

        private static void HandlePlayerChoice(IScoreTracker result)
        {
            //Handling the exception if the user adds incorrect entry:
            bool correctMenuInput = false;
            while (correctMenuInput == false)
            {
                try
                {
                    Console.WriteLine("Choose an Option");
                    result.MenuChoice = Console.ReadLine();
                    correctMenuInput = true;
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            switch (result.MenuChoice)
            {
                case "1":
                    float noOfTurns = Maze();
                    AddPlayerScores(result, noOfTurns);
                    SaveScores(result);
                    DisplayMenu();
                    HandlePlayerChoice(result);
                    break;
                case "2":
                    WriteResults(result);
                    DisplayMenu();
                    HandlePlayerChoice(result);
                    break;
                case "3":
                    Console.WriteLine("THANKS FOR PLAYING, GOODBYE");
                    Environment.Exit(0);
                    break;
            }
        }

        private static float Maze()
        {
            IMaze maze = new FirstMaze();
            float noOfTurns = maze.MazePath();
            return noOfTurns;
        }

        private static void DisplayMenu()
        {
            //Menu
            Console.WriteLine("1.Play Game");
            Console.WriteLine("2.View Scores");
            Console.WriteLine("3.Quit");
        }

        private static IScoreTracker CreatePlayerScore()
        {
            //changed to instantiate the derived class, ThrowAwayPLayerScore()
            //which throws away the lowest score before calculating the Score Board Stats
            return new ThrowAwayPlayerScore();
        }

        private static void WriteResults(IScoreTracker result)
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

        private static void SaveScores(IScoreTracker result)
        {
        //File returns object StreamWriter which is compatible with TextWriter that WriteGrades expects.
        //Wrap in using {} so that the complier sets up a try, finally to make sure all resources are closed
        //for example outputFile.Close();
            using (StreamWriter outputFile = File.CreateText("scores.txt")) // Added using System.IO
            {
                result.WriteScores(outputFile);
            }

        }

        private static void AddPlayerScores(IScoreTracker result, float noOfTurns)
        {
            //Add scores to the list:
            result.AddScores(noOfTurns);
            result.AddScores(noOfTurns);

        }

        private static void GetPlayerName(IScoreTracker result)
        {
            //Handling the exception if the user leaves the Name empty
            bool correctNameInput = false;
            while (correctNameInput == false)
            {
                try
                {
                    Console.WriteLine("Please Enter Your Name: ");
                    result.PlayerName = Console.ReadLine();
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
            Console.WriteLine($"Hello {args.NewName}, Best Of Luck in the Maze!\n");
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
