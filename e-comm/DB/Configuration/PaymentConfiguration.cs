using e_comm.DB.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace e_comm.DB.Configuration
{
    public class PaymentConfiguration : BaseConfiguration<Payment>
    {
        public override void Configure(EntityTypeBuilder<Payment> builder)
        {

            base.Configure(builder);

            builder.HasOne(p => p.User).WithMany(p => p.Payments).HasForeignKey(p => p.UserId);
            builder.HasOne(p => p.Product).WithMany(p =>p.Payments).HasForeignKey(p => p.ProductId);         
        }
    }
}
