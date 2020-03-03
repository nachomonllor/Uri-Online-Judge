using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {


        static string MostrarFrecuencias(string s)
        {

            Dictionary<char, int> frec = new Dictionary<char, int>();

            for (int i = 0; i < s.Length; i++)
            {
                if (frec.ContainsKey(s[i])) frec[s[i]]++;
                else frec[s[i]] = 1;
            }


            var items = from pair in frec
                        orderby pair.Value ascending, pair.Key descending
                        select pair;

            StringBuilder ans = new StringBuilder();
            foreach (KeyValuePair<char, int> item in items)
            {
                //Console.WriteLine((int)item.Key + " " + item.Value);
                //ans.AppendLine((int)item.Key + " " + item.Value);
                ans.Append((int)item.Key);
                ans.Append(" ");
                ans.Append(item.Value);
                ans.Append('\n');
            }

            return ans.ToString().TrimEnd('\n') ;

        }

        static void Main(string[] args)
        {

            //string s = "AAABBC";

            //string s = "BBAAAACCCC";
            ////string s = "122333";
            //MostrarFrecuencias(s);

            StringBuilder ans = new StringBuilder();
            string linea = "";
            while ((linea = Console.ReadLine()) != null)
            {
               ans.AppendLine( MostrarFrecuencias(linea));
               ans.Append('\n');
            }

            Console.WriteLine(ans.ToString().TrimEnd('\n'));


            Console.ReadLine();
        }
    }
}