using Microsoft.AspNetCore.Mvc;
using Plasp.Express.OA.Models;
using Plasp.Express.OA.Service.Home;
using System.Diagnostics;
using UserDomainContract.ServerContract.IApplicationServices;

namespace Plasp.Express.OA.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUserService UserService;
        public HomeController(IUserService userService)
        {
            UserService = userService;
        }

        public IActionResult Index()
        {
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

        public IActionResult Test()
        {
            var notive = new TestBusiness(UserService).GetNotive();

            return View();
        }
    }
}
