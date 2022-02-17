using System;

namespace CalculatorLibrary.DateTimeExample.Bad
{
    public class UserRegistration_A : IRegistration
    {
        public bool Register(string userName)
        {
            if(DateTime.Now <= new DateTime(2022,6,1))
            {
                //Registration logic
                return true;
            }

            Console.WriteLine($"Unable to register a user {userName}");
            return false;
        }
    }
}
