using KSERP.Data.Entities.Oganization;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace KSERP.Data.Configurations.Organization
{
    public class PositionEmployeeConfigurations : IEntityTypeConfiguration<PositionEmployee>
    {
        public void Configure(EntityTypeBuilder<PositionEmployee> builder)
        {
            builder.ToTable("PositionEmployees");
            builder.HasKey(e => new { e.EmployeeId, e.PositionId });

            builder.HasOne(e => e.Employee).WithMany(e => e.PositionEmployees).HasForeignKey(e => e.PositionId);
            builder.HasOne(e => e.Position).WithMany(e => e.PositionEmployees).HasForeignKey(e => e.EmployeeId);
        }
    }
}
