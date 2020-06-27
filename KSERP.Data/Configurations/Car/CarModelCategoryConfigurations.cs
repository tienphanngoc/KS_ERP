using KSERP.Data.Entities.Car;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace KSERP.Data.Configurations.Car
{
    class CarModelCategoryConfigurations : IEntityTypeConfiguration<CarModelCategory>
    {
        public void Configure(EntityTypeBuilder<CarModelCategory> builder)
        {
            builder.ToTable("CarModelCategories");
            builder.HasKey(e => new { e.CarCategoryId, e.CarModelId });
            builder.HasOne(e => e.CarCategory).WithMany(c => c.CarModelCategories).HasForeignKey(e => e.CarCategoryId);
            builder.HasOne(e => e.CarModel).WithMany(c => c.CarModelCategories).HasForeignKey(e => e.CarModelId);
        }
    }
}
