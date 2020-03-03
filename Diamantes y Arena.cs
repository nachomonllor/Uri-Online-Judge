https://www.urionlinejudge.com.br/judge/es/problems/view/1069


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

            //string s = "<..><.<..>>";
            //string s = "<<<..<......<<<<....>";
            //Console.WriteLine(ContarDiamantes(s));

            int n = int.Parse(Console.ReadLine().Trim());

            while (n-- > 0)
            {
                string s = Console.ReadLine().Trim();
               // Console.WriteLine(ContarDiamantes(s));

                Stack<char> pila = new Stack<char>();
                int balanceado = 0;

                int ans = 0;

                for (int i = 0; i < s.Length; i++)
                {
                    if (s[i] == '<')
                    {
                        pila.Push(s[i]);
                        //balanceado++;
                    }
                    else
                    {
                        if (s[i] == '>')
                        {
                            //balanceado--;
                            //if (pila.Count == 0)
                            //{
                            //    //return "incorrect";
                            //}
                            
                            if (pila.Count > 0)
                            {
                                ans++;
                                pila.Pop();
                            }

                        }
                    }
                }

                Console.WriteLine(ans);


            }

            



            Console.ReadLine();
        }

    }
}
