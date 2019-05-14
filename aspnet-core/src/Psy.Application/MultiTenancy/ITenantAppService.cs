using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Psy.MultiTenancy.Dto;

namespace Psy.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

