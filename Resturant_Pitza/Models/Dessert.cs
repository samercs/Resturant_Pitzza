using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Resturant_Pitza.Models
{
    public class Dessert: Food
    {
        public int DessertId { get; set; }
        public string Type { get; set; }
        public string Size { get; set; }

    }
}
