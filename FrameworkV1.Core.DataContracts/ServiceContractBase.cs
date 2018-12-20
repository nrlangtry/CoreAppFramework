using System;
using System.Collections.Generic;
using System.Text;


namespace FrameworkV1.Core.DataContracts
{
    public abstract class ServiceContractBase
    {
        public Contracts.IServiceProvider ServiceProvider;

        protected ServiceContractBase(Contracts.IServiceProvider serviceProvider)
        {
            ServiceProvider = serviceProvider;
        }
    }
}
