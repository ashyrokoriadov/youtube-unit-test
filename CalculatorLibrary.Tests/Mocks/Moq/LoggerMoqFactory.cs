using CalculatorLibrary.Loggers;
using Moq;

namespace CalculatorLibrary.Tests.Mocks.Moq
{
    static class LoggerMoqFactory
    {
        public static ILogger Order()
        {
            var mock = new Mock<ILogger>();
            mock.Setup(m => m.Log(It.IsAny<string>())).Verifiable();           
            return mock.Object;
        }
    }
}
