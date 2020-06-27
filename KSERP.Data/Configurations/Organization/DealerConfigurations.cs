using KSERP.Data.Entities.Oganization;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace KSERP.Data.Configurations.Organization
{
    public class DealerConfigurations : IEntityTypeConfiguration<Dealer>
    {
        public void Configure(EntityTypeBuilder<Dealer> builder)
        {
            builder.ToTable("Dealers");
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id).UseIdentityColumn();
            builder.Property(e => e.Address).HasMaxLength(100);
            builder.Property(e => e.Email).HasMaxLength(100);
            builder.Property(e => e.Name).HasMaxLength(100);
            builder.Property(e => e.SalesHotline).HasMaxLength(15);
            builder.Property(e => e.ServicesHotline).HasMaxLength(15);
            builder.Property(e => e.CompanyName).HasMaxLength(150);
            builder.Property(e => e.CompanyAddress).HasMaxLength(250);
            builder.Property(e => e.CompanyRepresentBy).HasMaxLength(70);
            builder.Property(e => e.RepresentativePosition).HasMaxLength(70);
            builder.Property(e => e.CompanyTax).HasMaxLength(12);
            builder.HasOne(e => e.Brand).WithMany(b => b.Dealers).HasForeignKey(e => e.BrandId);
        }
    }
}
