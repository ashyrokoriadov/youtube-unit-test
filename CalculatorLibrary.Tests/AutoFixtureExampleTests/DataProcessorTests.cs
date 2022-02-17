using AutoFixture;
using CalculatorLibrary.AutoFixtureExample;
using NUnit.Framework;

namespace CalculatorLibrary.Tests.AutoFixtureExampleTests
{
    public class DataProcessorTests
    {
        private static Fixture _fixture = new Fixture();
        private DataProcessor _systemUnderTests;
        private DataParameters _dataParameters;

        [SetUp]
        public void Setup()
        {
            _systemUnderTests = new DataProcessor();

            _dataParameters = _fixture
                .Build<DataParameters>()
                .With(dp => dp.Mediana, 10M)
                .Create();
        }

        [Test]
        public void GIVEN_DataProcessor_WHEN_Process_method_is_invoked_THEN_correct_value_is_returned()
        {
            var actual = _systemUnderTests.Process(_dataParameters);
            Assert.IsNotNull(actual);
            Assert.AreEqual(10M, _dataParameters.Mediana);
        }
    }
}
