using System;
using System.Text;

namespace Module2Task1
{
    public class Logger
    {
        private static readonly Logger _instance = new Logger();
        private readonly StringBuilder _generalLog = new StringBuilder();

        static Logger()
        {
        }

        private Logger()
        {
        }

        public static Logger Instance => _instance;
        public string GeneralLog => _generalLog.ToString();

        public void LogEvent(LogTypes status, string message)
        {
            var logItem = $"{DateTime.UtcNow}: {status}: {message}";
            Console.WriteLine(logItem);
            _generalLog.AppendLine(logItem);
        }
    }
}
