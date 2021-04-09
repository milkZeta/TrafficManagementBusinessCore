using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using Abp.Authorization;
using TrafficManagementBusinessCore.Authorization.Roles;
using TrafficManagementBusinessCore.Authorization.Users;
using TrafficManagementBusinessCore.MultiTenancy;
using Microsoft.Extensions.Logging;

namespace TrafficManagementBusinessCore.Identity
{
    public class SecurityStampValidator : AbpSecurityStampValidator<Tenant, Role, User>
    {
        public SecurityStampValidator(
            IOptions<SecurityStampValidatorOptions> options,
            SignInManager signInManager,
            ISystemClock systemClock,
            ILoggerFactory loggerFactory) 
            : base(options, signInManager, systemClock, loggerFactory)
        {
        }
    }
}
