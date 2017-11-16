using System.Collections.Generic;
using System.Linq;
using GotCharacterApp.Models;
using GotCharacterApp.Entities;

namespace GotCharacterApp.Repositories
{
    public class GotCharacterRepository
    {
        GotCharacterContext GotCharacterContext;

        public GotCharacterRepository(GotCharacterContext gotCharacterContext)
        {
            GotCharacterContext = gotCharacterContext;
        }

        public List<GotCharacter> GetList()
        {
            return GotCharacterContext.GotCharacters.ToList();
        }

        public List<GotCharacter> NotAliveList()
        {
            var notAlive = from name in GotCharacterContext.GotCharacters
                          where name.IsAlive == false
                          select name;
            return notAlive.ToList();
        }

        public void AddCharacter(string name, bool isAlive, bool isFavourite)
        {
            var character = new GotCharacter()
            {
                Name = name,
                IsAlive = isAlive,
                IsFavourite = isFavourite
            };

            GotCharacterContext.GotCharacters.Add(character);
            GotCharacterContext.SaveChanges();
        }

        public void DeleteCharacter(int id)
        {
            GotCharacter deletedCharacter = 
                GotCharacterContext.GotCharacters.FirstOrDefault(x => x.Id == id);
            GotCharacterContext.GotCharacters.Remove(deletedCharacter);
            GotCharacterContext.SaveChanges();
        }

        public GotCharacter Updating(int id)
        {
            return GotCharacterContext.GotCharacters.FirstOrDefault(x => x.Id == id);
        }

        public void UpdateCharacter(GotCharacter character)
        {
            GotCharacterContext.GotCharacters.Update(character);
            GotCharacterContext.SaveChanges();
        }
    }
}
