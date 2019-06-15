using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            while (N-- > 0)
            {
                string a, b;
                string[] input = Console.ReadLine().Split(' ');

                a = input[0];
                b = input[1];

                string ans = "";

                int i = 0, j = 0;
                while (i < a.Length && j < b.Length)
                {
                    ans += a[i].ToString() + b[j].ToString();
                    i++;
                    j++;
                }
                while (i < a.Length)
                {
                    ans += a[i].ToString();
                    i++;
                }
                while (j < b.Length)
                {
                    ans += b[j].ToString();
                    j++;
                }

                Console.WriteLine(ans);

            }
            Console.ReadLine();

        }



    }
}



