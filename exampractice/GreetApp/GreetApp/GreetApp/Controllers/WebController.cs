using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GreetApp.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GreetApp.Controllers
{
    [Route("web")]
    public class WebController : Controller
    {
        public static int counter = 1;

        [Route("greeting")]
        public IActionResult Greeting([FromQuery] string name)
        {
            var greeting = new Greeting()
            {
                Id = counter++,
                Content = name
            };

            return View(greeting);
        }

    }
}
