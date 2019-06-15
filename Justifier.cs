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

            while (N != 0)
            {

                List<string> words = new List<string>();
                int max_len = 0;
                for (int i = 0; i < N; i++)
                {
                    words.Add(Console.ReadLine());
                    max_len = Math.Max(max_len, words[i].Length);
                }

                for (int i = 0; i < words.Count; i++)
                {
                    for (int j = 0; j < max_len - words[i].Length; j++)
                    {
                        Console.Write(" ");
                    }
                    Console.WriteLine(words[i]);
                }

                N = int.Parse(Console.ReadLine());
                if (N != 0)
                {
                    Console.WriteLine();
                }
            }


            //Console.ReadLine();
        }

    }
}
