using Microsoft.EntityFrameworkCore;
using GotCharacterApp.Models;

namespace GotCharacterApp.Entities
{
    public class GotCharacterContext : DbContext
    {
        public GotCharacterContext(DbContextOptions<GotCharacterContext> options) : base(options)
        {
        }

        public DbSet<GotCharacter> GotCharacters { get; set; }
    }
}
