using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace KSERP.Data.EF
{
    public class KSERPDbContextFactory : IDesignTimeDbContextFactory<KSERP_Dbcontext>
    {
        public KSERP_Dbcontext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();
            var connectionString = configuration.GetConnectionString("KSERPDatabase");
            var optionsBuilder = new DbContextOptionsBuilder<KSERP_Dbcontext>();
            optionsBuilder.UseSqlServer(connectionString);

            return new KSERP_Dbcontext(optionsBuilder.Options);
        }
    }
}
