using Microsoft.Extensions.Configuration;
using Castle.MicroKernel.Registration;
using Abp.Events.Bus;
using Abp.Modules;
using Abp.Reflection.Extensions;
using TrafficManagementBusinessCore.Configuration;
using TrafficManagementBusinessCore.EntityFrameworkCore;
using TrafficManagementBusinessCore.Migrator.DependencyInjection;

namespace TrafficManagementBusinessCore.Migrator
{
    [DependsOn(typeof(TrafficManagementBusinessCoreEntityFrameworkModule))]
    public class TrafficManagementBusinessCoreMigratorModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public TrafficManagementBusinessCoreMigratorModule(TrafficManagementBusinessCoreEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbSeed = true;

            _appConfiguration = AppConfigurations.Get(
                typeof(TrafficManagementBusinessCoreMigratorModule).GetAssembly().GetDirectoryPathOrNull()
            );
        }

        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(
                TrafficManagementBusinessCoreConsts.ConnectionStringName
            );

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
            Configuration.ReplaceService(
                typeof(IEventBus), 
                () => IocManager.IocContainer.Register(
                    Component.For<IEventBus>().Instance(NullEventBus.Instance)
                )
            );
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(TrafficManagementBusinessCoreMigratorModule).GetAssembly());
            ServiceCollectionRegistrar.Register(IocManager);
        }
    }
}
