using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sikidom2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Síkidom> síkidoms = new List<Síkidom>();
            síkidoms.Add(new Kor(2.5, "Kör"));
            síkidoms.Add(new Kor(5.1 ,"Kör"));
            síkidoms.Add(new Negyzet(2.5, "Négyzet"));
            síkidoms.Add(new Negyzet(4.1, "Négyzet"));
           

            foreach(Síkidom item in síkidoms)
            {
                string tipus = "";
                if (item.GetType().Equals(typeof(Kor)))
                {
                    Kor kor = (Kor)item;
                    tipus = "Kör";
                    Console.WriteLine($"{tipus}\t kerület: {item.Kerulet():N2}, \tterület: {item.Terulet()} \tsugara: {kor.Sugar():N2}");
                }
                else if (item.GetType().Equals(typeof(Negyzet)))
                {
                    tipus = "Négyzet";
                    Console.WriteLine($"{tipus}\t kerület: {item.Kerulet():N2}, \tterület: {item.Terulet()} \tsugara: {Negyzet.Oldal():N2}");
                }
            }

            Console.WriteLine("\n Program vége");
            Console.ReadKey();
        }
    }
}
