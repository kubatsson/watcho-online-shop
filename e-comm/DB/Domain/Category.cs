using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace e_comm.DB.Domain
{
    public class Category : Base
    {
        public string CategoryName { get; set; }
        public Gender Gender { get; set; }
        public int GenderId { get; set; }
        public List<Product> Products { get; set; }

    }
}
