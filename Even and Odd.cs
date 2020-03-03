https://www.urionlinejudge.com.br/judge/es/problems/view/1259

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


            //int[] arr = {   4,
            //                32,
            //                34,
            //                543,
            //                3456,
            //                654,
            //                567,
            //                87,
            //                6789,
            //                98  };




            List<int> pares = new List<int>();
            List<int> impares = new List<int>();

            int n = int.Parse(Console.ReadLine().Trim());

            while (n-- > 0)
            {
                int elem = int.Parse(Console.ReadLine().Trim());
                if (elem % 2 == 0)
                {
                    pares.Add(elem);
                }
                else
                {
                    impares.Add(elem);
                }
            }

            pares.Sort();
            impares.Sort();
            impares.Reverse();

            for (int i = 0; i < pares.Count; i++)
            {
                Console.WriteLine(pares[i]);
            }

            for (int i = 0; i < impares.Count; i++)
            {
                Console.WriteLine(impares[i]);
            }


            Console.ReadLine();

        }

    }
}
