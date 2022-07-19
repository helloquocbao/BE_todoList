using Abp.Application.Services;
using Sadec.TodoList.MultiTenancy.Dto;

namespace Sadec.TodoList.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

