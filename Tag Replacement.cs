using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    class Program
    {


        static string reemplazar(string cadena, string original, string reemplazo)
        {
            original = original.ToLower();
            string copia = cadena.ToLower();

            string ans = "";
            for (int i = 0; i < cadena.Length; i++)
            {

                while (i + original.Length < copia.Length && copia.Substring(i, original.Length) == original)
                {
                    i += original.Length;

                    ans += reemplazo;
                }

                ans += cadena[i];
            }
            return ans;
        }

        static void Main(string[] args)
        {

            while (true)
            {

                string original = Console.ReadLine();
                string replaced = Console.ReadLine();
                string third = Console.ReadLine();

                if (original == null && replaced == null && third == null)
                {
                    break;
                }

                //string original = "HI";
                //string replaced = "667";
                //string third = "92<HI=/>HOLA como ESTAS<z==//HIb><CcHIhi>";

                //string original = "BODY";
                //string replaced =  "10";
                //string third = "<><BODY garbage>body</BODY>";

                //string original = "aBc";
                // string replaced = "923";
                // string third = "<dont replacethis>abcabc<abcabcde>";

                //string third = "<ta>bLe<TaBlewidth=100></table></ta>";


                List<string> partes = new List<string>();
                int i = 0;

                while (i < third.Length)
                {

                    string abierto = "";
                    while (i < third.Length &&
                        third[i] != '<')
                    {
                        abierto += third[i];
                        i++;
                    }

                    //  Console.WriteLine(abierto);
                    if (abierto.Length > 0) partes.Add(abierto);

                    string encerrado = "";
                    while (i < third.Length &&
                        third[i] != '>')
                    {
                        encerrado += third[i];
                        i++;
                    }
                    if (i < third.Length)
                    {
                        encerrado += third[i];
                        i++;
                    }

                    // Console.WriteLine(encerrado);
                    if (encerrado.Length > 0) partes.Add(encerrado);
                }

                string ans = "";
                foreach (string s in partes)
                {
                    //Console.WriteLine(s);
                    if (s[0] == '<')
                    {
                        //  ans += reemplazar(s.ToLower(), original.ToLower(), replaced);
                        // ans += s.Replace(original.ToLower(), replaced);
                        ans += reemplazar(s, original, replaced);
                    }
                    else
                    {
                        ans += s;
                    }

                }

                Console.WriteLine(ans);

            }

            Console.ReadLine();

        }




    }
}

