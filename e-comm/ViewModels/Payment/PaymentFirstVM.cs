using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace e_comm.ViewModels.Payment
{
    public class PaymentFirstVM
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int CategoryId { get; set; }                      
        public int GenderId { get; set; }
        public string ImageRoute { get; set; }        
        public string ShortDescription { get; set; }      
        public double Price { get; set; }
        public string DiscountCode { get; set; }
        public ShippingInfo CustomerInfo { get; set; }

        public class ShippingInfo{
            [Required]
            public string FullName { get; set; }
            [Required]
            public string Email { get; set; }          
            [Required]
            public string Zip { get; set; }
            [Required]
            public string Country { get; set; }
            [Required]
            public string City { get; set; }
            [Required]
            public string StreetAddress { get; set; }
        }
        
    }
}
