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

            while (true)
            {
                string frase = Console.ReadLine();
                if (frase == null)
                {
                    break;
                }

                string[] input = frase.Split(' ');

                int i = 0;

                int cont = 0;
                while (i + 1 < input.Length)
                {
                    bool iguales = false;
                    while (i + 1 < input.Length && char.ToLower(input[i][0]) == char.ToLower(input[i + 1][0]))
                    {
                        iguales = true;
                        i++;
                    }
                    if (iguales)
                    {
                        cont++;
                    }
                    i++;
                }

                Console.WriteLine(cont);

            }
            Console.ReadLine();

        }

    }
}
