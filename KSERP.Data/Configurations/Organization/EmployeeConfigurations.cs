using KSERP.Data.Entities.Oganization;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace KSERP.Data.Configurations.Organization
{
    public class EmployeeConfigurations : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.ToTable("Employees");
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id).UseIdentityColumn();
            builder.Property(e => e.Email).HasMaxLength(50);
            builder.Property(e => e.FirstName).HasMaxLength(50);
            builder.Property(e => e.LastName).HasMaxLength(20);
            builder.Property(e => e.IdentityCardNo).HasMaxLength(16);
            builder.Property(e => e.PlaceOfIssue).HasMaxLength(50);
            builder.Property(e => e.ProfileImage).HasMaxLength(70);
            builder.Property(e => e.PhoneNumber).HasMaxLength(15);
            builder.HasOne(e => e.User).WithOne(e => e.Employee).HasForeignKey<Employee>(e => e.UserId);
        }
    }
}
