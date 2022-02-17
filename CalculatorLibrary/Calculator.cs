using System;

namespace CalculatorLibrary
{
    public class Calculator : ICalculator
    {
        public decimal Add(decimal a, decimal b) => a + b;

        public decimal Subtract(decimal a, decimal b) => a - b;

        public decimal Multiply(decimal a, decimal b) => a * b;

        public decimal Divide(decimal a, decimal b) => a / b;
    }
}
