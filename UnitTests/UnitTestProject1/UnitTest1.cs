using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTests;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Program objPro = new Program();
            int actual = objPro.AddIntegers(2, 3);
            int i = 0;
            var temp = 2 / i;
            Assert.IsTrue(actual == 6);
        }
    }
}
