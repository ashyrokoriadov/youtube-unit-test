using System;

namespace CalculatorLibrary.DateTimeExample.Good
{
    public class UserRegistration : IRegistration
    {
        private readonly IDateTimeProvider _dateTimeProvider;

        public UserRegistration(IDateTimeProvider dateTimeProvider)
        {
            _dateTimeProvider = dateTimeProvider;
        }

        public bool Register(string userName)
        {
            if (_dateTimeProvider.CurrentDateTime <= new DateTime(2022, 6, 1))
            {
                //Registration logic
                return true;
            }

            Console.WriteLine($"Unable to register a user {userName}");
            return false;
        }
    }
}
