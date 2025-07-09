using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTesting.core.Features;

namespace UnitTesting.MsTest

{
    [TestClass]
   public  class CalculatorTests
    {
        [TestMethod]
        public void Add_TwoNumbers_ReturnsSum()
        {
            // Arrange
            var calculator = new Calculator();
            int a = 5;
            int b = 3;
            // Act
            int result = calculator.Add(a, b);
            // Assert
            Assert.AreEqual(8, result);
        }

        [TestMethod]
        public void Subtract_TwoNumbers_ReturnsDifference()
        {
            // Arrange
            var calculator = new Calculator();
            int a = 5;
            int b = 3;
            // Act
            int result = calculator.Subtract(a, b);
            // Assert
            Assert.AreEqual(2, result);
        }

        //parameterized testing

        [TestMethod]
        [DataRow(1, 1, 2)]
        [DataRow(2 , 2, 4)]
        [DataRow(3, 3, 6)]
        public void Add_Paramaterized_returnSums(int a, int b, int expectedSum)
        {
            // Arrange
            var calculator = new Calculator();
            // Act
            int result = calculator.Add(a, b);
            // Assert
            Assert.AreEqual(expectedSum, result);
        }


    }
}
