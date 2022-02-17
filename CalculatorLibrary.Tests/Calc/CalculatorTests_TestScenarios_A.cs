using NUnit.Framework;
using System;

namespace CalculatorLibrary.Tests.Calc
{
    public class CalculatorTests_TestScenarios_A
    {
        private ICalculator _systemUnderTests;

        [SetUp]
        public void Setup()
        {
            _systemUnderTests = new Calculator();
            //_systemUnderTests = new FakeCalculator();
        }

        [TestCase(2, 3, 5)]
        [TestCase(3, 4, 7)]
        [TestCase(4, 5, 9)]
        public void GIVEN_Calculator_WHEN_Add_method_is_invoked_THEN_correct_value_is_returned(
            decimal a, 
            decimal b, 
            decimal expected)
        {
            var actual = _systemUnderTests.Add(a, b);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(4, 3, 1)]
        [TestCase(6, 4, 2)]
        [TestCase(8, 5, 3)]
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
        [TestCase(3, 4, 12)]
        [TestCase(4, 5, 20)]
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
        [TestCase(12, 4, 3)]
        [TestCase(20, 5, 4)]
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
        [TestCase(12, 0)]
        [TestCase(20, 0)]
        public void GIVEN_Calculator_WHEN_Divide_method_with_zero_divider_is_invoked_THEN_exception_is_thrown(
            decimal a,
            decimal b
            )
        {
            Assert.Throws<DivideByZeroException>(() => { _systemUnderTests.Divide(a, b); });
        }
    }
}
