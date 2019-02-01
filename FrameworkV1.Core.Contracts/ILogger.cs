using System;

namespace FrameworkV1.Core.Contracts
{
    public interface ILogger : IServiceContractBase
    {
        void Debug(string message);

        void Trace(string message);

        void Information(string message);

        void Warning(string message, Exception ex);

        void Error(string message, Exception ex);

        void Critical(string message, Exception ex);
    }
}
