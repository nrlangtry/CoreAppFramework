using Microsoft.Extensions.Logging;
using System;
using External = Microsoft.Extensions.Logging;
using Local = FrameworkV1.Core.Contracts;

namespace FrameworkV1.Infrastructure
{
    public class Logger : Local.ILogger
    {
        private External.ILogger _logger;

        public Logger(External.ILoggerFactory loggerFactory)
        {
            _logger = loggerFactory.CreateLogger("FrameworkV1");
        }

        public void LogDebug(string message)
        {
            _logger.LogDebug(message);
        }

        public void LogTrace(string message)
        {
            _logger.LogTrace(message);
        }

        public void LogInformation(string message)
        {
            _logger.LogInformation(message);
        }

        public void LogWarning(string message, Exception ex)
        {
            _logger.LogWarning(ex, message);
        }

        public void LogError(string message, Exception ex)
        {
            _logger.LogError(ex, message);
        }

        public void LogCritical(string message, Exception ex)
        {
            _logger.LogCritical(ex, message);
        }
    }
}
