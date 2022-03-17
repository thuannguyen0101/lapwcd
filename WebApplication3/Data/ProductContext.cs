using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebApplication3.Models;

namespace WebApplication3.Data
{
    public class ProductContext : DbContext
    {
        public ProductContext() : base("ProductContext") { }
        public DbSet<Product> Products { get; set; }

        public DbSet<Category> Categories { get; set; }
    }
}