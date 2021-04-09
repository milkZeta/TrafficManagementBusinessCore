using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using TrafficManagementBusinessCore.Authorization.Roles;
using TrafficManagementBusinessCore.Authorization.Users;
using TrafficManagementBusinessCore.MultiTenancy;

namespace TrafficManagementBusinessCore.EntityFrameworkCore
{
    public class TrafficManagementBusinessCoreDbContext : AbpZeroDbContext<Tenant, Role, User, TrafficManagementBusinessCoreDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public TrafficManagementBusinessCoreDbContext(DbContextOptions<TrafficManagementBusinessCoreDbContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("DVLP");
            base.OnModelCreating(modelBuilder);
        }
    }
}
