using KSERP.Data.Configurations;
using KSERP.Data.Configurations.Car;
using KSERP.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace KSERP.Data.EF
{
    public class KSERP_Dbcontext : DbContext
    {
        public KSERP_Dbcontext(DbContextOptions options) : base(options)
        {
        }
        public KSERP_Dbcontext()
        {

        }    
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new BrandConfigurations());
            modelBuilder.ApplyConfiguration(new CarCategoryConfigurations());
            modelBuilder.ApplyConfiguration(new CarColorConfigurations());
            modelBuilder.ApplyConfiguration(new CarCategoryColorConfigurations());
        }
        public DbSet<Brand> Brands { get; set; }

    }
}
