using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Egyezoszamjegyek
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] szamsor = new double[2];
            double szam1, szam2;

            do
            {
                Console.WriteLine("Adj meg egy számot");
                szam1 = double.Parse(Console.ReadLine());
                szamsor[0] = szam1;

                Console.WriteLine("Adj meg még egy számot");
                szam2 = double.Parse(Console.ReadLine());
                szamsor[1] = szam2;

            } while (szamsor[0] != szamsor[1] );

            Console.WriteLine("Utolsó két szám megegyezik!");

            foreach (var index in szamsor)
            {
                Console.WriteLine(index);
            }

            Console.ReadKey();
        }
    }
}
