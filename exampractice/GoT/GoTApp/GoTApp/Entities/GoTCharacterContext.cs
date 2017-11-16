using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GoTApp.Models;
using GoTApp.Repositories;
using Microsoft.EntityFrameworkCore;

namespace GoTApp.Entities
{
    public class GoTCharacterContext : DbContext
    {
        public GoTCharacterContext(DbContextOptions<GoTCharacterContext> options) : base(options)
        {
        }

        public DbSet<GoTCharacter> GoTCharacters { get; set; }
    }
}
