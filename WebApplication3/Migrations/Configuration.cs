namespace WebApplication3.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using WebApplication3.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<WebApplication3.Data.ProductContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(WebApplication3.Data.ProductContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
            var categories = new List<Category>
            {
                new Category{CategoryName="Ao",Description="Ao mac"},
                new Category{CategoryName="Quan",Description="quan mac"},
                new Category{CategoryName="Mu",Description="mu doi"}
            };
            categories.ForEach(s => context.Categories.Add(s));
            context.SaveChanges();
            var products = new List<Product>
            {
            new Product{ProductName="Áo thun", QuantityPerUnit="1000", CategoryId=1, UnitPrice="10000"},
            new Product{ProductName="Áo ngắn tay cổ lọ", QuantityPerUnit="1000", CategoryId=1, UnitPrice="10000"},
            new Product{ProductName="Áo dài tay", QuantityPerUnit="1000", CategoryId=1, UnitPrice="10000"},
            new Product{ProductName="quan gió", QuantityPerUnit="1000", CategoryId=2, UnitPrice="10000"},
            new Product{ProductName="Áo thu đông", QuantityPerUnit="1000", CategoryId=1, UnitPrice="10000"},
            new Product{ProductName="Áo bomber", QuantityPerUnit="1000", CategoryId=1, UnitPrice="10000"},
            new Product{ProductName="Quần bò", QuantityPerUnit="1000", CategoryId=2, UnitPrice="10000"},
            new Product{ProductName="Quần kaki", QuantityPerUnit="1000", CategoryId=2, UnitPrice="10000"},
            new Product{ProductName="Quần jogger", QuantityPerUnit="1000", CategoryId=2, UnitPrice="10000"},
            new Product{ProductName="Mu coi", QuantityPerUnit="1000", CategoryId=3, UnitPrice="10000"},

            };

            products.ForEach(s => context.Products.Add(s));
            context.SaveChanges();
        }
    }
}
