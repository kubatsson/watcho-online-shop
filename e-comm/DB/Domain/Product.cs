using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace e_comm.DB.Domain
{
    public class Product : Base
    {
        public int ProductName { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public List<Payment> Payments { get; set; }
    }
}
