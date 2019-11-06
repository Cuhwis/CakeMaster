using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace CakeMaster.Models
{
    public class Order
    {
        [BindNever]
        public int OrderID { get; set; }
        [BindNever]
        public ICollection<CartLine> Lines { get; set; }
        
     // Information Required for all CarryOut and Delivery Orders.
        [Required(ErrorMessage = "Please enter a name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please enter a Phone Number")]
        public string Phone { get; set; }
        public string Description { get; set; }

        //Carry Out Option
        public bool CarryOut { get; set; }
     // [Required(ErrorMessage = "Please enter a Carry Out Date")]
        public DateTime CarryOutDate { get; set; }

        //Delivery Option
        public bool Delivery { get; set; }
        // [Required(ErrorMessage = "Please enter a delivey date")]
        public DateTime DeliveryDate { get; set; } = new DateTime(default);
     // [Required(ErrorMessage = "Please enter the first address line")]
        public string Line1 { get; set; }
        public string Line2 { get; set; }
        public string Line3 { get; set; }
     // [Required(ErrorMessage = "Please enter a city name")]
        public string City { get; set; }
     // [Required(ErrorMessage = "Please enter a state name")]
        public string State  { get; set; }
        public string Zip { get; set; }
     // [Required(ErrorMessage = "Please enter a country name")]
        public string Country { get; set; }

        //Admin Info 
        [BindNever]
        public bool Shipped { get; set; }
        public string Status { get; set; }
    }
}
