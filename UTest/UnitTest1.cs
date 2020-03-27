using Microsoft.VisualStudio.TestTools.UnitTesting;
using PrimesChecker;

namespace UTest
{
    [TestClass]
    public class UnitTest1
    {
        [DataTestMethod]
        [DataRow(2, false)]
        [DataRow(3, true)]
        [DataRow(100, false)]
        [DataRow(21478314, false)]
        [DataRow(1942979, true)]
        public void PrimeTestTrue(int val, bool result)
        {
            var service = new PrimeService();
            Assert.AreEqual(service.IsPrime(val), result);
        }
    }
}
