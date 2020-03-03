https://www.urionlinejudge.com.br/judge/es/problems/view/2157


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {

        static string ImprimirSecuencia(int ini, int fin)
        {

            StringBuilder sb = new StringBuilder();

            for (int i = ini; i <= fin; i++) sb.Append(i);
            
            char[] rev = sb.ToString().ToCharArray();
            Array.Reverse(rev);
            return sb.ToString() + new string(rev);
            
        }

        static void Main(string[] args)
        {

            //Console.WriteLine(ImprimirSecuencia(10, 13));
            int n = int.Parse(Console.ReadLine().Trim());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Trim().Split(' ');
                int ini = int.Parse(input[0]);
                int fin = int.Parse(input[1]);

                Console.WriteLine(ImprimirSecuencia(ini, fin));
            }

            Console.ReadLine();
        }
    }
}
