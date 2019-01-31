using FrameworkV1.Core.Contracts;
using FrameworkV1.Core.Contracts.Accessors;
using FrameworkV1.Infrastructure.Utils;
using Microsoft.Extensions.DependencyInjection;

namespace FrameworkV1.Infrastructure.Accessors
{
    public class AccessorServiceProvider : ServiceProviderBase
    {
        protected IPersonAccessor PersonAccessor => GetService<IPersonAccessor>();

        public AccessorServiceProvider(ILogger logger)
            : base(logger)
        {
            serviceCollection.AddScoped<IPersonAccessor, PersonAccessor>();
        }
    }
}
