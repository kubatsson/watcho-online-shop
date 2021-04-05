using e_comm.DB.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace e_comm.DB.Configuration
{
    public class GenderConfiguration : BaseConfiguration<Gender>
    {
        public override void Configure(EntityTypeBuilder<Gender> builder)
        {
            base.Configure(builder);
            
            builder.HasMany(p => p.Users)
                   .WithOne(p => p.Gender)
                   .HasForeignKey(p => p.GenderId);

            builder.HasMany(p => p.Products)
                   .WithOne(p => p.Gender)
                   .HasForeignKey(p => p.GenderId);

            builder.HasData(new Gender[]
            {
                new Gender
                {
                    Id = 1,
                    GenderName="Male",
                   
                },
                new Gender
                {
                    Id = 2,
                    GenderName="Female",
                    
                },
               
            });
        }
    }
}
