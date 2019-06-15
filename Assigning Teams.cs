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

            string[] input = Console.ReadLine().Split(' ');
            int A = int.Parse(input[0]);
            int B = int.Parse(input[1]);
            int C = int.Parse(input[2]);
            int D = int.Parse(input[3]);

            Console.WriteLine(Math.Abs((A + D) - (B + C)));


            Console.ReadLine();
        }
    }
}
