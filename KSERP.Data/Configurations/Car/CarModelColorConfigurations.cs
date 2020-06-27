using KSERP.Data.Entities.Car;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace KSERP.Data.Configurations.Car
{
    public class CarModelColorConfigurations : IEntityTypeConfiguration<CarModelColor>
    {
        public void Configure(EntityTypeBuilder<CarModelColor> builder)
        {
            builder.ToTable("CarModelColors");
            builder.HasKey(e => new { e.CarColorId, e.CarModelId });
            builder.HasOne(e => e.CarColor).WithMany(c => c.CarModelColors).HasForeignKey(e => e.CarColorId);
            builder.HasOne(e => e.CarModel).WithMany(c => c.CarModelColors).HasForeignKey(e => e.CarModelId);
        }
    }
}
