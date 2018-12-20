using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FrameworkV1.Web.Controllers
{
    public abstract partial class BaseController : Controller
    {
        protected Core.Contracts.IServiceProvider ServiceProvider { get; set; }

        protected BaseController(Core.Contracts.IServiceProvider serviceProvider)
        {
            ServiceProvider = serviceProvider;
        }
    }
}
