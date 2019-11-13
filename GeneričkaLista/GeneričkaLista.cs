using System;
using System.Collections.Generic;

namespace Vsite.CSharp.VrijednosniReferentniTip
{
    class GeneričkaLista
    {
        public struct VrijednTip
        {
            public int X;
        }

        static void Main(string[] args)
        {
            List<VrijednTip> lista = new List<VrijednTip>();
            VrijednTip vt = new VrijednTip();
            for (int i = 0; i < 10; ++i)
            {
                vt.X = i;
                lista.Add(vt);
            }

            Ispis(lista);

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey();
        }

        public static void Ispis(List<VrijednTip> lista)
        {
            // TODO:030 Dodati petlju koja će ispisati član X za svaki element kolekcije lista.

            // TODO:031 Prevesti kod i usporediti dobiveni IL kod s kodom iz projekta Otpakiravanje.

        }
    }
}
