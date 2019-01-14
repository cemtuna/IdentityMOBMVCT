using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;


namespace MvcWebUI.Identity

{
    public class AccountDbContext :IdentityDbContext<DssUser>
    {

        public AccountDbContext(): base("AccountDbContext")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.HasDefaultSchema("DSS");
        }
    }
}