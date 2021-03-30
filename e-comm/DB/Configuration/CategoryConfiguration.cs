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
        }
    }
}
