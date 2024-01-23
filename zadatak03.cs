using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadatak03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite rečenicu:");
            string recenica = Console.ReadLine();

            string[] rijeci = recenica.Split(' ');

            string prvaRijec = rijeci[0];
            string zadnjaRijec = rijeci[rijeci.Length - 1];

            Console.WriteLine("\nPrva riječ: " + prvaRijec);
            Console.WriteLine("Zadnja riječ: " + zadnjaRijec);

            Console.ReadLine();
        }
    }
}
