using KSERP.Data.Entities.Car;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace KSERP.Data.Configurations.Car
{
    public class CarCategoryConfigurations : IEntityTypeConfiguration<CarCategory>
    {
        public void Configure(EntityTypeBuilder<CarCategory> builder)
        {
            builder.ToTable("CarCategories");
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id).UseIdentityColumn();
            builder.Property(e => e.Name).IsRequired().HasMaxLength(50);
            builder.Property(e => e.BrandId).IsRequired();
            builder.HasOne(e => e.Brand).WithMany(e => e.CarCategories).HasForeignKey(e => e.BrandId);
        }
    }
}
