using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreApplication.Models
{
    public class MainInfo
    {
        public Guid Id { get; set; }
        public string ShopName { get; set; }
        public byte[] ShopCover{ get; set; }
        public byte[] ShopLogo { get; set; }
        public string ShopDescription { get; set; }
    }
}
