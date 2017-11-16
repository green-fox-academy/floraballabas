using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CheckListApp.Repositories;
using CheckListApp.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CheckListApp.Controllers
{
    public class RESTController : Controller
    {
        ItemRepository itemRepository;
        public RESTController(ItemRepository itemRepository)
        {
            this.itemRepository = itemRepository;
        }
        [Route("/api")]
        [HttpGet]
        public IEnumerable<Item> IndexWithApi()
        {
            return itemRepository.GetList();
        }
        [HttpPost]
        [Route("/api/add")]
        public void AddNewItemWithApi([FromBody]string item, RaceCategory raceCategory)
        {
            itemRepository.AddItem(item, raceCategory);
        }
    }
}
