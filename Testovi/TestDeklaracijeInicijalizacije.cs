using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vsite.CSharp.VrijednosniReferentniTip.Testovi
{
    [TestClass]
    public class TestDeklaracijeInicijalizacije : ConsoleTest
    {
        [TestMethod]
        public void TestVrijednosnogTipa()
        {
            DeklaracijaInicijalizacija.DeklaracijaInicijalizacijaVrijednosnogTipa(7);
            Assert.AreEqual(1, cw.Count);
            Assert.AreEqual(7, cw.GetInt());
        }

        [TestMethod]
        public void TestReferentnogTipa()
        {
            DeklaracijaInicijalizacija.DeklaracijaInicijalizacijaReferentnogTipa(12);
            Assert.AreEqual(1, cw.Count);
            Assert.AreEqual(12, cw.GetInt());
        }
    }
}
