

using UnitTesting.core.Features;
using static UnitTesting.core.Features.NumberHelper;

namespace UnitTesting.MsTest
{
    [TestClass]
    public class NumberHelperTest
    {

        private NumberHelper _numberHelper;
        [TestInitialize]
        // Used to avoid code duplication in test methods
        public void Setup()
        {
            _numberHelper = new NumberHelper(); // Arrange is happening here if we neglect value intialization in below code
        }

        [TestCleanup]
        // Used to clean up resources after each test method
        public void Cleanup()
        {
            _numberHelper = null;
        }

        //[TestMethod]
        //public void IsEven_NumberIsEven_ReturnsTrue()
        //{
        //    // Arrange
        //    int number = 4;
        //    // Act
        //    bool result = _numberHelper.IsEven(number);
        //    // Assert
        //    Assert.IsTrue(result);
        //}

        //[TestMethod]
        //public void IsOdd_NumberIsOdd_ReturnsTrue()
        //{
        //    // Arrange
        //    int number = 5;
        //    // Act
        //    bool result = _numberHelper.IsOdd(number);
        //    // Assert
        //    Assert.IsTrue(result);
        //}

        [TestMethod]
        [DataRow(2, NumberType.Even)]
        [DataRow(4, NumberType.Even)]
        [DataRow(5, NumberType.Odd)]
        [DataRow(7, NumberType.Odd)]
        public void GetNumberType_ValidInput_ReturnsCorrectType(int input, NumberType expected)
        {
            // Act
            var result = _numberHelper.GetNumberType(input);

            // Assert
            Assert.AreEqual(expected, result);
        }
    }
}
