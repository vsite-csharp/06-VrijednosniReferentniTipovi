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

        public void ispis()
        {
            Console.WriteLine(X);
        }
    }

    // referentni tip (klasa)
    class ReferentniTip
    {
        public ReferentniTip(int x)
        {
            X = x;
        }
        public readonly int X;
        public void ispis() {
            Console.WriteLine(X);
        }
    }

    internal class DeklaracijaInicijalizacija
    {
        public static void DeklaracijaInicijalizacijaVrijednosnogTipa(int x)
        {
            VrijednosniTip vt;
            vt = new VrijednosniTip(x);
            vt.ispis();

        }

        public static void DeklaracijaInicijalizacijaReferentnogTipa(int x)
        {
            ReferentniTip rt;
            rt = new ReferentniTip(x);
            rt.ispis();

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
            Console.ReadKey();
        }
    }
}