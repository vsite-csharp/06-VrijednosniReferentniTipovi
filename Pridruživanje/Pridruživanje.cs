using System;

namespace Vsite.CSharp.VrijednosniReferentniTip
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


            VrijednTip vt2 = new VrijednTip();
            vt2 = vt1;
            Console.WriteLine(vt1.X);
            Console.WriteLine(vt2.X);

            Console.WriteLine($"Pridružujemo vt1.X={drugaVrijednost}:");
            vt1.X = drugaVrijednost;

            Console.WriteLine(vt1.X);
            Console.WriteLine(vt2.X);
        }

        public static void PridruživanjeKlasa(int prvaVrijednost, int drugaVrijednost)
        {
            RefTip rt1 = new RefTip();
            rt1.X = prvaVrijednost;

            RefTip rt2 = new RefTip();
            rt2 = rt1;

            Console.WriteLine(rt1.X);
            Console.WriteLine(rt2.X);

            Console.WriteLine($"Pridružujemo rt1.X={drugaVrijednost}:");
            rt1.X = drugaVrijednost;

            Console.WriteLine(rt1.X);
            Console.WriteLine(rt2.X);
        }

        public static void PridruživanjeNovogObjektaČlanuPreslikaneStukture(int prvaVrijednost, int drugaVrijednost)
        {
            VrijednTip vt1 = new VrijednTip();
            vt1.X = prvaVrijednost;
            vt1.Rt = new RefTip();
            vt1.Rt.X = prvaVrijednost;

            VrijednTip vt2 = new VrijednTip();
            vt2 = vt1;

            Console.WriteLine(vt1.Rt.X);
            Console.WriteLine(vt2.Rt.X);

            Console.WriteLine($"Pridružujemo vt1.Rt.X={drugaVrijednost}:");
            vt1.Rt.X = drugaVrijednost;

            Console.WriteLine(vt1.Rt.X);
            Console.WriteLine(vt2.Rt.X);

            Console.WriteLine($"Članu vt1.Rt pridružujemo novi objekt i zadajemo da je vt1.Rt.X={prvaVrijednost}:");

            vt1.Rt = new RefTip();
            vt1.Rt.X = prvaVrijednost;
            Console.WriteLine(vt1.Rt.X);
            Console.WriteLine(vt2.Rt.X);

        }


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
            Console.ReadKey(true);
        }
    }
}
