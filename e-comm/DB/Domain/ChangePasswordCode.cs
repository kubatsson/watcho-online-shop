using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace e_comm.DB.Domain
{
    public class ChangePasswordCode : Base
    {
        public string Value { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public DateTime Created { get; set; }
    }
}
