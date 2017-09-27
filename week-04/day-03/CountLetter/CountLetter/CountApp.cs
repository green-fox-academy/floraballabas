using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountLetter
{
    public class CountApp
    {
        public Dictionary<char, int> LetterCounter(string input)
        {
            Dictionary<char, int> letterDictionary = new Dictionary<char, int>();
            char[] inputArray = input.ToCharArray();
            
            foreach (var character in inputArray)
            {
                if (!letterDictionary.ContainsKey(character))
                {
                    letterDictionary.Add(character, 1);
                }
                else
                {
                    letterDictionary[character]++;
                }
            }
            return letterDictionary;
        }
    }
}
