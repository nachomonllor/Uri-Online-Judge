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
                string frase = Console.ReadLine();
                int derecha = int.Parse(Console.ReadLine());

                //string alfab = "abcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxyz";
                string alfab = "ABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZ";
                string ans = "";

                for (int i = 0; i < frase.Length; i++)
                {

                    int indalfab = alfab.LastIndexOf(frase[i]);
                    ans += alfab[indalfab - derecha].ToString();

                }

                Console.WriteLine(ans);

            }

            Console.ReadLine();

        }

    }
}
