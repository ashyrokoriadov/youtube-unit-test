using System;

namespace CalculatorLibrary.Tests.Mocks.Own
{
    class CalculatorOwnMock : ICalculator
    {
        public decimal Add(decimal a, decimal b) => 0;

        public decimal Subtract(decimal a, decimal b) => 0;

        public decimal Multiply(decimal a, decimal b) => 0;

        public decimal Divide(decimal a, decimal b)
        {
            if (b == 0)
                throw new DivideByZeroException();
            return 0;
        }
    }
}
