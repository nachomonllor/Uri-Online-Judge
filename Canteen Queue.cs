
https://www.urionlinejudge.com.br/judge/es/problems/view/1548

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {

        static int Solve(int[] arr)
        {

            int[] copia = arr.ToArray();

            Array.Sort(copia);
            Array.Reverse(copia);

            int cont = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == copia[i])
                {
                    cont++;
                }
            }

            return cont;
        }

        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine().Trim());

            while (n-- > 0)
            {
                int len = int.Parse(Console.ReadLine().Trim());

                int[] arr = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), e => int.Parse(e));


                Console.WriteLine(Solve(arr));


            }


            Console.ReadLine();

        }

    }
}
