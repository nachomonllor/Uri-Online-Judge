using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {

        static string BloggoShortcuts(string S)
        {
            string res = "";
            bool guionBajo = false;
            bool asterisco = false;

            for (int i = 0; i < S.Length; i++)
            {
                if (S[i] == '_')
                {
                    if (guionBajo)
                    {
                        res += "</i>";
                        guionBajo = false;
                    }
                    else
                    {
                        res += "<i>";
                        guionBajo = true;
                    }

                }
                else if (S[i] == '*')
                {
                    if (asterisco)
                    {
                        res += "</b>";
                        asterisco = false;
                    }
                    else
                    {
                        res += "<b>";
                        asterisco = true;

                    }
                }
                else
                {
                    res += S[i];
                }
            }
            return res;
        }

        static void Main(string[] args)
        {
            while (true)
            {
                string input = Console.ReadLine();
                if (input == null)
                {
                    break;
                }
                Console.WriteLine(BloggoShortcuts(input));

            }

            Console.ReadLine();
        }


    }
}

