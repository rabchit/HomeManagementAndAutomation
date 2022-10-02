using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeManagementAndAutomation.Persistence
{
    public class HomeDbContextFactory : IDesignTimeDbContextFactory<HomeDbContext>
    {
        public HomeDbContext CreateDbContext(string[] args)
    {
        IConfigurationRoot configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json")
            .Build();

        var builder = new DbContextOptionsBuilder<HomeDbContext>();
        var connectionString = configuration.GetConnectionString("HomeConnectionString");

        builder.UseSqlServer(connectionString);


        return new HomeDbContext(builder.Options);
    }

}
}
