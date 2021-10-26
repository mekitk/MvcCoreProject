using Microsoft.AspNetCore.Mvc;
using Northwind.MvcWeb.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Northwind.MvcWeb.UI.Controllers
{
    public class DenemeController : Controller
    {
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
    }
}
