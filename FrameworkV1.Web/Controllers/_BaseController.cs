using FrameworkV1.Core.Contracts;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FrameworkV1.Web.Controllers
{
    public abstract partial class BaseController : Controller
    {
        protected Core.Contracts.IServiceProvider ServiceProvider;
        protected ILogger Logger => ServiceProvider.GetService<ILogger>();

        protected BaseController(Core.Contracts.IServiceProvider serviceProvider)
        {
            ServiceProvider = serviceProvider;

            Logger.LogDebug("BaseController initialized");
        }
    }
}
