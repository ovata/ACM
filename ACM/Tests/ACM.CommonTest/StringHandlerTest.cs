using ACM.COMMON;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.CommonTest
{
    [TestClass]
    public class StringHandlerTest
    {
        [TestMethod]
        public void InsertSpace()
        {
            //Arrange
            var source = "SonicPolystarBuilding";
            var expected = "Sonic Polystar Building";

            //Act
            var actual = source.InsertSpaces();

            //Assert
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void InsertedSpace()
        {
            //Arrange
            var source = "Sonic Polystar Building";
            var expected = "Sonic Polystar Building";

            //Act
            var actual = source.InsertSpaces();

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
