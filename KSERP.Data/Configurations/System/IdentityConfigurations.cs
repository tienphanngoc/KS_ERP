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
    public class RoleConfigurations : IEntityTypeConfiguration<Role>
    {
        public void Configure(EntityTypeBuilder<Role> builder)
        {
            builder.ToTable("Roles");
            builder.Property(e => e.Name).HasMaxLength(100);
            builder.Property(e => e.NormalizedName).HasMaxLength(100);
        }
    }
    public class RolePositionConfiguration : IEntityTypeConfiguration<RolePosition>
    {
        public void Configure(EntityTypeBuilder<RolePosition> builder)
        {
            builder.ToTable("RolePositions");
            builder.HasKey(e => new { e.RoleId, e.PositionId });

            builder.HasOne(e => e.Role).WithMany(e => e.RolePositions).HasForeignKey(e => e.RoleId);
            builder.HasOne(e => e.Position).WithMany(e => e.RolePositions).HasForeignKey(e => e.PositionId);
        }
    }
}
