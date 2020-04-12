using CFPP.Database.Entities;
using Microsoft.EntityFrameworkCore;

namespace CFPP.Database.Context
{
    public class CFPPDbContext : DbContext
    {
        public CFPPDbContext(DbContextOptions<CFPPDbContext> options) : base(options)
        {
        }

        //DBSets
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Case> Cases { get; set; }

        //model Builder
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Customer>().HasIndex(s => s.CustomerId).IsUnique();
            //modelBuilder.Entity<Case>().HasIndex(s => s.CustomerCode).IsUnique();

            //Data Seeding - Test

            modelBuilder.Entity<Customer>()
        .HasData(
            new Customer
            {
                CustomerId = 4,
                CustomerName = "John Doe",
                VATCode = "JD232456",

            }
        );
        }
    }
}
