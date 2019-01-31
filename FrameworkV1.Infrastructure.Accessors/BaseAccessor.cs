using FrameworkV1.Core.Contracts;

namespace FrameworkV1.Infrastructure.Accessors
{
    public class BaseAccessor
    {
        protected IServiceProvider ServiceProvider;
        protected ILogger Logger;

        protected BaseAccessor(IServiceProvider serviceProvider, ILogger logger)
        {
            ServiceProvider = serviceProvider;
            Logger = logger;

            Logger.Debug($"{nameof(BaseAccessor)} initialized");
        }
    }
}
