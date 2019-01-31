using Microsoft.AspNetCore.Mvc;
using FrameworkV1.Core.Contracts;
using FrameworkV1.Core.Contracts.Managers;

namespace FrameworkV1.Clients.Web.Controllers
{
    public abstract partial class BaseController : Controller
    {
        private IServiceProvider ServiceProvider;
        protected ILogger Logger => ServiceProvider.GetService<ILogger>();
        protected IPersonManager PersonManager => ServiceProvider.GetService<IPersonManager>();

        protected BaseController(IServiceProvider serviceProvider)
        {
            ServiceProvider = serviceProvider;

            Logger.Debug($"{nameof(BaseController)} initialized");
        }
    }
}
