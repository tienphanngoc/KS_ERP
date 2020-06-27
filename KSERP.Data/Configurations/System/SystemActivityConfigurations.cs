using KSERP.Data.Entities.System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace KSERP.Data.Configurations.System
{
    public class SystemActivityConfigurations : IEntityTypeConfiguration<SystemActivity>
    {
        public void Configure(EntityTypeBuilder<SystemActivity> builder)
        {
            builder.ToTable("SystemActivities");
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id).UseIdentityColumn();
            builder.Property(e => e.DeviceName).HasMaxLength(30);
            builder.Property(e => e.ClientIp).HasMaxLength(20);
            builder.Property(e => e.MacAddress).HasMaxLength(30);
            builder.Property(e => e.OS).HasMaxLength(30);
            builder.Property(e => e.Time).HasDefaultValueSql("GETDATE()");
        }
    }
}
