using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CelsiusFahrenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            double celsius;
            int hibak = 0;
            Console.WriteLine(  "Add meg a Celsius fokot amit Fahrenheitbe fogunk átváltani.");

            do
            {
                if (hibak > 1)
                {
                    Console.WriteLine("Hibás adatot adot meg!");
                }
                hibak++;


            } while (!double.TryParse(Console.ReadLine(), out celsius));

            Console.WriteLine($"Eredmény: {Math.Round(celsius * 1.8000 + 32, 2)} Fahrenheit. ");
            Console.ReadLine();
        }
    }
}
