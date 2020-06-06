using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ACm.BLTest
{
    [TestClass]
    public class OrderRepoTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            // -- Arrange
            var ordRepo = new OrderRepo();
            var expected = new Order(11)
            {
                OrderDate = new DateTimeOffset(DateTime.Now.Year, 4, 14, 10, 00, 00,
                                                       new TimeSpan(7, 0, 0))
            };

            // -- Act
            var actual = ordRepo.Retrieve(11);

            // -- Assert
            Assert.AreEqual(expected.OrderId, actual.OrderId);
            Assert.AreEqual(expected.OrderDate, actual.OrderDate);
        }
    }
}
