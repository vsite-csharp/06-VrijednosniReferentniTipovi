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

    // Dodati definiciju strukture IzvedenaStruktura koja nasljeđuje strukturu BaznaStruktura. Provjeriti što prevoditelj javlja.
    //struct IzvedenaStruktura : /*BaznaStruktura*/ //: IDisposable
    //{
    //    //public void Dispose()
    //    //{
    //    //    throw new NotImplementedException();
    //    //}
    //}


    class BaznaKlasa
    {
        public BaznaKlasa(int x)
        {
            X = x;
        }
        public readonly int X;
    }

    // Dodati definiciju klase IzvedenaKlasa koja nasljeđuje klasu BaznaKlasa. Provjeriti što prevoditelj javlja.
    class IzvedenaKlasa : BaznaKlasa
    {
        public IzvedenaKlasa(int x) : base(x)
        {

        }
    }
    // Ispraviti pogrešku (dodati konstruktor u IzvedenaKlasa) tako da prevoditelj ne prijavljuje pogrešku.

    internal class Nasljeđivanje
    {
        public static void NasljeđivanjeKlase(int x)
        {
            // Inicijalizirati objekt tipa "IzvedenaKlasa" i proslijediti konstruktoru x.
            IzvedenaKlasa ik = new IzvedenaKlasa(x);

            // Dodati naredbu za ispis vrijednosti člana "X" na konzolu.
            Console.WriteLine(ik.X);

            // Pokrenuti testove i provjeriti prolaze li testovi u grupi "TestNasljeđivanja".
        }

        static void Main(string[] args)
        {
            NasljeđivanjeKlase(3);
            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey();
        }
    }
}
