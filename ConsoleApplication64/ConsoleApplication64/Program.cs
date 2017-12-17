using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication64
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Skladnik> pizza = new List<Skladnik>();
            pizza.Add(new Skladnik("sdsdds", 2));
            pizza.Add(new Skladnik("sdd", 2.4));
            pizza.Add(new Skladnik("utt", 3.2));
            pizza.Add(new Skladnik("iukj", 4.1));
            pizza.Add(new Skladnik("err", 5.2));
            pizza.Add(new Sos("opioi", 1.2));
            foreach(var element in pizza)
            {
                Console.WriteLine(element);
            }
            // polcenie 3
            
            pizza.Sort();
            Console.WriteLine("elementy o parzystych indeksach");
            for (int i = 0; i < pizza.Count;i++ )
            {
                if (i % 2 == 0) Console.WriteLine(pizza[i]);
            }
            pizza.Reverse();


            //polecenia 4
            try
            {
                Skladnik skl1 = new Skladnik("ss", -5);
            }
            catch
            {
                Console.WriteLine("Cena nie może być ujemna");
            }

            //polecenie 7
            Queue<Zamowienie> zamowienia = new Queue<Zamowienie>();
            NaWynos nw1 = new NaWynos();
            nw1.UstawCzasDostawy("dd");
            NaWynos nw2 = new NaWynos();
            nw2.UstawCzasDostawy("jutro");
            NaWynos nw3 = new NaWynos();
            nw3.UstawCzasDostawy("hgf");
            NaMiejscu nw4 = new NaMiejscu();
            nw4.UstawCzasDostawy("5555");
            NaMiejscu nw5 = new NaMiejscu();
            nw5.UstawCzasDostawy("ljh");
            zamowienia.Enqueue(nw1);
            zamowienia.Enqueue(nw2);
            zamowienia.Enqueue(nw3);
            zamowienia.Enqueue(nw4);
            zamowienia.Enqueue(nw5);
            foreach(var element in zamowienia)
            {
                Console.WriteLine(element.PoprawnyCzas());
            }
            while( zamowienia.Count >0)
            {
                zamowienia.Dequeue();
            }

                Console.ReadKey();
        }
    }
}
