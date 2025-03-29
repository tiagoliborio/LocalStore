using LocalStore.Models;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace LocalStore.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Store> Stores { get; set; }
    }
}
