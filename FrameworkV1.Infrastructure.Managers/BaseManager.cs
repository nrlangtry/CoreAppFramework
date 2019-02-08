using FrameworkV1.Core.Contracts;
using FrameworkV1.Core.Contracts.Accessors;
using FrameworkV1.Infrastructure.Accessors;

namespace FrameworkV1.Infrastructure.Managers
{
    public abstract class BaseManager
    {
        public IServiceProvider AccessorServiceProvider { get; private set };
        protected ILogger Logger;

        protected IPersonAccessor PersonAccessor => AccessorServiceProvider.GetService<IPersonAccessor>();

        protected BaseManager(ILogger logger)
        {
            //EngineServiceProvider = new EngineServiceProvider(logger);
            AccessorServiceProvider = new AccessorServiceProvider(logger);

            Logger = logger;

            Logger.Debug($"{nameof(BaseManager)} initialized");
        }
    }
}
