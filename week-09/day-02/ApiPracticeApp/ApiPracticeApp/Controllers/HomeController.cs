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
            return File("Index.html", "text/html");
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

        [Route("/dountil/{what}")]
        [Route("/dountil")]
        [HttpPost]
        public IActionResult Index(string what, [FromBody] JsonObject until)
        {

            if (until == null || until.Until == null)
            {
                return Json(new { error = "Please provide a number!" });
            }
            if (string.IsNullOrEmpty(what))
            {
                return NotFound();
            }
            else if (what == "sum")
            {
                int sum = 0;

                for (int i = 0; i <= until.Until; i++)
                {
                    sum += i;
                }
                return Json(new { result = sum });
            }
            else if (what == "factor")
            {
                int fact = 1;
                fact = (int)until.Until;
                for (int i = (int)until.Until - 1; i >= 1; i--)
                {
                    fact = fact * i;
                }
                return Json(new { result = fact });
            }
            else
            {
                return Json(new { result = 4 });
            }
        }

        [HttpPost]
        [Route("/array")]
        public IActionResult ArrayHandler([FromBody] ArrayObject arrayObject)
        {
            if (arrayObject.Action == "Sum")
            {
                int result = arrayObject.Sum(arrayObject.Number);
                return Json(new { result = result });
            }

            if (arrayObject.Action == "Multiply")
            {
                int result = arrayObject.Multiply(arrayObject.Number);
                return Json(new { result = result });
            }

            if (arrayObject.Action == "Double")
            {
                int[] result = arrayObject.Double(arrayObject.Number);
                return Json(new { result = result });
            }
            return Json(new { error = "Please provide what to do with the numbers!" });
        }
    }
}
