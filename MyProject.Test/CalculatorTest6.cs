using NUnit.Framework;

namespace TestedProject.Test
{
    [TestFixture(CalculatorType.Standard)]
    [TestFixture(CalculatorType.Slow)]
    public sealed class CalculatorTest6
    {
        private ICalculator _calculator;
        private readonly CalculatorType _calculatorType;
        private readonly CalculatorFactory _calculatorFactory;

        public CalculatorTest6(CalculatorType calculatorType)
        {
            _calculatorType = calculatorType;
            _calculatorFactory = new CalculatorFactory();
        }

        [SetUp]
        public void Setup()
        {
            _calculator = _calculatorFactory.Get(_calculatorType);
        }

        [TestCaseSource(typeof(CalculatorTestCaseDataFactory5), "GetTestCases")]
        public void CalculatorTestMethod(CalculatorTestCaseData testCase)
        {
            int result = _calculator.Divide(testCase.FirstNumber, testCase.SecondNumber);
            Assert.AreEqual(testCase.ExpectedResult, result);
        }
    }
}