using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreApplication.Models
{
    public class IndexViewModel
    {
        public PageViewModel PageViewModel { get; set; }
        public IEnumerable<ProductModel> Models { get; set; }
    }
}
