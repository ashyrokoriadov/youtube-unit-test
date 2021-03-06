using CalculatorLibrary.Loggers;
using CalculatorLibrary.Tests.Mocks.Own;
using NUnit.Framework;
using System;

namespace CalculatorLibrary.Tests.CalcWithLoggers
{
    public class CalculatorWithDbLoggingTest_OwnMock_Ok
    {
        private ICalculator _systemUnderTests;
        private ICalculator _calculator;
        private ILogger _logger;

        [SetUp]
        public void Setup()
        {
            _calculator = new CalculatorOwnMock();
            _logger = new LoggerOwnMock();
            _systemUnderTests = new CalculatorWithDbLogging_Ok(_logger, _calculator);
        }

        [Test]
        public void GIVEN_Calculator_WHEN_Add_method_is_invoked_THEN_correct_value_is_returned()
        {
            var actual = _systemUnderTests.Add(2, 3);
            Assert.AreEqual(0, actual);
        }

        [Test]
        public void GIVEN_Calculator_WHEN_Subtract_method_is_invoked_THEN_correct_value_is_returned()
        {
            var actual = _systemUnderTests.Subtract(2, 3);
            Assert.AreEqual(0, actual);
        }

        [Test]
        public void GIVEN_Calculator_WHEN_Multiply_method_is_invoked_THEN_correct_value_is_returned()
        {
            var actual = _systemUnderTests.Multiply(2, 3);
            Assert.AreEqual(0, actual);
        }

        [Test]
        public void GIVEN_Calculator_WHEN_Divide_method_is_invoked_THEN_correct_value_is_returned()
        {
            var actual = _systemUnderTests.Divide(4, 2);
            Assert.AreEqual(0, actual);
        }

        [Test]
        public void GIVEN_Calculator_WHEN_Divide_method_with_zero_divider_is_invoked_THEN_exception_is_thrown()
        {
            Assert.Throws<DivideByZeroException>(() => { _systemUnderTests.Divide(4, 0); });
        }
    }
}
