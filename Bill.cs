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

            //ImprimirPatron(4); 

            int n = int.Parse(Console.ReadLine().Trim());

            while (n-- > 0)
            {
                int x = int.Parse(Console.ReadLine().Trim());
                if (x % 2 == 0)
                {
                    Console.WriteLine(0);
                }
                else
                {
                    Console.WriteLine(1);
                }

            }

            Console.ReadLine();

        }
    }
}
