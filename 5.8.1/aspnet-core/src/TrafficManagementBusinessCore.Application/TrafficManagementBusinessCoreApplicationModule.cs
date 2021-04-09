using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using TrafficManagementBusinessCore.Authorization;

namespace TrafficManagementBusinessCore
{
    [DependsOn(
        typeof(TrafficManagementBusinessCoreCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class TrafficManagementBusinessCoreApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<TrafficManagementBusinessCoreAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(TrafficManagementBusinessCoreApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
