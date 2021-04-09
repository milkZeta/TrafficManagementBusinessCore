using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using TrafficManagementBusinessCore.EntityFrameworkCore;
using TrafficManagementBusinessCore.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace TrafficManagementBusinessCore.Web.Tests
{
    [DependsOn(
        typeof(TrafficManagementBusinessCoreWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class TrafficManagementBusinessCoreWebTestModule : AbpModule
    {
        public TrafficManagementBusinessCoreWebTestModule(TrafficManagementBusinessCoreEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(TrafficManagementBusinessCoreWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(TrafficManagementBusinessCoreWebMvcModule).Assembly);
        }
    }
}