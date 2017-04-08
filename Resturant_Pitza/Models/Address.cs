using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Resturant_Pitza.Models
{
    public class Address
    {
        public int AddressId { get; set; }
        public string Country { get; set; }
        public string Area { get; set; }
        public int Block { get; set; }
        public string BuildingNumber { get; set; }
        public string FlatNo { get; set; }
        public string Street { get; set; }
        public string ZipCode { get; set; }
    }
}
