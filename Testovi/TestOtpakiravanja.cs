using System;
using System.Collections;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Vsite.CSharp.VrijednosniReferentniTip.Testovi
{
    [TestClass]
    public class TestOtpakiravanja : ConsoleTest
    {
        ArrayList brojevi = new ArrayList { 1, 5, 10 };

        [TestMethod]
        public void IspišiCastObjectUShort()
        {
            Otpakiravanje.IspišiCastObjectUShort(brojevi);
            Assert.AreEqual(2, cw.Count);
            Assert.AreEqual("Pokušavamo članove tipa object pretvoriti u short", cw.GetString());
            Assert.AreEqual("Specified cast is not valid.", cw.GetString());
        }

        [TestMethod]
        public void IspišiCastObjectUIntPaUShort()
        {
            Otpakiravanje.IspišiCastObjectUIntPaUShort(brojevi);
            Assert.AreEqual(4, cw.Count);
            Assert.AreEqual("Pokušavamo članove pretvoriti prvo int pa u u short", cw.GetString());
            Assert.AreEqual(1, cw.GetInt());
            Assert.AreEqual(5, cw.GetInt());
            Assert.AreEqual(10, cw.GetInt());
        }
    }
}
