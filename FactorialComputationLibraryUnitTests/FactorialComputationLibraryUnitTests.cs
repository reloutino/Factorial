using System;
using FactorialComputationLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FactorialComputationLibraryUnitTests
{
    [TestClass]
    public class FactorialComputationLibraryUnitTests
    {
        FactorialComputationService _factorialComputationService;
        [TestInitialize]
        public void TestInit()
        {
            _factorialComputationService = new FactorialComputationService();
        }

        [TestMethod]
        public void TestFor0()
        {
            //Arrange
            var input = 0;
            //Act
            var result = _factorialComputationService.GetFactorial(input);
            //Assert
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void TestForAPositiveInteger()
        {
            //Arrange
            var input = 5;
            //Act
            var result = _factorialComputationService.GetFactorial(input);
            //Assert
            Assert.AreEqual(120, result);
        }

        [TestMethod]
        [ExpectedException(typeof(ArithmeticException))]
        public void TestForANegativeInteger()
        {
            //Arrange
            var input = -1;
            //Act
            var result = _factorialComputationService.GetFactorial(input);
            //Assert
        }

        [TestMethod]
        [ExpectedException(typeof(OverflowException))]
        public void TestForOverflows()
        {
            //Arrange
            var input = 99;
            //Act
            var result = _factorialComputationService.GetFactorial(input);
            //Assert
        }
    }
}
