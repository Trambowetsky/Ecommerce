using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreApplication.Models
{
    public class ProductPhoto
    {
        public Guid Id { get; set; }
        public ProductModel ProductId { get; set; }
        public byte[] Image { get; set; }
        public bool IsCoverImg { get; set; }
    }
}
