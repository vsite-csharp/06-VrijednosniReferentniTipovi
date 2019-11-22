using System;
using System.Collections;

namespace Vsite.CSharp.VrijednosniReferentniTip
{
    class Otpakiravanje
    {
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
            Console.ReadKey();
        }

        public static void IspišiDirektnoKaoShort(ArrayList lista)
        {
            try
            {
                Console.WriteLine("Pokušavamo članove u foreach tretirati kao short");
                foreach (short s in lista)
                {
                    // TODO:020 Dodati naredbu za ispis člana s. Postaviti prekidnu točku (breakpoint) na početak metode, pokrenuti program i provjeriti izvođenje
                    Console.WriteLine(s);

                    /*ISPIS:  Pokusavamo clanove u foreach tretirati kao short
                                Specified cast is not valid.

                                Pokusavamo clanove tipa object pretvoriti u short

                                Pokusavamo clanove pretvoriti prvo int pa u u short

                                GOTOVO!!!*/
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
                    // TODO:021 Napraviti eksplicitnu pretvorbu člana o u tip short te dodati naredbu za ispis. 
                    // Postaviti prekidnu točku (breakpoint) na početak metode, pokrenuti program i provjeriti izvođenje
                   
                    Console.WriteLine((short)o);

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
                    // TODO:022 Napratiti eksplicitnu pretvorbu člana o u int, a potom u tip short te dodati naredbu za ispis. Pokrenuti program i provjeriti ispis.
                    int obj;
                    obj = (int)o;
                    Console.WriteLine((short)obj);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
