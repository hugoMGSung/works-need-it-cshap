using System;
using System.Collections.Generic;

#nullable disable

namespace CodeFirstTestApp.Models
{
    public partial class Customer
    {
        public Customer()
        {
            Orders = new HashSet<Order>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
