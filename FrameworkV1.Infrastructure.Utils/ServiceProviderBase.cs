using FrameworkV1.Core.Contracts;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Logging;
using System;

namespace FrameworkV1.Infrastructure.Utils
{
    public class ServiceProviderBase : Core.Contracts.IServiceProvider
    {
        private static System.IServiceProvider serviceProvider;
        protected readonly IServiceCollection serviceCollection;

        public ServiceProviderBase(Core.Contracts.ILogger logger)
        {
            serviceCollection = new ServiceCollection()
            {
                new ServiceDescriptor(typeof(Core.Contracts.ILogger), logger)
            };
        }

        public T GetService<T>() where T : IServiceContractBase
        {
            if (serviceProvider == null)
            {
                serviceProvider = serviceCollection.BuildServiceProvider();
            }

            var service = serviceProvider.GetService<T>();

            if (service == null)
            {
                throw new Exception($"Service Provider does not support {typeof(T)}");
            }

            return service;
        }

        public void OverrideService<T, I>(ServiceLifetime lifetime)
        {
            var service = new ServiceDescriptor(typeof(T), typeof(I), lifetime);
            serviceCollection.Replace(service);

            serviceProvider = serviceCollection.BuildServiceProvider();
        }

        public void OverrideService<T>(T instance)
        {
            var service = new ServiceDescriptor(typeof(T), instance);
            serviceCollection.Replace(service);

            serviceProvider = serviceCollection.BuildServiceProvider();
        }
    }
}
