using NUnit.Framework;
using TestWithNUnitCP;

namespace MyProject.Test
{
    [TestFixture]
    public sealed class CalculatorTest3
    {
        private Calculator _calculator;

        [SetUp]
        public void Setup()
        {
            _calculator = new Calculator();
        }

        [TestCaseSource(typeof(CalculatorTest3TestCaseDataFactory), "TestCases")]
        public void CalculatorTestMethod(int firstNumber, int secondNumer, int expectedResult)
        {
            var result = _calculator.Divide(firstNumber, secondNumer);
            Assert.AreEqual(expectedResult, result,"A meaning description to help if test crashes");
        }
    }
}