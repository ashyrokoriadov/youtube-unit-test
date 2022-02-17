using AutoFixture;
using CalculatorLibrary.DateTimeExample;
using CalculatorLibrary.DateTimeExample.Good;
using CalculatorLibrary.Tests.Mocks.Moq.DateTimeMocks;
using NUnit.Framework;

namespace CalculatorLibrary.Tests.DateTimeExampleTests.Good
{
    public class UserRegistartionTests
    {
        private static Fixture _fixture = new Fixture();

        private IRegistration _systemUnderTestsAfterThreshold;
        private IRegistration _systemUnderTestsBeforeThreshold;
        private IDateTimeProvider _dateTimeProviderAfterThreshold;
        private IDateTimeProvider _dateTimeProviderBeforeThreshold;
        private string _userName;

        [SetUp]
        public void Setup()
        {
            _dateTimeProviderAfterThreshold = DateTimeMockFactory.OrderWithDateAfterThreshold();
            _dateTimeProviderBeforeThreshold = DateTimeMockFactory.OrderWithDateBeforeThreshold();

            _systemUnderTestsAfterThreshold = new UserRegistration(_dateTimeProviderAfterThreshold);
            _systemUnderTestsBeforeThreshold = new UserRegistration(_dateTimeProviderBeforeThreshold);

            _userName = _fixture.Create<string>();
        }

        [Test]
        public void GIVEN_UserRegistration_WHEN_Register_method_is_invoked_after_threshold_THEN_false_is_returned()
        {
            var actual = _systemUnderTestsAfterThreshold.Register(_userName);
            Assert.IsFalse(actual);
        }

        [Test]
        public void GIVEN_UserRegistration_WHEN_Register_method_is_invoked_before_threshold_THEN_true_is_returned()
        {
            var actual = _systemUnderTestsBeforeThreshold.Register(_userName);
            Assert.IsTrue(actual);
        }
    }
}
