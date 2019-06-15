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

                string alfab = "abcdefghijklmnopqrstuvwxyz";

                Dictionary<char, int> diccio = new Dictionary<char, int>();
                for (int i = 0; i < alfab.Length; i++)
                {
                    diccio[alfab[i]] = 0;
                }

                for (int i = 0; i < frase.Length; i++)
                {
                    if (char.IsLetter(char.ToLower(frase[i])))
                    {
                        diccio[frase[i]]++;
                    }
                }

                int letras = 0;
                foreach (KeyValuePair<char, int> kvp in diccio)
                {
                    if (kvp.Value > 0)
                    {
                        letras++;
                    }
                }

                if (letras == alfab.Length)
                {
                    Console.WriteLine("frase completa");
                }
                else if (letras >= alfab.Length / 2)
                {
                    Console.WriteLine("frase quase completa");
                }
                else
                {
                    Console.WriteLine("frase mal elaborada");
                }
            
            }

            Console.ReadLine();
        }




    }
}


