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

            double sum = 0;
            int valid = 0;
            while (true)
            {
                double x = double.Parse(Console.ReadLine().Trim());

                if (x < 0 || x > 10)
                {
                    Console.WriteLine("nota invalida");
                }
                else
                {
                    sum += x;
                    valid++;
                }
                if (valid == 2) break;

            }

            Console.WriteLine("media = " + (sum / 2.0));

            Console.ReadLine();
        }
 
    }
}