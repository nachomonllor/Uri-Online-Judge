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

            double val_i = 0;
            double val_j = 1;
            double incremento_j = 0.2;
            for (double i = 0; val_i <= 2; i++)
            {
                for (int cont = 0; cont < 3; cont++)
                {
                    //I=0 J=1
                    Console.WriteLine("I=" + val_i + " J=" + (val_j++));
                }

                val_i += 0.2;
                val_j = 1;
                val_j += incremento_j;
                incremento_j += 0.2;

            }


            Console.ReadLine();
        }



    }
}