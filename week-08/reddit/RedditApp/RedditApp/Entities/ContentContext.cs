using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RedditApp.Models;
using Microsoft.EntityFrameworkCore;

namespace RedditApp.Entities
{
    public class ContentContext : DbContext
    {
        public ContentContext(DbContextOptions<ContentContext> options) : base(options)
        {
        }

        public DbSet<Content> Contents { get; set; }
    }

}
