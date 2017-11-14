using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RedditApp.Repositories;
using RedditApp.Models;

namespace RedditApp.Controllers
{
    [Route("")]
    public class HomeController : Controller
    {
        ContentRepository contentRepository;
        public HomeController(ContentRepository contentRepository)
        {
            this.contentRepository = contentRepository;
        }

        [Route("")]
        [HttpGet]
        public IActionResult Index()
        {
            return View(contentRepository.GetList());
        }

        [Route("/api")]
        [HttpGet]
        public IEnumerable<Content> IndexWithApi()
        {
            return contentRepository.GetList();
        }

        [Route("/add")]
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [Route("/add")]
        [HttpPost]
        public IActionResult Add(string content)
        {
            contentRepository.AddPost(content);
            return RedirectToAction("index");
        }

        [Route("/{id}/delete")]
        [HttpPost]
        public IActionResult Delete(int id)
        {
            contentRepository.DeletePost(id);
            return RedirectToAction("index");
        }

        [Route("/{id}/update")]
        [HttpGet]
        public IActionResult Update([FromQuery]int id)
        {
            var content = contentRepository.GetId(id);
            return View(content);
        }

        [Route("/{id}/update")]
        [HttpPost]
        public IActionResult Update(Content content)
        {
            contentRepository.UpdatePost(content);
            return RedirectToAction("index");
        }

        [Route("vote/up/{id}")]
        public IActionResult VoteUp(int id)
        {
            contentRepository.Vote("up", id);
            return RedirectToAction("index");
        }

        [Route("vote/down/{id}")]
        public IActionResult VoteDown(int id)
        {
            contentRepository.Vote("down", id);
            return RedirectToAction("index");
        }

    }
}
