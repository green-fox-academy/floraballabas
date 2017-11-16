using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GoTApp.Entities;
using GoTApp.Models;
using GoTApp.Controllers;

namespace GoTApp.Repositories
{
    public class GoTCharacterRepository
    {
        GoTCharacterContext GoTCharacterContext;

        public GoTCharacterRepository(GoTCharacterContext goTCharacterContext)
        {
            GoTCharacterContext = goTCharacterContext;
        }

        public List<GoTCharacter> GetList()
        {
            return GoTCharacterContext.GoTCharacters.ToList();
        }

        public List<GoTCharacter> StillAliveList(bool IsAlive)
        {
            var stillAlive = from character in GoTCharacterContext.GoTCharacters
                             where character.IsAlive == true
                             select character;
            return stillAlive.ToList();
        }

        public void AddCharacter(string name, bool isAlive, bool isLikeable)
        {
            var character = new GoTCharacter
            {
                Name = name,
                IsAlive = isAlive,
                IsLikeable = isLikeable
            };
            GoTCharacterContext.GoTCharacters.Add(character);
            GoTCharacterContext.SaveChanges();
        }

        public void DeleteCharacter(int id)
        {
            var deletedCharacter = GoTCharacterContext.GoTCharacters.FirstOrDefault(x => x.Id == id);
            GoTCharacterContext.GoTCharacters.Remove(deletedCharacter);
            GoTCharacterContext.SaveChanges();
        }

        public GoTCharacter UpdatingCharacter(int id)
        {
            return GoTCharacterContext.GoTCharacters.FirstOrDefault(x => x.Id == id);
        }

        public void UpdateCharacter(GoTCharacter goTCharacter)
        {
            GoTCharacterContext.GoTCharacters.Update(goTCharacter);
            GoTCharacterContext.SaveChanges();
        }
    }
}
