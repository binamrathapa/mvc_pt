using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace ECOM.Models
{
    public class ECOMContext : DbContext
    {
        public DbSet<Product> Products
        {
            get;set;
        }
        public DbSet<User> Users
        { 
            get; set; 
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

        public System.Data.Entity.DbSet<ECOM.Models.Category> Categories { get; set; }

        public System.Data.Entity.DbSet<ECOM.Models.ProductViewModel> ProductViewModels { get; set; }
    }
}