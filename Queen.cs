using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {

                //string input = "4 4 6 2";
                //string input = "3 5 3 5";
                string input = Console.ReadLine(); // "5 5 4 3";

                int X1, Y1, X2, Y2;

                X1 = int.Parse(input.Split(' ')[0]);
                Y1 = int.Parse(input.Split(' ')[1]);
                X2 = int.Parse(input.Split(' ')[2]);
                Y2 = int.Parse(input.Split(' ')[3]);

                if (X1 == 0 && X2 == 0 && Y1 == 0 && Y2 == 0)
                {
                    break;
                }

                int movimientos = 0;
                if (X1 == X2 && Y1 == Y2)
                {
                    Console.WriteLine("0");
                    continue;
                    //break;
                }
                else
                {
                    //NORTE
                    int fila = X1, col = Y1;
                    if (col == Y2)
                    {
                        while (fila >= 0)
                        {
                            fila--;
                            if (fila == X2)
                            {
                                movimientos = 1;
                                break;
                            }
                        }
                    }

                    //NORESTE
                    fila = X1;
                    col = Y1;
                    while (fila >= 0 && col < 8)
                    {
                        fila--;
                        col++;
                        if (fila == X2 && col == Y2)
                        {
                            movimientos = 1;
                            break;
                        }
                    }

                    //ESTE
                    fila = X1;
                    col = Y1;
                    if (fila == X2)
                    {
                        while (col < 8)
                        {
                            col++;
                            if (col == Y2)
                            {
                                movimientos = 1;
                                break;
                            }
                        }
                    }

                    //SURESTE
                    fila = X1;
                    col = Y1;
                    while (fila < 8 && col < 8)
                    {
                        fila++;
                        col++;
                        if (fila == X2 && col == Y2)
                        {
                            movimientos = 1;
                            break;
                        }
                    }

                    //SUR
                    fila = X1;
                    col = Y1;
                    if (col == Y2)
                    {
                        while (fila < 8)
                        {
                            fila++;
                            if (fila == X2)
                            {
                                movimientos = 1;
                                break;
                            }
                        }
                    }

                    //SUROESTE
                    fila = X1;
                    col = Y1;
                    while (fila < 8 && col >= 0)
                    {
                        fila++;
                        col--;
                        if (fila == X2 && col == Y2)
                        {
                            movimientos = 1;
                            break;
                        }
                    }


                    //OESTE
                    fila = X1;
                    col = Y1;
                    if (fila == X2)
                    {
                        while (col >= 0)
                        {
                            col--;
                            if (col == Y2)
                            {
                                movimientos = 1;
                                break;
                            }
                        }
                    }

                    //NOROESTE
                    fila = X1;
                    col = Y1;
                    while (fila >= 0 && col >= 0)
                    {
                        fila--;
                        col--;
                        if (fila == X2 && col == Y2)
                        {
                            movimientos = 1;
                            break;
                        }
                    }

                    if (movimientos == 1)
                    {
                        Console.WriteLine(movimientos);
                        continue;
                        // break;
                    }

                }

                if (movimientos != 1)
                {
                    Console.WriteLine("2");
                }

            }

            Console.ReadLine();

        }



    }
}
