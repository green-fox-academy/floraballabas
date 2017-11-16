using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GreetApp.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GreetApp.Controllers
{
    [Route("")]
    public class HomeController : Controller
    {
        Greet greet;

        public HomeController(Greet greet)
        {
            this.greet = greet;
        }

        [Route("/hello")]
        public IActionResult Hello()
        {
            return Content("Hello Flóra");
        }

        [Route("index")]
        [HttpGet]
        public IActionResult Index()
        {
            return View(greet);
        }

        [Route("index")]
        [HttpPost]
        public IActionResult GetInformation(Greet greet)
        {
            return RedirectToAction("greet", greet);
        }

        [Route("greet")]
        [HttpGet]
        public IActionResult Greet(Greet greet)
        {
            return View(greet);
        }
    }
}
