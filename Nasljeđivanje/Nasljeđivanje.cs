namespace Vsite.CSharp.VrijednosniReferentniTip
{
    struct BaznaStruktura
    {
        public BaznaStruktura(int x)
        {
            X = x;
        }
        public readonly int X;
    }

    // :010 Dodati definiciju strukture IzvedenaStruktura koja nasljeđuje strukturu BaznaStruktura. Provjeriti što prevoditelj javlja.
    // strukture se ne mogu naslijeđivati... vrijednostni tip... ali interface se može napraviti pa naslijediti kao struct
    //struct IzvedenaStruktura : BaznaStruktura
    //{
    //}

    class BaznaKlasa
    {
        public BaznaKlasa(int x)
        {
            X = x;
        }
        public readonly int X;
    }
    class IzvedenaKlasa : BaznaKlasa
    {
        public IzvedenaKlasa(int x) : base(x)
        {
        }
    }

    // :011 Dodati definiciju klase IzvedenaKlasa koja nasljeđuje klasu BaznaKlasa. Provjeriti što prevoditelj javlja.
    // Greška kod naslijeđivanja jer postoji konstruktor s ulaznom varijablom; 
    // :012 Ispraviti pogrešku (dodati konstruktor u IzvedenaKlasa) tako da prevoditelj ne prijavljuje pogrešku.

    internal class Nasljeđivanje
    {
        public static void NasljeđivanjeKlase(int x)
        {
            var izvVar = new IzvedenaKlasa(x);
            // :013 Inicijalizirati objekt tipa "IzvedenaKlasa" i proslijediti konstruktoru x.
            Console.WriteLine(izvVar.X);
            // :014 Dodati naredbu za ispis vrijednosti člana "X" na konzolu.

            // :015 Pokrenuti testove i provjeriti prolaze li testovi u grupi "TestNasljeđivanja".
        }

        static void Main(string[] args)
        {
            NasljeđivanjeKlase(3);
            Console.WriteLine("GOTOVO!!!");
        }
    }
}
