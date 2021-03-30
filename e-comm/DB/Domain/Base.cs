using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace e_comm.DB.Domain
{
    public class Base
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime ModifedAt { get; set; }

        protected Base()
        {
            CreatedAt = DateTime.UtcNow;
            ModifedAt = CreatedAt;
        }
    }
}
