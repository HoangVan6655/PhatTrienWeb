using System;
using System.Collections.Generic;

#nullable disable

namespace Project.Models
{
    public partial class Customer
    {
        public Customer()
        {
            Orders = new HashSet<Order>();
        }

        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerPhone { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
