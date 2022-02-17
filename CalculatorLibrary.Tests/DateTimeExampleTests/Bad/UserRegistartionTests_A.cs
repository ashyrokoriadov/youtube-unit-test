using AutoFixture;
using CalculatorLibrary.DateTimeExample;
using CalculatorLibrary.DateTimeExample.Bad;
using NUnit.Framework;

namespace CalculatorLibrary.Tests.DateTimeExampleTests.Bad
{
    public class UserRegistartionTests_A
    {
        private static Fixture _fixture = new Fixture();

        private IRegistration _systemUnderTests;
        private string _userName;

        [SetUp]
        public void Setup()
        {
            _systemUnderTests = new UserRegistration_A();
            _userName = _fixture.Create<string>();
        }

        [Test]
        public void GIVEN_UserRegistration_WHEN_Register_method_is_invoked_before_threshold_THEN_true_is_returned()
        {
            var actual = _systemUnderTests.Register(_userName);
            Assert.IsTrue(actual);
        }
    }
}
