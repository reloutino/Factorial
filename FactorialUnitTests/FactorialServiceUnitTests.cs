using System;
using Factorial;
using FactorialComputationLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;

namespace FactorialUnitTests
{
    [TestClass]
    public class FactorialServiceUnitTests
    {
        FactorialService _factorialService;
        IFactorialComputationService _mockedFactorialComputationService;

        [TestInitialize]
        public void TestInit()
        {
            _mockedFactorialComputationService = Substitute.For<IFactorialComputationService>();
            _factorialService = new FactorialService(_mockedFactorialComputationService);
        }

        [TestMethod]
        public void TestForAnInteger()
        {
            //Arrange
            var input = "5";
            _mockedFactorialComputationService.GetFactorial(Arg.Any<int>()).Returns(120);
            //Act
            var result = _factorialService.Process(input);
            _mockedFactorialComputationService.Received().GetFactorial(Arg.Any<int>());
            //Assert
            Assert.AreEqual(120, result);
        }


        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void TestForNotAnInteger()
        {
            //Arrange
            var input = "abc";
            //Act
            var result = _factorialService.Process(input);
            //Assert
        }
    }
}
