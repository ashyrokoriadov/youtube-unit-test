using NUnit.Framework;
using System;

namespace CalculatorLibrary.Tests.CalcWithLoggers
{
    public class CalculatorWithDbLoggingTest_Bad
    {
        private ICalculator _systemUnderTests;

        [SetUp]
        public void Setup()
        {
            _systemUnderTests = new CalculatorWithDbLogging_Bad();
        }

        [Test]
        [Ignore("This test fails always.")]
        public void GIVEN_Calculator_WHEN_Add_method_is_invoked_THEN_correct_value_is_returned()
        {
            var actual = _systemUnderTests.Add(2, 3);
            Assert.AreEqual(5, actual);
        }

        [Test]
        [Ignore("This test fails always.")]
        public void GIVEN_Calculator_WHEN_Subtract_method_is_invoked_THEN_correct_value_is_returned()
        {
            var actual = _systemUnderTests.Subtract(2, 3);
            Assert.AreEqual(-1, actual);
        }

        [Test]
        [Ignore("This test fails always.")]
        public void GIVEN_Calculator_WHEN_Multiply_method_is_invoked_THEN_correct_value_is_returned()
        {
            var actual = _systemUnderTests.Multiply(2, 3);
            Assert.AreEqual(6, actual);
        }

        [Test]
        [Ignore("This test fails always.")]
        public void GIVEN_Calculator_WHEN_Divide_method_is_invoked_THEN_correct_value_is_returned()
        {
            var actual = _systemUnderTests.Divide(4, 2);
            Assert.AreEqual(2, actual);
        }

        [Test]
        [Ignore("This test fails always.")]
        public void GIVEN_Calculator_WHEN_Divide_method_with_zero_divider_is_invoked_THEN_exception_is_thrown()
        {
            Assert.Throws<DivideByZeroException>(() => { _systemUnderTests.Divide(4, 0); });
        }
    }
}
