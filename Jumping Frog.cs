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
            string[] input = Console.ReadLine().Trim().Split(' ');

            int p = int.Parse(input[0]);
            int n = int.Parse(input[1]);
            int[] a = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), e => int.Parse(e));

            string ans = "YOU WIN";


            for (int i = 1; i < n; i++)
            {
                if (Math.Abs(a[i] - a[i - 1]) > p)
                {
                    ans = "GAME OVER";
                    break;
                }
            }

            Console.WriteLine(ans);

            Console.ReadLine();
        }

    }
}