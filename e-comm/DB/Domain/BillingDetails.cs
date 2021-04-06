using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace e_comm.DB.Domain
{
    public class BillingDetails : Base
    {
        public string Email { get; set; }
        public string Fullname { get; set; }
        public string StreetAddress { get; set; }
        public string Zip { get; set; }
        public string Country { get; set; }
        public string City { get; set; }        
        public int UserId { get; set; }
        public User User { get; set; }
        
    }
}
