using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using IronBankApp.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace IronBankApp.Controllers
{
    [Route("")]
    public class HomeController : Controller
    {
        BankAccount bankaccount = new BankAccount("Tywin", 1000, FamilyName.Family.Lannister, false, true);

        [Route("list")]
        public IActionResult List()
        {
            bankaccount.BankAccountList.Add(new BankAccount("Robert", 100.5, FamilyName.Family.Baratheon, true, true));
            bankaccount.BankAccountList.Add(new BankAccount("Olenna", 2000, FamilyName.Family.Tyrell, false, true));
            bankaccount.BankAccountList.Add(new BankAccount("Doran", 2030.3, FamilyName.Family.Martell, false, true));
            bankaccount.BankAccountList.Add(new BankAccount("Eddard", 800, FamilyName.Family.Stark, false, false));
            bankaccount.BankAccountList.Add(new BankAccount("Brynden", 543.2, FamilyName.Family.Tully, false, false));
            bankaccount.BankAccountList.Add(new BankAccount("Jon", 9362.8, FamilyName.Family.Arryn, false, false));

            return View(bankaccount.BankAccountList);
        }

        [HttpPost]
        [Route("list")]
        public IActionResult BalanceRaise()
        {
            bankaccount.Raise();
            return RedirectToAction("List");
        }
    }
}
