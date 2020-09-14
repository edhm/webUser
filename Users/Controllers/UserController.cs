using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Users.Controllers
{
    public class UserController : Controller
    {
        [HttpGet]
        public IActionResult Index(int id)
        {
            ViewData["id"] = id;
            return View();
        }
    }
}
