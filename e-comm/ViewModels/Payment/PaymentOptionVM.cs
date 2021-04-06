using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace e_comm.ViewModels.Payment
{
    public class PaymentOptionVM
    {
        public string ProductName { get; set; }
        public int CategoryId { get; set; }
        public int GenderId { get; set; }
        public string ImageRoute { get; set; }
        public string ShortDescription { get; set; }
        public double Price { get; set; }
        public string DiscountCode { get; set; }
        public ShippingInfo CustomerInfo { get; set; }
        public string PaypalRoute { get; set; }


        public class ShippingInfo
        {
            
            public string FullName { get; set; }
            
            public string Email { get; set; }
            
            public string PhoneNumber { get; set; }
           
            public string Zip { get; set; }
            
            public string Country { get; set; }
            
            public string City { get; set; }
            
            public string StreetAddress { get; set; }
        }
    }
}
