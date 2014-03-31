using System;
using NUnit.Framework;
using TestWithNUnitCP;

namespace MyProject.Test
{
    [TestFixture]
    public sealed class CalculatorTest2
    {
        [SetUp]
        public void Setup()
        {
            _calculator = new Calculator();
        }

        private Calculator _calculator;

        [TestCase(1, 1, ExpectedResult = 1, TestName = "OneDividedByOne")]
        [TestCase(2, 1, ExpectedResult = 2, TestName = "TwoDividedByOne")]
        [TestCase(1, 0, ExpectedResult = 0, ExpectedException = typeof (DivideByZeroException), TestName = "OneDividedByZero")]
        public int CalculatorTestMethod(int firstNumber, int secondNumer)
        {
            return _calculator.Divide(firstNumber, secondNumer);
        }
    }
}