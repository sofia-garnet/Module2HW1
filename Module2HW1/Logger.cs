using System;
using System.Text;

namespace Module2HW1
{
    public class Logger
    {
        private static readonly Logger _instance;
        private StringBuilder _logStorage;
        static Logger()
        {
            _instance = new Logger();
        }

        private Logger()
        {
            _logStorage = new StringBuilder();
        }

        public static Logger Instance
        {
            get
            {
                return _instance;
            }
        }

        public void Log(LogType logTypeName, string message)
        {
            var logContent = $"{DateTime.Now}: {logTypeName}: {message}: {Environment.NewLine}";
            Console.Write(logContent);
            _logStorage.Append(logContent);
        }

        public string GetLog()
        {
            return _logStorage.ToString();
        }
    }
}