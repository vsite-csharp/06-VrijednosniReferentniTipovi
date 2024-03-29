﻿using System.Collections;

namespace Vsite.CSharp.VrijednosniReferentniTip
{
    class Otpakiravanje
    {
        public static void IspišiDirektnoKaoShort(ArrayList lista)
        {
            try
            {
                Console.WriteLine("Pokušavamo članove u foreach tretirati kao short");
                foreach (short s in lista)
                {
                    // TODO:050 Dodati naredbu za ispis člana s. Postaviti prekidnu točku (breakpoint) na početak metode, pokrenuti program i provjeriti izvođenje.

                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public static void IspišiCastObjectUShort(ArrayList lista)
        {
            try
            {
                Console.WriteLine("Pokušavamo članove tipa object pretvoriti u short");
                foreach (object o in lista)
                {
                    // TODO:051 Napraviti eksplicitnu pretvorbu člana o u tip short te dodati naredbu za ispis. 
                    // TODO:052Postaviti prekidnu točku (breakpoint) na početak metode, pokrenuti program i provjeriti izvođenje

                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public static void IspišiCastObjectUIntPaUShort(ArrayList lista)
        {
            try
            {
                Console.WriteLine("Pokušavamo članove pretvoriti prvo int pa u u short");
                foreach (object o in lista)
                {
                    // TODO:053 Napratiti eksplicitnu pretvorbu člana o u int, a potom u tip short te dodati naredbu za ispis. Pokrenuti program i provjeriti ispis.

                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        // TODO:054 Pokrenuti testove i provjeriti prolaze li oba testa u grupi TestOtpakiravanja.

        static void Main(string[] args)
        {
            // ArrayList rukuje s kolekcijom članova tipa object (ne zna ništa o konkretnom tipu)
            ArrayList lista = new ArrayList();
            for (int i = 0; i < 10; ++i)
            {
                lista.Add(i);  // pakira vrijednosni tip int i dodaje referencu na njega u listu
            }

            IspišiDirektnoKaoShort(lista);
            Console.WriteLine();

            IspišiCastObjectUShort(lista);
            Console.WriteLine();

            IspišiCastObjectUIntPaUShort(lista);
            Console.WriteLine();

            Console.WriteLine("GOTOVO!!!");
        }

    }
}
