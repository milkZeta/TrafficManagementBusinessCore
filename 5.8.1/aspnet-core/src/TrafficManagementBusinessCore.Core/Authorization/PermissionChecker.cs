using Abp.Authorization;
using TrafficManagementBusinessCore.Authorization.Roles;
using TrafficManagementBusinessCore.Authorization.Users;

namespace TrafficManagementBusinessCore.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
