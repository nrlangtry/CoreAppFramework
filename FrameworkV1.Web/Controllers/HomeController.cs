using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using FrameworkV1.Web.Models;
using FrameworkV1.Core.Contracts.Managers;

namespace FrameworkV1.Web.Controllers
{
    public class HomeController : BaseController
    {
        public HomeController(Core.Contracts.IServiceProvider serviceProvider) : base(serviceProvider) { }

        public IActionResult Index()
        {
            var people = ServiceProvider.GetService<IPersonManager>().GetPeople();

            return View(people);
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
