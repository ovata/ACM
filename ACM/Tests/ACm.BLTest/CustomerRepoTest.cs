using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace ACm.BLTest
{
    [TestClass]
    public class CustomerRepoTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            // -- Arrange
            var custRepo = new CustomerRepo();
            var expected = new Customer(1)
            {
                Email = "test@test.com",
                FirstName = "Biola",
                LastName = "Ade"
            };

            // -- Act
            var actual = custRepo.Retrieve(1);

            // -- Assert
            Assert.AreEqual(expected.CustomerId, actual.CustomerId);
            Assert.AreEqual(expected.Email, actual.Email);
            Assert.AreEqual(expected.FirstName, actual.FirstName);
            Assert.AreEqual(expected.LastName, actual.LastName);
        }

        [TestMethod]
        public void TestMethod2()
        {
            // -- Arrange
            var custRepo = new CustomerRepo();
            var expected = new Customer(1)
            {
                Email = "test@test.com",
                FirstName = "Biola",
                LastName = "Ade",
                AddressList = new List<Address>()
                {
                    new Address()
                    {
                        AddressType = 1,
                        StreetLine1 = "Victoria Ave",
                        StreetLine2 = "Flour Road",
                        City = "Houston",
                        State = "Texas",
                        Country = "USA",
                        PostalCode = "243"
                    },

                    new Address()
                    {
                        AddressType = 2,
                        StreetLine1 = "Mike Street",
                        StreetLine2 = "Wilton Road",
                        City = "Atlanta",
                        State = "Goergia",
                        Country = "USA",
                        PostalCode = "874"
                    }
                }
            };

            // -- Act
            var actual = custRepo.Retrieve(1);

            // -- Assert
            Assert.AreEqual(expected.CustomerId, actual.CustomerId);
            Assert.AreEqual(expected.Email, actual.Email);
            Assert.AreEqual(expected.FirstName, actual.FirstName);
            Assert.AreEqual(expected.LastName, actual.LastName);

            for (int i = 0; i < 1; i++)
            {
                Assert.AreEqual(expected.AddressList[i].AddressType, actual.AddressList[i].AddressType);
                Assert.AreEqual(expected.AddressList[i].StreetLine1, actual.AddressList[i].StreetLine1);
                Assert.AreEqual(expected.AddressList[i].StreetLine2, actual.AddressList[i].StreetLine2);
                Assert.AreEqual(expected.AddressList[i].City, actual.AddressList[i].City);
                Assert.AreEqual(expected.AddressList[i].State, actual.AddressList[i].State);
                Assert.AreEqual(expected.AddressList[i].Country, actual.AddressList[i].Country);
                Assert.AreEqual(expected.AddressList[i].PostalCode, actual.AddressList[i].PostalCode);
            }
        }
    }
}