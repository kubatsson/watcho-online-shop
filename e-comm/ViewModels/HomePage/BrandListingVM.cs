using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace e_comm.ViewModels.HomePage
{
    public class BrandListingVM
    {
        public List<Row> Rows { get; set; }
        public bool logged { get; set; }
        public string loggedString { get; set; }
        public string Search { get; set; }

        public class Row
        {
            public string Route { get; set; }
            public string ProductName { get; set; }
            public int CategoryId { get; set; }


        }
    }
}
