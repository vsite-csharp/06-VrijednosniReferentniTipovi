﻿using System.Collections;

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

            // TODO:040 Dodati petlju koja će za svaki član liste ispisati vrijednost njegovog člana X

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

            // TODO:041 Dodati petlju koja će za svaki član liste ispisati vrijednost njegovog člana X

        }
        // TODO:042 Pokrenuti testove i provjeriti prolaze li oba testa u grupi TestZapakiravanja

        static void Main(string[] args)
        {
            Console.WriteLine("Dodavanje klase");
            DodavanjeKlaseUArrayList();

            Console.WriteLine("Dodavanje strukture");
            DodavanjeStruktureUArrayList();

            Console.WriteLine("GOTOVO!!!");
        }
    }
}
