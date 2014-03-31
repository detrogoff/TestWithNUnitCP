using System;
using System.Collections;
using NUnit.Framework;

namespace MyProject.Test
{
    public class CalculatorTest3TestCaseDataFactory
    {
        public static IEnumerable TestCases
        {
            get
            {
                yield return new TestCaseData(1, 1, 1).SetName("OneDividedByOne");
                yield return new TestCaseData(2, 1, 2).SetName("TwoDividedByOne");
                yield return new TestCaseData(1, 0, default(int))
                    .Throws(typeof(DivideByZeroException))
                    .SetName("OneDividedByZero");
            }
        }
    }
}