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

                if (input == "0 0 0" || input == "1 1 1")
                {
                    Console.WriteLine("*");
                }
                else
                {
                    if (input == "1 0 0" || input == "0 1 1")
                    {
                        Console.WriteLine("A");
                    }
                    if (input == "0 1 0" || input == "1 0 1")
                    {
                        Console.WriteLine("B");
                    }
                    if (input == "0 0 1" || input == "1 1 0")
                    {
                        Console.WriteLine("C");
                    }
                }

            }

            Console.ReadLine();

        }

    }
}
