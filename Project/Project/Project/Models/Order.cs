using System;
using System.Collections.Generic;

#nullable disable

namespace Project.Models
{
    public partial class Order
    {
        public Order()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }

        public int OrderId { get; set; }
        public DateTime? OrderDate { get; set; }
        public string OrderTotal { get; set; }
        public string OrderStatus { get; set; }
        public int CustomerId { get; set; }
        public string OrderShipAddress { get; set; }
        public string OrderShipPhone { get; set; }
        public string OrderShipName { get; set; }
        public string OrderShipEmail { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
