using System;
using NUnit.Framework;
using TestWithNUnitCP;

namespace MyProject.Test
{
    [TestFixture]
    public sealed class CalculatorTest1
    {
        private Calculator _calculator;

        [SetUp]
        public void Setup()
        {
            _calculator = new Calculator();
        }

        [Test]
        public void OneDividedByOne()
        {
            int result = _calculator.Divide(1, 1);
            Assert.AreEqual(1, result);
        }

        [Test]
        public void TwoDividedByOne()
        {
            int result = _calculator.Divide(2, 1);
            Assert.AreEqual(2, result);
        }

        [Test]
        public void OneDividedByZero()
        {
            Assert.Throws<DivideByZeroException>(() => _calculator.Divide(1, 0));
            Console.Write("this is a test");
        }
    }
}