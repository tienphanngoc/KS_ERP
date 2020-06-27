using KSERP.Data.Entities.Oganization;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace KSERP.Data.Configurations.Organization
{
    public class PositionConfigurations : IEntityTypeConfiguration<Position>
    {
        public void Configure(EntityTypeBuilder<Position> builder)
        {
            builder.ToTable("Positions");
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id).UseIdentityColumn();
            builder.Property(e => e.Name).IsRequired().HasMaxLength(50);
            builder.Property(e => e.DepartmentId).IsRequired();

            builder.HasOne(e => e.Parent).WithMany(e => e.Childs).HasForeignKey(e => e.ParentId);
            builder.HasOne(e => e.Department).WithMany(d => d.Positions).HasForeignKey(e => e.DepartmentId);
        }
    }
}
