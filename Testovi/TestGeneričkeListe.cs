using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Vsite.CSharp.VrijednosniReferentniTip.Testovi
{
    [TestClass]
    public class TestGeneričkeListe : ConsoleTest
    {
        [TestMethod]
        public void TestIspisa()
        {
            List<GeneričkaLista.VrijednTip> lista = new List<GeneričkaLista.VrijednTip>();
            GeneričkaLista.VrijednTip vt = new GeneričkaLista.VrijednTip();
            for (int i = 0; i < 10; i += 3)
            {
                vt.X = i;
                lista.Add(vt);
            }

            GeneričkaLista.Ispis(lista);
            Assert.AreEqual(4, cw.Count);
            Assert.AreEqual(0, cw.GetInt());
            Assert.AreEqual(3, cw.GetInt());
            Assert.AreEqual(6, cw.GetInt());
            Assert.AreEqual(9, cw.GetInt());
        }
    }
}
