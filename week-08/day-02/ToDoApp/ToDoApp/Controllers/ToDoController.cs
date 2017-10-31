using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ToDoApp.Entities;
using ToDoApp.Models;
using ToDoApp.Repositories;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Todos.Controllers
{
    [Route("todo")]
    public class TodoController : Controller
    {
        ToDoRepository TodoRepository;

        public TodoController(ToDoRepository todoRepository)
        {
            TodoRepository = todoRepository;
        }

        //[Route("/todo")]
        //public IActionResult Index()
        //{
        //    return View();
        //}

        [Route("/")]
        public IActionResult List()
        {
            string temp = "This is todo";
            return View((object)temp);
        }
    }
}
