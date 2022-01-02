using System;
using System.Collections.Generic;

#nullable disable

namespace Project.Models
{
    public partial class OrderDetail
    {
        public int OrderDetailsId { get; set; }
        public int ProductId { get; set; }
        public int? OrderDetailsQuantity { get; set; }
        public int OrderId { get; set; }
        public int? OrderDetailsPrice { get; set; }

        public virtual Order Order { get; set; }
        public virtual Product Product { get; set; }

        internal object Insert(Order order)
        {
            throw new NotImplementedException();
        }

        internal void Insert(OrderDetail orderDetail)
        {
            throw new NotImplementedException();
        }
    }
}
