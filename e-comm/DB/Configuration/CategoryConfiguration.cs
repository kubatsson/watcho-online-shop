using e_comm.DB.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace e_comm.DB.Configuration
{
    public class CategoryConfiguration : BaseConfiguration<Category>
    {
        public override void Configure(EntityTypeBuilder<Category> builder)
        {

            base.Configure(builder);

            builder.HasMany(p => p.Products)
                   .WithOne(p => p.Category)
                   .HasForeignKey(p => p.CategoryId);

            builder.HasData(
                new Category
                {
                    Id=1,
                    CategoryName="Ade Kaye",
                    GenderId=2,
                    
                },
                new Category
                {
                    Id = 2,
                    CategoryName = "Bedat",
                    GenderId = 2,
                },
                new Category
                {
                    Id = 3,
                    CategoryName = "Bertha",
                    GenderId = 2,
                },
                new Category
                {
                    Id = 4,
                    CategoryName = "Eterna",
                    GenderId = 2,
                },
                new Category
                {
                    Id = 5,
                    CategoryName = "Casio",
                    GenderId = 1,
                },
                new Category
                {
                    Id = 6,
                    CategoryName = "Rolex",
                    GenderId = 1,
                },
                new Category
                {
                    Id = 7,
                    CategoryName = "Omega",
                    GenderId = 1,
                },
                new Category
                {
                    Id = 8,
                    CategoryName = "Certina",
                    GenderId = 1,
                }



                );
        }
    }
}
