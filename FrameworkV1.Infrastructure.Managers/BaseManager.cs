using FrameworkV1.Core.Contracts;
using FrameworkV1.Core.Contracts.Accessors;
using FrameworkV1.Infrastructure.Accessors;
using FrameworkV1.Infrastructure.Utils;

namespace FrameworkV1.Infrastructure.Managers
{
    public abstract class BaseManager
    {
        public IServiceProvider AccessorServiceProvider { get; private set; }

        protected IPersonAccessor PersonAccessor => AccessorServiceProvider.GetService<IPersonAccessor>();

        protected BaseManager()
        {
            //EngineServiceProvider = new EngineServiceProvider(l);
            AccessorServiceProvider = new AccessorServiceProvider();

            Logger.Debug($"{nameof(BaseManager)} initialized");
        }
    }
}
