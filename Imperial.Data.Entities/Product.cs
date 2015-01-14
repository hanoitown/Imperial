using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imperial.Data.Entities
{
    public class Product
    {
        public static Product New(string name, string description, string SKU)
        {
            return new Product
            {
                Id = Guid.NewGuid(),
                Name = name,
                Description = description,
                SKU = SKU
            };
        }

        public void AddPrice(PriceScheme scheme, decimal price)
        {
            if (price < 0)
                throw new Exception("negative price");

            this.Prices.Add(new ProductPrice()
            {
                PriceScheme = scheme,
                IsActive = true,
                Price = price
            });
        }

        public Guid Id { get; set; }
        public string Code { get; set; }
        public string Name{ get; set; }
        public string Description { get; set; }
        public string SKU { get; set; }
        public ICollection<ProductPrice> Prices { get; set; }
        public ProductCategory Category { get; set; }
        public ProductGroup Group { set; get; }
        public ICollection<ProductTag> Tags { get; set; }
        public Product()
        {
            Prices = new List<ProductPrice>();
            Tags = new List<ProductTag>();
        }
    }
}
