using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication63
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] tab1 = new int[5];
            //int[] tab2 = { 4, 5, 6, 0, 7 };
            //int[] tab3 = tab2;
            ////tab2[7] = 10;
            ////Array.Sort(tab2);
            ////Array.Resize(ref tab2, 3);
            //Array.Reverse(tab2);
            //foreach(var el in tab2)
            //{
            //    Console.WriteLine(el);
            //}

            //for (int i = 0; i < tab2.Length;i++ )
            //{
            //    Console.WriteLine(tab2[i]);
            //}
            //    //Console.ReadKey();

            //// polecenie3 - druga czesc
            //    Osoba[,] osoby = new Osoba[2, 3];
            //    osoby[1, 1] = new Osoba("Jan", "kowalski");

            //    Osoba os1 = new Osoba("Anna", "Nowak");
            //    osoby[0, 2] = os1;

            //    osoby[0, 1] = new Student("Krzysztof", "Słoneczny", 12345);

            //Przychodnia przychodnia = new Przychodnia();
            //przychodnia.DodajPacjenta("Jan", "Nowak");
            //przychodnia.DodajPacjenta("Anna", "Nowaczyk");
            //przychodnia.DodajPacjenta("Zenon", "Zimowy");
            ////for(int i=0; i<przychodnia.RozmiarKolejki(); i++)
            ////{
            ////    przychodnia[i].
            ////}
            
            //while(przychodnia.RozmiarKolejki()>0)
            //{
            //    przychodnia.Wizyta();
            //}

            //Stack<int> liczby = new Stack<int>();
            //liczby.Push(4);
            //liczby.Push(-4);
            //liczby.Push(344);
            //liczby.Push(-76);
            //foreach(var element in liczby)
            //{
            //    Console.WriteLine(element);
            //}

            //ArrayList listaN = new ArrayList();
            //listaN.Add(55);
            //listaN.Add(55.3);
            //listaN.Add(55.2);
            ////listaN.Add("sdssd");
            ////listaN.Add(new Student("Jan", "Kowalski",23445));
            ////listaN.Sort();
            //Console.WriteLine(listaN[1]);

            KsiazkaTelefoniczna ks1 = new KsiazkaTelefoniczna();
            ks1.DodajDoKsiazki(895260888, "Jan", "Kowalski");
            ks1.DodajDoKsiazki(512345555, "Anna", "Kowalska");
            ks1.DodajDoKsiazki(678654444, "Krzysztof", "Nowak");
        }
    }
}
