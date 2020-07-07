using System;
using System.Collections.Generic;
using Microsoft.Extensions.Logging;

namespace Logging_Performance
{
    public class LoggerMessageLogging
    {
        private readonly ILogger _logger;

        public LoggerMessageLogging(ILogger logger)
        {
            _logger = logger;
        }
                
        public void LogInfo() => _logInfo(_logger, null);

        public void LogInfo(string value1) => _logInfo1(_logger, value1, null);

        public void LogInfo(string value1, int value2) => _logInfo2(_logger, value1, value2, null);

        public void LogDebug() => _logDebug(_logger, null);            
        public void LogDebug(string value1) => _logDebug1(_logger, value1, null);

        public void LogDebug(string value1, int value2) => _logDebug2(_logger, value1, value2, null);

        public void LogWarning() => _logWarning(_logger, null);
        public void LogWarning(string value1) => _logWarning1(_logger, value1, null);

        public void LogWarning(string value1, int value2) => _logWarning2(_logger, value1, value2, null);


        private static readonly Action<ILogger, Exception> _logInfo = LoggerMessage.Define(
                LogLevel.Information,
                Events.Started,
                "LoggerMessage infomation with no params");

        private static readonly Action<ILogger, string, Exception> _logInfo1 = LoggerMessage.Define<string>(
                LogLevel.Information,
                Events.Started,
                "LoggerMessage infomation with one param! {Param1}");

        private static readonly Action<ILogger, string, int, Exception> _logInfo2 = LoggerMessage.Define<string, int>(
            LogLevel.Information,
            Events.Started,
            "LoggerMessage infomation with two params! {Param1}, {Param2}");

        private static readonly Action<ILogger, Exception> _logDebug = LoggerMessage.Define(
                LogLevel.Debug,
                Events.Started,
                "LoggerMessage Debug with no params");

        private static readonly Action<ILogger, string, Exception> _logDebug1 = LoggerMessage.Define<string>(
                LogLevel.Debug,
                Events.Started,
                "LoggerMessage Debug with one param! {Param1}");

        private static readonly Action<ILogger, string, int, Exception> _logDebug2 = LoggerMessage.Define<string, int>(
            LogLevel.Debug,
            Events.Started,
            "LoggerMessage Debug with two params! {Param1}, {Param2}");

        private static readonly Action<ILogger, Exception> _logWarning = LoggerMessage.Define(
                LogLevel.Warning,
                Events.Started,
                "LoggerMessage Warning with no params");

        private static readonly Action<ILogger, string, Exception> _logWarning1 = LoggerMessage.Define<string>(
                LogLevel.Warning,
                Events.Started,
                "LoggerMessage Warning with one param! {Param1}");

        private static readonly Action<ILogger, string, int, Exception> _logWarning2 = LoggerMessage.Define<string, int>(
            LogLevel.Warning,
            Events.Started,
            "LoggerMessage Warning with two params! {Param1}, {Param2}");
    }
    internal static class Events
    {
        public static readonly EventId Started = new EventId(100, "Started");
    }
}
