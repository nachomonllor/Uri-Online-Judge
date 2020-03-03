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

            int[] arr = new int[1000];

            int t = int.Parse(Console.ReadLine().Trim());

            int cont = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = cont;
                cont++;
                if (cont == t)
                {
                    cont = 0;
                }
            }

            for (int i = 0; i < arr.Length; i++)
            {
                //N[0] = 0
                Console.WriteLine("N[{0}] = {1}", i, arr[i]);
            }

            Console.ReadLine();
        }
 
    }
}