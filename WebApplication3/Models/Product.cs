using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication3.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int SupplierId { get; set; }
        public int CategoryId { get; set; }
        public string QuantityPerUnit { get; set; }
        public string UnitPrice { get; set; }
        public string UnitInStock { get; set; }
        public string UnitInOrder { get; set; }
        public string ReorderLevel { get; set; }
        public string Discontinued { get; set; }

        public virtual Category Category { get; set; }
    }
}