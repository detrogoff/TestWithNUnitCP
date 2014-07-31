using System;
using System.Collections;
using NUnit.Framework;

namespace TestedProject.Test
{
    public class CalculatorTestCaseDataFactory5
    {
        private static readonly TestCaseDataFactory<CalculatorTestCaseData> TestCaseDataFactory = new TestCaseDataFactory<CalculatorTestCaseData>();

        public IEnumerable GetTestCases
        {
            get
            {
                yield return OneDividedByOne();
                yield return TwoDividedByOne();
                yield return OneDividedByZero().Throws(typeof(DivideByZeroException));
            }
        }

        private TestCaseData OneDividedByOne()
        {
            var calculatorTCD = new CalculatorTestCaseData
            {
                FirstNumber = 1,
                SecondNumber = 1,
                ExpectedResult = 1
            };
            return TestCaseDataFactory.Get(calculatorTCD);
        }

        private TestCaseData TwoDividedByOne()
        {
            var calculatorTCD = new CalculatorTestCaseData
            {
                FirstNumber = 2,
                SecondNumber = 1,
                ExpectedResult = 2
            };
            return TestCaseDataFactory.Get(calculatorTCD);
        }

        private TestCaseData OneDividedByZero()
        {
            var calculatorTCD = new CalculatorTestCaseData
            {
                FirstNumber = 1,
                SecondNumber = 0
            };
            return TestCaseDataFactory.Get(calculatorTCD);
        }
    }
}