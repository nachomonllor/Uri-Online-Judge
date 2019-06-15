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

            //string input = "round  elimination during  onsite  contest";

            int N = int.Parse(Console.ReadLine());

            while (N-- > 0)
            {
                string input = Console.ReadLine(); // "    u   r i  o   n l  i      n e    ";

                input = input.Trim();

                string ans = "";

                if (input.Length > 0)
                {
                    ans += input[0];
                }

                for (int i = 1; i < input.Length; i++)
                {
                    if (input[i - 1] == ' ' && input[i] != ' ')
                    {
                        ans += input[i];
                    }
                }

                Console.WriteLine(ans);

            }

            Console.ReadLine();

        }

    }
}
