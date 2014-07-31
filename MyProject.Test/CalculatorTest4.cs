using NUnit.Framework;

namespace TestedProject.Test
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

        [TestCaseSource(typeof(CalculatorTestCaseDataFactory4), "GetTestCases")]
        public void CalculatorTestMethod(CalculatorTestCaseData testCase)
        {
            int result = _calculator.Divide(testCase.FirstNumber, testCase.SecondNumber);
            Assert.AreEqual(testCase.ExpectedResult, result);
        }
    }
}