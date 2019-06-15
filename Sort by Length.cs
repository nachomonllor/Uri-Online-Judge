using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {


        static string SortByLength(string s)
        {
            string[] x = s.Split(' ');

            for (int i = 1; i < x.Length; i++)
            {
                int indice = i;
                while (indice > 0 && x[indice].Length > x[indice - 1].Length)
                {
                    string temp = x[indice];
                    x[indice] = x[indice - 1];
                    x[indice - 1] = temp;
                    indice--;
                }
            }

            return String.Join(" ", x);
        }



        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine().Trim());

            while (n-- > 0)
            {
                string input = Console.ReadLine().Trim();
                Console.WriteLine(SortByLength(input));
            }

            Console.ReadLine();
        }
    }
}
