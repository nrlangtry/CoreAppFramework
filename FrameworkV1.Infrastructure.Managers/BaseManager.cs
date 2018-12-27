using FrameworkV1.Core.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace FrameworkV1.Infrastructure.Managers
{
    public abstract partial class BaseManager
    {
        protected Core.Contracts.IServiceProvider ServiceProvider;
        protected ILogger Logger => ServiceProvider.GetService<ILogger>();

        protected BaseManager(Core.Contracts.IServiceProvider serviceProvider)
        {
            ServiceProvider = serviceProvider;

            Logger.LogDebug($"{nameof(BaseManager)} initialized");
        }
    }
}
