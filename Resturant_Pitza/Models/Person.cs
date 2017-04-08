using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Resturant_Pitza.Models
{
    
    public class ApplicationUser : IdentityUser
    {
        public string FName { get; set; }
        public string LName { get; set; }

        public int PaymentInfoId { get; set; }

        public virtual PaymentInfo PaymentInfo { get; set; }



    }
}
