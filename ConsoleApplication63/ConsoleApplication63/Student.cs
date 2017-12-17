using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication63
{
    class Student:Osoba
    {
        int indeks;

        public Student(string imie, string nazwisko, int indeks)
            :base(imie, nazwisko)
        {
            this.indeks = indeks;
        }

        public override string ToString()
        {
            return base.ToString()+", indeks: "+indeks;
        }
    }
}
