using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sikidom2
{
    class Negyzet : Síkidom
    {
        double oldal;

        public double Oldal { get => oldal; set => oldal = value; }

        public Negyzet(double oldal,string tipus) :base(tipus)
        {
            Oldal = oldal;
            
        }

        public override double Kerulet()
        {
            return oldal * 4;
        }

        public override double Terulet()
        {
            return oldal * oldal;
        }
    }
}
