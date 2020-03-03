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

            long[] fib = new long[61];

            fib[0] = 0;
            fib[1] = 1;
            for (int i = 2; i < fib.Length; i++)
            {
                fib[i] = fib[i - 1] + fib[i - 2];
            }

            //for (int i = 0; i < fib.Length; i++)
            //{
            //    Console.WriteLine("{0} {1}",i, fib[i]);
            //}

            int t = int.Parse(Console.ReadLine());

            while (t-- > 0)
            {
                int x = int.Parse(Console.ReadLine().Trim());
                //Fib(0) = 0
                Console.WriteLine("Fib({0}) = {1}", x, fib[x] );
            }

            Console.ReadLine();
        }
 
    }
}