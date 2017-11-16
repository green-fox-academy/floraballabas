using LoginApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoginApp.Entities
{
    public class AuthorContext : DbContext
    {
        public AuthorContext(DbContextOptions<AuthorContext> options) : base(options)
        {
        }

        public DbSet<Author> Authors { get; set; }
    }

}
