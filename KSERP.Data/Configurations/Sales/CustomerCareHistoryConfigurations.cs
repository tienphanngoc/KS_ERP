using KSERP.Data.Entities.Sales;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace KSERP.Data.Configurations.Sales
{
    public class CustomerCareHistoryConfigurations : IEntityTypeConfiguration<CustomerCareHistory>
    {
        public void Configure(EntityTypeBuilder<CustomerCareHistory> builder)
        {
            builder.ToTable("CustomerCareHistories");
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id).UseIdentityColumn();
            builder.Property(e => e.Content).HasMaxLength(200).IsRequired().HasDefaultValue("Chưa điền");
            builder.Property(e => e.Result).HasMaxLength(200).HasDefaultValue("Chưa điền");
            builder.Property(e => e.DateCare).IsRequired().HasDefaultValueSql("GETDATE()");
            builder.HasOne(e => e.Customer).WithMany(e => e.CustomerCareHistories).HasForeignKey(e => e.CustomerId).OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(e => e.Employee).WithMany(e => e.CustomerCareHistories).HasForeignKey(e => e.SalesCareId).OnDelete(DeleteBehavior.NoAction);
        }
    }
}
