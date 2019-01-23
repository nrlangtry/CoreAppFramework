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

        public static void Debug(string message)
        {
            logger.LogDebug(message);
        }

        public static void Trace(string message)
        {
            logger.LogTrace(message);
        }

        public static void Information(string message)
        {
            logger.LogInformation(message);
        }

        public static void Warning(string message, Exception ex)
        {
            logger.LogWarning(ex, message);
        }

        public static void Error(string message, Exception ex)
        {
            logger.LogError(ex, message);
        }

        public static void Critical(string message, Exception ex)
        {
            logger.LogCritical(ex, message);
        }
    }
}
