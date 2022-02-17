using Moq;
using System;

namespace CalculatorLibrary.Tests.Mocks.Moq
{
    static class CalculatorMoqFactory
    {        
        public static ICalculator Order(decimal returnValue)
        {
            var mock = new Mock<ICalculator>();
            mock.Setup(m => m.Add(It.IsAny<decimal>(), It.IsAny<decimal>())).Returns(returnValue);
            mock.Setup(m => m.Subtract(It.IsAny<decimal>(), It.IsAny<decimal>())).Returns(returnValue);
            mock.Setup(m => m.Multiply(It.IsAny<decimal>(), It.IsAny<decimal>())).Returns(returnValue);
            mock.Setup(m => m.Divide(It.IsAny<decimal>(), It.IsAny<decimal>())).Returns(returnValue);
            mock.Setup(m => m.Divide(It.IsAny<decimal>(), 0)).Throws<DivideByZeroException>();
            return mock.Object;
        }

        public static ICalculator Order()
        {
            var mock = new Mock<ICalculator>();
            mock.Setup(m => m.Add(2, 3)).Returns(5);
            mock.Setup(m => m.Subtract(4,3)).Returns(1);
            mock.Setup(m => m.Multiply(2, 3)).Returns(6);
            mock.Setup(m => m.Divide(6, 3)).Returns(2);
            mock.Setup(m => m.Divide(6, 0)).Throws<DivideByZeroException>();
            return mock.Object;
        }
    }

    class CalculatorMock : ICalculator
    {
        public decimal Add(decimal a, decimal b)
        {
            if (a == 2 && b == 3)
                return 5;

            return default(decimal);
        }

        public decimal Divide(decimal a, decimal b)
        {
            if (a == 6 && b == 3)
                return 2;

            if (a == 6 && b == 0)
                throw new DivideByZeroException();

            return default(decimal);
        }

        public decimal Multiply(decimal a, decimal b)
        {
            if (a == 2 && b == 3)
                return 6;

            return default(decimal);
        }

        public decimal Subtract(decimal a, decimal b)
        {
            if (a == 4 && b == 3)
                return 1;

            return default(decimal);
        }
    }
}