using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;

namespace FrameworkV1.Infrastructure.Utils
{
    public static class Logger
    {
        private static ILogger _logger;
        private static ILogger logger
        {
            get
            {
                if (_logger == null)
                {
                    // Get the .NET Core LoggerFactory
                    var serviceCollection = new ServiceCollection();
                    var provider = serviceCollection.BuildServiceProvider();
                    _logger = provider.GetService<ILoggerFactory>().CreateLogger("FrameworkV1");

                }

                return _logger;
            }
        }

        public static void LogDebug(string message)
        {
            logger.LogDebug(message);
        }

        public static void LogTrace(string message)
        {
            logger.LogTrace(message);
        }

        public static void LogInformation(string message)
        {
            logger.LogInformation(message);
        }

        public static void LogWarning(string message, Exception ex)
        {
            logger.LogWarning(ex, message);
        }

        public static void LogError(string message, Exception ex)
        {
            logger.LogError(ex, message);
        }

        public static void LogCritical(string message, Exception ex)
        {
            logger.LogCritical(ex, message);
        }
    }
}
