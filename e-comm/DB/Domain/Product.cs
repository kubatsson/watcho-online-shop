using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace e_comm.DB.Domain
{
    public class Product : Base
    {
        public string ProductName { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public List<Payment> Payments { get; set; }
        public Gender Gender { get; set; }
        public int GenderId { get; set; }
        public string ImageRoute { get; set; }
        public string ShortDescription { get; set; }
        public double Price { get; set; }
    }
}
