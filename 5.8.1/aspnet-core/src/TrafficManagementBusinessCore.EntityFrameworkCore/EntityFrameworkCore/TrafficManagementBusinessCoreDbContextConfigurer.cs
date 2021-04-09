using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace TrafficManagementBusinessCore.EntityFrameworkCore
{
    public static class TrafficManagementBusinessCoreDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<TrafficManagementBusinessCoreDbContext> builder, string connectionString)
        {
            //builder.UseSqlServer(connectionString);
             //builder.UseOracle(connectionString);
            builder.UseOracle(connectionString, b => b.UseOracleSQLCompatibility("11"));

        }

        public static void Configure(DbContextOptionsBuilder<TrafficManagementBusinessCoreDbContext> builder, DbConnection connection)
        {
            //builder.UseSqlServer(connection);
            builder.UseOracle(connection, b => b.UseOracleSQLCompatibility("11"));
        }
    }
}
