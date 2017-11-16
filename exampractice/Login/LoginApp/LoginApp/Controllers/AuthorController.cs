using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LoginApp.Repositories;
using LoginApp.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LoginApp.Controllers
{
    [Route("/home")]
    public class AuthorController : Controller
    {
        private AuthorRepository authorRepository;

        public AuthorController(AuthorRepository authorRepository)
        {
            this.authorRepository = authorRepository;
        }

        [HttpPost]
        public IActionResult LoginHandler(Author authorFromForm)
        {
            if (authorRepository.AuthenticateAuthor(authorFromForm.Name))
            {
                return LocalRedirect("/home/" + authorFromForm.Name);
            }

            return RedirectToAction("login", "login");
        }

        [HttpGet]
        [Route("/home/{authorName}")]
        public IActionResult Index(string authorName)
        {
            var user = authorRepository.GetAuthorInfo(authorName);
            return View(user);
        }
    }
}
