using System;
using System.Diagnostics;

namespace Vsite.CSharp.VrijednosniReferentniTip
{
    struct MojaStruktura
    {
        public MojaStruktura(int a)
        {
            A = a;
        }

        public readonly int A;
    }

    class MojaKlasa
    {
        public MojaKlasa(int a)
        {
            A = a;
        }

        public readonly int A;
    }

    class UtjecajGCa
    {
        static void Main(string[] args)
        {
            // Pogledati što kod radi, pokrenuti program i analizirati ispisana vremena.
            const int brojElemenata = 1000000;

            // stvaramo objekte i pokrećemo metode da bi JIT preveo u strojni kod prije korištenja
            Stopwatch sw = new Stopwatch();
            sw.Restart();
            sw.Stop();

            MojaStruktura s = new MojaStruktura(0);
            MojaKlasa k = new MojaKlasa(0);

            GC.Collect();
            GC.WaitForPendingFinalizers();

            // ********************************************************
            // 1. instanciramo strukture
            sw.Restart();

            for (int i = 0; i < brojElemenata; ++i)
            {
                MojaStruktura ms = new MojaStruktura(i);
            }

            GC.Collect();
            GC.WaitForPendingFinalizers();

            sw.Stop();
            Console.WriteLine($"Strukutre:          {sw.ElapsedTicks}");

            // ********************************************************
            // 2. instanciramo klase
            sw.Restart();

            for (int i = 0; i < brojElemenata; ++i)
            {
                MojaKlasa mk = new MojaKlasa(i);
            }

            GC.Collect();
            GC.WaitForPendingFinalizers();

            sw.Stop();
            Console.WriteLine($"Klase:              {sw.ElapsedTicks}");

            // ********************************************************
            // 3. ponovno instanciramo strukture
            sw.Restart();

            for (int i = 0; i < brojElemenata; ++i)
            {
                MojaStruktura ms = new MojaStruktura(i);
            }

            GC.Collect();
            GC.WaitForPendingFinalizers();

            sw.Stop();
            Console.WriteLine($"Strukutre:          {sw.ElapsedTicks}");

            // ********************************************************
            // 4. ponovno instanciramo klase, ali sada ne računamo vrijeme za GC
            sw.Restart();

            for (int i = 0; i < brojElemenata; ++i)
            {
                MojaKlasa mk = new MojaKlasa(i);
            }

            sw.Stop();
            Console.WriteLine($"Klase (bez GC):     {sw.ElapsedTicks}");

            // ********************************************************
            // mjerimo samo GC
            sw.Restart();

            GC.Collect();
            GC.WaitForPendingFinalizers();

            sw.Stop();
            Console.WriteLine($"GC:                 {sw.ElapsedTicks}");

            // ********************************************************
            // 5. ponovno instanciramo strukture
            sw.Restart();

            for (int i = 0; i < brojElemenata; ++i)
            {
                MojaStruktura ms = new MojaStruktura(i);
                int n = ms.A;
            }

            sw.Stop();
            Console.WriteLine($"Strukutre (bez GC): {sw.ElapsedTicks}");

            // ********************************************************
            // mjerimo samo GC
            sw.Restart();

            GC.Collect();
            GC.WaitForPendingFinalizers();

            sw.Stop();
            Console.WriteLine($"GC:                 {sw.ElapsedTicks}");

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey();
        }
    }
}
