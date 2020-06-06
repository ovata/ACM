using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace ACm.BLTest
{
    [TestClass]
    public class ProductRepoTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            // -- Arrange
            var prodRepo = new ProductRepo();
            var expected = new Product(2)
            {
                CurrentPrice = 5.09m,
                ProductName = "Dove",
                ProductionDescription = "Bathing Soap"
            };

            // -- Act
            var actual = prodRepo.Retrieve(2);

            // -- Assert
            Assert.AreEqual(expected.ProductId, actual.ProductId);
            Assert.AreEqual(expected.ProductName, actual.ProductName);
            Assert.AreEqual(expected.ProductionDescription, actual.ProductionDescription);
        }
    }
}
