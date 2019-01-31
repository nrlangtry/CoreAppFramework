using FrameworkV1.Core.Contracts;
using FrameworkV1.Core.Contracts.Accessors;

namespace FrameworkV1.Infrastructure.Managers
{
    public abstract partial class BaseManager
    {
        protected IServiceProvider ServiceProvider;
        protected ILogger Logger;

        protected IPersonAccessor PersonAccessor => ServiceProvider.GetService<IPersonAccessor>();

        protected BaseManager(IServiceProvider serviceProvider, ILogger logger)
        {
            ServiceProvider = serviceProvider;
            Logger = logger;

            Logger.Debug($"{nameof(BaseManager)} initialized");
        }
    }
}
