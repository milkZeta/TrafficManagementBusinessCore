using System.Threading.Tasks;
using Abp.Application.Services;
using TrafficManagementBusinessCore.Sessions.Dto;

namespace TrafficManagementBusinessCore.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
