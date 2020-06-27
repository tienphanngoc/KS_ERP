using KSERP.Data.Entities.Sales;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace KSERP.Data.Configurations.Sales
{
    public class CustomerConfigurations : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.ToTable("Customer");
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id).UseIdentityColumn();
            builder.Property(e => e.Name).HasMaxLength(70).IsRequired();
            builder.Property(e => e.Address).HasMaxLength(150);
            builder.Property(e => e.Email).HasMaxLength(70);
            builder.Property(e => e.Job).HasMaxLength(150);
            builder.Property(e => e.PhoneNumber1).HasMaxLength(15);
            builder.Property(e => e.PhoneNumber2).HasMaxLength(15);
            builder.Property(e => e.Note).HasMaxLength(250);
            builder.HasOne(e => e.CurrentSalesCare).WithMany(e => e.Customers).HasForeignKey(e => e.CurrentSalesCareId);
        }
    }
}
