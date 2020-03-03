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

            int n = int.Parse(Console.ReadLine().Trim());
            int[] arr = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), e => int.Parse(e));

            int min = int.MaxValue;
            int ind = -1;
            for (int i = 0; i < n; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                    ind = i;
                }
            }

            Console.WriteLine(ind +1);

            Console.ReadLine();
        }
    }
}
