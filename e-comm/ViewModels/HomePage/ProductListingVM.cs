using e_comm.DB.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace e_comm.ViewModels.HomePage
{
    public class ProductListingVM
    {
        public List<Row> Rows { get; set; }
        public List<Category> Categories { get; set; }
        public bool logged { get; set; }
        public string loggedString { get; set; }
        public string Search { get; set; }
        public class Row
        {
            public string Route { get; set; }
            public string Price { get; set; }
            public string ProductName { get; set; }
            public int CategoryId { get; set; }
            public int GenderId { get; set; }
            public string ShortDescription { get; set; }


        }
    }
}
