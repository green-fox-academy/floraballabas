using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ApiPracticeApp.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ApiPracticeApp.Controllers
{
    [Route("")]
    public class HomeController : Controller
    {

        [HttpGet]
        public IActionResult Index()
        {
            return File("index.html", "text/html");
        }

        [HttpGet]
        [Route("/doubling")]
        public IActionResult Doubling(int? input)
        {
            if (input == null)
            {
                return Json(new { error = "Please provide an input!" });
            }
            return Json(new { received = input, result = input * 2 });
        }

        [HttpGet]
        [Route("/greeter")]
        public IActionResult Greeter(string name, string title)
        {
            if (name == null)
            {
                return Json(new { error = "Please provide a name!" });
            }
            else if (title == null)
            {
                return Json(new { error = "Please provide a title!" });
            }
            return Json(new { welcome_message = $"Oh, hi there {name}, my dear {title}!" });
        }

        [HttpGet]
        [Route("/appenda/{appendable}")]
        public IActionResult AppendA(string appendable)
        {
            return Json(new { appended = $"{appendable}a" });
        }

        [HttpGet]
        [Route("/appenda/")]
        public IActionResult Append()
        {
            return NotFound();
        }
        
        [HttpPost]
        [Route("/dountil/{what}")]
        public IActionResult DoUntil([FromBody] JsonObject jsonObject, string what)
        {
            int resultNumber = 0;

            if (jsonObject == null)
            {
                return Json(new { error = "Please provide a number!" });
            }

            if (string.IsNullOrEmpty(what))
            {
                return NotFound();
            }

            if (what == "sum")
            {
                for (int i = 0; i <= jsonObject.Until; i++)
                {
                    resultNumber += i;
                }
            }

            if (what == "factor")
            {
                resultNumber = 1;
                for (int i = 1; i <= jsonObject.Until; i++)
                {
                    resultNumber *= i;
                }
            }
            return Json(new { result = $"{resultNumber}" });
        }
    }
}
