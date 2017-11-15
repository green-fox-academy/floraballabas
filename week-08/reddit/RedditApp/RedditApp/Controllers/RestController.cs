using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RedditApp.Repositories;
using RedditApp.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RedditApp.Controllers
{
    public class RestController : Controller
    {
        PostRepository postRepository;

        public RestController(PostRepository postRepository)
        {
            this.postRepository = postRepository;
        }

        [HttpGet]
        [Route("/api/posts")]
        public IEnumerable<Content> ListContents()
        {
            return postRepository.ListPost();
        }

        [HttpPost]
        [Route("/api/posts")]
        public IActionResult AddNewContent([FromBody]Content content)
        {
            postRepository.AddNewPost(content);
            return Json(content);
        }
    }
}
