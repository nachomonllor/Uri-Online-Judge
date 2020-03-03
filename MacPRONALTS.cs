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

            Dictionary<int, double> dic = new Dictionary<int, double>();
            double precio = 1.5;
            for (int i = 1001; i <= 1005; i++)
            {
                dic[i] = precio;
                precio++;
            }

            int p = int.Parse(Console.ReadLine().Trim());

            double ans = 0;

            while (p-- > 0)
            {
                string[] input = Console.ReadLine().Trim().Split(' ');
                int num_prod = int.Parse(input[0]);
                int cant = int.Parse(input[1]);

                ans += dic[num_prod] * cant;
            }

            Console.WriteLine(ans.ToString("0.00"));

            Console.ReadLine();
        }
    }
}
