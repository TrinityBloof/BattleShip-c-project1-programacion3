using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace battleship
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //matriz mapa jugador1
            int[,] mapaPlayer = new int[10, 10];
            //matriz mapa tiros realizados
            int[,] mapaShots = new int[10, 10];
            //matriz mapa jugador 2
            int[,] mapaPlayer2 = new int[10, 10];
            //matriz mapa tiros realizados
            int[,] mapaShots2 = new int[10, 10];
            //pos x y
            int x = 5, y = 2, x2 = 5, y2 = 2;
            //turno y barcos
            int turno = 1, barco = 5, barco2 = 5;

        juego:
            if (barco == 0 && barco2 == 0)
            {
                SetCursorPosition(0, 0);
                if (turno == 1)
                {
                    x = 55;
                    y = 2;
                    Mapa.imprimirMapa(mapaPlayer, mapaShots);
                    Console.WriteLine("");
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("*************************************Turno del jugador " + turno + "*************************************");
                    Console.WriteLine("              Usa WASD para moverte y disparar en el terreno");
                    Console.WriteLine("                 (Solo puedes interactuar con los * del terreno)");
                    Console.ForegroundColor = ConsoleColor.White;
                    SetCursorPosition(x, y);
                }
                else if (turno == 2)
                {
                    x2 = 55;
                    y2 = 2;
                    Mapa.imprimirMapa(mapaPlayer2, mapaShots2);
                    Console.WriteLine("");
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("*************************************Turno del jugador " + turno + "*************************************");
                    Console.WriteLine("                  Usa WASD para moverte y disparar en el terreno");
                    Console.WriteLine("                 (Solo puedes interactuar con los * del terreno)");
                    Console.ForegroundColor = ConsoleColor.White;
                    SetCursorPosition(x2, y2);
                }
            }
            else
            {
                SetCursorPosition(0, 0);
                if (turno == 1)
                {
                    Mapa.imprimirMapa(mapaPlayer, mapaShots);
                    Console.WriteLine("");
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("*************************************Turno del jugador " + turno + "*************************************");
                    Console.WriteLine("             Usa WASD para moverte por el terreno y colocar tus barcos");
                    Console.WriteLine("                 (Solo puedes interactuar con los * del terreno)");
                    Console.ForegroundColor = ConsoleColor.White;
                    SetCursorPosition(x, y);
                }
                else if (turno == 2)
                {
                    Mapa.imprimirMapa(mapaPlayer2, mapaShots2);
                    Console.WriteLine("");
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("*************************************Turno del jugador " + turno + "*************************************");
                    Console.WriteLine("             Usa WASD para moverte por el terreno y colocar tus barcos");
                    Console.WriteLine("                 (Solo puedes interactuar con los * del terreno)");
                    Console.ForegroundColor = ConsoleColor.White;
                    SetCursorPosition(x2, y2);
                }

                ConsoleKeyInfo keyInfo;

                while ((keyInfo = Console.ReadKey(true)).Key != ConsoleKey.Escape)
                {
                    switch (keyInfo.Key)
                    {
                        case ConsoleKey.W:
                            if (turno == 1)
                            {
                                if (y > 2)
                                {
                                    SetCursorPosition(x, y - 1);
                                    y--;
                                }
                            }
                            if (turno == 2)
                            {
                                if (y2 > 2)
                                {
                                    SetCursorPosition(x2, y2 - 1);
                                    y2--;
                                }
                            }
                            break;

                        case ConsoleKey.D:
                            if (turno == 1)
                            {
                                if (x < 41)
                                {
                                    SetCursorPosition(x + 1, y);
                                    x++;
                                }
                            }
                            if (turno == 2)
                            {
                                if (x2 < 41)
                                {
                                    SetCursorPosition(x2 + 1, y2);
                                    x2++;
                                }
                            }
                            break;

                        case ConsoleKey.S:
                            if (turno == 1)
                            {
                                if (y < 11)
                                {
                                    SetCursorPosition(x, y + 1);
                                    y++;
                                }
                            }
                            if (turno == 2)
                            {
                                if (y2 < 11)
                                {
                                    SetCursorPosition(x2, y2 + 1);
                                    y2++;
                                }
                            }
                            break;

                        case ConsoleKey.A:
                            if (turno == 1)
                            {
                                if (x > 5)
                                {
                                    SetCursorPosition(x - 1, y);
                                    x--;
                                }
                            }
                            if (turno == 2)
                            {
                                if (x2 > 5)
                                {
                                    SetCursorPosition(x2 - 1, y2);
                                    x2--;
                                }
                            }
                            break;
                        case ConsoleKey.Spacebar:
                            if (turno == 1)
                            {
                                if (x == 5)
                                {
                                    int ayuda = y - 2;
                                    if (mapaPlayer[0+ayuda,y - 2 - ayuda] == 0)
                                    {
                                        mapaPlayer[0+ayuda, y-2-ayuda] = 1;
                                        barco--;
                                        if (barco == 0)
                                        {
                                            turno = 2;
                                            goto juego;
                                        } else
                                        {
                                            goto juego;
                                        }
                                    }
                                }
                            }
                            if (turno == 2)
                            {
                                if (x2 == 5)
                                {
                                    int ayuda = y2 - 2;
                                    if (mapaPlayer2[0 + ayuda, y2 - 2 - ayuda] == 0)
                                    {
                                        mapaPlayer2[0 + ayuda, y2 - 2 - ayuda] = 1;
                                        barco2--;
                                        if (barco2 == 0)
                                        {
                                            turno = 1;
                                            goto juego;
                                        }
                                        else
                                        {
                                            goto juego;
                                        }
                                    }
                                }
                            }
                            break;
                    }
                }
            }

        }
    }
}
