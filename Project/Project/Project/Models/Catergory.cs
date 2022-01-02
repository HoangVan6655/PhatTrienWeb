using System;
using System.Collections.Generic;

#nullable disable

namespace Project.Models
{
    public partial class Catergory
    {
        public Catergory()
        {
            Products = new HashSet<Product>();
        }

        public int CatergoryId { get; set; }
        public string CatergoryName { get; set; }
        public string CatergoryDescription { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
