using System;

namespace CalculatorLibrary.DateTimeExample.Good
{
    public class DateTimeProvider : IDateTimeProvider
    {
        public DateTime CurrentDateTime => DateTime.UtcNow;
    }
}
