using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication65
{
    class Sos:Skladnik
    {
        public Sos(string nazwaSosu, double cenaSosu)
            :base(nazwaSosu, cenaSosu)
        {
            
        }

        public override string ToString()
        {
            return String.Format("Sos: {0}, cena: {1}", nazwaSkladnika, cenaSkladnika);
        }
    }
}
