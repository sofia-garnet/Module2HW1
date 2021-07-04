using System;
using System.IO;

namespace Module2HW1
{
    public class Starter
    {
        private readonly Logger _logger = Logger.Instance;

        public void Run()
        {
            var action = new Actions();
            Result result = null;
            var random = new Random();
            const int iterationQuantity = 100;
            for (var i = 0; i < iterationQuantity; i++)
            {
                var methodNumber = random.Next(1, 4);
                switch (methodNumber)
                {
                    case 1:
                    {
                        result = action.Start();
                        break;
                    }

                    case 2:
                    {
                        result = action.Skip();
                        break;
                    }

                    case 3:
                    {
                        result = action.BreakLogic();
                        break;
                    }
                }

                if (result == null)
                {
                    const string message = "Result is null";
                    _logger.Log(LogType.Error, message);
                }
                else if (result.Status == false)
                {
                    const string message = "Action failed by a reason:";
                    _logger.Log(LogType.Error, $"{message} {result.ErrorMessage}");
                }
            }

            File.WriteAllText("log.txt", _logger.GetLog());
        }
    }
}