using KSERP.Data.Configurations;
using KSERP.Data.Configurations.Car;
using KSERP.Data.Configurations.Organization;
using KSERP.Data.Configurations.Sales;
using KSERP.Data.Configurations.System;
using KSERP.Data.Configurations.Utilities;
using KSERP.Data.Entities;
using KSERP.Data.Entities.System;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace KSERP.Data.EF
{
    public class KSERP_Dbcontext : IdentityDbContext<User, Role, int>
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

            //Car
            modelBuilder.ApplyConfiguration(new CarCategoryConfigurations());
            modelBuilder.ApplyConfiguration(new CarColorConfigurations());
            modelBuilder.ApplyConfiguration(new CarCategoryColorConfigurations());
            modelBuilder.ApplyConfiguration(new CarModelCategoryConfigurations());
            modelBuilder.ApplyConfiguration(new CarModelColorConfigurations());
            modelBuilder.ApplyConfiguration(new CarModelConfigurations());

            //Organization
            modelBuilder.ApplyConfiguration(new DealerConfigurations());
            modelBuilder.ApplyConfiguration(new DepartmentConfigurations());
            modelBuilder.ApplyConfiguration(new PositionConfigurations());
            modelBuilder.ApplyConfiguration(new EmployeeConfigurations());
            modelBuilder.ApplyConfiguration(new PositionEmployeeConfigurations());

            //Sales
            modelBuilder.ApplyConfiguration(new CustomerConfigurations());
            modelBuilder.ApplyConfiguration(new CustomerCareHistoryConfigurations());

            //Utilities
            modelBuilder.ApplyConfiguration(new NotificationConfigurations());

            //System
            modelBuilder.ApplyConfiguration(new AppConfigConfigurations());
            modelBuilder.ApplyConfiguration(new SystemActivityConfigurations());

            //Identity
            modelBuilder.ApplyConfiguration(new UserConfigurations());
            modelBuilder.ApplyConfiguration(new RoleConfigurations());
            modelBuilder.ApplyConfiguration(new RolePositionConfiguration());
            modelBuilder.Entity<IdentityUserClaim<int>>().ToTable("UserClaims");
            modelBuilder.Entity<IdentityUserRole<int>>().ToTable("UserRoles").HasKey(x => new { x.UserId, x.RoleId });
            modelBuilder.Entity<IdentityUserLogin<int>>().ToTable("UserLogins").HasKey(x => x.UserId);

            modelBuilder.Entity<IdentityRoleClaim<int>>().ToTable("RoleClaims");
            modelBuilder.Entity<IdentityUserToken<int>>().ToTable("UserTokens").HasKey(x => x.UserId);

        }
        public DbSet<Brand> Brands { get; set; }

    }
}
