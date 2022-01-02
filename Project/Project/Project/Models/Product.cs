using System;
using System.Collections.Generic;

#nullable disable

namespace Project.Models
{
    public partial class Product
    {
        public Product()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }

        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public int? ProductPrice { get; set; }
        public string ProductImageUrl { get; set; }
        public int? ProductQuantity { get; set; }
        public int? ProductPromotionPrice { get; set; }
        public int CatergoryId { get; set; }

        public virtual Catergory Catergory { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
