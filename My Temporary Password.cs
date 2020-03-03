https://www.urionlinejudge.com.br/judge/es/problems/view/2714

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {


        static void Solve(string data)
        {

            if (data.Length != 20)
            {
                Console.WriteLine("INVALID DATA");
            }
            else
            {
                if (data.Substring(0, 2) != "RA")
                {
                    Console.WriteLine("INVALID DATA");
                }
                else
                {
                    long num = long.Parse(data.Substring(2, 18));

                    Console.WriteLine(num);

                }
            }

        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine().Trim());

            for (int i = 0; i < n; i++)
            {
                string linea = Console.ReadLine().Trim();
                Solve(linea);
            }

            Console.ReadLine();
        }
    }
}
