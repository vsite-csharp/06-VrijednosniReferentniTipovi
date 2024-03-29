﻿namespace Vsite.CSharp.VrijednosniReferentniTip
{
    // vrijednosni tip zbog 'struct'
    struct VrijednTip
    {
        public int X;
        public RefTip Rt;
    }

    // referentni tip (klasa)
    class RefTip
    {
        public int X;
    }

    class Pridruživanje
    {
        public static void PridruživanjeStruktura(int prvaVrijednost, int drugaVrijednost)
        {
            VrijednTip vt1 = new VrijednTip();
            vt1.X = prvaVrijednost;

            // TODO:020 Deklarirati novi objekt "vt2" tipa VrijednTip i pridružiti mu vrijednost objekta "vt1"


            // TODO:021 Dodati naredbe koje će ispisati vrijednosti članova vt1.X, odnosno vt2.X


            Console.WriteLine($"Pridružujemo vt1.X={drugaVrijednost}:");
            vt1.X = drugaVrijednost;

            // TODO:022 Ponoviti naredbe za ispis vrijednosti članova vt1.X, odnosno vt2.X. Pokrenuti program i provjeriti ispis.

        }

        public static void PridruživanjeKlasa(int prvaVrijednost, int drugaVrijednost)
        {
            RefTip rt1 = new RefTip();
            rt1.X = prvaVrijednost;

            // TODO:023 Deklarirati novi objekt "rt2" RefTip i pridružiti mu objekt "rt1".


            // TODO:024 Dodati naredbe koje će ispisati vrijednosti članova rt1.X, odnosno rt2.X.


            Console.WriteLine($"Pridružujemo rt1.X={drugaVrijednost}:");
            rt1.X = drugaVrijednost;

            // TODO:025 Ponoviti naredbe za ispis vrijednosti članova rt1.X, odnosno rt2.X. Pokrenuti program i provjeriti ispis.

        }

        public static void PridruživanjeNovogObjektaČlanuPreslikaneStukture(int prvaVrijednost, int drugaVrijednost)
        {
            VrijednTip vt1 = new VrijednTip();
            vt1.X = prvaVrijednost;
            vt1.Rt = new RefTip();
            vt1.Rt.X = prvaVrijednost;

            // TODO:026 Deklarirati novi objekt "vt2" tipa VrijednTip i pridružiti mu objekt "vt1".


            // TODO:027 Dodati naredbe koje će ispisati vrijednosti članova vt1.Rt.X, odnosno vt2.Rt.X.


            Console.WriteLine($"Pridružujemo vt1.Rt.X={drugaVrijednost}:");
            vt1.Rt.X = drugaVrijednost;

            // TODO:028 Ponoviti naredbe za ispis vrijednosti članova vt1.Rt.X, odnosno vt2.Rt.X. Pokrenuti program i provjeriti ispis.


            Console.WriteLine($"Članu vt1.Rt pridružujemo novi objekt i zadajemo da je vt1.Rt.X={prvaVrijednost}:");

            // TODO:029 Otkomentirati donje naredbe, ponoviti naredbe za ispis vrijednosti članova vt1.Rt.X, odnosno vt2.Rt.X. Pokrenuti program i provjeriti ispis.
            //vt1.Rt = new RefTip();
            //vt1.Rt.X = prvaVrijednost;


        }
        // TODO:029a Pokrenuti testove i provjeriti prolaze li sva 3 testa u grupi TestPridruživanja.

        static void Main(string[] args)
        {
            Console.WriteLine("Pridruživanje vrijednosnih tipova (struktura)");
            PridruživanjeStruktura(1, 5);
            Console.WriteLine();
            Console.WriteLine("Pridruživanje referentnih tipova (klasa)");
            PridruživanjeKlasa(1, 5);
            Console.WriteLine();
            Console.WriteLine("Pridruživanje novog objekta članu preslikane strukture");
            PridruživanjeNovogObjektaČlanuPreslikaneStukture(1, 5);

            Console.WriteLine("GOTOVO!!!");
        }
    }
}
