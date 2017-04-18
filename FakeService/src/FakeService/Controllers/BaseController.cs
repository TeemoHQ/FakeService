using DataBaseTables;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FakeService.Controllers
{
    public class BaseController : Controller
    {
        protected static MyDBContext _context;
        public BaseController(MyDBContext context)
        {
            _context = context;
        }
    }
}
