using System;

namespace CalculatorLibrary 
{
    public class FakeCalculator : ICalculator
    {
        public decimal Add(decimal a, decimal b) => 5;

        public decimal Subtract(decimal a, decimal b) => -1;

        public decimal Multiply(decimal a, decimal b) => 6;

        public decimal Divide(decimal a, decimal b) 
        {
            if (b == 0)
                throw new DivideByZeroException();
            return 2;
        }
    }
}
