using Abp.MultiTenancy;
using TrafficManagementBusinessCore.Authorization.Users;

namespace TrafficManagementBusinessCore.MultiTenancy
{
    public class Tenant : AbpTenant<User>
    {
        public Tenant()
        {            
        }

        public Tenant(string tenancyName, string name)
            : base(tenancyName, name)
        {
        }
    }
}
