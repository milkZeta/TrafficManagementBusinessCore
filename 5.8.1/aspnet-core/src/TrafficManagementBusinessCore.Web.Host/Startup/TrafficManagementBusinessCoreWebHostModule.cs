using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using TrafficManagementBusinessCore.Configuration;

namespace TrafficManagementBusinessCore.Web.Host.Startup
{
    [DependsOn(
       typeof(TrafficManagementBusinessCoreWebCoreModule))]
    public class TrafficManagementBusinessCoreWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public TrafficManagementBusinessCoreWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(TrafficManagementBusinessCoreWebHostModule).GetAssembly());
        }
    }
}
