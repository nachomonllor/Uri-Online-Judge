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
                string a = Console.ReadLine();
                string b = Console.ReadLine();

                if (a == null && b == null)
                {
                    break;
                }
                int max_len = 0;

                for (int i = 0; i < b.Length; i++)
                {
                    for (int j = i; j < b.Length; j++)
                    {
                        if (a.Contains(b.Substring(i, j - i + 1)))
                        {
                            max_len = Math.Max(max_len, j - i + 1);
                        }
                        else
                        {
                            break;
                        }
                    }
                }

                Console.WriteLine(max_len);

            }


            Console.ReadLine();

        }



    }
}


