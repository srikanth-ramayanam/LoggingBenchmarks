using Microsoft.Extensions.Logging;

namespace Logging_Performance
{
    public class LoggerLogging
    {
        private readonly ILogger _logger;

        public LoggerLogging(ILogger logger) 
        {
            _logger = logger;
        } 

        public void LogInfo() =>
            _logger.LogInformation("Log infomation message with no params");

        public void LogInfo(string value1) =>
            _logger.LogInformation("Log infomation message with one param! {Param1}", value1);

        public void LogInfo(string value1, int value2) =>
            _logger.LogInformation("Log infomation message with two params! {Param1}, {Param2}", value1, value2);

        public void LogDebug() =>
            _logger.LogDebug("Log debug message with No params!");
        public void LogDebug(string value1) =>
            _logger.LogDebug("Log debug message with one param {Param1}", value1);

        public void LogDebug(string value1, int value2) =>
            _logger.LogDebug("Log debug message with two params! {Param1}, {Param2}", value1, value2);

        public void LogWarning() =>
            _logger.LogWarning("Log Warning message with No params!");
        public void LogWarning(string value1) =>
            _logger.LogWarning("Log Warning message with one param {Param1}", value1);

        public void LogWarning(string value1, int value2) =>
            _logger.LogWarning("Log Warning message with two params! {Param1}, {Param2}", value1, value2);
    }
}
