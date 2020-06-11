using ACM.BL;
using ACM.COMMON;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.CommonTest
{
    [TestClass]
    public class LoggingServiceTest
    {
        [TestMethod]
        public void WriteTestToFile()
        {
            //Arrange
            var changedItems = new List<ILoggable>();

            var cust = new Customer(1)
            {
                Email = "test@test.com",
                FirstName = "Vincent",
                LastName = "Elon",
                AddressList = null
            };

            changedItems.Add(cust);

            var prod = new Product(1)
            {
                ProductName = "Durex",
                ProductionDescription = "Latex Condoms",
                CurrentPrice = 20
            };

            changedItems.Add(prod);

            //Act
            LoggingService.WriteToFile(changedItems);

            //Assert

        }
    }
}
