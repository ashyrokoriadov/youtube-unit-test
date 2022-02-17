using CalculatorLibrary.Loggers;

namespace CalculatorLibrary
{
    public class CalculatorWithDbLogging_Ok : ICalculator
    {
        private readonly ILogger _logger;
        private readonly ICalculator _calculator;

        public CalculatorWithDbLogging_Ok(ILogger logger, ICalculator calculator)
        {
            _logger = logger;
            _calculator = calculator;
        }

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
