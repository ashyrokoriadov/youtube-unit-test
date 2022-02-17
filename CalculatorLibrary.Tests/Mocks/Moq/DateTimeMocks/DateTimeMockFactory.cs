using CalculatorLibrary.DateTimeExample.Good;
using Moq;
using System;

namespace CalculatorLibrary.Tests.Mocks.Moq.DateTimeMocks
{
    static class DateTimeMockFactory
    {
        public static IDateTimeProvider OrderWithDateBeforeThreshold()
        {
            var mock = new Mock<IDateTimeProvider>();
            mock.Setup(m => m.CurrentDateTime).Returns(new DateTime(2022, 6, 1));
            return mock.Object;
        }

        public static IDateTimeProvider OrderWithDateAfterThreshold()
        {
            var mock = new Mock<IDateTimeProvider>();
            mock.Setup(m => m.CurrentDateTime).Returns(new DateTime(2022, 6, 2));
            return mock.Object;
        }
    }
}
