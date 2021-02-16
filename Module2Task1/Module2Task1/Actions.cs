namespace Module2Task1
{
    public class Actions
    {
        private readonly Logger _logger = Logger.Instance;

        public Result InfoAction()
        {
            var logMessage = $"Start method: {nameof(InfoAction)}";
            _logger.LogEvent("Info", logMessage);

            var result = new Result();
            result.Status = true;
            return result;
        }

        public Result WarningAction()
        {
            var logMessage = $"Skipped logic in method: {nameof(WarningAction)}";
            _logger.LogEvent("Warning", logMessage);

            var result = new Result();
            result.Status = true;
            return result;
        }

        public Result ErrorAction()
        {
            var result = new Result();
            result.Status = false;
            result.ErrMessage = "I broke a logic.";
            return result;
        }
    }
}
