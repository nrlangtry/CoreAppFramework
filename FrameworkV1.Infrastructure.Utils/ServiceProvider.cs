using System;
using FrameworkV1.Core.Contracts;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace FrameworkV1.Infrastructure.Utils
{
    public class ServiceProvider
    {
        private static IServiceCollection _serviceCollection;
        private static System.IServiceProvider _serviceProvider;

        public static void AddServiceProvider(IServiceCollection serviceCollection)
        {
            _serviceCollection = serviceCollection;
        }

        public static T GetService<T>() where T : IServiceContractBase
        {
            if (_serviceProvider == null)
            {
                _serviceProvider = _serviceCollection.BuildServiceProvider();
            }

            var service = _serviceProvider.GetService<T>();

            if (service == null)
            {
                throw new Exception($"Service Provider does not support {typeof(T)}");
            }

            return service;
        }

        public static void OverrideService<T, I>(ServiceLifetime lifetime)
        {
            var service = new ServiceDescriptor(typeof(T), typeof(I), lifetime);
            _serviceCollection.Replace(service);

            _serviceProvider = _serviceCollection.BuildServiceProvider();
        }

        public static void OverrideService<T>(T instance)
        {
            throw new NotImplementedException();
        }
    }
}
