using System.Threading.Tasks;
using Abp.Application.Services;
using TrafficManagementBusinessCore.Authorization.Accounts.Dto;

namespace TrafficManagementBusinessCore.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
