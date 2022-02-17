using CalculatorLibrary.Loggers;
using CalculatorLibrary.Tests.Mocks.Moq;
using NUnit.Framework;
using System;

namespace CalculatorLibrary.Tests.CalcWithLoggers
{
    class CalculatorWithDbLoggingTest_Moq_Ok_Version2
    {
        private ICalculator _systemUnderTests;
        private ICalculator _calculator;
        private ILogger _logger;

        [SetUp]
        public void Setup()
        {
            _calculator = CalculatorMoqFactory.Order();
            _logger = LoggerMoqFactory.Order();
            _systemUnderTests = new CalculatorWithDbLogging_Ok(_logger, _calculator);
        }

        [TestCase(2, 3, 5)]
        public void GIVEN_Calculator_WHEN_Add_method_is_invoked_THEN_correct_value_is_returned(
            decimal a,
            decimal b,
            decimal expected
            )
        {
            var actual = _systemUnderTests.Add(a, b);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(4, 3, 1)]
        public void GIVEN_Calculator_WHEN_Subtract_method_is_invoked_THEN_correct_value_is_returned(
            decimal a,
            decimal b,
            decimal expected
            )
        {
            var actual = _systemUnderTests.Subtract(a, b);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(2, 3, 6)]
        public void GIVEN_Calculator_WHEN_Multiply_method_is_invoked_THEN_correct_value_is_returned(
            decimal a,
            decimal b,
            decimal expected
            )
        {
            var actual = _systemUnderTests.Multiply(a, b);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(6, 3, 2)]
        public void GIVEN_Calculator_WHEN_Divide_method_is_invoked_THEN_correct_value_is_returned(
            decimal a,
            decimal b,
            decimal expected
            )
        {
            var actual = _systemUnderTests.Divide(a, b);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(6, 0)]
        public void GIVEN_Calculator_WHEN_Divide_method_with_zero_divider_is_invoked_THEN_exception_is_thrown(
            decimal a,
            decimal b
            )
        {
            Assert.Throws<DivideByZeroException>(() => { _systemUnderTests.Divide(a, b); });
        }
    }
}
