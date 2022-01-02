using System;
namespace Project.Models
{
    public class CartItem
    {
        public int Quantity { set; get; }
        public Product product { set; get; }
    }
}
