using MvcWebUI.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MvcWebUI.Models
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(): base()
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.HasDefaultSchema("DSS");
        }

        public DbSet<CEM_LU_IL> Cities { get; set; }
        public DbSet<CEM_TEST_MIG> TestMigs { get; set; }

    }
}