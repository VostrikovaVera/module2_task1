using System;
using System.Text;

namespace Module2Task1
{
    public class Logger
    {
        private static readonly Logger _instance = new Logger();

        static Logger()
        {
        }

        public static Logger Instance
        {
            get
            {
                return _instance;
            }
        }

        public StringBuilder GeneralLog { get; }

        public Logger ()
        {
            GeneralLog = new StringBuilder();
        }

        public void LogEvent(string status, string message)
        {
            var logItem = $"{DateTime.UtcNow}: {status}: {message}";
            Console.WriteLine(logItem);
            GeneralLog.AppendLine(logItem);
        }
    }
}
