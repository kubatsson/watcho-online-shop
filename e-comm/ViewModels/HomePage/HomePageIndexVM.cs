using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace e_comm.ViewModels.HomePage
{
    public class HomePageIndexVM
    {

        public List<Row> Rows { get; set; }
        public class Row
        {
            public string Route { get; set; }
        }
    }
}
