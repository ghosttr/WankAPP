using System;
using NUnit.Framework;
using WankAPP;

namespace WankAPPTests
{
    [TestFixture]
    public class WankTests
    {
        [Test]
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
