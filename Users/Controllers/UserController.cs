using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Users.Controllers
{
   //[Route("[controller]")]
    public class UserController : Controller
    {
        //[HttpGet]
        [Route("/User/EHM")]
        [Route("[controller]/[action]/{data}")]
        
        public IActionResult Index(string data,int age)
        {
            String datos = data + " "+ age;
            return View("Index", datos);
        }
        public IActionResult Index()
        {
            return View();
        }
    } 

}
