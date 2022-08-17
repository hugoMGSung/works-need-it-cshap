using System;
using System.Collections.Generic;

#nullable disable

namespace DataBaseFirstTestApp.Models
{
    public partial class Product
    {
        public Product()
        {
            ProductOrders = new HashSet<ProductOrder>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        public virtual ICollection<ProductOrder> ProductOrders { get; set; }
    }
}
