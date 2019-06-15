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
                if (input == null) break;

                long a = long.Parse(input.Split(' ')[0]);
                long b = long.Parse(input.Split(' ')[1]);

                Console.WriteLine(Math.Abs(a - b));
            }
        }

    }
}
