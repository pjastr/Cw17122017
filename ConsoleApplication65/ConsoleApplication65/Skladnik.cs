using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication65
{
    class Skladnik:IComparable<Skladnik>
    {
        protected string nazwaSkladnika;
        protected double cenaSkladnika;

        public Skladnik(string nazwaSkladnika, double cenaSkladnika)
        {
            if (cenaSkladnika < 0) throw new Exception();
            this.nazwaSkladnika = nazwaSkladnika;
            this.cenaSkladnika = cenaSkladnika;
        }

        public override string ToString()
        {
            return String.Format("Składnik: {0}, cena: {1}", nazwaSkladnika,cenaSkladnika);
        }

        public double PobierzCene()
        {
            return cenaSkladnika;
        }

        public int CompareTo(Skladnik other)
        {
            return other.cenaSkladnika.CompareTo(this.cenaSkladnika);
        }
    }
}
