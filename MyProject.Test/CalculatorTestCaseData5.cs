using System;
using System.Collections;
using NUnit.Framework;

namespace MyProject.Test
{
    public class CalculatorTestCaseData5
    {
        public int FirstNumber { get; private set; }
        public int SecondNumber { get; private set; }
        public int ExpectedResult { get; private set; }

        private static readonly TestCaseDataFactory<CalculatorTestCaseData5> TestCaseDataFactory = new TestCaseDataFactory<CalculatorTestCaseData5>();

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
            var calculatorTCD = new CalculatorTestCaseData5
            {
                FirstNumber = 1,
                SecondNumber = 1,
                ExpectedResult = 1
            };
            return TestCaseDataFactory.Get(calculatorTCD);
        }

        private TestCaseData TwoDividedByOne()
        {
            var calculatorTCD = new CalculatorTestCaseData5
            {
                FirstNumber = 2,
                SecondNumber = 1,
                ExpectedResult = 2
            };
            return TestCaseDataFactory.Get(calculatorTCD);
        }

        private TestCaseData OneDividedByZero()
        {
            var calculatorTCD = new CalculatorTestCaseData5
            {
                FirstNumber = 1,
                SecondNumber = 0
            };
            return TestCaseDataFactory.Get(calculatorTCD);
        }
    }
}