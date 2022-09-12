using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4evszak
{
    class Program
    {
        static void Main(string[] args)
        {
            int honapszam, hibasadat = 0;
            string evszak = "";
            int[] honapok = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };

            do
            {
                if (hibasadat > 0)
                {
                    Console.WriteLine("Helyes adatokat írj be! A hónapok száma 1-12 skálán lehet választani!\nÍrd be újra a számot!");
                }
                hibasadat++;
            } while (!int.TryParse(Console.ReadLine(), out honapszam) || honapszam > 12 || honapszam < 1);

            if (honapszam == honapok[0] || honapszam == honapok[1] || honapszam == honapok[11])
            {
                evszak = "Tél";
            }
            else if (honapszam == honapok[2] || honapszam == honapok[3] || honapszam == honapok[4])
            {
                evszak = "Tavasz";
            }
            else if (honapszam == honapok[5] || honapszam == honapok[6] || honapszam == honapok[7])
            {
                evszak = "Nyár";
            }
            else if (honapszam == honapok[8] || honapszam == honapok[9] || honapszam == honapok[10])
            {
                evszak = "Ősz";
            }

            Console.WriteLine($"A megadot adatok alapján az évszak: {evszak}\nBeírt hónap: {honapszam}");
            Console.ReadKey();
        }
    }
}
