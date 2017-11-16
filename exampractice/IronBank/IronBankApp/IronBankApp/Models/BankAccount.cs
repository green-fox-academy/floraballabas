using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IronBankApp.Models;

namespace IronBankApp.Models
{
    public class BankAccount
    {
        public string Name { get; set; }
        public double Balance { get; set; }
        public FamilyName.Family FamilyName { get; set; }
        public string Currency { get; set; } = "Gold";
        public List<BankAccount> BankAccountList = new List<BankAccount>();
        public bool IsKing { get; set; }
        public bool IsPowerHungry { get; set; }

        public BankAccount(string name, double balance, FamilyName.Family familyname, bool isKing, bool isPowerHungry)
        {
            Name = name;
            Balance = balance;
            FamilyName = familyname;
            IsKing = isKing;
            IsPowerHungry = isPowerHungry;
        }

        public void Raise()
        {
            for (int i = 0; i < BankAccountList.Count; i++)
            {
                if (BankAccountList[i].IsKing == false)
                {
                    BankAccountList[i].Balance += 10;
                }
                else
                {
                    BankAccountList[i].Balance += 100;
                }
            }
        }
    }
}
