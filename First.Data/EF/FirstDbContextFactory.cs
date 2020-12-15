using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace First.Data.EF
{
    public class FirstDbContextFactory : IDesignTimeDbContextFactory<FirstDbContext>
    {
        public FirstDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionString = configuration.GetConnectionString("FirstDb");

            var optionsBuilder = new DbContextOptionsBuilder<FirstDbContext>();
            optionsBuilder.UseSqlServer(connectionString);

            return new FirstDbContext(optionsBuilder.Options);
        }
    }
}
