using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Resturant_Pitza.Models
{
    public class Pizza: Food
    {
        public int PizzaId { get; set; }
        public string Size { get; set; }
        public string Thickness { get; set; }
        public string Topping1 { get; set; }
        public string Topping2 { get; set; }
        public string Topping3 { get; set; }
        public string ExtraCheese { get; set; }

    }
}
