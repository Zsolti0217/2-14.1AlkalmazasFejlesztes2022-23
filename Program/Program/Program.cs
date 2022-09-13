using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        //Állítsunk elő véletlenszerűen 40 egész számot
        //a [-100,100]-ból és írjuk ki a képernyőre egymás mellé!
        //A kiírás végén adjuk meg hány darab pozitív szám van! 

        {
            Random random = new Random();

            for (int i = 0; i <= 40; i++)
            {
                Console.WriteLine($"{random.Next(-100,100)}");
            }
            Console.ReadKey();
            
            

           
        }
    }
}
