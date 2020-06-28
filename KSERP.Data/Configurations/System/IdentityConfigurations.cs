using KSERP.Data.Entities.System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace KSERP.Data.Configurations.System
{
    public class UserConfigurations : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("Users");
            builder.Property(e => e.Email).HasMaxLength(70);
            builder.Property(e => e.PhoneNumber).HasMaxLength(15);
            builder.Property(e => e.UserName).HasMaxLength(70);
        }
    }
}
