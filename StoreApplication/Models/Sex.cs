using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreApplication.Models
{
    public class SexDictionary
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Localization SexLocalization { get; set; }
    }
}
