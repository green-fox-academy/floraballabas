using Microsoft.EntityFrameworkCore;
using RedditApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RedditApi.Entities
{
    public class PostContext : DbContext
    {
        public PostContext(DbContextOptions<PostContext> options) : base(options)
        {
        }

        public DbSet<Post> Reddit { get; set; }
    }
}
