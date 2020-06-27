using KSERP.Data.Entities.Car;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace KSERP.Data.Configurations.Car
{
    public class CarColorConfigurations : IEntityTypeConfiguration<CarColor>
    {
        public void Configure(EntityTypeBuilder<CarColor> builder)
        {
            builder.ToTable("CarColors");
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id).UseIdentityColumn();
            builder.Property(e => e.Name).IsRequired().HasMaxLength(50);
            builder.Property(e => e.HEXCode).IsRequired().HasMaxLength(7);
        }
    }
}
