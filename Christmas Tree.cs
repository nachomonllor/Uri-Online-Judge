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
                string input = Console.ReadLine();
                if (input == null)
                {
                    break;
                }

                int N = int.Parse(input);

                int ancho = 0;

                for (int i = 1; ancho < N; i++)
                {
                    for (int j = 1; j <= (N / 2) - i + 1; j++)
                    {
                        Console.Write(" ");
                    }
                    ancho = i * 2 - 1;
                    for (int j = 0; j < ancho; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }

                for (int i = 0; i < N / 2; i++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine("*");
                for (int i = 0; i < N / 2 - 1; i++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine("***");

                Console.WriteLine();
            }
            Console.ReadLine();

        }




    }
}

