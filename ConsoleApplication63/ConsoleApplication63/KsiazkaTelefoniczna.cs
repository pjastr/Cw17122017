using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication63
{
    class KsiazkaTelefoniczna
    {
        Dictionary<int, Osoba> numery = new Dictionary<int, Osoba>();

        public void DodajDoKsiazki(int numer, string imie, string nazwisko)
        {
            Osoba temp2 = new Osoba(imie, nazwisko);
            numery.Add(numer, temp2);
        }
    }
}
