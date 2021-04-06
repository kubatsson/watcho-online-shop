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

            builder.HasOne(p => p.Token).WithOne(p => p.User).HasForeignKey<Token>(p => p.UserId);
            builder.HasOne(p => p.ChangePassword).WithOne(p => p.User).HasForeignKey<ChangePasswordCode>(p => p.UserId);
            builder.HasOne(p => p.BillingDetails).WithOne(p => p.User).HasForeignKey<BillingDetails>(p => p.UserId);

            builder.HasData(
                new User
                {
                    Id=1,
                    GenderId=1,
                    Email="adiskubat@outlook.com",
                    PasswordHash= "C29v6PDxBQq/0r05p0yzXWxUdm7dH5xQ+Y2sagbcKbY=",
                    PasswordSalt= "NBRH/6nbEfnhdyx9a7w6lA==",
                    Username="testuser"
                }
                );          
        }
    }
}
