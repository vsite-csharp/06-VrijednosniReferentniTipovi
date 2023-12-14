namespace Vsite.CSharp.VrijednosniReferentniTip
{
    // vrijednosni tip zbog 'struct'
    struct VrijednosniTip
    {
        public VrijednosniTip(int x)
        {
            X = x;
        }
        public readonly int X;
    }

    // referentni tip (klasa)
    class ReferentniTip
    {
        public ReferentniTip(int x)
        {
            X = x;
        }
        public readonly int X;
    }

    internal class DeklaracijaInicijalizacija
    {
        public static void DeklaracijaInicijalizacijaVrijednosnogTipa(int x)
        {
            // : Deklarirati (ali ne inicijalizirati) objekt "vt" tipa "VrijednosniTip".
            //VrijednosniTip vt;
            VrijednosniTip vt = new VrijednosniTip(x);
            // :001 Dodati naredbu za ispis na konzolu vrijednosti člana "X". Pogledati što prevoditelj prijavljuje.
            Console.WriteLine(vt.X);
            // :002 Inicijalizirati objekt tako da ne prijavljuje pogrešku. Konstruktoru proslijediti argument "x" metode "DeklaracijaInicijalizacijaVrijednosnogTipa".

            // :003 Pokrenuti program i provjeriti ispis.
        }

        public static void DeklaracijaInicijalizacijaReferentnogTipa(int x)
        {
            // :004 Deklarirati (ali ne inicijalizirati) objekt "rt" tipa "ReferentniTip".
            //ReferentniTip rt;
            // :005 Dodati naredbu za ispis na konzolu vrijednosti člana "X". Pogledati što prevoditelj prijavljuje.
            Console.WriteLine(x);
            // :006 Inicijalizirati objekt null referencom. Pogledati što prevoditelj prijavljuje i pokrenuti program.
            //ReferentniTip rt = null;
            // :007 Inicijalizirati objekt pozivom konstruktora kojem se proslijedi argument "x" metode "DeklaracijaInicijalizacijaReferentnogTipa".
            ReferentniTip rt = new ReferentniTip(x);
            // :008 Pokrenuti program i provjeriti ispis.
            // :009 Pokrenuti testove i provjeriti prolaze li testovi u grupi "TestDeklaracijeInicijalizacije".
        }

        static void Main(string[] args)
        {
            try
            {
                DeklaracijaInicijalizacijaVrijednosnogTipa(3);
                DeklaracijaInicijalizacijaReferentnogTipa(5);
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine($"Objekt nije inicijaliziran, bačena je iznimka tipa 'NullReferenceException': {e.Message}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Bačena je iznimka tipa '{e.GetType()}': {e.Message}");
            }
            Console.WriteLine("GOTOVO!!!");
        }
    }
}