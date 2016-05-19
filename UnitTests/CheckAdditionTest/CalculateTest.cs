using System;
using UnitTests;
using NUnit.Framework;

namespace CheckAdditionTest
{
    [TestFixture]
    public class CalculateTest
    {
        [Test]
        public void Test_Addition_Positive()
        {
            Program objPro = new Program();
            int actual = objPro.AddIntegers(2, 3);
            Assert.AreEqual(5, actual);
        }
        [Test]
        public void Test_Addition_Negative()
        {
            Program objPro = new Program();
            int actual = objPro.AddIntegers(2, 3);
            Assert.AreEqual(6, actual);
        }
    }
}
