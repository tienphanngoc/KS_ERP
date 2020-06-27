using KSERP.Data.Entities.System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace KSERP.Data.Configurations.System
{
    public class AppConfigConfigurations : IEntityTypeConfiguration<AppConfig>
    {
        public void Configure(EntityTypeBuilder<AppConfig> builder)
        {
            builder.ToTable("AppConfigs");
            builder.HasKey(e => e.Key);
            builder.Property(e => e.Value).HasMaxLength(100);
        }
    }
}
