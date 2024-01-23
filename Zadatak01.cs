using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadatak01
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
               double a = 2.5;
               double b = 1.8;
               double c = 3.2;
               double d = 4.7;

               double x = (Math.Pow(a, 2) + Math.Pow(b, 2) + Math.Pow(c, 2) + Math.Pow(d, 2)) / (Math.Pow(a + b, 2) + Math.Pow(c + d, 2));

               Console.WriteLine("Rezultat izraza je: " + x);

               Console.ReadLine();
        }
    }
}
