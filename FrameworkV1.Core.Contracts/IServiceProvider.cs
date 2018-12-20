using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace FrameworkV1.Core.Contracts
{
    public interface IServiceProvider
    {
        T GetService<T>() where T : IServiceContractBase;

        void OverrideService<T, I>(ServiceLifetime lifetime);

        void OverrideService<T>(T instance);
    }
}
