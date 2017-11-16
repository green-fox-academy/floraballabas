using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GoTApp.Repositories;
using GoTApp.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GoTApp.Controllers
{
    [Route("gotcharacter")]
    public class GoTCharacterController : Controller
    {
        GoTCharacterRepository GoTCharacterRepository;

        public GoTCharacterController(GoTCharacterRepository goTCharacterRepository)
        {
            GoTCharacterRepository = goTCharacterRepository;
        }

        [Route("/gotcharacter")]
        [HttpGet]
        public IActionResult List(bool IsAlive)
        {
            if (IsAlive)
            {
                return View(GoTCharacterRepository.StillAliveList(IsAlive));
            }
            return View(GoTCharacterRepository.GetList());
        }

        [Route("/gotcharacter/add")]
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [Route("/gotcharacter/add")]
        [HttpPost]
        public IActionResult Add(string name, bool isAlive, bool isLikeable)
        {
            GoTCharacterRepository.AddCharacter(name, isAlive, isLikeable);
            return RedirectToAction("List");
        }

        [Route("/{id}/delete")]
        [HttpPost]
        public IActionResult Delete(int id)
        {
            GoTCharacterRepository.DeleteCharacter(id);
            return RedirectToAction("List");
        }

        [Route("/{id}/updating")]
        [HttpGet]
        public IActionResult Updating([FromQuery]int id)
        {
            var character = GoTCharacterRepository.UpdatingCharacter(id);
            return View(character);
        }

        [Route("/{id}/update")]
        [HttpPost]
        public IActionResult Update(GoTCharacter goTCharacter)
        {
            GoTCharacterRepository.UpdateCharacter(goTCharacter);
            return RedirectToAction("List");
        }
    }
}
