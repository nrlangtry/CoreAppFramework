using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using FrameworkV1.Clients.Web.Models;
using FrameworkV1.Core.Contracts.Managers;
using System;

namespace FrameworkV1.Clients.Web.Controllers
{
    public class HomeController : BaseController
    {
        public HomeController(Core.Contracts.IServiceProvider serviceProvider) : base(serviceProvider) { }

        public IActionResult Index()
        {
            try
            {
                var people = ServiceProvider.GetService<IPersonManager>().GetPeople();

                return View(people);
            }
            catch (Exception ex)
            {
                Logger.LogError("HomeController.Index", ex);
            }

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
