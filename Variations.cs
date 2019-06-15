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

            int t = int.Parse(Console.ReadLine());

            while (t-- > 0)
            {
                string S = Console.ReadLine();

                string variaciones = "AEIOSaeios";

                int pos = 1;

                for (int i = 0; i < S.Length; i++)
                {
                    if (variaciones.Contains(S[i]))
                    {
                        pos *= 3;
                    }
                    else
                    {
                        pos *= 2;
                    }
                }

                Console.WriteLine(pos);

            }

            Console.ReadLine();
        }



    }
}

