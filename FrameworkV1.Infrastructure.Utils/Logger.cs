using Microsoft.Extensions.Logging;
using System;

namespace FrameworkV1.Infrastructure.Utils
{
    public class Logger : Core.Contracts.ILogger
    {
        private static ILogger _logger;

        private static ILogger GetLogger()
        {
            if (_logger == null)
            {
                var loggerFactory = new LoggerFactory();
                _logger = loggerFactory.CreateLogger("FrameworkV1");
            }

            return _logger;
        }

        public void Debug(string message)
        {
            GetLogger().LogDebug(message);
        }

        public void Trace(string message)
        {
            GetLogger().LogTrace(message);
        }

        public void Information(string message)
        {
            GetLogger().LogInformation(message);
        }

        public void Warning(string message, Exception ex)
        {
            GetLogger().LogWarning(ex, message);
        }

        public void Error(string message, Exception ex)
        {
            GetLogger().LogError(ex, message);
        }

        public void Critical(string message, Exception ex)
        {
            GetLogger().LogCritical(ex, message);
        }
    }
}
