using System;
using System.Collections;
using NUnit.Framework;

namespace MyProject.Test
{
    public class CalculatorTestCaseData4
    {
        public int FirstNumber { get; private set; }
        public int SecondNumber { get; private set; }
        public int ExpectedResult { get; private set; }

        public IEnumerable GetTestCases
        {
            get
            {
                yield return new TestCaseData(OneDividedByOne()).SetName("OneDividedByOne");
                yield return new TestCaseData(TwoDividedByOne()).SetName("TwoDividedByOne");
                yield return new TestCaseData(OneDividedByZero())
                    .Throws(typeof(DivideByZeroException))
                    .SetName("OneDividedByZero");
            }
        }

        private CalculatorTestCaseData4 OneDividedByOne()
        {
            return new CalculatorTestCaseData4
                {
                    FirstNumber = 1,
                    SecondNumber = 1,
                    ExpectedResult = 1
                };
        }

        private CalculatorTestCaseData4 TwoDividedByOne()
        {
            return new CalculatorTestCaseData4
                {
                    FirstNumber = 2,
                    SecondNumber = 1,
                    ExpectedResult = 2
                };
        }

        private CalculatorTestCaseData4 OneDividedByZero()
        {
            return new CalculatorTestCaseData4
                {
                    FirstNumber = 1,
                    SecondNumber = 0
                };
        }
    }
}