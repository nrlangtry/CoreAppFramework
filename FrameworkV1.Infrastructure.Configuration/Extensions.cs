﻿using FrameworkV1.Core.Contracts.Accessors;
using FrameworkV1.Core.Contracts.Managers;
using FrameworkV1.Infrastructure.Accessors;
using FrameworkV1.Infrastructure.Managers;
using Microsoft.Extensions.DependencyInjection;

namespace FrameworkV1.Infrastructure.Configuration
{
    public static class Extensions
    {
        public static IServiceCollection AddFramework(this IServiceCollection serviceCollection)
        {
            // Managers
            serviceCollection.AddScoped<IPersonManager, PersonManager>();

            // Accessors
            serviceCollection.AddScoped<IPersonAccessor, PersonAccessor>();

            Utils.ServiceProvider.Init(serviceCollection);

            return serviceCollection;
        }
    }
}
