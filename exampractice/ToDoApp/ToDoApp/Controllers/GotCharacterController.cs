using Microsoft.AspNetCore.Mvc;
using GotCharacterApp.Models;
using GotCharacterApp.Repositories;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GotCharacterApp.Controllers
{
    [Route("gotcharacter")]
    public class GotCharacterController : Controller
    {
        GotCharacterRepository GotCharacterRepository;

        public GotCharacterController(GotCharacterRepository gotCharacterRepository)
        {
            GotCharacterRepository = gotCharacterRepository;
        }

        [Route("/gotcharacter")]
        [HttpGet]
        public IActionResult List(bool IsAlive)
        {
            if (IsAlive)
            {
                return View(GotCharacterRepository.NotAliveList());
            }
            return View(GotCharacterRepository.GetList());
        }

        [Route("/gotcharacter/add")]
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [Route("/gotcharacter/add")]
        [HttpPost]
        public IActionResult Add(string name, bool isAlive, bool isFavourite)
        {
            GotCharacterRepository.AddCharacter(name, isAlive, isFavourite);
            return RedirectToAction("List");
        }

        [Route("/{id}/delete")]
        [HttpPost]
        public IActionResult Delete(int id)
        {
            GotCharacterRepository.DeleteCharacter(id);
            return RedirectToAction("List");
        }

        [Route("/{id}/update")]
        [HttpPost]
        public IActionResult Update(int id)
        {
            var character = GotCharacterRepository.Updating(id);
            return View(character);
        }

        [Route("/{id}/edit")]
        [HttpPost]
        public IActionResult Edit(GotCharacter character)
        {
            GotCharacterRepository.UpdateCharacter(character);
            return RedirectToAction("List");
        }
    }
}
