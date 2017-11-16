using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BucketListApp.Repositories;
using BucketListApp.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BucketListApp.Controllers
{
    [Route("/")]
    public class HomeController : Controller
    {
        BucketListRepository bucketListRepository;

        public HomeController(BucketListRepository bucketListRepository)
        {
            this.bucketListRepository = bucketListRepository;
        }

        [Route("/")]
        [HttpGet]
        public IActionResult Index()
        {
            return View(bucketListRepository.GetList());
        }

        [Route("/add")]
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [Route("/add")]
        [HttpPost]
        public IActionResult Add(string activity)
        {
            bucketListRepository.AddToList(activity);
            return RedirectToAction("index");
        }

        [Route("/{id}/delete")]
        [HttpPost]
        public IActionResult Delete(int id)
        {
            bucketListRepository.DeleteItem(id);
            return RedirectToAction("index");
        }

        [Route("/{id}/update")]
        [HttpGet]
        public IActionResult Update([FromQuery]int id)
        {
            var bucketlist = bucketListRepository.GetId(id);
            return View(bucketlist);
        }

        [Route("/{id}/update")]
        [HttpPost]
        public IActionResult Update(BucketList bucketlist)
        {
            bucketListRepository.UpdateItem(bucketlist);
            return RedirectToAction("index");
        }
    }
}
