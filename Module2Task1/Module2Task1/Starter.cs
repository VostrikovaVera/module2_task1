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
        private Result actionResult;

        public void Run()
        {
            var logger = Logger.getInstance();

            for (int i = 0; i < 100; i++)
            {
                var actionNumber = _random.Next(_minRandomAction, _maxRandomAction);

                switch (actionNumber)
                {
                    case (int)ActionTypes.InfoAction:
                        actionResult = actions.InfoAction();
                        break;
                    case (int)ActionTypes.WarningAction:
                        actionResult = actions.WarningAction();
                        break;
                    case (int)ActionTypes.ErrorAction:
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