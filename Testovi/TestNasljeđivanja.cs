using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Vsite.CSharp.VrijednosniReferentniTip.Testovi
{
    [TestClass]
    public class TestNasljeđivanja : ConsoleTest
    {
        [TestMethod]
        public void IzvedenaKlasaJeIspravnoDefinirana()
        {
            Type t = typeof(Vsite.CSharp.VrijednosniReferentniTip.BaznaKlasa);
            Assembly? skup = Assembly.GetAssembly(t);
            Assert.IsNotNull(skup);
            var izvedenaKlasa = skup.GetTypes().FirstOrDefault(type => type.BaseType?.ToString() == "Vsite.CSharp.VrijednosniReferentniTip.BaznaKlasa");
            Assert.IsNotNull(izvedenaKlasa);
            var konstruktor = izvedenaKlasa.GetConstructor(new[] { typeof(int) });
            Assert.IsNotNull(konstruktor);
            var instanca = konstruktor?.Invoke(new object[] { 37 });
            var vrijednostPolja = izvedenaKlasa.InvokeMember("X", BindingFlags.GetField, null, instanca, null);
            Assert.AreEqual(37, vrijednostPolja);
        }

        [TestMethod]
        public void NasljeđivanjeKlase()
        {
            Nasljeđivanje.NasljeđivanjeKlase(12);
            Assert.AreEqual(1, cw.Count);
            Assert.AreEqual(12, cw.GetInt());
        }
    }
}
