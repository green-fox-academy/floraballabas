using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimbaBank.Models
{
    public class BankAccount
    {
        public string Name { get; set; }
        public string Balance { get; set; }
        public AnimalType.TypeOfAnimal AnimalType { get; set; }
        public List<BankAccount> ListOfAccounts = new List<BankAccount>();
        public bool IsKing;

        public BankAccount(string name, string balance, AnimalType.TypeOfAnimal type, bool isKing)
        {
            Name = name;
            Balance = balance +".00" + " Zebra";
            AnimalType = type;
            IsKing = isKing;
        }

    }
}
