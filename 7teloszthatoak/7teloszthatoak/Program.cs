using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7teloszthatoak
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine( "Add meg az első számot");
            int szam1, szam2;
            int hibak1 = 0, hibak2 = 1;

            do
            {
                if (hibak1 > 0)
                { Console.WriteLine("Helyesen add meg az adatokat! Csak egész szám értelmezhető!\nPróbád újra"); }
                hibak1++;
            } while (!int.TryParse(Console.ReadLine(), out szam1));
            Console.WriteLine("Add meg a  második számot!");
            do
            {
                if (hibak2 > 0)
                { Console.WriteLine("Helyesen add meg az adatokat! Csak egész szám értelmezhető!\nPróbád újra"); }
                hibak2++;
            } while (!int.TryParse(Console.ReadLine(), out szam2));

            if(szam1 < szam2)
            {
                int x = szam1;
                szam1 = szam2;
                szam2 = x;
            }

        int[] szamsor = new int[szam1 - szam2 + 1];
        for (int i = 0; i < szamsor.Length; i++)
        {
            szamsor[i] = szam2;
            szam2++;
        }

        Console.WriteLine("Héttel osztható számok: ");

            foreach (var item in szamsor)
            {
                if (item % 7 == 0)
                {
                    Console.WriteLine(item);
                }
            }
            Console.ReadKey();



        }
    }
}
