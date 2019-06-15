
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
                string frase = Console.ReadLine();
                if (frase == null)
                {
                    break;
                }


                string lower = "abcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxyz";
                string upper = "ABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZ";
                string ans = "";

                for (int i = 0; i < frase.Length; i++)
                {
                    if (char.IsLetter(frase[i]))
                    {
                        if (char.IsLower(frase[i]))
                        {
                            int indalfab = lower.IndexOf(frase[i]);
                            ans += lower[indalfab + 13].ToString();
                        }
                        else
                        {
                            int indalfab = upper.IndexOf(frase[i]);
                            ans += upper[indalfab + 13].ToString();
                        }
                    }
                    else
                    {
                        ans += frase[i];
                    }
                }

                Console.WriteLine(ans);

            }
            Console.ReadLine();

        }



    }
}

