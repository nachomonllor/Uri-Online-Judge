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

            int n = int.Parse(Console.ReadLine());

            while (n-- > 0)
            {
                int k = int.Parse(Console.ReadLine());
                List<string> lenguas = new List<string>();
                for (int i = 0; i < k; i++)
                {
                    lenguas.Add(Console.ReadLine());
                }

                bool iguales = true;
                for (int i = 1; i < k; i++)
                {
                    if (lenguas[i - 1] != lenguas[i])
                    {
                        iguales = false;
                        break;
                    }
                }
                if (iguales)
                {
                    Console.WriteLine(lenguas[0]);
                }
                else
                {
                    Console.WriteLine("ingles");
                }
            }

            Console.ReadLine();
        }



    }
}

