using System;

namespace FrameworkV1.Core.Contracts
{
    public interface ILogger
    {
        void LogTrace(string message);

        void LogInformation(string message);

        void LogWarning(string message, Exception ex);

        void LogError(string message, Exception ex);

        void LogCritical(string message, Exception ex);
    }
}
