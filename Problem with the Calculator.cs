https://www.urionlinejudge.com.br/judge/es/problems/view/2694


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

            int n = int.Parse(Console.ReadLine().Trim());


            for (int i = 0; i < n; i++)
            {
                string linea = Console.ReadLine().Trim();

                List<int> lista = new List<int>();
                string num = "";
                for (int j = 0; j < linea.Length; j++)
                {
                    if (char.IsDigit(linea[j]))
                    {
                        num += linea[j];
                    }
                    else
                    {
                        if (num != "")
                        {
                            lista.Add(int.Parse(num));
                        }
                        num = "";
                    }
                }
                if (num != "")
                {
                    lista.Add(int.Parse(num));
                }

                Console.WriteLine(lista.Sum());

            }


            Console.ReadLine();
        }
    }
}
