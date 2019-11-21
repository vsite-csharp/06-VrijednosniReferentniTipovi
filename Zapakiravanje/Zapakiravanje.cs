using System;
using System.Collections;

namespace Vsite.CSharp.VrijednosniReferentniTip
{
    class RefTip
    {
        public int X;
    }

    struct VrijednTip
    {
        public int X;
    }

    class Zapakiravanje
    {
        public static void DodavanjeKlaseUArrayList()
        {
            // ArrayList rukuje s kolekcijom članova tipa object (ne zna ništa o konkretnom tipu)
            ArrayList lista = new ArrayList();
            RefTip rt = new RefTip();

            for (int i = 0; i < 10; ++i)
            {
                rt.X = i;
                lista.Add(rt);
            }

            //  Dodati petlju koja će za svaki član liste ispisati vrijednost njegovog člana X
            for (int i = 0; i < 10; ++i)
            {
                RefTip r=(RefTip)lista[i];
                Console.WriteLine(r.X);          //isti podatak u listi jer je ref
            }

        }

        public static void DodavanjeStruktureUArrayList()
        {
            ArrayList lista = new ArrayList();
            VrijednTip vt = new VrijednTip();

            for (int i = 0; i < 10; ++i)
            {
                vt.X = i;
                lista.Add(vt);
            }

            // Dodati petlju koja će za svaki član liste ispisati vrijednost njegovog člana X
            for (int i = 0; i < 10; ++i)
            {
                VrijednTip v = (VrijednTip)lista[i];
                Console.WriteLine(v.X);            //RAZLIČITI PODATCI U LISTI
            }
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Dodavanje klase");
            DodavanjeKlaseUArrayList();

            Console.WriteLine("Dodavanje strukture");
            DodavanjeStruktureUArrayList();

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey();
        }
    }
}
