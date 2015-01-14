using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Imperial.Data.Entities
{
    public class ProductTag
    {
        public int Id { get; set; }
        public int Count { get; set; }
        public Tag Tag{ get; set; }
        public Product Product { get; set; }
        public ProductTag()
        {

        }
    }
}
