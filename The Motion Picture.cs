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
            double a = double.Parse(input[0]);
            double b = double.Parse(input[1]);

            Console.WriteLine( (((b / a) - 1) * 100).ToString("0.00") + "%" );


            Console.ReadLine();
        }
    }
}
