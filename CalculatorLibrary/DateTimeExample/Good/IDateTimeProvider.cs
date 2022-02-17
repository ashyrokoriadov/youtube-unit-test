using System;

namespace CalculatorLibrary.DateTimeExample.Good
{
    public interface IDateTimeProvider
    {
        DateTime CurrentDateTime { get; }
    }
}
