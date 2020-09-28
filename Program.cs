﻿using System;

namespace RockPapperScissorsConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputPlayer;
            //string inputCPU;
            int randomInt;
            bool playAgain = true;

            while (playAgain)
            {
                int scorePlayer = 0;
                int scoreCPU = 0;

                while (scorePlayer < 3 && scoreCPU < 3)
                {
                    Console.Write("Choose between ROCK,PAPER and SCISSORS: ");
                    inputPlayer = Console.ReadLine().ToUpper();

                    Random random = new Random();
                    randomInt = random.Next(1, 4);

                    switch (randomInt)
                    {
                        case 1:
                            //inputCPU = "ROCK";
                            Console.WriteLine("\t\tComputer chose ROCK");
                            if (inputPlayer == "ROCK")
                            {
                                Console.WriteLine("DRAW!!\n\n");
                            }
                            else if (inputPlayer == "PAPER")
                            {
                                Console.WriteLine("PLAYER WINS!!\n\n");
                                scorePlayer++;
                            }
                            else if (inputPlayer == "SCISSORS")
                            {
                                Console.WriteLine("CPU WINS!!\n\n");
                                scoreCPU++;
                            }
                            break;
                        case 2:
                           // inputCPU = "PAPER";
                            Console.WriteLine("Computer chose PAPER");
                            if (inputPlayer == "PAPER")
                            {
                                Console.WriteLine("DRAW!!\n\n");
                            }
                            else if (inputPlayer == "ROCK")
                            {
                                Console.WriteLine("CPU WINS!!\n\n");
                                scorePlayer++;
                            }
                            else if (inputPlayer == "SCISSORS")
                            {
                                Console.WriteLine("PLAYER WINS!!\n\n");
                                scoreCPU++;
                            }
                            break;
                        case 3:
                            //inputCPU = "SCISSORS";
                            Console.WriteLine("Computer chose SCISSORS");
                            if (inputPlayer == "SCISSORS")
                            {
                                Console.WriteLine("DRAW!!\n\n");
                            }
                            else if (inputPlayer == "ROCK")
                            {
                                Console.WriteLine("PLAYER WINS!!\n\n");
                                scorePlayer++;
                            }
                            else if (inputPlayer == "PAPER")
                            {
                                Console.WriteLine("CPU WINS!!\n\n");
                                scoreCPU++;
                            }
                            break;
                        default:
                            Console.WriteLine("Invalid entry!");
                            break;
                    }
                }
                if (scorePlayer == 3)
                {
                    Console.WriteLine("Player WON!");
                }
                else if (scoreCPU == 3)
                {
                    Console.WriteLine("CPU WON!");
                }
                else
                {
                    Console.WriteLine("No one WON!");
                }

                Console.WriteLine("Do you want to play again?(y/n)");
                string loop = Console.ReadLine();
                if (loop == "y")
                {
                    playAgain = true;
                }
                else if (loop == "n")
                {
                    playAgain = false;
                }
                else
                {
                    Console.WriteLine("Nothing Chosen!");
                }
            }
        }
    }
}
