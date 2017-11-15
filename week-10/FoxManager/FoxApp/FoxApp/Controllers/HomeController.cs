using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FoxApp.Repositories;
using FoxApp.Models;
using FoxApp.Services;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FoxApp.Controllers
{
    [Route("/home")]
    public class HomeController : Controller
    {
        private FoxService foxService;

        public HomeController(FoxService foxService)
        {
            this.foxService = foxService;
        }

        [HttpPost]
        public IActionResult LoginHandler(Student studentFromForm)
        {
            if (foxService.AuthenticateStudent(studentFromForm.Name))
            {
                return LocalRedirect("/home/" + studentFromForm.Name);
            }

            return LocalRedirect("");
        }

        [HttpGet]
        [Route("/home/{studentName}")]
        public IActionResult Profile(string studentName)
        {
            var user = foxService.GetStudentInfo(studentName);
            var projects = foxService.GetStudentProjects(studentName);
            return View(user);
        }
    }
}
