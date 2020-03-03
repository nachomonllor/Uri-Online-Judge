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
                int x = int.Parse(Console.ReadLine().Trim());

                if (x != 2002)
                {
                    Console.WriteLine("Senha Invalida");
                }
                else
                {
                    Console.WriteLine("Acesso Permitido");
                    break;
                }

            }


            Console.ReadLine();
        }



    }
}