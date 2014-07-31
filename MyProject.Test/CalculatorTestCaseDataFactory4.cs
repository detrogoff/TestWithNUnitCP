using System;
using System.Collections;
using NUnit.Framework;

namespace TestedProject.Test
{
    public class CalculatorTestCaseDataFactory4
    {
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

        private CalculatorTestCaseData OneDividedByOne()
        {
            return new CalculatorTestCaseData
                {
                    FirstNumber = 1,
                    SecondNumber = 1,
                    ExpectedResult = 1
                };
        }

        private CalculatorTestCaseData TwoDividedByOne()
        {
            return new CalculatorTestCaseData
                {
                    FirstNumber = 2,
                    SecondNumber = 1,
                    ExpectedResult = 2
                };
        }

        private CalculatorTestCaseData OneDividedByZero()
        {
            return new CalculatorTestCaseData
                {
                    FirstNumber = 1,
                    SecondNumber = 0
                };
        }
    }
}