using e_comm.DB.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace e_comm.DB.Configuration
{
    public class UserConfiguration : BaseConfiguration<User>
    {
        public override void Configure(EntityTypeBuilder<User> builder)
        {
            base.Configure(builder);

            builder.HasOne(p => p.Token).WithOne(p => p.User).HasForeignKey<User>(p => p.TokenId);
            builder.HasOne(p => p.ChangePassword).WithOne(p => p.User).HasForeignKey<User>(p => p.ChangePasswordId);
            builder.HasOne(p => p.BillingDetails).WithOne(p => p.User).HasForeignKey<User>(p => p.BillingDetailsId);

        }
    }
}
