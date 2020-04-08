using CFPP.Database.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CFPP.Database.Context
{
    public class CFPPDbContext : DbContext
    {
        public CFPPDbContext(DbContextOptions<CFPPDbContext> options) : base(options)
        {
        }

        //DBSets
        public virtual DbSet<Customer> Customers { get; set; }


        //model Builder
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Customer>().HasIndex(s => s.CustomerId).IsUnique();
            //modelBuilder.Entity<Case>().HasIndex(s => s.CustomerCode).IsUnique();
        }
    }
}
