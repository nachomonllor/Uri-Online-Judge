using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {

        static void Multiplos(int[] arr)
        {
            int[] m = new int[6];

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    m[2]++;
                }
                if (arr[i] % 3 == 0)
                {
                    m[3]++;
                }
                if (arr[i] % 4 == 0)
                {
                    m[4]++;
                }
                if (arr[i] % 5 == 0)
                {
                    m[5]++;
                }

            }

            for (int i = 2; i < m.Length; i++)
            {
                Console.WriteLine("{0} Multiplo(s) de {1}", m[i], i);
            }


        }


        static void Main(string[] args)
        {

            //int[] arr = { 2, 5, 4, 20, 10 };

            //Multiplos(arr);
            int n = int.Parse(Console.ReadLine().Trim());
            int[] arr = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), e => int.Parse(e));


            Multiplos(arr);

            Console.ReadLine();
        }
    }
}
