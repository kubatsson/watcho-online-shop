using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace e_comm.DB.Domain
{
    public class User : Base
    {        
        public Gender Gender { get; set; }      
        public int GenderId { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public string PasswordSalt { get; set; }
        public List<Payment> Payments { get; set; }
        public string Username { get; set; }       
        public Token Token { get; set; }        
        public ChangePasswordCode ChangePassword { get; set; }        
        public BillingDetails BillingDetails { get; set; }



    }
}
