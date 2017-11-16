using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BucketListApp.Models;
using BucketListApp.Repositories;

namespace BucketListApp.Entities
{
    public class BucketListContext : DbContext
    {
        public BucketListContext(DbContextOptions<BucketListContext> options) : base(options)
        {
        }

        public DbSet<BucketList> BucketLists { get; set; }
    }
}
