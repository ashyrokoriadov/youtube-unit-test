using CalculatorLibrary.Loggers;

namespace CalculatorLibrary
{
    public class CalculatorWithDbLogging_Bad : ICalculator
    {
        private readonly DbLogger _logger = new DbLogger();
        private readonly ICalculator _calculator = new Calculator();

        public decimal Add(decimal a, decimal b)
        {
            _logger.Log("Add operation.");
            return _calculator.Add(a, b);
        }

        public decimal Divide(decimal a, decimal b)
        {
            _logger.Log("Divide operation.");
            return _calculator.Divide(a, b);
        }

        public decimal Multiply(decimal a, decimal b)
        {
            _logger.Log("Multiply operation.");
            return _calculator.Multiply(a, b);
        }

        public decimal Subtract(decimal a, decimal b)
        {
            _logger.Log("Subtract operation.");
            return _calculator.Subtract(a, b);
        }
    }
}
