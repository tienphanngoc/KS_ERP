using KSERP.Data.Entities.Car;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace KSERP.Data.Configurations.Car
{
    public class CarCategoryColorConfigurations : IEntityTypeConfiguration<CarCategoryColor>
    {
        public void Configure(EntityTypeBuilder<CarCategoryColor> builder)
        {
            builder.ToTable("CarCategoryColors");
            builder.HasKey(e => new { e.CarCategoryId, e.CarColorId });
            builder.HasOne(e => e.CarCategory).WithMany(c => c.CarCategoryColors).HasForeignKey(e => e.CarCategoryId);
            builder.HasOne(e => e.CarColor).WithMany(c => c.CarCategoryColors).HasForeignKey(e => e.CarColorId);
        }
    }
}
