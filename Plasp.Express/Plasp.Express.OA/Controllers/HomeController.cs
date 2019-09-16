using Microsoft.AspNetCore.Mvc;
using Plasp.Express.OA.Models;
using Plasp.Express.OA.Service.Home;
using Plasp.Express.OA.Service.Models;
using Plasp.Express.OA.Service.Models.Home;
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

        public IActionResult SignIn()
        {
            var notive = new TestBusiness(UserService).GetNotive();

            return View();
        }

        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public IActionResult Login(LoginParam param)
        {
            var remark = string.Empty;
            if (string.IsNullOrWhiteSpace(param?.UserName))
                remark = "用户名不可为空!";
            if (string.IsNullOrWhiteSpace(param.Password))
                remark = "密码不可为空!";

            return new JsonResult(new BaseResult {
                Remark = remark,
                Status = string.IsNullOrEmpty(remark) 
                    ? RunStatus.Success 
                    : RunStatus.Failed
            });
        }
    }
}
