using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACm.BLTest
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            // -- Arrange
            Customer customer = new Customer
            {
                FirstName = "Ola",
                LastName = "Tobi"
            };
            string expected = "Ola, Tobi";

            // -- Act
            string actual = customer.FullName;

            // -- Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void Fullname()
        {
            // -- Arrange
            Customer customer = new Customer
            {
                LastName = "Tobi"
            };
            string expected = "Tobi";

            // -- Act
            string actual = customer.FullName;

            // -- Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void Fullname1()
        {
            // -- Arrange
            Customer customer = new Customer
            {
                LastName = "Ola"
            };
            string expected = "Ola";

            // -- Act
            string actual = customer.FullName;

            // -- Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void InstanceCount()
        {
            // -- Arrange
            Customer customer = new Customer();
            customer.FirstName = "Davis";
            Customer.InstanceCount += 1;

            Customer c1 = new Customer();
            c1.FirstName = "Davis";
            Customer.InstanceCount += 1;

            Customer c2 = new Customer();
            c2.FirstName = "Davis";
            Customer.InstanceCount += 1;

            // -- Act

            // -- Assert
            Assert.AreEqual(3, Customer.InstanceCount);
        }

        [TestMethod]
        public void Validate()
        {
            // -- Arrange
            var cust = new Customer
            {
                LastName = "Baggy",
                Email = "hfgdkhfgkh@test.com"
            };

            var expected = true;

            // -- Act
            var actual = cust.Validate();

            // -- Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
