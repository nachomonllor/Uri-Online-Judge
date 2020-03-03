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

            long x = long.Parse(Console.ReadLine().Trim());
            long y = long.Parse(Console.ReadLine().Trim());

            if (x > y)
            {
                long temp = x;
                x = y;
                y = temp;
            }

            for (long i = x + 1; i < y; i++)
            {
                if (i % 5 == 2 || i % 5 == 3)
                {
                    Console.WriteLine(i);
                }
            }


            Console.ReadLine();
        }
 
    }
}