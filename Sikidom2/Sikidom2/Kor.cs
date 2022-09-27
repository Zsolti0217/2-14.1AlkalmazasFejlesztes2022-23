using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sikidom2
{
    class Kor : Síkidom
    {
        double sugar;

        public Kor(double sugar, string tipus) :base(tipus)
        {
            this.sugar = sugar;
        }

        public override double Kerulet()
        {
            return 2 * sugar * Math.PI;
        }

        public override double Terulet()
        {
            return sugar * sugar * Math.PI;
        }
        
    }
}
