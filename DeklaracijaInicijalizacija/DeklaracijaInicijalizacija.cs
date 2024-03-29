﻿namespace Vsite.CSharp.VrijednosniReferentniTip
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
            // TODO:000 Deklarirati (ali ne inicijalizirati) objekt "vt" tipa "VrijednosniTip".

            // TODO:001 Dodati naredbu za ispis na konzolu vrijednosti člana "X". Pogledati što prevoditelj prijavljuje.
            // TODO:002 Inicijalizirati objekt tako da ne prijavljuje pogrešku. Konstruktoru proslijediti argument "x" metode "DeklaracijaInicijalizacijaVrijednosnogTipa".

            // TODO:003 Pokrenuti program i provjeriti ispis.
        }

        public static void DeklaracijaInicijalizacijaReferentnogTipa(int x)
        {
            // TODO:004 Deklarirati (ali ne inicijalizirati) objekt "rt" tipa "ReferentniTip".

            // TODO:005 Dodati naredbu za ispis na konzolu vrijednosti člana "X". Pogledati što prevoditelj prijavljuje.
            // TODO:006 Inicijalizirati objekt null referencom. Pogledati što prevoditelj prijavljuje i pokrenuti program.
            // TODO:007 Inicijalizirati objekt pozivom konstruktora kojem se proslijedi argument "x" metode "DeklaracijaInicijalizacijaReferentnogTipa".

            // TODO:008 Pokrenuti program i provjeriti ispis.
            // TODO:009 Pokrenuti testove i provjeriti prolaze li testovi u grupi "TestDeklaracijeInicijalizacije".
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