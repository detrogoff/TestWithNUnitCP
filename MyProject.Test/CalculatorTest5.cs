using NUnit.Framework;
using TestWithNUnitCP;

namespace MyProject.Test
{
[TestFixture]
public sealed class CalculatorTest5
{
    private Calculator _calculator;

    [SetUp]
    public void Setup()
    {
        _calculator = new Calculator();
    }

    [TestCaseSource(typeof(CalculatorTestCaseData5), "GetTestCases")]
    public void CalculatorTestMethod(CalculatorTestCaseData5 testCase)
    {
        int result = _calculator.Divide(testCase.FirstNumber, testCase.SecondNumber);
        Assert.AreEqual(testCase.ExpectedResult, result);
    }
}
}