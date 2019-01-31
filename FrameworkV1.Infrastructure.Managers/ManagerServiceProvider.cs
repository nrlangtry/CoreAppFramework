using FrameworkV1.Core.Contracts;
using FrameworkV1.Core.Contracts.Managers;
using FrameworkV1.Infrastructure.Accessors;
using FrameworkV1.Infrastructure.Utils;
using Microsoft.Extensions.DependencyInjection;

namespace FrameworkV1.Infrastructure.Managers
{
    public class ManagerServiceProvider : ServiceProviderBase
    {
        protected IPersonManager PersonManager => GetService<IPersonManager>();

        public ManagerServiceProvider(ILogger logger)
            : base(logger)
        {
            serviceCollection.AddScoped<IPersonManager, PersonManager>();
        }
    }
}
