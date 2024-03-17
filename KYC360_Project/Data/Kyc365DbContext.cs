using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using KYC360_Project.Models;

namespace KYC360_Project.Data
{
    public class Kyc365DbContext : DbContext
    {
        public Kyc365DbContext()
        { 
        }
        public Kyc365DbContext(DbContextOptions<Kyc365DbContext> options) : base(options)
        {

        }

        public DbSet<Entity> Entities { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Date> Dates { get; set; }
        public DbSet<Name> Names { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Address>().HasNoKey();
          
        }
    }
}
