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
                int x, y;
                string input = Console.ReadLine();
                x = int.Parse(input.Split(' ')[0]);
                y = int.Parse(input.Split(' ')[1]);

                List<string> nombres = new List<string>();
                nombres.Add("Rafael");
                nombres.Add("Beto");
                nombres.Add("Carlos");

                List<int> funciones = new List<int>();
                funciones.Add((int)Math.Pow((3 * x), 2) + (int)Math.Pow(y, 2));
                funciones.Add(2 * (int)Math.Pow(x, 2) + (int)Math.Pow((5 * y), 2));
                funciones.Add(-100 * x + (int)Math.Pow(y, 3));

                for (int i = 0; i < 3 - 1; i++)
                {
                    for (int j = i + 1; j < 3; j++)
                    {
                        if (funciones[i] < funciones[j])
                        {
                            int temp = funciones[i];
                            funciones[i] = funciones[j];
                            funciones[j] = temp;

                            string tempNombre = nombres[i];
                            nombres[i] = nombres[j];
                            nombres[j] = tempNombre;
                        }
                    }
                }

                //for (int i = 0; i < 3; i++)
                //{
                //    Console.WriteLine(nombres[i] + " " + funciones[i]);
                //}
                Console.WriteLine(nombres[0] + " ganhou");
            }

            Console.ReadLine();
        }

    }
}
