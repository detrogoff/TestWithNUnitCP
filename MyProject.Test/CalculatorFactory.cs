using System;

namespace TestedProject.Test
{
    public class CalculatorFactory
    {
        public ICalculator Get(CalculatorType calculatorType)
        {
            switch (calculatorType)
            {
                case CalculatorType.Standard: return new Calculator();
                case CalculatorType.Slow: return new SlowCalculator();
            }

            string message = String.Format("No implementation matching for type {0}. Please add it", calculatorType);
            throw new ArgumentException(message);
        }
    }
}