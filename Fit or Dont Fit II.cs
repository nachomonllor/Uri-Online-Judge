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
            int N = int.Parse(Console.ReadLine());

            while (N-- > 0)
            {
                string a, b;
                string[] input = Console.ReadLine().Split(' ');
                a = input[0];
                b = input[1];

                if (b.Length <= a.Length)
                {

                    //if (b[b.Length - 1] == a[a.Length - 1])
                    //{
                    //    Console.WriteLine("encaixa");
                    //}
                    if (a.Substring(a.Length - b.Length, b.Length) == b)
                    {
                        Console.WriteLine("encaixa");
                    }
                    else
                    {
                        Console.WriteLine("nao encaixa");
                    }
                }
                else
                {
                    Console.WriteLine("nao encaixa");
                }
            }

            Console.ReadLine();
        }


    }
}
