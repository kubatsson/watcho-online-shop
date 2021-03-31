using e_comm.DB.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace e_comm.DB.EF
{
    public class DBcon : DbContext
    {
        public DbSet<Gender> Genders { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<User> Users { get; set; }


        public DBcon(DbContextOptions<DBcon> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            
            base.OnModelCreating(modelBuilder);
        }

    }
}
