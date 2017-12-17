using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication63
{
    class Przychodnia
    {
        Queue<Osoba> kolejka = new Queue<Osoba>();

        public void DodajPacjenta(string imie, string nazwisko)
        {
            Osoba tempOsoba = new Osoba(imie, nazwisko);
            kolejka.Enqueue(tempOsoba);
        }

        public void Wizyta()
        {
            Console.WriteLine("Wizyta: {0}",kolejka.Dequeue());
        }

        public int RozmiarKolejki()
        {
            return kolejka.Count;
        }


        public Queue<Osoba> PobierzKolejke()
        {
            return kolejka;
        }



    }
}
