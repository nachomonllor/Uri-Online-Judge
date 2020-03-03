https://www.urionlinejudge.com.br/judge/es/problems/view/1066

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

            int pares = 0, impares = 0, neg = 0, pos = 0;
            for (int i = 0; i < 5; i++)
            {
                int x = int.Parse(Console.ReadLine().Trim());
                if (x < 0) neg++;
                if (x > 0) pos++;
                if (x % 2 == 0) pares++;
                if (x % 2 != 0) impares++;
            }

            Console.WriteLine("{0} valor(es) par(es)", pares);
            Console.WriteLine("{0} valor(es) impar(es)", impares);
            Console.WriteLine("{0} valor(es) positivo(s)", pos);
            Console.WriteLine("{0} valor(es) negativo(s)", neg);

            Console.ReadLine();
        }
    }
}