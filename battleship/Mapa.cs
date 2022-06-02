using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace battleship
{
    internal class Mapa
    {

        public static void imprimirMapa(int[,] mapaPlayer, int[,] mapaShots)
        {
            char letra = 'A';
            Console.WriteLine("--------------Mapa del jugador--------------");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("[ ] [0] [1] [2] [3] [4] [5] [6] [7] [8] [9]");
            Console.ForegroundColor = ConsoleColor.White;
            for (int i = 0; i < mapaPlayer.GetLength(0); i++)
            {
                for (int j = 0; j < mapaPlayer.GetLength(1); j++)
                {
                    if (mapaPlayer[i, j] == 0)
                    {
                        if (i == 0 && j == 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.Write("[" + letra + "] ");
                            Console.ForegroundColor = ConsoleColor.White;
                            letra++;
                        }
                        if (j == 9 && i < 9)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.Write("[*] ");
                            Console.WriteLine("");
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.Write("[" + letra + "] ");
                            Console.ForegroundColor = ConsoleColor.White;
                            letra++;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.Write("[*] ");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                    } else if (mapaPlayer[i, j] == 1)
                    {
                        if (i == 0 && j == 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.Write("[" + letra + "] ");
                            Console.ForegroundColor = ConsoleColor.White;
                            letra++;
                        }
                        if (j == 9 && i < 9)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write("[*] ");
                            Console.WriteLine("");
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.Write("[" + letra + "] ");
                            Console.ForegroundColor = ConsoleColor.White;
                            letra++;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write("[*] ");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                    }
                    else
                    {
                        if (j == 9)
                        {
                            Console.WriteLine("");
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write(mapaPlayer[i, j] + " ");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                    }

                }

            }

            Console.WriteLine("");
            letra = 'A';
            SetCursorPosition(50, 0);
            Console.WriteLine("---------------Mapa de tiros---------------");
            SetCursorPosition(50, 1);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("[ ] [0] [1] [2] [3] [4] [5] [6] [7] [8] [9]");
            Console.ForegroundColor = ConsoleColor.White;
            SetCursorPosition(50, 2);
            for (int i = 0; i < mapaShots.GetLength(0); i++)
            {
                if (letra != 'A')
                SetCursorPosition(54, i+2);
                for (int j = 0; j < mapaShots.GetLength(1); j++)
                {
                    if (mapaShots[i, j] == 0)
                    {
                        if (i == 0 && j == 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.Write("[" + letra + "] ");
                            Console.ForegroundColor = ConsoleColor.White;
                            letra++;
                        }
                        if (j == 9 && i < 9)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.Write("[*] ");
                            Console.WriteLine("");
                            Console.ForegroundColor = ConsoleColor.Blue;
                            SetCursorPosition(50, i+3);
                            Console.Write("[" + letra + "] ");
                            Console.ForegroundColor = ConsoleColor.White;
                            letra++;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.Write("[*] ");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                    }
                    else
                    {
                        if (j == 9)
                        {
                            Console.WriteLine("");
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write(mapaShots[i, j] + " ");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                    }

                }

            }
        }
    }
}
