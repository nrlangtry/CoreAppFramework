using FrameworkV1.Core.Contracts;
using FrameworkV1.Infrastructure;
using Microsoft.Extensions.DependencyInjection;

namespace FrameworkV1.Core
{
    public static class Extensions
    {
        public static IServiceCollection AddFrameworkLogger(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddSingleton<ILogger, Logger>();

            return serviceCollection;
        }

        public static IServiceCollection AddServiceProvider(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddSingleton<IServiceProvider, Infrastructure.ServiceProvider>();
            serviceCollection.AddSingleton<IServiceCollection>(serviceCollection);

            return serviceCollection;
        }
    }
}
