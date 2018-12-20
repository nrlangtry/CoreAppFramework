using System;
using FrameworkV1.Core.Contracts;
using FrameworkV1.Core.Contracts.Accessors;
using FrameworkV1.Core.Contracts.Managers;
using FrameworkV1.Infrastructure.Accessors;
using FrameworkV1.Infrastructure.Managers;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Local = FrameworkV1.Core.Contracts;

namespace FrameworkV1.Infrastructure
{
    public class ServiceProvider : Local.IServiceProvider
    {
        private IServiceCollection _serviceCollection;
        private System.IServiceProvider _serviceProvider;

        public ServiceProvider(IServiceCollection serviceCollection)
        {
            _serviceCollection = serviceCollection;

            // Managers
            _serviceCollection.AddScoped<IPersonManager, PersonManager>();

            // Accessors
            _serviceCollection.AddScoped<IPersonAccessor, PersonAccessor>();
        }

        public T GetService<T>() where T : IServiceContractBase
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

        public void OverrideService<T, I>(ServiceLifetime lifetime)
        {
            var service = new ServiceDescriptor(typeof(T), typeof(I), lifetime);
            _serviceCollection.Replace(service);

            _serviceProvider = _serviceCollection.BuildServiceProvider();
        }

        public void OverrideService<T>(T instance)
        {
            throw new NotImplementedException();
        }
    }
}
