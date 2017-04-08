using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Resturant_Pitza.Models
{
    public class Food
    {
        public int FoodId { get; set; }
        public decimal Prices { get; set; }
        public FoodType FoodType { get; set; }
    }

    public enum FoodType
    {
        Pizza,
        Beverage,
        Dessert
    }
}
