//https://www.urionlinejudge.com.br/judge/es/problems/view/2028

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {

        static string Repetir(string s, int n)
        {
            var result = s;

            for (var i = 0; i < n - 1; i++)
            {
                result += s;
            }

            return result;
        }     

        static void Main(string[] args)
        {
            
            Dictionary<int, string> dic = new Dictionary<int, string>();

            dic.Add(0, "0 ");

            for (int i = 1; i < 201; i++)
            {
                dic.Add(i, dic[i - 1] + Repetir(i + " ", i));
            }

            string linea;
            int caso = 1;
            while ((linea = Console.ReadLine()) != null)
            {
                int x = int.Parse(linea.Trim());
                string numero = "numero";
                int len = (x * (x + 1)) / 2 + 1;

                if(len > 1) numero += "s";

                Console.WriteLine( "Caso {0}: {1} {2}", caso, len, numero );
                Console.WriteLine(dic[x].Trim());
                caso++;
                Console.WriteLine();
            }


            Console.ReadLine();
        }
    }
}

