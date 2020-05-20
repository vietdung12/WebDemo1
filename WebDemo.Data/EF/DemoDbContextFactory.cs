using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace WebDemo.Data.EF
{
    public class DemoDbContextFactory : IDesignTimeDbContextFactory<DemoDbContext>
    {
        public DemoDbContext CreateDbContext(string[] args)
        {
            //SetBasePath
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json").Build();

            var connectionString = configuration.GetConnectionString("WebDemo1Db");
            //
            var optionsBuilder = new DbContextOptionsBuilder<DemoDbContext>();
            optionsBuilder.UseSqlServer(connectionString);

            return new DemoDbContext(optionsBuilder.Options);
        }
    }
}
