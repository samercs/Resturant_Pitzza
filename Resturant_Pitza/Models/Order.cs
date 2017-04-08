using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Resturant_Pitza.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        [StringLength(450)]
        public string PersonId { get; set; }
        public int AddressId { get; set; }
        public int PitzzaId { get; set; }
        public int DessertId { get; set; }
        public int BeverageId { get; set; }

        [ForeignKey("PersonId")]
        public virtual ApplicationUser ApplicationUser { get; set; }

        public virtual Address Address { get; set; }
        [ForeignKey("PitzzaId")]
        public virtual Pizza Pizza { get; set; }
        [ForeignKey("DessertId")]
        public virtual Dessert Dessert { get; set; }
        [ForeignKey("BeverageId")]
        public virtual Beverage Beverage { get; set; }
    }
}
