using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using TrafficManagementBusinessCore.Configuration;
using TrafficManagementBusinessCore.Web;

namespace TrafficManagementBusinessCore.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class TrafficManagementBusinessCoreDbContextFactory : IDesignTimeDbContextFactory<TrafficManagementBusinessCoreDbContext>
    {
        public TrafficManagementBusinessCoreDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<TrafficManagementBusinessCoreDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            TrafficManagementBusinessCoreDbContextConfigurer.Configure(builder, configuration.GetConnectionString(TrafficManagementBusinessCoreConsts.ConnectionStringName));

            return new TrafficManagementBusinessCoreDbContext(builder.Options);
        }
    }
}
