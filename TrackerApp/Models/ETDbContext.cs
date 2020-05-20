using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EpidemicTracker.Data.Models
{
    public class ETDbContext : DbContext
    {
        public DbSet<Patient> Patient { get; set; }
        public DbSet<Occupations> Occupations { get; set; }
        public DbSet<AddressTypes> AddressTypes { get; set; }
        public DbSet<Address> Address { get; set; }
        public DbSet<Hospital> Hospital { get; set; }
        public DbSet<StaffRole> StaffRole { get; set; }
        public DbSet<HospitalStaff> HospitalStaff { get; set; }
        public DbSet<DiseaseType> DiseaseType { get; set; }
        public DbSet<DiseaseDetails> DiseaseDetails { get; set; }
        public DbSet<TreatmentStatus> TreatmentStatus { get; set; }
        public DbSet<Treatment> Treatment { get; set; }
        public DbSet<Prescription> Prescription { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=EpidemicTracker.Data;" + "Trusted_Connection=True;");
        }
        
    }
}
