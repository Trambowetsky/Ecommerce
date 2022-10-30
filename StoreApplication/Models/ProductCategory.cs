using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreApplication.Models
{
    public class ProductCategory
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public ProductCategory ParentCategory { get; set; }
        public bool IsMain { get; set; }

    }
}
