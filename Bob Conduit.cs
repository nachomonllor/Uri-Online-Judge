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
            int t = int.Parse(Console.ReadLine().Trim());


            while (t-- > 0)
            {
                string[] input = Console.ReadLine().Trim().Split(' ');
                double a = double.Parse(input[0]);
                double b = double.Parse(input[1]);

                Console.WriteLine(  Math.Ceiling((a * 2 + b * 2) / 2.0));
            }


            Console.ReadLine();
        }

    }
}