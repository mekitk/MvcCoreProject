using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Northwind.MvcWeb.UI.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Northwind.MvcWeb.UI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            List<Users> userList = new List<Users>
            {
                new Users{Id=1,CreateDate=DateTime.Now.AddDays(1),UserName="Ali"},
                  new Users{Id=2,CreateDate=DateTime.Now.AddDays(2),UserName="mehmet"},
                    new Users{Id=3,CreateDate=DateTime.Now.AddDays(3),UserName="Mustafa"},
            };
            return View(userList);
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
