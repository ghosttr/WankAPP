using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WankAPP;

namespace WankAPPTests
{
    [TestClass]
    public class WankTests
    {
        [TestMethod]
        public void TestFap()
        {
            Wank wank = new Wank();
            Assert.AreEqual("8====MM=D", wank.Fap());
            Assert.AreEqual("8===MM==D", wank.Fap());
            Assert.AreEqual("8==MM===D", wank.Fap());
            Assert.AreEqual("8=MM====D", wank.Fap());
            Assert.AreEqual("8==MM===D", wank.Fap());
            Assert.AreEqual("8===MM==D", wank.Fap());
        }
    }
}
