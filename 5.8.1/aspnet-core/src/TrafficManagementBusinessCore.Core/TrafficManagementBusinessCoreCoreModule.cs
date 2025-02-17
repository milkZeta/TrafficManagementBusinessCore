﻿using Abp.Modules;
using Abp.Reflection.Extensions;
using Abp.Timing;
using Abp.Zero;
using Abp.Zero.Configuration;
using TrafficManagementBusinessCore.Authorization.Roles;
using TrafficManagementBusinessCore.Authorization.Users;
using TrafficManagementBusinessCore.Configuration;
using TrafficManagementBusinessCore.Localization;
using TrafficManagementBusinessCore.MultiTenancy;
using TrafficManagementBusinessCore.Timing;

namespace TrafficManagementBusinessCore
{
    [DependsOn(typeof(AbpZeroCoreModule))]
    public class TrafficManagementBusinessCoreCoreModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Auditing.IsEnabledForAnonymousUsers = true;

            // Declare entity types
            Configuration.Modules.Zero().EntityTypes.Tenant = typeof(Tenant);
            Configuration.Modules.Zero().EntityTypes.Role = typeof(Role);
            Configuration.Modules.Zero().EntityTypes.User = typeof(User);

            TrafficManagementBusinessCoreLocalizationConfigurer.Configure(Configuration.Localization);

            // Enable this line to create a multi-tenant application.
            Configuration.MultiTenancy.IsEnabled = TrafficManagementBusinessCoreConsts.MultiTenancyEnabled;

            // Configure roles
            AppRoleConfig.Configure(Configuration.Modules.Zero().RoleManagement);

            Configuration.Settings.Providers.Add<AppSettingProvider>();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(TrafficManagementBusinessCoreCoreModule).GetAssembly());
        }

        public override void PostInitialize()
        {
            IocManager.Resolve<AppTimes>().StartupTime = Clock.Now;
        }
    }
}
