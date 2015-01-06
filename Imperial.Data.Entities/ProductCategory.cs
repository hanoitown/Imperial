﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Imperial.Data.Entities
{
    public class ProductCategory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<Product> Products { get; set; }
        public ProductCategory()
        {
            Products = new List<Product>();
        }
    }
}
