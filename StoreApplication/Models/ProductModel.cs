using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreApplication.Models
{
    public class ProductModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string Manufacturer { get; set; }
        public decimal DiscountPrice { get; set; }
        public int DiscountPercentage { get; set; }
        public bool IsNew { get; set; }
        public OriginCountry Country { get; set; }
        public ProductCategory Category { get; set; }
        public List<ProductTag> Tags { get; set; }

        protected static int CalculateDiscountPercentage(decimal ogPrice, decimal discPrice) {
            int perc = 0;
            perc = (int)((ogPrice - discPrice) / ((ogPrice + discPrice) / 2)) / 100;
            return perc;
        }
        protected static decimal CalculateDiscountPrice(decimal ogPrice, int perc)
        {
            decimal newPrice = 0;
            if (ogPrice != 0) {
                newPrice = (ogPrice * perc) / 100;
            }
            return newPrice;
        }

    }
}
