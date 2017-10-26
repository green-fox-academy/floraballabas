using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GreetSomeone.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GreetSomeone.Controllers
{
    public class HomeController : Controller
    {
        UserInfo userinfo;

        public HomeController(UserInfo userinfo)
        {
            this.userinfo = userinfo;
        }

        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            return View(userinfo);
        }

        [HttpPost]
        [Route("")]
        public IActionResult ForwardToPage(UserInfo userinfo)
        {
            return RedirectToAction("Greet", userinfo);
        }

        [HttpGet]
        [Route("greet")]
        public IActionResult Greet(UserInfo userinfo)
        {
            return View(userinfo);
        }
    }
}
