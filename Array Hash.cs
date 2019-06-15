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
                int L = int.Parse(Console.ReadLine());

                int sum = 0;
                //string alfab = "abcdefghijklmnopqrstuvwxyz";
                string alfab = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
                for (int i = 0; i < L; i++)
                {
                    string cad = Console.ReadLine();

                    for (int j = 0; j < cad.Length; j++)
                    {
                        int alfabet_position = alfab.IndexOf(cad[j]);
                        int element_input = i;
                        int position_element = j;

                        sum += alfabet_position + element_input + position_element;
                    }
                }
                Console.WriteLine(sum);

            }

            Console.ReadLine();
        }

    }
}
