using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imperial.Data.Entities
{
    public class ProductPrice
    {        
        public int Id { get; set; }
        public bool IsActive { get; set; }
        public Product Product { get; set; }    // CHOCOLATE
        public PriceScheme PriceScheme { get; set; } // STANDARD PRICE
        public Currency Currency { get; set; }  // VND
        public Tax Tax { get; set; }            // VAT
        public decimal Price { get; set; }      // 100
        public decimal TaxValue { set; get; }        //10

        public ProductPrice()
        {

        }
    }
}
