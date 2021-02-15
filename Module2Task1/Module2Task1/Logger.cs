using System;
using System.Text;

namespace Module2Task1
{
    class Logger
    {
        private static Logger instance;
        public StringBuilder GeneralLog { get; }

        public Logger ()
        {
            GeneralLog = new StringBuilder(0);
        }

        public static Logger getInstance()
        {
            if (instance == null)
                instance = new Logger();
            return instance;
        }

        public void LogEvent(LogTypes status, string message)
        {
            var logItem = $"{DateTime.UtcNow}: {status}: {message}";
            Console.WriteLine(logItem);
            GeneralLog.Append(logItem + "\n");
        }
    }
}
