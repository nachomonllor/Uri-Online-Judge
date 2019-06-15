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

            while (true)
            {

                string s = Console.ReadLine();

                if (s == null)
                {
                    break;

                }
                if (s == string.Empty)
                {
                    Console.WriteLine();
                    continue;
                }

                SortedSet<char> hs = new SortedSet<char>();

                int i;

                for (i = 0; i < s.Length; i++)
                {
                    if (s[i] != ' ')
                        hs.Add(s[i]);
                }

                string ordenado = "";

                foreach (char ch in hs)
                {
                    ordenado += ch;
                }

                // Console.WriteLine(ordenado);

                List<char[]> lista = new List<char[]>();

                i = 1;
                char ini = ' ', fin = ' ';
                while (i < ordenado.Length)
                {
                    ini = ordenado[i - 1];
                    while (i < ordenado.Length && ordenado[i - 1] + 1 == ordenado[i])
                    {
                        i++;
                    }
                    fin = ordenado[i - 1];

                    //Console.Write(ini + ":" + fin + ", "); 
                    lista.Add(new char[] { ini, fin });
                    i++;
                }

                if (i - 1 >= 0 && i - 1 < ordenado.Length &&
                    fin != ordenado[i - 1])
                {
                    //Console.WriteLine(ordenado[i-1] + ":" + ordenado[i-1]);
                    lista.Add(new char[] { ordenado[i - 1], ordenado[i - 1] });
                }

                // Console.WriteLine(i + " " + ordenado.Length);
                for (i = 0; i < lista.Count - 1; i++)
                {
                    Console.Write(lista[i][0] + ":" + lista[i][1] + ", ");
                }
                Console.Write(lista[i][0] + ":" + lista[i][1]);

                Console.WriteLine();

            }

            Console.ReadLine();

        }



    }
}

