using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_GAME
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int playerscore = 0;
            int enemyscore = 0;

            Console.WriteLine("Welcome to rock/paper/scissors game");
            Console.WriteLine("First to 5 points wins!");

            while (playerscore < 5 && enemyscore < 5) 
            {
                Console.WriteLine("Please enter 1: Rock / 2: Paper / 3: Scissors");
                string playerchoice = Console.ReadLine();

                int enemychoice = random.Next(0, 3);

                if (enemychoice == 0)
                {
                    Console.WriteLine("Enemy chooses Rock");

                    switch (playerchoice)
                    {
                        case "1":
                            Console.WriteLine("Tie");
                            break;
                        case "2":
                            Console.WriteLine("Player Wins");
                            playerscore++;
                            break;
                        case "3":
                            Console.WriteLine("Enemy Wins");
                            enemyscore++;
                            break;
                        default:
                            Console.WriteLine("Invalid Choice");
                            break;
                    }
                }
                else if (enemychoice == 1)
                {
                    Console.WriteLine("Enemy chooses Paper");

                    switch (playerchoice)
                    {
                        case "1":
                            Console.WriteLine("Enemy Wins");
                            enemyscore++;
                            break;
                        case "2":
                            Console.WriteLine("Tie");
                            break;
                        case "3":
                            Console.WriteLine("Player Wins");
                            playerscore++;
                            break;
                        default:
                            Console.WriteLine("Invalid Choice");
                            break;
                    }
                }
                else if (enemychoice == 2)
                {
                    Console.WriteLine("Enemy chooses Scissors");

                    switch (playerchoice)
                    {
                        case "1":
                            Console.WriteLine("Player Wins");
                            playerscore++;
                            break;
                        case "2":
                            Console.WriteLine("Enemy Wins");
                            enemyscore++;
                            break;
                        case "3":
                            Console.WriteLine("Tie");
                            break;
                        default:
                            Console.WriteLine("Invalid Choice");
                            break;
                    }
                }


                Console.WriteLine($"Current Scores: Player - {playerscore}, Enemy - {enemyscore}");
            }

            if (playerscore == 5)
            {
                Console.WriteLine("Congratulations! You won the game!");
            }
            else
            {
                Console.WriteLine("Game Over! The enemy wins.");
            }
        }
    }
}
