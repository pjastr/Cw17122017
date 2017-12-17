using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication65
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Skladnik> pizza = new List<Skladnik>();
            pizza.Add(new Skladnik("ser", 1.7));
            pizza.Add(new Skladnik("szynka", 2.3));
            pizza.Add(new Skladnik("dff", 5.1));
            pizza.Add(new Skladnik("ttt", 4.2));
            pizza.Add(new Skladnik("rrr", 1.2));
            pizza.Add(new Sos("pomidorowy", 3.1));
            foreach(var element in pizza)
            {
                Console.WriteLine(element);
            }

            //polecenie3a 
            pizza.Sort();

            //polecenie 3b
            Console.WriteLine("3b");
            for (int i = 0; i < pizza.Count;i++ )
            {
                if (i % 2 == 0) Console.WriteLine(pizza[i]);
            }

            //polcenie 3c
            pizza.Reverse();

            //polecenie 4
            try
            {
                Skladnik skladnik1 = new Skladnik("ssss", -3);
            }
            catch
            {
                Console.WriteLine("Cena nie może być ujemna");
            }

            //polecenie 7

            Queue<Zamowienie> zamowienia = new Queue<Zamowienie>();
            NaMiejscu nm1 = new NaMiejscu();
            nm1.UstawCzasDostawy("jutro");
            NaMiejscu nm2 = new NaMiejscu();
            nm2.UstawCzasDostawy("dziś");
            NaWynos nm3 = new NaWynos();
            nm3.UstawCzasDostawy("rano");
            NaMiejscu nm4 = new NaMiejscu();
            nm4.UstawCzasDostawy("20:00");
            NaWynos nm5 = new NaWynos();
            nm5.UstawCzasDostawy("wieczorem");
            zamowienia.Enqueue(nm1);
            zamowienia.Enqueue(nm2);
            zamowienia.Enqueue(nm3);
            zamowienia.Enqueue(nm4);
            zamowienia.Enqueue(nm5);
            //polecenie 7d
            foreach(var element in zamowienia)
            {
                Console.WriteLine(element.PoprawnyCzas());
            }
            while(zamowienia.Count >0)
            {
                zamowienia.Dequeue();
            }
            
            //polcenie 8d
            Pizza pizza1 = new Pizza();
            pizza1.DodajDoPrzepisu("ssss");
            pizza1.DodajDoPrzepisu("wweer");
            pizza1.Wypisz();
            Piec.NastawCzas(34);


                Console.ReadKey();
        }
    }
}
