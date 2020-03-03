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

            int t = int.Parse(Console.ReadLine().Trim());

            int[] arr = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), e => int.Parse(e));

            int cont = 0;
            for (int i = 0; i < 5; i++)
            {
                if (t == arr[i])
                {
                    cont++;
                }
            }

            Console.WriteLine(cont);


            Console.ReadLine();
        }
    }
}
