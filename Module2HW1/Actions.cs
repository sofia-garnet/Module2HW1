namespace Module2HW1
{
    public class Actions
    {
        private readonly Logger _logger = Logger.Instance;

        public Result Start()
        {
            const bool status = true;
            const string message = "Start method: " + nameof(Start);
            _logger.Log(LogType.Info, message);
            var result = new Result(status, message);
            return result;
        }

        public Result Skip()
        {
            const bool status = true;
            const string message = "Skipped logic in method: " + nameof(Skip);
            _logger.Log(LogType.Warning, message);
            var result = new Result(status, message);
            return result;
        }

        public Result BreakLogic()
        {
            const bool status = false;
            const string message = "I broke a logic.";
            var result = new Result(status, message);
            return result;
        }
    }
}