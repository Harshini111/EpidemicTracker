using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EpidemicTracker.Data.Models
{
    public class ETDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Occupations> Occupations { get; set; }
        public DbSet<AddressTypes> AddressTypes { get; set; }
        public DbSet<Address> Address { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=EpidemicTracker.Data;" + "Trusted_Connection=True;");
        }
        
    }
}
