using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataBaseTables;
using Microsoft.AspNetCore.Mvc;

namespace FakeService.Controllers
{
    public class HomeController : BaseController
    {
        public HomeController(MyDBContext context) : base(context)
        {
        }

        public IActionResult Index()
        {
            ViewData["Hos"] = _context.医院信息.ToList();
            ViewData["Dept"] = _context.科室信息.ToList();
            ViewData["Doc"] = _context.医生介绍.ToList();
            return View();
        }

    }
}
