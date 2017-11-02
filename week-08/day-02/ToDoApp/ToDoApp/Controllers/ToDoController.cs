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

        [Route("/todo")]
        [HttpGet]
        public IActionResult List(bool IsActive)
        {
            if (IsActive)
            {
                return View(TodoRepository.NotDoneList());
            }
            return View(TodoRepository.GetList());
        }

        [Route("/todo/add")]
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [Route("/todo/add")]
        [HttpPost]
        public IActionResult Add(string title)
        {
            TodoRepository.AddTodo(title);
            return RedirectToAction("List");
        }


        //[Route("")]
        //public IActionResult List()
        //{
        //    return View(TodoRepository.GetLastToDo());
        //}

        //[Route("/add")]
        //public IActionResult AddTodo()
        //{
        //    TodoRepository.AddTodo();
        //    return RedirectToAction("List");
        //}

        //[Route("/getlist")]
        //public IActionResult List()
        //{
        //    return View(TodoRepository.GetList());
        //}
    }
}
