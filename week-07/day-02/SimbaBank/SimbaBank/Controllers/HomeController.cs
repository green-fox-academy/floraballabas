using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SimbaBank.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SimbaBank.Controllers
{
    public class HomeController : Controller
    {
        [Route("simba")]
        public IActionResult Index()
        {
            var bankaccount = new BankAccount("Simba", "2000", AnimalType.TypeOfAnimal.Lion);
            return View(bankaccount);
        }

        [Route("banklist")]
        public IActionResult BankList()
        {
            var bankaccount = new BankAccount("Simba", "2000", AnimalType.TypeOfAnimal.Lion);

            bankaccount.ListOfAccounts.Add(new BankAccount("Rafiki", "2000", AnimalType.TypeOfAnimal.Monkey));
            bankaccount.ListOfAccounts.Add(new BankAccount("Nala", "5000", AnimalType.TypeOfAnimal.Lion));
            bankaccount.ListOfAccounts.Add(new BankAccount("Mufasa", "4000", AnimalType.TypeOfAnimal.Lion));
            bankaccount.ListOfAccounts.Add(new BankAccount("Zordon", "2000", AnimalType.TypeOfAnimal.Lion));
            bankaccount.ListOfAccounts.Add(new BankAccount("Pumba", "2000", AnimalType.TypeOfAnimal.Warthog));

            return View(bankaccount.ListOfAccounts);
        }
    }
}
