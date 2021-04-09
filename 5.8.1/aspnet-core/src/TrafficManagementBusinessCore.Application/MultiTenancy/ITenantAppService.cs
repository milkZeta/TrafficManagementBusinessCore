using Abp.Application.Services;
using TrafficManagementBusinessCore.MultiTenancy.Dto;

namespace TrafficManagementBusinessCore.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

