using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WebApplicationTC.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodSum()
        {
            Common Commonobj = new Common();
            int Sum = Commonobj.Sum(10, 33);
            Assert.AreEqual(43, Sum);
        }
        [TestMethod]
        public void TestMethodSup()
        {
            Common Commonobj = new Common();
            int Sum = Commonobj.Sup(55, 44);
            Assert.AreEqual(11, Sum);
        }
    }
}
