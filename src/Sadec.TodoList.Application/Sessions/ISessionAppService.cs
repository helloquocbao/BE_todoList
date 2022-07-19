using System.Threading.Tasks;
using Abp.Application.Services;
using Sadec.TodoList.Sessions.Dto;

namespace Sadec.TodoList.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
