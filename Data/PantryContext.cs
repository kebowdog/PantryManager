using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PantryManager.Models;

namespace PantryManager.Data
{
    public class PantryContext : DbContext
    {
        public PantryContext(DbContextOptions<PantryContext> options) : base(options)
        {

        }

        public DbSet<IPantryItem> Items { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Pantry> Pantries { get; set; }

    }
}
