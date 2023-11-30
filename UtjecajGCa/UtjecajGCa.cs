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
        const int brojElemenata = 1000000;

        public static long[] InicijalizacijaDealokacijaStruktura(int brojPonavljanja)
        {
            var tikovi = new long[brojPonavljanja];
            Stopwatch sw = new Stopwatch();

            for (int n = 0; n < brojPonavljanja; ++n)
            {
                // pokrećemo štopericu
                sw.Restart();

                // instanciramo mnoštvo objekata vrijednosnog tipa (strukture)
                for (int i = 0; i < brojElemenata; ++i)
                {
                    MojaStruktura ms = new MojaStruktura(i);
                }

                // ručno pokrećemo GC
                GC.Collect();

                // GC oslobađa memoriju u zasebnim nitima (threadovima) pa trebamo čekati da svi završe
                GC.WaitForPendingFinalizers();

                // zaustavlajmo štopericu
                sw.Stop();

                // pohranimo izmjereno vrijeme
                tikovi[n] = sw.ElapsedTicks;
            }
            // vraćamo izmjerena vremena
            return tikovi;
        }

        public static long[] InicijalizacijaDealokacijaKlasa(int brojPonavljanja)
        {
            // :030 Ponoviti kod prethodne metode ali za inicijalizaciju objekata tipa MojaKlasa

            var tikovi = new long[brojPonavljanja];
            Stopwatch sw = new Stopwatch();

            for (int n = 0; n < brojPonavljanja; ++n)
            {
                // pokrećemo štopericu
                sw.Restart();

                // instanciramo mnoštvo objekata referentnog tipa (klase)
                for (int i = 0; i < brojElemenata; ++i)
                {
                    MojaKlasa ms = new MojaKlasa(i);
                }

                // ručno pokrećemo GC
                GC.Collect();

                // GC oslobađa memoriju u zasebnim nitima (threadovima) pa trebamo čekati da svi završe
                GC.WaitForPendingFinalizers();

                // zaustavlajmo štopericu
                sw.Stop();

                // pohranimo izmjereno vrijeme
                tikovi[n] = sw.ElapsedTicks;
            }
            // vraćamo izmjerena vremena
            return tikovi;

        }

        public static long[,] InicijalizacijaDealokacijaStrukturaOdvojeno(int brojPonavljanja)
        {
            var tikovi = new long[brojPonavljanja, 2];
            Stopwatch sw = new Stopwatch();

            for (int n = 0; n < brojPonavljanja; ++n)
            {
                // pokrećemo štopericu
                sw.Restart();

                // instanciramo mnoštvo objekata vrijednosnog tipa (strukture)
                for (int i = 0; i < brojElemenata; ++i)
                {
                    MojaStruktura ms = new MojaStruktura(i);
                }

                // zaustavlajmo štopericu
                sw.Stop();

                // dodajemo vrijeme izmjereno za inicijalizaciju
                tikovi[n, 0] = sw.ElapsedTicks;

                // pokrećemo štopericu za mjerenje GC-a
                sw.Restart();

                // ručno pokrećemo GC
                GC.Collect();

                // GC oslobađa memoriju u zasebnim nitima (threadovima) pa trebamo čekati da svi završe
                GC.WaitForPendingFinalizers();

                // zaustavlajmo štopericu
                sw.Stop();

                // pohranimo vrijeme izmjereno za dealokaciju
                tikovi[n, 1] = sw.ElapsedTicks;
            }
            // vraćamo izmjerena vremena
            return tikovi;
        }

        public static long[,] InicijalizacijaDealokacijaKlasaOdvojeno(int brojPonavljanja)
        {
            // :031 Ponoviti kod gornje metode ali za inicijalizaciju objekata tipa MojaKlasa

            // :032 Provjeriti prolaze li svi testovi iz grupe TestUtjecajaGCa
            var tikovi = new long[brojPonavljanja, 2];
            Stopwatch sw = new Stopwatch();

            for (int n = 0; n < brojPonavljanja; ++n)
            {
                // pokrećemo štopericu
                sw.Restart();

                // instanciramo mnoštvo objekata referentnog tipa (klase)
                for (int i = 0; i < brojElemenata; ++i)
                {
                    MojaKlasa ms = new MojaKlasa(i);
                }

                // zaustavlajmo štopericu
                sw.Stop();

                // dodajemo vrijeme izmjereno za inicijalizaciju
                tikovi[n, 0] = sw.ElapsedTicks;

                // pokrećemo štopericu za mjerenje GC-a
                sw.Restart();

                // ručno pokrećemo GC
                GC.Collect();

                // GC oslobađa memoriju u zasebnim nitima (threadovima) pa trebamo čekati da svi završe
                GC.WaitForPendingFinalizers();

                // zaustavlajmo štopericu
                sw.Stop();

                // pohranimo vrijeme izmjereno za dealokaciju
                tikovi[n, 1] = sw.ElapsedTicks;
            }
            // vraćamo izmjerena vremena
            return tikovi;
        }

        static void IspišiRezultate(long[] rezultati)
        {
            foreach (var rezultat in rezultati)
            {
                Console.WriteLine(rezultat);
            }
            Console.WriteLine($"MINIMUM: {rezultati.Min()}");
        }

        static void IspišiRezultate(long[,] rezultati)
        {
            int brojParova = rezultati.GetLength(0);
            long minInicijalizacija = long.MaxValue;
            long minDealokacija = long.MaxValue;
            for (int i = 0; i < brojParova; ++i)
            {
                Console.WriteLine($"{rezultati[i, 0]}  {rezultati[i, 1]}");
                if (rezultati[i, 0] < minInicijalizacija)
                {
                    minInicijalizacija = rezultati[i, 0];
                }
                if (rezultati[i, 1] < minDealokacija)
                {
                    minDealokacija = rezultati[i, 1];
                }
            }
            Console.WriteLine($"MINIMUMI: {minInicijalizacija}  {minDealokacija}");
        }

        static void Main()
        {
            const int brojPonavljanja = 10;

            // **********************************************************************************
            // 0. Prvo pokrećemo metode da bi ih JIT preveo u strojni kod prije stvarnog mjerenja
            InicijalizacijaDealokacijaKlasa(1);
            InicijalizacijaDealokacijaStruktura(1);
            InicijalizacijaDealokacijaKlasaOdvojeno(1);
            InicijalizacijaDealokacijaStrukturaOdvojeno(1);


            // ***********************************************************************
            // 1. Mjerenje vremena potrebnih za inicijalizaciju i dealokaciju objekata
            Console.WriteLine("*** Inicijalizacija i dealokacija klasa ***");
            IspišiRezultate(InicijalizacijaDealokacijaKlasa(brojPonavljanja));

            Console.WriteLine("*** Inicijalizacija i dealokacija struktura ***");
            IspišiRezultate(InicijalizacijaDealokacijaStruktura(brojPonavljanja));

            // ***************************************************************************************
            // 2. Odvojeno mjerenje vremena potrebnih za inicijalizaciju, odnosno dealokaciju objekata
            Console.WriteLine("*** Inicijalizacija i dealokacija struktura - odvojeno mjerenje ***");
            IspišiRezultate(InicijalizacijaDealokacijaStrukturaOdvojeno(brojPonavljanja));

            Console.WriteLine("*** Inicijalizacija i dealokacija klasa - odvojeno mjerenje ***");
            IspišiRezultate(InicijalizacijaDealokacijaKlasaOdvojeno(brojPonavljanja));

            Console.WriteLine("GOTOVO!!!");
        }
    }
}
