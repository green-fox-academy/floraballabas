using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AnagramApp.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AnagramApp.Controllers
{
    public class HomeController : Controller
    {
        Checker checker;

        public HomeController(Checker checker)
        {
            this.checker = checker;
        }

        [Route("")]
        [HttpGet]
        public IActionResult Index()
        {
            return View(checker);
        }

        [Route("")]
        [HttpPost]
        public IActionResult ForwardToPage(Checker checker)
        {
            return RedirectToAction("anagram", checker);
        }

        [Route("anagram")]
        [HttpGet]
        public IActionResult Anagram(Checker checker)
        {
            checker.AnagramCheck();
            return View(checker);
        }
    }
}
