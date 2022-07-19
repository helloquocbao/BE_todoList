using System.Threading.Tasks;
using Abp.Application.Services;
using Sadec.TodoList.Authorization.Accounts.Dto;

namespace Sadec.TodoList.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
