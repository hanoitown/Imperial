using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Imperial.Data.Entities
{
    public class ProductTag
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Product> Products { get; set; }
        public ProductTag()
        {
            Products = new List<Product>();
        }
    }
}
