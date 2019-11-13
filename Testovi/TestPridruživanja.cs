using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Vsite.CSharp;

namespace Vsite.CSharp.VrijednosniReferentniTip.Testovi
{
    [TestClass]
    public class TestPridruživanja : ConsoleTest
    {
        [TestMethod]
        public void PridruživanjeStrukturaRadiDubokuKopiju()
        {
            Pridruživanje.PridruživanjeStruktura(1, 5);
            Assert.AreEqual(1, cw.GetInt());
            Assert.AreEqual(1, cw.GetInt());

            cw.GetString();

            Assert.AreEqual(5, cw.GetInt());
            Assert.AreEqual(1, cw.GetInt());
        }

        [TestMethod]
        public void PridruživanjeKlasaRadiPlitkuKopiju()
        {
            Pridruživanje.PridruživanjeKlasa(1, 5);
            Assert.AreEqual(1, cw.GetInt());
            Assert.AreEqual(1, cw.GetInt());

            cw.GetString();

            Assert.AreEqual(5, cw.GetInt());
            Assert.AreEqual(5, cw.GetInt());
        }

        [TestMethod]
        public void PridruživanjeNovogObjektaReferentnomČlanuStvaraDubokuKopiju()
        {
            Pridruživanje.PridruživanjeNovogObjektaČlanuPreslikaneStukture(1, 5);
            Assert.AreEqual(1, cw.GetInt());
            Assert.AreEqual(1, cw.GetInt());

            cw.GetString();

            Assert.AreEqual(5, cw.GetInt());
            Assert.AreEqual(5, cw.GetInt());

            cw.GetString();

            Assert.AreEqual(1, cw.GetInt());
            Assert.AreEqual(5, cw.GetInt());
        }
    }
}
