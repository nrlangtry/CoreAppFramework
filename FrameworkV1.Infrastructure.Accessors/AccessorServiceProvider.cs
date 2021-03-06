﻿using FrameworkV1.Core.Contracts;
using FrameworkV1.Core.Contracts.Accessors;
using FrameworkV1.Infrastructure.Utils;
using Microsoft.Extensions.DependencyInjection;

namespace FrameworkV1.Infrastructure.Accessors
{
    public class AccessorServiceProvider : ServiceProviderBase
    {
        public AccessorServiceProvider()
            : base()
        {
            serviceCollection.AddScoped<IPersonAccessor, PersonAccessor>();
        }
    }
}
