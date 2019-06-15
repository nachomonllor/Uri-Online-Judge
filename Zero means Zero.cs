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
            long N, M;

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "0 0")
                {
                    break;
                }
                M = long.Parse(input.Split(' ')[0]);
                N = long.Parse(input.Split(' ')[1]);
                string res = (M + N).ToString();

                string sin_ceros = "";
                for (int i = 0; i < res.Length; i++)
                {
                    if (res[i] != '0')
                    {
                        sin_ceros += res[i];
                    }
                }

                Console.WriteLine(sin_ceros);
            }
        }

    }
}

