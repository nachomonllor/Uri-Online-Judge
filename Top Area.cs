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


            //double[][] matriz = 
            //{
            //    new double[]{ 1, 2, 3, 4, 5, 6},
            //    new double[]{ 7, 8, 9,10,11,12},
            //    new double[]{13,14,15,16,17,18},
            //    new double[]{19,20,21,22,23,24},
            //    new double[]{25,26,27,28,29,30},
            //    new double[]{31,32,33,34,35,36},

            //};

            double[][] matriz = new double[12][];
            string s = Console.ReadLine().Trim();


            for (int i = 0; i < 12; i++)
            {
                matriz[i] = new double[12];
                for (int j = 0; j < 12; j++)
                {
                    double x = double.Parse(Console.ReadLine().Trim());
                    matriz[i][j] = x;

                }
            }

            double area = 0;
            int ini = 1, fin = matriz.Length-1;
            double sum = 0.0;
            for (int i = 0; i < matriz.Length / 2; i++)
            {
                for (int j = ini; j < fin; j++)
                {
                   // Console.Write(matriz[i][j] + " ");
                    sum += matriz[i][j];
                    area++;
                }
                ini++;
                fin--;
               // Console.WriteLine();
            }

            if (s == "S")
            {
                Console.WriteLine(sum);
            }
            else
            {
                Console.WriteLine((sum / area).ToString("0.0"));
            }


            Console.ReadLine();
        }

    }
}