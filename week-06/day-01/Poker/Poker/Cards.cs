using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poker
{
    public class Cards
    {
        private string card;
        private bool IsValid;

        public Cards(string cardInput)
        {
            if (IsItAcceptable(cardInput))
            {
                this.card = cardInput;
            }
            else
            {
                this.card = "6D";
            }
        }

        public bool IsItAcceptable(string cardInput)
        {
            if (cardInput.Count() == 2)
            {
                IsValid = true;
            }
            else
            {
                IsValid = false;
            }
            return IsValid;
        }
    }
}
