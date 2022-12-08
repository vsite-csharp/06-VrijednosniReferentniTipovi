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

    

    // TODO:010 Dodati definiciju strukture IzvedenaStruktura koja nasljeđuje strukturu BaznaStruktura. Provjeriti što prevoditelj javlja.


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
        public void ispis()
        {
            Console.WriteLine(X);
        }
    }

    // TODO:011 Dodati definiciju klase IzvedenaKlasa koja nasljeđuje klasu BaznaKlasa. Provjeriti što prevoditelj javlja.
    // TODO:012 Ispraviti pogrešku (dodati konstruktor u IzvedenaKlasa) tako da prevoditelj ne prijavljuje pogrešku.

    internal class Nasljeđivanje
    {
        public static void NasljeđivanjeKlase(int x)
        {
            // TODO:013 Inicijalizirati objekt tipa "IzvedenaKlasa" i proslijediti konstruktoru x.
            IzvedenaKlasa izvedenaKlasa = new IzvedenaKlasa(x);
            // TODO:014 Dodati naredbu za ispis vrijednosti člana "X" na konzolu.
            izvedenaKlasa.ispis();

            // TODO:015 Pokrenuti testove i provjeriti prolaze li testovi u grupi "TestNasljeđivanja".
        }

        static void Main(string[] args)
        {
            NasljeđivanjeKlase(3);
            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey();
        }
    }
}
