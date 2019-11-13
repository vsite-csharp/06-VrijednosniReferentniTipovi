using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Vsite.CSharp;

namespace Vsite.CSharp.VrijednosniReferentniTip.Testovi
{
    [TestClass]
    public class TestZapakiravanja : ConsoleTest
    {
        [TestMethod]
        public void DodavanjeKlaseUArrayList()
        {
            Zapakiravanje.DodavanjeKlaseUArrayList();
            Assert.AreEqual(10, cw.Count);
            Assert.AreEqual(9, cw.GetInt());
            Assert.AreEqual(9, cw.GetInt());
            Assert.AreEqual(9, cw.GetInt());
            Assert.AreEqual(9, cw.GetInt());
        }

        [TestMethod]
        public void DodavanjeStruktureUArrayList()
        {
            Zapakiravanje.DodavanjeStruktureUArrayList();
            Assert.AreEqual(10, cw.Count);
            Assert.AreEqual(0, cw.GetInt());
            Assert.AreEqual(1, cw.GetInt());
            Assert.AreEqual(2, cw.GetInt());
            Assert.AreEqual(3, cw.GetInt());
        }
    }
}
