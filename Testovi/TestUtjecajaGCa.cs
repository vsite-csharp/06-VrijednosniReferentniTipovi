using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vsite.CSharp.VrijednosniReferentniTip.Testovi
{
    [TestClass]
    public class TestUtjecajaGCa : ConsoleTest
    {
        [TestMethod]
        public void ProvjeriVremenaInicijalizacijaDealokacija()
        {
            var zaStrukture = UtjecajGCa.InicijalizacijaDealokacijaStruktura(5);
            Assert.AreEqual(5, zaStrukture.Length);
            var zaKlase = UtjecajGCa.InicijalizacijaDealokacijaKlasa(5);
            Assert.AreEqual(5, zaKlase.Length);

            Assert.IsTrue(zaStrukture.Min() < zaKlase.Min());
        }
        [TestMethod]
        public void ProvjeriOdvojenaVremenaInicijalizacijaDealokacija()
        {
            var zaStrukture = UtjecajGCa.InicijalizacijaDealokacijaStrukturaOdvojeno(5);
            Assert.AreEqual(10, zaStrukture.Length);
            var zaKlase = UtjecajGCa.InicijalizacijaDealokacijaKlasaOdvojeno(5);
            Assert.AreEqual(10, zaKlase.Length);

            var inicijalizacijeStruktura = Enumerable.Range(0, zaStrukture.GetLength(0))
                      .Select(i => zaStrukture[i, 0]);
            var dealokacijeStruktura = Enumerable.Range(0, zaStrukture.GetLength(0))
                      .Select(i => zaStrukture[i, 1]);
            var inicijalizacijeKlasa = Enumerable.Range(0, zaKlase.GetLength(0))
                      .Select(i => zaKlase[i, 0]);
            var dealokacijeKlasa = Enumerable.Range(0, zaKlase.GetLength(0))
                      .Select(i => zaKlase[i, 1]);

            Assert.IsTrue(dealokacijeStruktura.Min() < inicijalizacijeKlasa.Min());
            Assert.IsTrue(inicijalizacijeKlasa.Min() > dealokacijeKlasa.Min());

            Assert.IsTrue(inicijalizacijeStruktura.Min() < inicijalizacijeKlasa.Min());
            Assert.IsTrue(dealokacijeStruktura.Min() < dealokacijeKlasa.Min());
        }
    }
}
