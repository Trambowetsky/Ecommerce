using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreApplication.Models
{
    public class OriginCountry
    {
        public Guid Id { get; set; }
        public string CountryName { get; set; }
        public Localization NameLocalization { get; set; }
    }
}
