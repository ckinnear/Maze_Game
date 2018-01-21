using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maze_Game
{
    class FirstMaze : Maze
    {
        public override float MazePath()
        {
            float noOfTurns = 0; 

            Console.WriteLine("First Turn. Do you go:\n1.Left or 2.Right?");
            float choice = float.Parse(Console.ReadLine());
            if (choice == 1)
            {
                noOfTurns++;
                Console.WriteLine("Success! You avoided the Dragon");
                Console.WriteLine("Next choice do you go:\n1.Left or 2.Right?");
                choice = float.Parse(Console.ReadLine());
                if (choice == 1)
                {
                    noOfTurns++;
                    Console.WriteLine("You avoided the Wizard");
                    Console.WriteLine("Great so far, next turn:\n1.Left or 2.Right?");
                    choice = float.Parse(Console.ReadLine());
                    if (choice == 2)
                    {
                        noOfTurns++;
                        Console.WriteLine("Just missed the Giant");
                        Console.WriteLine("This time:\n1.Left or 2.Right");
                        choice = float.Parse(Console.ReadLine());
                        if (choice == 1)
                        {
                            noOfTurns++;
                            Console.WriteLine("No attack from a goblin this time!");
                            Console.WriteLine("You have reached the boss:\n1.Left or 2.Right");
                            choice = float.Parse(Console.ReadLine());
                            if (choice == 2)
                            {
                                noOfTurns++;
                                Console.WriteLine("Congratulations, you won the game!!");
                            }
                            else
                            {
                                Console.WriteLine("The Boss has defeated you, hard luck");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Goblin hits you on the head with a club");
                        }
                    }
                    else
                    {
                        Console.WriteLine("A Giant stood on you");
                    }
                }
                else
                {
                    Console.WriteLine("A Wizard turn you into a toad");
                }
            }
            else
            {
                Console.WriteLine("A Dragon atacked you");
            }


            return noOfTurns;
        }
    }
}
