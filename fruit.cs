using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormCRUD
{
    class fruit
    {
        string nev;
        int ar;
        int db;
        DateTime beszerzes;

        public string Nev { get => nev; set => nev = value; }
        public int Ar { get => ar; set => ar = value; }
        public int Db { get => db; set => db = value; }
        public DateTime Beszerzes { get => beszerzes; set => beszerzes = value; }

        public fruit(string nev, int ar, int db, DateTime beszerzes)
        {
            Nev = nev;
            Ar = ar;
            Db = db;
            Beszerzes = beszerzes;
        }
        public override string ToString()
        {
            return $"{nev} ({db}db)";
        }
    }
}
