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
                string line = Console.ReadLine();

                int mitad = line.Length / 2;

                string izq = line.Substring(0, mitad);
                string der = line.Substring(mitad, line.Length - mitad);


                string inv_izq = "";
                for (int i = izq.Length - 1; i >= 0; i--)
                {
                    inv_izq += izq[i];
                }

                string inv_der = "";
                for (int i = der.Length - 1; i >= 0; i--)
                {
                    inv_der += der[i];
                }

                Console.WriteLine(inv_izq + inv_der);

                //Console.WriteLine(mitad);
            }

            Console.ReadLine();

        }

    }
}
