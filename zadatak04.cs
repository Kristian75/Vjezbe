using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadatak04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite cijeli broj i decimalni broj odvojene razmakom:");
            string input = Console.ReadLine();
            string[] numbers = input.Split(' ');

            int x = int.Parse(numbers[0]);
            double y = double.Parse(numbers[1]);

            Console.WriteLine("Uneseni brojevi su:");
            Console.WriteLine("x = " + x);
            Console.WriteLine("y = " + y);

            Console.ReadLine();
        }
    }
}
