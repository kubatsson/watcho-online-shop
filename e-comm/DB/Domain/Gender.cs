using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace e_comm.DB.Domain
{
    public class Gender : Base
    {
        public string GenderName { get; set; }

        public List <User> Users { get; set; }

        public List<Product> Products { get; set; }
    }
}
