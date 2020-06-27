using KSERP.Data.Entities.Car;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace KSERP.Data.Configurations.Car
{
    public class CarModelConfigurations : IEntityTypeConfiguration<CarModel>
    {
        public void Configure(EntityTypeBuilder<CarModel> builder)
        {
            builder.ToTable("CarModels");
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id).UseIdentityColumn();
            builder.Property(e => e.Engine).HasMaxLength(50);
            builder.Property(e => e.GearBox).HasMaxLength(50);
            builder.Property(e => e.YOM).HasDefaultValue(0);
            builder.Property(e => e.MY).HasDefaultValue(0);
            builder.Property(e => e.SalesPrice).HasDefaultValue(0);
        }
    }
}
