using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2019_09_20
{
    class Szemely
    {
        public String nev { get; set; }
        public int szulEv { get; set; }

        //konstruktor
        public Szemely(String aNev, int aSzulEv)
        {
            nev = aNev;
            szulEv = aSzulEv;
        }

        //metodus
        public int eletkor()
        {
            return DateTime.Now.Year - szulEv;
        }

    }
}
