using FrameworkV1.Core.Contracts;

namespace FrameworkV1.Infrastructure.Accessors
{
    public abstract class BaseAccessor
    {
        protected ILogger Logger;

        protected BaseAccessor(ILogger logger)
        {
            Logger = logger;

            Logger.Debug($"{nameof(BaseAccessor)} initialized");
        }
    }
}
