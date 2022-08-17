using System;
using System.Collections.Generic;

#nullable disable

namespace DataBaseFirstTestApp.Models
{
    public partial class Order
    {
        public Order()
        {
            ProductOrders = new HashSet<ProductOrder>();
        }

        public int Id { get; set; }
        public DateTime? OrderDate { get; set; }
        public int CustomerId { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual ICollection<ProductOrder> ProductOrders { get; set; }
    }
}
