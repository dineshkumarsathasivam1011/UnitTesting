using UnitTesting.core.Features;

namespace UnitTesting.MsTest
{

    [TestClass]
    public class AgeValaidationTests
    {

        private AgeValidation _ageValidation;
        [TestInitialize]
        public void Setup()
        {
            _ageValidation = new AgeValidation();
        }

        [TestCleanup]
        public void Cleanup()
        {
            _ageValidation = null;
        }
        //Positive test cases
        [TestMethod]
        public void IsAdult_GivenAge_ReturnsTrue()
        { //Act
            bool result = _ageValidation.IsAdult(20);
            //Assert
            Assert.IsTrue(result, "Expected age 20 to be considered an adult.");

        }
        //Negative test cases

        [TestMethod]
        public void IsAdult_GivenMinorAge_ReturnsFalse()
        { //Act
            bool result = _ageValidation.IsAdult(16);
            //Assert
            Assert.IsFalse(result, "Expected age 16 to not be considered an adult.");
        }
        //Ignorance test cases
        [TestMethod]
        [Ignore("This test is a placeholder for future features.")]
        public void FutureFeature()
        {
                       // This test is ignored and will not run
           // Assert.Inconclusive("This test is a placeholder for future features.");
           Assert.Fail("This test is a placeholder for future features. It should not be run yet.");
        }
    }
}
