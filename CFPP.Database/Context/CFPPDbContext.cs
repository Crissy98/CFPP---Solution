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
        public virtual DbSet<Case> Cases { get; set; }
    }
}
