using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13e3431zaz
{
    using System;

    namespace TicTacToe
    {
        class Program
        {


            static string[] options = { "1", "2", "3", "4", "5", "6", "7", "8", "9" };
            static bool Playing = true;
            static int turn = 0;

            static void Main(string[] args)
            {

                Intro();
                Board();

                while (Playing)
                {
                    if (turn % 2 == 0)
                    {
                        Console.WriteLine("Player 1's turn");
                    }
                    else
                    {
                        Console.WriteLine("Player 2's turn");
                    }

                    int playerInput1;
                    Console.WriteLine("");
                    bool torf = int.TryParse(Console.ReadLine(), out playerInput1);
                    playerInput1--;


                    if (torf && playerInput1 < 9 && playerInput1 > -1)
                    {
                        if (options[playerInput1] == "x" || options[playerInput1] == "o")
                        {
                            Console.WriteLine("illegal move,try again!");
                        }
                        else
                        {
                            if (turn % 2 == 0)
                            {
                                options[playerInput1] = "x";
                                turn++;

                                Board();
                                WinCondition();
                                Tie();
                            }
                            else
                            {
                                options[playerInput1] = "o";
                                turn++;

                                Board();
                                WinCondition();
                                Tie();
                            }

                        }
                    }
                    else
                    {
                        Console.WriteLine("illegal move,try again!");
                    }
                }
            }
            public static void Board()
            {
                Console.Clear();

                Console.WriteLine("     |     |      ");

                Console.WriteLine($"  {options[0]}  |  {options[1]}  |  {options[2]}");

                Console.WriteLine("_____|_____|_____ ");

                Console.WriteLine("     |     |      ");

                Console.WriteLine($"  {options[3]}  |  {options[4]}  |  {options[5]}");

                Console.WriteLine("_____|_____|_____ ");

                Console.WriteLine("     |     |      ");

                Console.WriteLine($"  {options[6]}  |  {options[7]}  |  {options[8]}");

                Console.WriteLine("     |     |      ");
            }

            public static void WinCondition()
            {
                if (options[0] == options[1] && options[1] == options[2])
                {
                    Playing = false;
                    if (turn % 2 == 0)
                    {
                        Console.WriteLine("player 1 has won,\n.want to play again loser player 2 y/n ?");
                    }
                    else
                    {
                        Console.WriteLine("Player 2 has won,\n do you want to play again,loser player 1 y/n ?");
                    }
                }
                else if (options[3] == options[4] && options[4] == options[5])
                {
                    Playing = false;
                    if (turn % 2 == 0)
                    {
                        Console.WriteLine("player 1 has won,\n.want to play again loser player 2 y/n ?");
                    }
                    else
                    {
                        Console.WriteLine("Player 2 has won,\n do you want to play again,loser player 1 y/n ?");
                    }
                }
                else if (options[6] == options[7] && options[7] == options[8])
                {
                    Playing = false;
                    if (turn % 2 == 0)
                    {
                        Console.WriteLine("player 1 has won,\n.want to play again loser player 2 y/n ?");
                    }
                    else
                    {
                        Console.WriteLine("Player 2 has won,\n do you want to play again,loser player 1 y/n ?");
                    }
                }

                else if (options[0] == options[3] && options[3] == options[6])
                {
                    Playing = false;
                    if (turn % 2 == 0)
                    {
                        Console.WriteLine("player 1 has won,\n.want to play again loser player 2 y/n ?");
                    }
                    else
                    {
                        Console.WriteLine("Player 2 has won,\n do you want to play again,loser player 1 y/n ?");
                    }
                }
                else if (options[1] == options[4] && options[4] == options[7])
                {
                    Playing = false;
                    if (turn % 2 == 0)
                    {
                        Console.WriteLine("player 1 has won,\n.want to play again loser player 2 y/n ?");
                    }
                    else
                    {
                        Console.WriteLine("Player 2 has won,\n do you want to play again,loser player 1 y/n ?");
                    }
                }
                else if (options[2] == options[5] && options[5] == options[8])
                {
                    Playing = false;
                    if (turn % 2 == 0)
                    {
                        Console.WriteLine("player 1 has won,\n.want to play again loser player 2 y/n ?");
                    }
                    else
                    {
                        Console.WriteLine("Player 2 has won,\n do you want to play again,loser player 1 y/n ?");
                    }
                }

                else if (options[0] == options[4] && options[4] == options[8])
                {
                    Playing = false;
                    if (turn % 2 == 0)
                    {
                        Console.WriteLine("player 1 has won,\n.want to play again loser player 2 y/n ?");
                    }
                    else
                    {
                        Console.WriteLine("Player 2 has won,\n do you want to play again,loser player 1 y/n ?");
                    }
                }
                else if (options[2] == options[4] && options[4] == options[6])
                {
                    Playing = false;
                    if (turn % 2 == 0)
                    {
                        Console.WriteLine("player 1 has won,\n.want to play again loser player 2 y/n ?");
                    }
                    else
                    {
                        Console.WriteLine("Player 2 has won,\n do you want to play again,loser player 1 y/n ?");
                    }
                }

            }

            public static void Intro()
            {

                Console.WriteLine("Welcome to\n");
                Console.WriteLine("\n1.About the author.\n Emir Gursen The author\n\n2.new game.\n\n3.exit");
                Console.ReadKey(false);
                Console.Clear();
            }

            public static void Tie()
            {
                if (options[0] != "1" && options[1] != "2" && options[2] != "3" && options[3] != "4" && options[4] != "5" && options[5] != "6" && options[6] != "7" && options[7] != "8" && options[8] != "9")
                {
                    Console.WriteLine("The game is a tie");
                    Playing = false;
                }
            }
        }



    }


}