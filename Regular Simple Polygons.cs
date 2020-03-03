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

            string[] input = Console.ReadLine().Trim().Split(' ');
            long a = long.Parse(input[0]);
            long b = long.Parse(input[1]);

            Console.WriteLine(a * b);

            Console.ReadLine();
        }
    }
}
