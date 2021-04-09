using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace TrafficManagementBusinessCore.Controllers
{
    public abstract class TrafficManagementBusinessCoreControllerBase: AbpController
    {
        protected TrafficManagementBusinessCoreControllerBase()
        {
            LocalizationSourceName = TrafficManagementBusinessCoreConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
