using System;

namespace CalculatorLibrary.Loggers
{
    public class DbLogger : ILogger
    {
        public void Log(string logMessage) => LogMessageToDb(logMessage);

        private void LogMessageToDb(string logMessage)
        {
            throw new Exception("No connection could me made to a database.");
        }
    }
}
