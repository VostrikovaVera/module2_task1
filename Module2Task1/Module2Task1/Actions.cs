namespace Module2Task1
{
    class Actions
    {
        private readonly Logger _logger = Logger.getInstance();
        private readonly Result _result = new Result();

        public Result InfoAction()
        {
            var logMessage = $"Start method: {nameof(InfoAction)}";
            _logger.LogEvent(LogTypes.Info, logMessage);

            _result.Status = true;
            return _result;
        }

        public Result WarningAction()
        {
            var logMessage = $"Skipped logic in method: {nameof(WarningAction)}";
            _logger.LogEvent(LogTypes.Warning, logMessage);

            _result.Status = true;
            return _result;
        }

        public Result ErrorAction()
        {
            _result.Status = false;
            _result.ErrMessage = "I broke a logic.";
            return _result;
        }
    }
}
