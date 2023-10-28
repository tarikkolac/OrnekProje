using Abp.Application.Services;
using OrnekProje.MultiTenancy.Dto;

namespace OrnekProje.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

