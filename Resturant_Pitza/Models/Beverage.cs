using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Resturant_Pitza.Models
{
    public class Beverage: Food
    {
        public int BeverageId { get; set; }
        public string Type { get; set; }
        public string Size { get; set; }
        public bool Cold { get; set; }
        public bool Diet { get; set; }
    }
}
