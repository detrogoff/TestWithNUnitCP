using NUnit.Framework;
using TestWithNUnitCP;

namespace MyProject.Test
{
    [TestFixture]
    public sealed class CalculatorTest4
    {
        private Calculator _calculator;

        [SetUp]
        public void Setup()
        {
            _calculator = new Calculator();
        }

        [TestCaseSource(typeof(CalculatorTestCaseData4), "GetTestCases")]
        public void CalculatorTestMethod(CalculatorTestCaseData4 testCase)
        {
            int result = _calculator.Divide(testCase.FirstNumber, testCase.SecondNumber);
            Assert.AreEqual(testCase.ExpectedResult, result);
        }
    }
}