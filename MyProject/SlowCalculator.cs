using System.Threading;

namespace TestedProject
{
    public class SlowCalculator : ICalculator
    {
        public int Divide(int a, int b)
        {
            //this is a slow calculator
            Thread.Sleep(10);
            return a / b;
        }
    }
}