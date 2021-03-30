using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace e_comm.DB.Domain
{
    public class Category
    {
        public string CategoryName { get; set; }
        public Gender Gender { get; set; }
        public int GenderId { get; set; }

    }
}
