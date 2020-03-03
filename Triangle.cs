using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {

        static string puede(int[] a)
        {
            List<int> aux = new List<int>(a);

            for (int i = 0; i < aux.Count; i++)
            {
                List<int> nuevo = aux.ToList();
                nuevo.RemoveAt(i);
                nuevo.Sort();

                if (nuevo[0] + nuevo[1] > nuevo[2])
                {
                    return "S";
                }

            }
            return "N";
        }

        static void Main(string[] args)
        {

            int[] a = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), e => int.Parse(e));
            Console.WriteLine(puede(a));

            Console.ReadLine();
        }
    }
}
