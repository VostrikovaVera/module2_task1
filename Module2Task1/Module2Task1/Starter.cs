using System;
using System.IO;

namespace Module2Task1
{
    public class Starter
    {
        private readonly int _minRandomAction = 0;
        private readonly int _maxRandomAction = 3;
        private readonly Random _random = new Random();
        private readonly Actions actions = new Actions();
        private readonly Logger logger = Logger.Instance;

        public void Run()
        {

            for (var i = 0; i < 100; i++)
            {
                var actionResult = new Result();
                var actionNumber = _random.Next(_minRandomAction, _maxRandomAction);

                switch (actionNumber)
                {
                    case 0:
                        actionResult = actions.InfoAction();
                        break;
                    case 1:
                        actionResult = actions.WarningAction();
                        break;
                    case 2:
                        actionResult = actions.ErrorAction();
                        break;
                };

                if (!actionResult.Status)
                {
                    var logMessage = $"Action failed by a reason: {actionResult.ErrMessage}";
                    logger.LogEvent(LogTypes.Error, logMessage);
                }
            }

            File.WriteAllText("log.txt", logger.GeneralLog.ToString());
        }
    }
}